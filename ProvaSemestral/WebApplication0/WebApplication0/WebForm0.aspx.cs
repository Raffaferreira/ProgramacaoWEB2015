using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0
{
	public partial class WebForm0 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Ordenar_Click(object sender, EventArgs e)
		{
			if (TextBox1.Text.Length == 0)
			{
				lblMensagem.Text = "Existe algum campo vázio, verifique e preencha corretamente!";
				return;
			}
			if (TextBox2.Text.Length == 0)
			{
				lblMensagem.Text = "Existe algum campo vázio, verifique e preencha corretamente!";
				return;
			}
			if (TextBox3.Text.Length == 0)
			{
				lblMensagem.Text = "Existe algum campo vázio, verifique e preencha corretamente!";
				return;
			}
			if (TextBox4.Text.Length == 0)
			{
				lblMensagem.Text = "Existe algum campo vázio, verifique e preencha corretamente!";
				return;
			}
			if (TextBox5.Text.Length == 0)
			{
				lblMensagem.Text = "Existe algum campo vázio, verifique e preencha corretamente!";
				return;
			}

			string[] valores = new string[5] { TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text };
			Array.Sort(valores);
			Array.Reverse(valores);

			TextBox1.Text = valores[0];
			TextBox2.Text = valores[1];
			TextBox3.Text = valores[2];
			TextBox4.Text = valores[3];
			TextBox5.Text = valores[4];

			lblMensagem.Text = "Textos Ordenados!";
		}


	}
}