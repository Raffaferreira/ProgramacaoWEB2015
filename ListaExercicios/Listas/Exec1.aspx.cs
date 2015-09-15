using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Listas
{
	public partial class Exec1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ButtonCalcular_Click(object sender, EventArgs e)
		{
			if (TextBox1.Text.Length == 0)
			{
				lblMensagemErro.Text = "Campos Inválidos, insira um valor a ser Calculado";
				return;
			}

			if (TextBox2.Text.Length == 0)
			{
				lblMensagemErro.Text = "Campos Inválidos, insira um valor a ser Calculado";
				return;
			}

			float tempo, velocidade, distancia, litros;

			if (float.TryParse(TextBox1.Text, out tempo) == false)
			{
				lblMensagemErro.Text = "Tempo invalido";
				return;
			}

			if (float.TryParse(TextBox2.Text, out velocidade) == false)
			{
				lblMensagemErro.Text = "Tempo invalido";
				return;
			}

			distancia = tempo * velocidade;
			TextBox3.Text = distancia.ToString();

			litros = distancia / 12;
			TextBox4.Text = litros.ToString();

			lblMensagemErro.Text = "Valor calculados !";
		}
	}
}