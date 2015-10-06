<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exclusao.aspx.cs" Inherits="CadastroSimples.Exclusao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

	<title>Exclusão</title>

	<style type="text/css">
		body {
			margin: 5px;
			padding: 5px;
		}

		p {
		}

		.cadaster-content {
			border: 1px solid #000;
			background-color: #EFEFEF;
			text-align: center;
			height: 100%;
		}

		.wrapper-content {
			width: 100%;
			height: 100%;
		}
	</style>

</head>
<body>

	<form id="form1" runat="server">
		<div class="cadaster-content">
			<h1 style="text-align: center;">EXCLUSÃO DE CADASTRO</h1>
			<div class="wrapper-content">
				<asp:Label runat="server" ID="lblMsg"></asp:Label>
				<br />
				<asp:Button runat="server" ID="btnSIM" Text="Sim" OnClick="btnSIM_Click" />
				<asp:Button runat="server" ID="btnNAO" Text="Nao" OnClick="btnNAO_Click" />
			</div>
		</div>
	</form>

</body>
</html>
