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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            lbl_Login.Text = "Usuário";
            lbl_Password.Text = "Senha";
            btn_OK.Text = "Ok";
            btn_Cancel.Text = "Cancel";
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
