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
		public float valorA, valorB, valorC;

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ButtonOrdernar_Click(object sender, EventArgs e)
		{
			string ladoA = TextA.Text;
			string ladoB = TextB.Text;
			string ladoC = TextC.Text;

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

			float[] vetor = new float[] { valorA, valorB, valorC };
			Array.Sort(vetor);

			Valor1.Text = vetor[0].ToString();
			Valor2.Text = vetor[1].ToString();
			Valor3.Text = vetor[2].ToString();

			labelMensagem.Text = "ORDENADOS MIZERAVII....";
		}
	}
}