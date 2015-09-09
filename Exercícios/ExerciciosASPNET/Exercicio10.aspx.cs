using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExerciciosASPNET
{
	public partial class Exercicio10 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// Ao carregar a página, deve ser false pois se não, todo o momento
			// que carregar a página (requisição ser feita), irá adicionar estes items a todo Page_Load da página, sempre
			// adicionando essas quantidades de ListItem.
			if ( IsPostBack == false )
			{
				//ListaNomes2.Items.Add(new ListItem("", ""));
				//ListaNomes2.Items.Add(new ListItem(" "," "));
				//ListaNomes2.Items.Add(new ListItem("", ""));
				//ListaNomes2.Items.Add(new ListItem(" ", " "));
			}

		}

		protected void BtnAdicionar2_Click(object sender, EventArgs e)
		{
			if ( DropListNomes.SelectedItem.Text == "" )
			{
				LabelMensagem2.Text = "Nada selecionado, você tem que selecionar algo da lista, para adicionar na tabela !";
			}
			else
			{
				ListItem selecionado = DropListNomes.SelectedItem;
				ListItem novoItem = new ListItem(selecionado.Text, selecionado.Value);
				ListaNomes2.Items.Add(novoItem);
				//ListaNomes2.Items.Add(new ListItem(DropListNomes.SelectedItem.Text, DropListNomes.SelectedItem.Value));
				LabelMensagem2.Text = "Item adicionado a lista";
			}
		}

		protected void BtnRemover2_Click(object sender, EventArgs e)
		{
			if ( ListaNomes2.SelectedIndex < 0 )
			{
				LabelMensagem2.Text = "Você não selecionou nenhum item, para remover !";
			}
			else
			{
				ListaNomes2.Items.RemoveAt(ListaNomes2.SelectedIndex);
				LabelMensagem2.Text = "Item selecionado removido !";
			}
		}

		protected void BtnRemoverTodos2_Click(object sender, EventArgs e)
		{
			ListaNomes2.Items.Clear();
			LabelMensagem2.Text = "Removidos todos!";
		}

		// Identidade = É o proprio o objeto
		// Igualdade = Dois objetos separados, distintos porém iguais.


	}
}