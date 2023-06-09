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
    public partial class frm_ArquivoImagem_UC : UserControl
    {
        public frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();
            lbl_ArquivoImagem.Text = nomeArquivoImagem;
            pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog Cdb = new ColorDialog();

            if(Cdb.ShowDialog() == DialogResult.OK)
            {
                lbl_ArquivoImagem.ForeColor = Cdb.Color;
            }
        }

        private void btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog Fdb = new FontDialog();
            if(Fdb.ShowDialog() == DialogResult.OK)
            {
                lbl_ArquivoImagem.Font = Fdb.Font;
            }

        }
    }
}
