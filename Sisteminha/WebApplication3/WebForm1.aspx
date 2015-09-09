<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Login</title>
	<style>
		.content-wrapper {
			margin: 0 auto;
			padding: 0;
		}
	</style>
</head>
<body>

	<form id="form1" runat="server">
		<div id="content-wrapper" class="content-wrapper">
			<asp:TextBox ID="TextBox" runat="server" TextMode="Password"></asp:TextBox>
			<asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
			<asp:Label ID="LabelMensagem" runat="server"></asp:Label>
		</div>
	</form>

</body>
</html>
