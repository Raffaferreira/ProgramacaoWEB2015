using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Listas
{
	public partial class Exec2 : System.Web.UI.Page
	{
		protected float resultado;

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Soma_Click(object sender, EventArgs e)
		{
			string valor1 = TextNumero1.Text;
			float valorText1;

			string valor2 = TextNumero2.Text;
			float valorText2;

			if ( float.TryParse(valor1,out valorText1) == false )
			{
				LabelMensagem.Text = "Valores não passado em algum campo, verifique novamente !";
				return;
			}

			if (float.TryParse(valor2, out valorText2) == false)
			{
				LabelMensagem.Text = "Valores não passado em algum campo, verifique novamente !";
				return;
			}

			resultado = valorText1 + valorText2;

			TextResultado.Text = resultado.ToString();
			LabelMensagem.Text = "Valores calculados";
		}

		protected void Substracao_Click(object sender, EventArgs e)
		{
			string valor1 = TextNumero1.Text;
			float valorText1;

			string valor2 = TextNumero2.Text;
			float valorText2;

			if (float.TryParse(valor1, out valorText1) == false)
			{
				LabelMensagem.Text = "Valores não passado em algum campo, verifique novamente !";
				return;
			}

			if (float.TryParse(valor2, out valorText2) == false)
			{
				LabelMensagem.Text = "Valores não passado em algum campo, verifique novamente !";
				return;
			}

			resultado = valorText1 - valorText2;

			TextResultado.Text = resultado.ToString();
			LabelMensagem.Text = "Valores calculados";
		}

		protected void Multiplicacao_Click(object sender, EventArgs e)
		{
			string valor1 = TextNumero1.Text;
			float valorText1;

			string valor2 = TextNumero2.Text;
			float valorText2;

			if (float.TryParse(valor1, out valorText1) == false)
			{
				LabelMensagem.Text = "Valores não passado em algum campo, verifique novamente !";
				return;
			}

			if (float.TryParse(valor2, out valorText2) == false)
			{
				LabelMensagem.Text = "Valores não passado em algum campo, verifique novamente !";
				return;
			}

			resultado = valorText1 * valorText2;

			TextResultado.Text = resultado.ToString();
			LabelMensagem.Text = "Valores calculados";
		}

		protected void Divisao_Click(object sender, EventArgs e)
		{
			string valor1 = TextNumero1.Text;
			float valorText1;

			string valor2 = TextNumero2.Text;
			float valorText2;

			if (float.TryParse(valor1, out valorText1) == false)
			{
				LabelMensagem.Text = "Valores não passado em algum campo, verifique novamente !";
				return;
			}

			if (float.TryParse(valor2, out valorText2) == false)
			{
				LabelMensagem.Text = "Valores não passado em algum campo, verifique novamente !";
				return;
			}

			resultado = valorText1 / valorText2;

			TextResultado.Text = resultado.ToString();
			LabelMensagem.Text = "Valores calculados";
		}
	}
}