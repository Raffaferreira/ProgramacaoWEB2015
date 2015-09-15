<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exec1.aspx.cs" Inherits="Listas.Exec1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Lista 01</title>
	<style type="text/css">
		#content {
			margin: 0 auto;
			width: 100%;
		}

		.wrapper {
			margin: 0 auto;
			width: 26%;
		}

		.espacamento {
			padding: 10px 85px 10px 85px;
			margin: 10px;
		}
	</style>
</head>
<body>

	<div id="content">
		<div class="wrapper">
			<form id="form1" runat="server">
				<div class="espacamento">
					<p>Tempo:</p>
					<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
					<p>Velocidade:</p>
					<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
					<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
					<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
					<asp:Button ID="ButtonCalcular" runat="server" Text="Calcular" OnClick="ButtonCalcular_Click" />
					<asp:Label ID="lblMensagemErro" runat="server"></asp:Label>
				</div>
			</form>
		</div>
	</div>

</body>
</html>
