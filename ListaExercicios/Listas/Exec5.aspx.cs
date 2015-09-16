using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Listas
{
	public partial class Exec5 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ButtonOrdernar_Click(object sender, EventArgs e)
		{
			string ladoA = TextB.Text;
			string ladoB = TextB.Text;
			string ladoC = TextC.Text;

			float valorA, valorB, valorC, maior1, maior2, maior3;

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

			if (valorA > valorB)
			{
				maior1 = valorA;
				maior2 = valorB;
			}
			if (valorB > valorC)
			{
				maior1 = valorB;
				maior2 = valorC;

			}
			if(valorC > valorA)
			{
				maior1 = valorC;
				maior2 = valorA;
				maior3 = valorB;

				Valor1.Text = maior1.ToString();
				Valor2.Text = maior2.ToString();
				Valor3.Text = maior3.ToString();
				return;
			}

			labelMensagem.Text = "Ordenados...!";
		}
	}
}