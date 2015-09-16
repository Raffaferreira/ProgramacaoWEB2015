using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Listas
{
	public partial class Exec4 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ButtonVerificar_Click(object sender, EventArgs e)
		{
			string ladoA = TextB.Text;
			string ladoB = TextB.Text;
			string ladoC = TextC.Text;

			float valorA, valorB, valorC;

			if (float.TryParse(ladoA, out valorA) == false)
			{
				labelMensagem.Text = "Valores não inseridos em algum campo...!";
				return;
			}
			if (float.TryParse(ladoB, out valorB) == false)
			{
				labelMensagem.Text = "Valores não inseridos em algum campo...!";
				return;
			}
			if (float.TryParse(ladoC, out valorC) == false)
			{
				labelMensagem.Text = "Valores não inseridos em algum campo...!";
				return;
			}
			
			if ((valorA + valorB) > valorC)
			{
				TextResultado.Text = "É um triangulo";
				return;
			}
			else
			{
				labelMensagem.Text = "Tipo de triangulo desconheido pelo armazenamento de dados aqui !";
			}

		}



	}
}