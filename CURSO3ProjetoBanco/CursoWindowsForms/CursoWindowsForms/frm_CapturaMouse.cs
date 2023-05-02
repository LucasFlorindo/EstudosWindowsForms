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
    public partial class frm_CapturaMouse : Form
    {
        public frm_CapturaMouse()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            string str = e.Button.ToString();
            MessageBox.Show("O botão pressionado foi: " + str);
        }
    }
}
