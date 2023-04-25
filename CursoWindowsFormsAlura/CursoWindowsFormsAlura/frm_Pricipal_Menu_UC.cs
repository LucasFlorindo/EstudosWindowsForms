﻿using System;
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
        public frm_Pricipal_Menu_UC()
        {
            InitializeComponent();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF2 f = new frm_ValidaCPF2();
            f.ShowDialog();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            frm_DemonstracaoKey_UC U = new frm_DemonstracaoKey_UC();
            TabPage TB = new TabPage();
            TB.Name = "Demonstração key" + ControleHelloWorld;
            TB.Text = "Demonstração Key" + ControleHelloWorld;
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            tbc_Aplicacoes.TabPages.Add(TB);
        }


        
        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ControleDemonstracaoKey += 1;
            frm_HelloWorld_UC U = new frm_HelloWorld_UC();
            TabPage TB = new TabPage();
            TB.Name = "Hello World" + ControleHelloWorld;
            TB.Text = "Hello World" + ControleHelloWorld;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            tbc_Aplicacoes.TabPages.Add(TB);

        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mascara f = new frm_Mascara();
            f.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF f = new frm_ValidaCPF();
            f.ShowDialog();
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
