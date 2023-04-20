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
    public partial class frm_ValidaCPF : Form
    {
        public frm_ValidaCPF()
        {
            InitializeComponent();
        }

        public bool Valida(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = "";
            msk_CPF.Text = "";

        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCPF = false;
            validaCPF = Valida(msk_CPF.Text);
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
    }
}
