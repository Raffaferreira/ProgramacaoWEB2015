<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>

	<form id="form1" runat="server">
		<div>
			<p>
				Comprimento da Estrada:
				<asp:TextBox runat="server" ID="ComprimentoEstrada"></asp:TextBox>
			</p>
			<p>
				Distância entre Pedágios:
				<asp:TextBox runat="server" ID="DistanciaPedagios"></asp:TextBox>
			</p>
			<p>
				Custo Por quilômetro percorrido<asp:TextBox runat="server" ID="CustoPercorrido"></asp:TextBox>
			</p>
			<p>
				Valor de Cada pedágio<asp:TextBox runat="server" ID="ValorPedagios"></asp:TextBox>
			</p>
			<p>
				Custo total:
				<asp:TextBox runat="server" ID="CustoTotal"></asp:TextBox>
			</p>
			<p>
				<asp:Button runat="server" ID="Calcular" Text="Calcular" OnClick="Calcular_Click" />
			</p>
			<p>
				<asp:Label runat="server" ID="lblMensagem"></asp:Label>
			</p>
		</div>
	</form>

</body>
</html>
