<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercicio9.aspx.cs" Inherits="ExerciciosASPNET.Exercicio9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

	<title>Exercicio 9</title>
	<style type="text/css">
		.listanomes
		{
			width: 200px;
		}

	</style>

</head>
<body>

	<div id="container9">
		<form id="form1" runat="server">
			<div id="wrapper">
				<p>Nome:</p>
				<div id="text-nome">
					<asp:TextBox ID="TextNome" runat="server"></asp:TextBox>
				</div>
				<div id="div-adicionar">
					<asp:Button ID="BtnAdicionar" runat="server" Text="Adicionar" OnClick="BtnAdicionar_Click" />
				</div>
				<div id="lista-text">
					<asp:ListBox ID="ListaNomes" runat="server" Rows="8" CssClass="listanomes"></asp:ListBox>
				</div>
				<div id="div-remover">
					<asp:Button ID="BtnRemover" runat="server" Text="Remover Selecionado" OnClick="BtnRemover_Click" />
				</div>
				<div id="remover-todos">
					<asp:Button ID="BtnRemoverTodos" runat="server" Text="Remover Todos" OnClick="BtnRemoverTodos_Click"/>
				</div>
				<div id="lblmensagem">
					<asp:Label ID="LabelMensagem" runat="server" CssClass="LabelMsg"></asp:Label>
				</div>

			</div>
		</form>
	</div>


</body>
</html>
