<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	
	<title>02</title>

	<style type="text/css">
		.listanomes {
			width: 200px;
			height: 400px;
		}
	</style>
</head>
<body>

	<form id="form1" runat="server">
		<div>
			<p>
				ID:
				<asp:TextBox runat="server" ID="textID"></asp:TextBox>
			</p>
			<p>
				<asp:Button runat="server" ID="Listar" Text="Listar" OnClick="Listar_Click" />
			</p>
			<p id="lista-nomes">
				<asp:ListBox ID="ListaNomes" runat="server" CssClass="listanomes"></asp:ListBox>
			</p>
			<p>
				<asp:Label runat="server" ID="lblMensagem"></asp:Label>
			</p>
		</div>
	</form>
</body>
</html>
