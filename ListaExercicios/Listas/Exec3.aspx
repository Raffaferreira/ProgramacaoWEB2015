<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exec3.aspx.cs" Inherits="Listas.Exec3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exec3</title>
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
					<p>Valor: </p>
					<asp:TextBox ID="TextBoxValor" runat="server"></asp:TextBox>
					<asp:Button ID="Fatorial" runat="server" Text="Fatorial" OnClick="Fatorial_Click"/>
					<asp:Button ID="Somatorio" runat="server" Text="Somatorio" OnClick="Somatorio_Click" />
					<asp:TextBox ID="TextBoxResultado" runat="server"></asp:TextBox>
					<asp:Label ID="LabelMensagem" runat="server"></asp:Label>
				</div>
			</form>
		</div>
	</div>
</body>
</html>
