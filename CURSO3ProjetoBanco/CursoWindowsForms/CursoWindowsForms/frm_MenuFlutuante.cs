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
                var vToolTip001 = DesnehaItemMenu("Item do Menu 1", "key");
                var vToolTip002 = DesnehaItemMenu("Item do Menu 2", "Frm_ValidaSenha");

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);

            }

            void vToolTip001_Click(object sender1, EventArgs e1)
            {

            }

            void vToolTip002_Click(object sender1, EventArgs e1)
            {

            }

            ToolStripMenuItem DesnehaItemMenu(string text, string nomeImagem)
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = text;

                Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
                vToolTip.Image = MyImage;

                return vToolTip;
            }
        }
    }
}
