using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>] sad
        /// 


         //DialogBox Types: 
         //OpenDialog: Escolher arquivo
         //SaveDialog: Salver arquivo no so
         //ColorDialog: Standard Colors box
         //FontDialog: Seleciona fonte
         //PrintDialog: Seleciona impressora para imprimir documento
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Principal_Menu_UC());
        }
    }
}
