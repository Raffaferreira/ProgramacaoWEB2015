using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Listas
{
	public partial class Exec3 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Fatorial_Click(object sender, EventArgs e)
		{
			string valor1 = TextBoxValor.Text;
			float valorText1;
			float resultado = 1;

			if (float.TryParse(valor1, out valorText1) == false)
			{
				LabelMensagem.Text = "O campo está nulo, digite um numero...!";
				return;
			}
			else
			{
				float resultado = 1;
				while ( valorText1 != 1 )
				{
					resultado = resultado * valorText1;
					valorText1--;
				}
			}
			TextBoxResultado.Text = resultado.ToString();
			LabelMensagem.Text = "Com sucesso...!!!";
		}
		
		protected void Somatorio_Click(object sender, EventArgs e)
		{
			string valor1 = TextBoxValor.Text;
			float valorText1;

			if (float.TryParse(valor1, out valorText1) == false)
			{
				LabelMensagem.Text = "O campo está nulo, digite um numero...!";
				return;
			}
			
		}

	}
}