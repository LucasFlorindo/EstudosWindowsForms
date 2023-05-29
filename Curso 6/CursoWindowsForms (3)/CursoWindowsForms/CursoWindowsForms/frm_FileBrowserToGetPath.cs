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
    public partial class frm_FileBrowserToGetPath : Form
    {
        public frm_FileBrowserToGetPath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string folderPath = folderBrowserDialog1.SelectedPath;
            textBox1.Text = folderPath;
        }
    }
}
