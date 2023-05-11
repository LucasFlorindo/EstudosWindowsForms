﻿using System;
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
        public Frm_Busca()
        {
            InitializeComponent();
            this.Text = "Busca";
            Tls_Principal.Items[0].ToolTipText = "Salvar seleção";
            Tls_Principal.Items[1].ToolTipText = "Fechar busca";
        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
    }
}
