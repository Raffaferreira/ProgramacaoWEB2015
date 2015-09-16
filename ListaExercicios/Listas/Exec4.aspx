<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exec4.aspx.cs" Inherits="Listas.Exec4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

   <title>Exec 4</title>
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
					Lado A:
					<asp:TextBox ID="TextA" runat="server"></asp:TextBox>
					Lado B:
					<asp:TextBox ID="TextB" runat="server"></asp:TextBox>
					Lado C:
					<asp:TextBox ID="TextC" runat="server"></asp:TextBox>
					Resultado:
					<asp:TextBox ID="TextResultado" runat="server"></asp:TextBox>
					<asp:Button ID="ButtonVerificar" runat="server" Text="Verificar" OnClick="ButtonVerificar_Click" />
					<asp:Label ID="labelMensagem" runat="server"></asp:Label>
				</div>
			</form>
		</div>
	</div>
</body>
</html>
