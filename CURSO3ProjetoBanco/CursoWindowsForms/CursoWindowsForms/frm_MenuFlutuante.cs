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
    public partial class frm_MenuFlutuante : Form
    {
        public frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var PosicaoX = e.X;
                var PosicaoY = e.Y;

                //MessageBox.Show("Relative click position: ("+PosicaoX.ToString()+","+ PosicaoY.ToString()+")");

                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = new ToolStripMenuItem();
                vToolTip001.Text = "Item do menu 1";
                ContextMenu.Items.Add(vToolTip001.Text);
                ContextMenu.Show(this, new Point(PosicaoX, PosicaoY));

            }

        }
    }
}
