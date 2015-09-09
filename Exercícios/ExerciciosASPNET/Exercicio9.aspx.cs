using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExerciciosASPNET
{
	public partial class Exercicio9 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void BtnAdicionar_Click(object sender, EventArgs e)
		{
			if ( TextNome.Text == "" )
			{
				LabelMensagem.Text = "Campo de texto vazio, insira algo para ser adicionado";
			}
			else
			{
				ListaNomes.Items.Add(TextNome.Text);
				TextNome.Text = "";
				LabelMensagem.Text = "";
			}
		}

		protected void BtnRemover_Click(object sender, EventArgs e)
		{
			if ( ListaNomes.SelectedIndex < 0 )
			{
				LabelMensagem.Text = "Você não selecionou nada, para remover, selecione algo";
			}
			else
			{
				ListaNomes.Items.RemoveAt(ListaNomes.SelectedIndex);
				LabelMensagem.Text = "Item excluido com sucesso";
			}
		}

		protected void BtnRemoverTodos_Click(object sender, EventArgs e)
		{
			ListaNomes.Items.Clear();
			LabelMensagem.Text = "Todos os itens foram removidos !";
			
		}


	}
}