using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
	public partial class Sistema : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack == true)
			{
				HttpCookie cookie = Request.Cookies["Rafael"];

				if (cookie == null || cookie.Value != "Conectado")
				{
					Response.Redirect("WebForm1.aspx");
				}
			}
		}

		protected void BtnLogout_Click(object sender, EventArgs e)
		{
			HttpCookie cookie1 = new HttpCookie("Rafael", "Desconectado");

			cookie1.Expires = DateTime.Now.AddYears(-1);

			Response.Cookies.Set(cookie1);

			Response.Redirect("WebForm1.aspx");
		}




	}
}