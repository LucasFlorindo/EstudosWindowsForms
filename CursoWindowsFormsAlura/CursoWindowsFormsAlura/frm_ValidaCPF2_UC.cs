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
    public partial class frm_ValidaCPF2_UC : UserControl
    {
        public frm_ValidaCPF2_UC()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            msk_CPF.Text = "";
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "").Replace(",", "");
            vConteudo = vConteudo.Trim();
            if (vConteudo == "")
            {
                MessageBox.Show("Você deve digitar o CPF!", "Mensagem de validação.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (vConteudo.Length != 11)
                {
                    MessageBox.Show("O CPF deve conter 11 dígitos!", "Mensagem de validação.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de validação)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        bool validaCPF = false;
                        validaCPF = Cls_Uteis.Valida(msk_CPF.Text);
                        if (validaCPF == true)
                        {

                            MessageBox.Show("CPF Válido!", "Mensagem de validação.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido!", "Mensagem de validação.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }


            }



        }

        private void msk_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

