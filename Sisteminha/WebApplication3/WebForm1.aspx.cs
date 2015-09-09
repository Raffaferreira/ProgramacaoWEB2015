using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
	public partial class WebForm1 : System.Web.UI.Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{
			//Tenta obter o cookie do cliente
			HttpCookie cookie = Request.Cookies["Rafael"];

			if (cookie != null && cookie.Value == "Conectado")
			{
				Response.Redirect("Sistema.aspx");
			}
			else
			{
				Response.Redirect("WebForm1.aspx");
			}
		}

		protected void BtnLogin_Click(object sender, EventArgs e)
		{
			string valorTxt = TextBox.Text;

			if (valorTxt == "1234")
			{
				//LabelMensagem.Text = "Senha Correta";

				HttpCookie cookie = new HttpCookie("Rafael", "Conectado");

				cookie.Expires = DateTime.Now.AddDays(7);

				Response.Cookies.Set(cookie);

				Response.Redirect("Sistema.aspx");
			}
			else
			{
				LabelMensagem.Text = "Senha incorreta";
			}
		}


	}
}