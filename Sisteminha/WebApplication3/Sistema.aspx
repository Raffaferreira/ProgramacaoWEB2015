<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sistema.aspx.cs" Inherits="WebApplication3.Sistema" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Sistema</title>
	<style type="text/css">
		.Mensagem {
			margin:0 auto;
			padding: 0;
			width: 100%;
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<h1 class="Mensagem">Vôcê está no Sistema, seja Bem-vindo !</h1>
			<asp:Button ID="BtnLogout" runat="server" Text="Log Out" OnClick="BtnLogout_Click"/>
			<asp:Label ID="LblMensagem" runat="server" ViewStateMode="Enabled"></asp:Label>
		</div>
	</form>
</body>
</html>
