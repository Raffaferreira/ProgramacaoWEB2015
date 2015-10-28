using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExerciciosASPNET
{
	public partial class Exercicio11 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void BtnAdicionar2_Click(object sender, EventArgs e)
		{
			string nome = txtNome.Text;
			float valor;

			if (nome.Length == 0)
			{
				LabelMensagem2.Text = "Digite um Nome, o campo está em branco !";
				return;
			}
			if (float.TryParse(txtValor.Text, out valor) == false)
			{
				LabelMensagem2.Text = "Digite um valor, o campo está em branco !";
				return;
			}

			ListaNomes2.Items.Add(string.Format("", txtNome.Text, txtValor.Text));
			LabelMensagem2.Text = "Itens adicionado na lista";
		}

		protected void BtnRemover2_Click(object sender, EventArgs e)
		{
			if( ListaNomes2.SelectedIndex < 0 )
			{
				LabelMensagem2.Text = "Você não selecionou nenhum item para ser excluído!";
				return;
			}
			else
			{
				ListaNomes2.Items.RemoveAt(ListaNomes2.SelectedIndex);
				LabelMensagem2.Text = "Item selecionado, foi removido!";
			}
		}

		protected void BtnRemoverTodos2_Click(object sender, EventArgs e)
		{
			ListaNomes2.Items.Clear();
			LabelMensagem2.Text = "Todos foram removidos!";
		}

		protected void ObterInfo_Click(object sender, EventArgs e)
		{
			if(ListaNomes2.SelectedIndex < 0  )
			{
				LabelMensagem2.Text = "Você não selecionou nenhum item para obter a informação!";
				return;
			}
			else
			{
				
			}

		}


	}
}