using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CursoWindowsFormsBiblioteca;

namespace CursoWindowsFormsAlura
{
    public partial class frm_ValidaCPF : Form
    {
        public frm_ValidaCPF()
        {
            InitializeComponent();
        }

        

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = "";
            msk_CPF.Text = "";

        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCPF = false;
            validaCPF = Cls_Uteis.Valida(msk_CPF.Text);
            if(validaCPF == true)
            {
                lbl_Resultado.Text = "CPF Válido!";
                lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                lbl_Resultado.Text = "CPF Inválido!";
                lbl_Resultado.ForeColor = Color.Red;
            }
        }

        private void frm_ValidaCPF_Load(object sender, EventArgs e)
        {

        }
    }
}
