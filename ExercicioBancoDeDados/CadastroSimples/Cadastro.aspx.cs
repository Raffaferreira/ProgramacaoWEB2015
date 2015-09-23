using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace CadastroSimples
{
	public partial class Cadastro : System.Web.UI.Page
	{
		SqlConnection cnn = new SqlConnection("Server=tcp:eot9dccau4.database.windows.net,1433;Database=testedb;User ID=alunos@eot9dccau4;Password=web2015$;Encrypt=True");
		SqlCommand command;
		private static int vezes = 0;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Page.IsPostBack == false)
			{
				vezes++;
			}
			labelMensagem.Text = "Você está carregando a página pela " + vezes + " vez";	
		}

		protected void Cadastrar_Click(object sender, EventArgs e)
		{
			string nome = TxtNome.Text;
			string endereco = TxtEndereco.Text;

			string email = TxtEmail.Text.Trim();
			int arroba, ponto, arroba2;
			arroba = email.IndexOf('@');
			arroba2 = email.LastIndexOf('@');
			ponto = email.LastIndexOf('.');

			//Converter nascimento
			string nascimento = TxtNascimento.Text;
			DateTime nascimentoData;

			//Converter Peso
			string peso = TxtPeso.Text;
			double pesoDouble;

			if (nome.Length == 0)
			{
				labelMensagem.Text = "Existe algum campo em branco, verifque novamente!";
				return;
			}
			if (endereco.Length == 0)
			{
				labelMensagem.Text = "Existe algum campo em branco, verifque novamente!";
				return;
			}
			if (arroba <= 0 || ponto <= (arroba + 1) || ponto == (email.Length - 1) || arroba2 != arroba)
			{
				labelMensagem.Text = "Existe algum campo em branco, verifque novamente!";
				return;
			}
			if (DateTime.TryParse(nascimento, System.Globalization.CultureInfo.GetCultureInfo("pt-br"), System.Globalization.DateTimeStyles.None, out nascimentoData) == false)
			{
				labelMensagem.Text = "Existe algum campo em branco, verifque novamente!";
				return;
			}
			if (double.TryParse(peso, out pesoDouble) == false)
			{
				labelMensagem.Text = "Existe algum campo em branco, verifque novamente!";
				return;
			}
			labelMensagem.Text = "";

			cnn.Open();

			command = new SqlCommand("INSERT INTO tbPessoa (Nome, Endereco, Email, Nascimento, Peso) VALUES (@a, @b, @c, @d, @e)", cnn);
			command.Parameters.Add(new SqlParameter("@a", SqlDbType.VarChar));
			command.Parameters.Add(new SqlParameter("@b", SqlDbType.VarChar));
			command.Parameters.Add(new SqlParameter("@c", SqlDbType.VarChar));
			command.Parameters.Add(new SqlParameter("@d", SqlDbType.Date));
			command.Parameters.Add(new SqlParameter("@e", SqlDbType.Float));

			command.Parameters[0].Value = nome;
			command.Parameters[1].Value = endereco;
			command.Parameters[2].Value = email;
			command.Parameters[3].Value = nascimentoData;
			command.Parameters[4].Value = pesoDouble;
			command.ExecuteNonQuery();
			command.Dispose();

			cnn.Close();
			cnn.Dispose();

			labelMensagem.Text = "CADASTRADO COM SUCESSO !!!";
		}
	}
}