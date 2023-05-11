using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Busca : Form
    {

        List<List<string>> _ListaBusca = new List<List<string>>();

        public string idSelect { get; set; }
        public Frm_Busca(List<List<string>> ListaBusca)
        {

            _ListaBusca = ListaBusca;
            InitializeComponent();
            this.Text = "Busca";
            Tls_Principal.Items[0].ToolTipText = "Salvar seleção";
            Tls_Principal.Items[1].ToolTipText = "Fechar busca";
            PreencherLista();
        }

        private void PreencherLista()
        {
            lst_Busca.Items.Clear();

            for(int i = 0; i<= _ListaBusca.Count - 1; i++)
            {
                //Nome é o elemento 1 na geração da lista ListaBusca.Add(new List<string> { C.Id, C.Nome});.
                lst_Busca.Items.Add(_ListaBusca[i][1]);

            }


        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();          
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            idSelect = _ListaBusca[lst_Busca.SelectedIndex][0];
            this.Close();
        }
    }
}
