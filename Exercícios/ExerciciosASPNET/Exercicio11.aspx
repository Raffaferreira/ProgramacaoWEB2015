<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercicio11.aspx.cs" Inherits="ExerciciosASPNET.Exercicio11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Exercicio 11</title>
	<style>
		.listanomes2
		{
			width: 200px;
		}
	</style>
</head>
<body>


	<form id="form11" runat="server">
		<div>

			Nome: <asp:TextBox runat="server" ID="txtNome"></asp:TextBox>
			<br />
			Valor: <asp:TextBox runat="server" ID="txtValor"></asp:TextBox>

			<div id="div-adicionar">
				<asp:Button ID="BtnAdicionar2" runat="server" Text="Adicionar" OnClick="BtnAdicionar2_Click"/>
			</div>
			<div id="lista-text">
				<asp:ListBox ID="ListaNomes2" runat="server" Rows="10" CssClass="listanomes2"></asp:ListBox>
			</div>
			<div id="div-remover">
				<asp:Button ID="BtnRemover2" runat="server" Text="Remover Selecionado" OnClick="BtnRemover2_Click"/>
			</div>
			<div id="remover-todos">
				<asp:Button ID="BtnRemoverTodos2" runat="server" Text="Remover Todos" OnClick="BtnRemoverTodos2_Click"/>
			</div>
			<div id="obter-info">
				<asp:Button ID="ObterInfo" runat="server" Text="Obter Informação"  OnClick="ObterInfo_Click"/>
			</div>
			<div id="lblmensagem">
				<asp:Label ID="LabelMensagem2" Visible="true" runat="server" CssClass="LabelMsg2"></asp:Label>
			</div>
		</div>
	</form>


</body>
</html>
