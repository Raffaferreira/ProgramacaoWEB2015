<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm0.aspx.cs" Inherits="WebApplication0.WebForm0" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>


	<form id="form1" runat="server">
		<div>
			<p>T1:
				<asp:TextBox runat="server" ID="TextBox1"></asp:TextBox></p>
			<p>T2:
				<asp:TextBox runat="server" ID="TextBox2"></asp:TextBox></p>
			<p>T3:
				<asp:TextBox runat="server" ID="TextBox3"></asp:TextBox></p>
			<p>T4:
				<asp:TextBox runat="server" ID="TextBox4"></asp:TextBox></p>
			<p>T5:
				<asp:TextBox runat="server" ID="TextBox5"></asp:TextBox></p>
			<p>
				<asp:Button runat="server" ID="Ordenar" Text="Ordenar" OnClick="Ordenar_Click" /></p>
			<p>
				<asp:Label ID="lblMensagem" runat="server"></asp:Label>
			</p>
		</div>
	</form>


</body>
</html>
