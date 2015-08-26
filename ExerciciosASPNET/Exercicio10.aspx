<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercicio10.aspx.cs" Inherits="ExerciciosASPNET.Exercicio10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercicio 10</title>
	<style>
		.listanomes2
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
				<asp:DropDownList ID="DropListNomes" runat="server" >
					<asp:ListItem>Rafael</asp:ListItem>
					<asp:ListItem>Isaias</asp:ListItem>
					<asp:ListItem>Raquel</asp:ListItem>
					<asp:ListItem>Paula</asp:ListItem>
					<asp:ListItem>Junior</asp:ListItem>
					<asp:ListItem>Larissa</asp:ListItem>
					<asp:ListItem>Gabriela</asp:ListItem>
					<asp:ListItem>Letícia</asp:ListItem>
				</asp:DropDownList>
				<div id="div-adicionar">
					<asp:Button ID="BtnAdicionar2" runat="server" Text="Adicionar" OnClick="BtnAdicionar2_Click" />
				</div>
				<div id="lista-text">
					<asp:ListBox ID="ListaNomes2" runat="server" Rows="10" CssClass="listanomes2"></asp:ListBox>
				</div>
				<div id="div-remover">
					<asp:Button ID="BtnRemover2" runat="server" Text="Remover Selecionado" OnClick="BtnRemover2_Click" />
				</div>
				<div id="remover-todos">
					<asp:Button ID="BtnRemoverTodos2" runat="server" Text="Remover Todos" OnClick="BtnRemoverTodos2_Click" />
				</div>
				<div id="lblmensagem">
					<asp:Label ID="LabelMensagem2" Visible="true" runat="server" CssClass="LabelMsg2"></asp:Label>
				</div>

			</div>
		</form>
	</div>


</body>
</html>
