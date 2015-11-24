using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Calcular_Click(object sender, EventArgs e)
		{
			int comprimentoEstrada;
			if(int.TryParse(ComprimentoEstrada.Text, out comprimentoEstrada) == false)
			{
				lblMensagem.Text = "Preencha todos os Campos, existe campo em branco !!";
				return;
			}
			int distanciaPedagio;
			if (int.TryParse(DistanciaPedagios.Text, out distanciaPedagio) == false)
			{
				lblMensagem.Text = "Preencha todos os Campos, existe campo em branco !!";
				return;
			}
			int custoQuilometro;
			if (int.TryParse(CustoPercorrido.Text, out custoQuilometro) == false)
			{
				lblMensagem.Text = "Preencha todos os Campos, existe campo em branco !!";
				return;
			}
			int valorPedagios;
			if (int.TryParse(ValorPedagios.Text, out valorPedagios) == false)
			{
				lblMensagem.Text = "Preencha todos os Campos, existe campo em branco !!";
				return;
			}

			int totalPedagios = comprimentoEstrada / distanciaPedagio;
			int totalValoresPedagios = totalPedagios * valorPedagios;
			int totalCustoQuilometros = custoQuilometro * comprimentoEstrada;
			int total = totalValoresPedagios + totalCustoQuilometros;

			CustoTotal.Text = total.ToString();

			lblMensagem.Text = "Calculado!!";
		}


	}
}