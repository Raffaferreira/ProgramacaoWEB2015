<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="CadastroSimples.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Cadastro</title>

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
			<div class="wrapper-content">
				<p>Nome: </p>
				<asp:TextBox runat="server" ID="TxtNome"></asp:TextBox>
				<p>Endereço: </p>
				<asp:TextBox runat="server" ID="TxtEndereco"></asp:TextBox>
				<p>E-mail: </p>
				<asp:TextBox runat="server" ID="TxtEmail"></asp:TextBox>
				<p>Nascimento: </p>
				<asp:TextBox runat="server" ID="TxtNascimento"></asp:TextBox>
				<p>Peso: </p>
				<asp:TextBox runat="server" ID="TxtPeso"></asp:TextBox>
				<p>
					<asp:Button runat="server" ID="Cadastrar" Text="Cadastrar" OnClick="Cadastrar_Click" />
				</p>
			</div>
			<asp:Label runat="server" ID="labelMensagem" ViewStateMode="Enabled"></asp:Label>
		</div>
	</form>

</body>
</html>
