<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

	<title></title>
</head>
<body>

	<form id="form1" runat="server">
		<div>
			Aluno:
			<asp:DropDownList ID="DropListNomes" runat="server">
			</asp:DropDownList>
			<div>
				Nota 1:
				<asp:TextBox ID="TxtNota1" runat="server"></asp:TextBox>
			</div>
			<div>
				Nota 2:
				<asp:TextBox ID="TxtNota2" runat="server"></asp:TextBox>
			</div>
			<div>
				Nota 3:
				<asp:TextBox ID="TxtNota3" runat="server"></asp:TextBox>
			</div>
			<div>
				Nota 4:
			<asp:TextBox ID="TxtNota4" runat="server"></asp:TextBox>
			</div>

			<asp:Button ID="SubmitNotas" Text="Submeter Notas" OnClick="SubmitNotas_Click" runat="server" />
		</div>
		<asp:Label ID="lblMensagem" runat="server"></asp:Label>
	</form>


</body>
</html>
