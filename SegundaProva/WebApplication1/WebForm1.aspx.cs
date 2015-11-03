using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WebApplication1
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		SqlConnection conn = new SqlConnection("Server=tcp:eot9dccau4.database.windows.net,1433;Database=testedb;User ID=alunos@eot9dccau4;Password=web2015$;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
		SqlCommand command;
		SqlDataReader reader;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Page.IsPostBack == false)
			{
				conn.Open();
				command = new SqlCommand("SELECT Nome, Id FROM tbAluno", conn);
				reader = command.ExecuteReader();

				string Nome;
				int valor;

				while (reader.Read())
				{
					Nome = reader.GetString(0);
					valor = reader.GetInt32(1);
					ListItem item = new ListItem(Nome, Convert.ToString(valor));
					DropListNomes.Items.Add(item);
				}

				reader.Close();
				reader.Dispose();
				command.Dispose();
				conn.Close();
				conn.Dispose();
			}
		}

		protected void SubmitNotas_Click(object sender, EventArgs e)
		{
			ListItem selecionado = DropListNomes.SelectedItem;

			double nota1;
			if (double.TryParse(TxtNota1.Text, out nota1) == false)
			{
				lblMensagem.Text = "Algum campo está vázio verifique e preencha novamente !";
				return;
			}

			double nota2;
			if (double.TryParse(TxtNota2.Text, out nota2) == false)
			{
				lblMensagem.Text = "Algum campo está vázio verifique e preencha novamente !";
				return;
			}

			double nota3;
			if (double.TryParse(TxtNota3.Text, out nota3) == false)
			{
				lblMensagem.Text = "Algum campo está vázio verifique e preencha novamente !";
				return;
			}

			double nota4;
			if (double.TryParse(TxtNota4.Text, out nota4) == false)
			{
				lblMensagem.Text = "Algum campo está vázio verifique e preencha novamente !";
				return;
			}

			conn.Open();
			command = new SqlCommand("INSERT INTO tbProva (IdAluno, Nota1, Nota2, Nota3, Nota4) VALUES (@a, @b, @c, @d, @e)", conn);
			command.Parameters.AddWithValue("@a", Convert.ToInt32(selecionado.Value));
			command.Parameters.AddWithValue("@b", nota1);
			command.Parameters.AddWithValue("@c", nota2);
			command.Parameters.AddWithValue("@d", nota3);
			command.Parameters.AddWithValue("@e", nota4);
			command.ExecuteNonQuery();
			command.Dispose();

			conn.Close();
			conn.Dispose();

			lblMensagem.Text = "NOTAS SUBMETIDAS COM SUCESSO!!!";
		}


	}
}