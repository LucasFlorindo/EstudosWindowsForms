﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; 
using System.Threading.Tasks;
using System.Windows.Forms;

using static CursoWindowsFormsBiblioteca.Cls_Uteis;

namespace CursoWindowsFormsAlura
{
    public partial class frm_ValidaSenha : Form
    {

        bool verSenhaTxt = false;
        public frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Senha.Text = "";
            lbl_Resultado.Text = "";

        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(txt_Senha.Text);
            lbl_Resultado.Text = forca.ToString();


            if (lbl_Resultado.Text ==  "Inaceitavel"| lbl_Resultado.Text == "Fraca")
            {
                lbl_Resultado.ForeColor = Color.Red;
            }

            if (lbl_Resultado.Text == "Aceitável")
            {
                lbl_Resultado.ForeColor = Color.Blue;
            }
            if (lbl_Resultado.Text == "Forte" | lbl_Resultado.Text == "Segura")
            {
                lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void btn_VerSenha_Click(object sender, EventArgs e)
        {
            
            if(verSenhaTxt == false)
            {
                txt_Senha.PasswordChar = '\0';
                verSenhaTxt = true;
                btn_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                txt_Senha.PasswordChar = '*';
                verSenhaTxt = false;
                btn_VerSenha.Text = "Ver senha";
            }


        }

        private void frm_ValidaSenha_Load(object sender, EventArgs e)
        {

        }
    }




}
