using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsFormsAlura
{
    public partial class frm_HelloWorld_UC : UserControl
    {
        public frm_HelloWorld_UC()
        {
            InitializeComponent();
        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = txt_ConteudoLabel.Text;
        }

        private void txt_ConteudoLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
