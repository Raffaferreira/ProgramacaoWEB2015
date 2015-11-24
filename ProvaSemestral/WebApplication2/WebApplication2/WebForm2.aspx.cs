using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WebApplication2
{
	public partial class WebForm2 : System.Web.UI.Page
	{
		SqlConnection conn = new SqlConnection("Server=tcp:eot9dccau4.database.windows.net,1433;Database=testedb;User ID=alunos@eot9dccau4;Password=web2015$;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
		SqlCommand command;
		SqlDataReader reader;
		
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Listar_Click(object sender, EventArgs e)
		{
			string nome;
			int idBusca;

			ListaNomes.Items.Clear();

			if(int.TryParse(textID.Text, out idBusca) == false)
			{
				lblMensagem.Text = "Campo de busca ID em branco..!";
				return;
			}

			conn.Open();
			command = new SqlCommand("SELECT Id, Nome FROM tbPessoa WHERE Id >= @a", conn);
			command.Parameters.AddWithValue("@a", idBusca);
			reader = command.ExecuteReader();

			while(reader.Read())
			{
				idBusca = reader.GetInt32(0);
				nome = reader.GetString(1);
				ListItem item = new ListItem(nome, Convert.ToString(idBusca));
				ListaNomes.Items.Add(item);
			}

			reader.Close();
			reader.Dispose();
			command.Dispose();
			conn.Close();
			conn.Dispose();
		}


	}
}