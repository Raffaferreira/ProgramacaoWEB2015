<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exec5.aspx.cs" Inherits="Listas.Exec5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Exec 5</title>
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
					Valor A:
					<asp:TextBox ID="TextA" runat="server"></asp:TextBox>
					Valor B:
					<asp:TextBox ID="TextB" runat="server"></asp:TextBox>
					Valor C:
					<asp:TextBox ID="TextC" runat="server"></asp:TextBox>
					Resultado:
					<asp:TextBox ID="Valor1" runat="server"></asp:TextBox>
					<asp:TextBox ID="Valor2" runat="server"></asp:TextBox>
					<asp:TextBox ID="Valor3" runat="server"></asp:TextBox>
					<asp:Button ID="ButtonOrdernar" runat="server" Text="Ordenar" OnClick="ButtonOrdernar_Click"/>
					<asp:Label ID="labelMensagem" runat="server"></asp:Label>
				</div>
			</form>
		</div>
	</div>
</body>
</html>
