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
                //var PosicaoX = e.X;
                //var PosicaoY = e.Y;

                //MessageBox.Show("Relative click position: ("+PosicaoX.ToString()+","+ PosicaoY.ToString()+")");

                var ContextMenu = new ContextMenuStrip();

                ContextMenu.Items.Add(DesnehaItemMenu("Item do Menu 1"));
                ContextMenu.Items.Add(DesnehaItemMenu("Item do Menu 2"));
                ContextMenu.Show(this, new Point(e.X, e.Y));

            }

            ToolStripMenuItem DesnehaItemMenu(string text)
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = text;
                return vToolTip;
            }
        }
    }
}
