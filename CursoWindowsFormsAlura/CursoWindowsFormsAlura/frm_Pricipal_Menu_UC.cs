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
    public partial class frm_Pricipal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemonstracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaCPF2 = 0;
        public frm_Pricipal_Menu_UC()
        {
            InitializeComponent();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;
            frm_ValidaCPF_UC U = new frm_ValidaCPF_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF" + ControleValidaCPF;
            TB.Text = "Valida CPF" + ControleValidaCPF;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            frm_DemonstracaoKey_UC U = new frm_DemonstracaoKey_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Demonstração key" + ControleHelloWorld;
            TB.Text = "Demonstração Key" + ControleHelloWorld;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            tbc_Aplicacoes.TabPages.Add(TB);
        }


        
        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ControleDemonstracaoKey += 1;
            frm_HelloWorld_UC U = new frm_HelloWorld_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Hello World" + ControleHelloWorld;
            TB.Text = "Hello World" + ControleHelloWorld;
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            tbc_Aplicacoes.TabPages.Add(TB);

        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;
            frm_Mascara_UC U = new frm_Mascara_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Mascara" + ControleMascara;
            TB.Text = "Mascara" + ControleMascara;
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;
            frm_ValidaCPF2_UC U = new frm_ValidaCPF2_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF2" + ControleValidaCPF2;
            TB.Text = "Valida CPF2" + ControleValidaCPF2;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaSenha f = new frm_ValidaSenha();
            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Principal_Menu_Load(object sender, EventArgs e)
        {

        }

        private void tbc_Aplicacoes_Click(object sender, EventArgs e)
        {

        }

        private void mnu_Principal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbc_Aplicacoes.TabPages.Remove(tbc_Aplicacoes.SelectedTab);
        }
    }
}
