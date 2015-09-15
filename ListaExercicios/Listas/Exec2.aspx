<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exec2.aspx.cs" Inherits="Listas.Exec2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Exec2</title>

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
					Numero 1:
					<asp:TextBox ID="TextNumero1" runat="server"></asp:TextBox>
					<div id="operadores">
						<asp:Button ID="Soma" runat="server" Text="+" OnClick="Soma_Click" />
						<asp:Button ID="Substracao" runat="server" Text="-" OnClick="Substracao_Click" />
						<asp:Button ID="Multiplicacao" runat="server" Text="*" OnClick="Multiplicacao_Click" />
						<asp:Button ID="Divisao" runat="server" Text="/" OnClick="Divisao_Click" />
					</div>
					Numero 2:
					<asp:TextBox ID="TextNumero2" runat="server"></asp:TextBox>
					Resultado:
					<asp:TextBox ID="TextResultado" runat="server"></asp:TextBox>
					<asp:Label ID="LabelMensagem" runat="server"></asp:Label>
				</div>
			</form>
		</div>
	</div>


</body>
</html>
