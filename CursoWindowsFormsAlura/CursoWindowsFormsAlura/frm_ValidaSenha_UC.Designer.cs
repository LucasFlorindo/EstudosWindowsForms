
namespace CursoWindowsFormsAlura
{
    partial class frm_ValidaSenha_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_VerSenha = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_VerSenha
            // 
            this.btn_VerSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VerSenha.Location = new System.Drawing.Point(304, 60);
            this.btn_VerSenha.Name = "btn_VerSenha";
            this.btn_VerSenha.Size = new System.Drawing.Size(111, 23);
            this.btn_VerSenha.TabIndex = 7;
            this.btn_VerSenha.Text = "Ver senha";
            this.btn_VerSenha.UseVisualStyleBackColor = true;
            this.btn_VerSenha.Click += new System.EventHandler(this.btn_VerSenha_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset.Location = new System.Drawing.Point(304, 31);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(111, 23);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = " Limpa";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Resultado.Location = new System.Drawing.Point(28, 21);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 29);
            this.lbl_Resultado.TabIndex = 5;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Senha.Location = new System.Drawing.Point(28, 34);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(261, 22);
            this.txt_Senha.TabIndex = 4;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            // 
            // frm_ValidaSenha_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_VerSenha);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Senha);
            this.Name = "frm_ValidaSenha_UC";
            this.Size = new System.Drawing.Size(483, 169);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VerSenha;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txt_Senha;
    }
}
