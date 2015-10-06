using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CadastroSimples
{
	public partial class Exclusao : System.Web.UI.Page
	{
		SqlConnection conn = new SqlConnection("Server=tcp:eot9dccau4.database.windows.net,1433;Database=testedb;User ID=alunos@eot9dccau4;Password=web2015$;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
		SqlCommand command;
		SqlDataReader reader;

		protected void Page_Load(object sender, EventArgs e)
		{	
			string nome = string.Empty;
			int id;
			if (int.TryParse(Request.QueryString["id"], out id) == false)
			{
				lblMsg.Text = "Id inválido ou não existe !";
				btnSIM.Visible = false;
				btnNAO.Visible = false;
				return;
			}

			conn.Open();
			command = new SqlCommand();
			command.CommandText = "SELECT Nome FROM tbPessoa WHERE Id = @a";
			command.Connection = conn;
			command.Parameters.AddWithValue("@a", id);
			reader = command.ExecuteReader();

			if (reader.Read() == true)
			{
				nome = reader.GetString(0);
				lblMsg.Text = "Deseja mesmo excluir registro com o Nome: " + nome + " - e com o ID: " + id + " ?";
				btnSIM.Visible = true;
				btnNAO.Visible = true;
			}
			else
			{
				lblMsg.Text = "Não existe usuário com este ID, tente novamente !";
				btnSIM.Visible = false;
				btnNAO.Visible = false;
			}

			reader.Close();
			reader.Dispose();
			command.Dispose();

			conn.Close();
			conn.Dispose();
		}

		protected void btnSIM_Click(object sender, EventArgs e)
		{
			int id;
			if (int.TryParse(Request.QueryString["id"], out id) == false)
			{
				//Nunca vai acontencer, proque já tem o id lá em cima, selecionado na mémoria
				return;
			}
			
			conn.Open();
			command = new SqlCommand();
			command.CommandText = "DELETE FROM tbPessoa WHERE Id = @a";
			command.Connection = conn;
			command.Parameters.AddWithValue("@a", id);
			command.ExecuteNonQuery();
			command.Dispose();

			conn.Close();
			conn.Dispose();

			lblMsg.Text = "PESSOA EXCLUÍDA";
		}

		protected void btnNAO_Click(object sender, EventArgs e)
		{
			Response.Redirect("Cadastro.aspx");
		}



	}
}