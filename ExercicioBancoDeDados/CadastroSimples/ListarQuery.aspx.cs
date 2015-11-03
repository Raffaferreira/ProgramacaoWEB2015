using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CadastroSimples
{
	public partial class Atualizar : System.Web.UI.Page
	{
		//private static readonly string webConfigName = ConfigurationManager.AppSettings.Get("AzureBancoDeDados");
        private static readonly string stringOfConnection = ConfigurationManager.ConnectionStrings["BancoLocalWEb"].ConnectionString;
		private static SqlConnection conn = new SqlConnection(stringOfConnection);
		SqlCommand cmd;
		SqlDataReader reader;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Page.IsPostBack == false)
			{
				int id;
				if (int.TryParse(Request.QueryString["id"], out id) == false)
				{
					lblMensagem.Text = "Id inválido !";
					return;
				}

				//SqlConnection conn = new SqlConnection("Server=tcp:eot9dccau4.database.windows.net,1433;Database=testedb;User ID=alunos@eot9dccau4;Password=web2015$;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
				conn.Open();
				cmd = new SqlCommand("SELECT Nome, Endereco, Email, Nascimento, Peso FROM tbPessoa WHERE Id = @a", conn);
				cmd.Parameters.AddWithValue("@a", id);
				reader = cmd.ExecuteReader();

				if (reader.Read() == true)
				{
					TxtNome.Text = reader.GetString(0);
					TxtEndereco.Text = reader.GetString(1);
					TxtEmail.Text = reader.GetString(2);
					TxtNascimento.Text = reader.GetDateTime(3).ToString("dd/MM/yyyy");
					TxtPeso.Text = reader.GetDouble(4).ToString("00.0");
				}
				else
				{
					lblMensagem.Text = "Id inválido seu burro, usuário anta, aprende a usar isso seu animal!";
				}

				reader.Close();
				reader.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();	

			}
		}

        protected void UpdateRegistro_Click(object sender, EventArgs e)
        {
            //##################################################################################################
            DateTime data;
            if (DateTime.TryParse(TxtNascimento.Text, out data) == false)
            {
                lblMensagem.Text = "Campo de data vazia !";
                return;
            }

            double peso;
            if (double.TryParse(TxtPeso.Text, out peso) == false)
            {
                lblMensagem.Text = "Campo de peso vazio!";
                return;
            }

            SqlConnection conn = new SqlConnection(stringOfConnection);
            conn.Open();
            cmd = new SqlCommand("UPDATE tbPessoa SET Nome=@a, Endereco=@b, Email=@c, Nascimento=@d, Peso=@e WHERE Id=@f", conn);
            cmd.Parameters.AddWithValue("@a", TxtNome.Text);
            cmd.Parameters.AddWithValue("@b", TxtEndereco.Text);
            cmd.Parameters.AddWithValue("@c", TxtEmail.Text);
            cmd.Parameters.AddWithValue("@d", data);
            cmd.Parameters.AddWithValue("@e", peso);
            cmd.Parameters.AddWithValue("@f", 0); //Esse parâmetro é o Id

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();

            lblMensagem.Text = "REGISTROS ATUALIZADOS";

            Response.Redirect("Cadastro.aspx");
				
        }


        




	}
}
