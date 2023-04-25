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
    public partial class frm_DemonstracaoKey_UC : UserControl
    {
        public frm_DemonstracaoKey_UC()
        {
            InitializeComponent();
        }

        private void frm_DemonstracaoKey_UC_Load(object sender, EventArgs e)
        {

        }

        private void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            txt_Msg.AppendText("\r\n" + "Pressionei a tecla: " + e.KeyCode + "\r\n");
            txt_Msg.AppendText("\t" + "Código da tecla: " + ((int)e.KeyCode) + "\r\n");
            txt_Msg.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");

            lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Msg.Text = "";
            txt_Input.Text = "";
            lbl_Upper.Text = "";
            lbl_Lower.Text = "";
        }
    }
}
