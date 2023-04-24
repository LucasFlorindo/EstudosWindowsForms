
namespace CursoWindowsFormsAlura
{
    partial class frm_Principal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_DemonstracaoKey = new System.Windows.Forms.Button();
            this.btn_HelloWorld = new System.Windows.Forms.Button();
            this.btn_Mascara = new System.Windows.Forms.Button();
            this.btn_ValidaCPF = new System.Windows.Forms.Button();
            this.btn_ValidaCPF2 = new System.Windows.Forms.Button();
            this.btn_ValidaSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DemonstracaoKey
            // 
            this.btn_DemonstracaoKey.Location = new System.Drawing.Point(12, 12);
            this.btn_DemonstracaoKey.Name = "btn_DemonstracaoKey";
            this.btn_DemonstracaoKey.Size = new System.Drawing.Size(114, 48);
            this.btn_DemonstracaoKey.TabIndex = 0;
            this.btn_DemonstracaoKey.Text = "Demonstração key";
            this.btn_DemonstracaoKey.UseVisualStyleBackColor = true;
            // 
            // btn_HelloWorld
            // 
            this.btn_HelloWorld.Location = new System.Drawing.Point(132, 12);
            this.btn_HelloWorld.Name = "btn_HelloWorld";
            this.btn_HelloWorld.Size = new System.Drawing.Size(114, 48);
            this.btn_HelloWorld.TabIndex = 1;
            this.btn_HelloWorld.Text = "Hello World";
            this.btn_HelloWorld.UseVisualStyleBackColor = true;
            // 
            // btn_Mascara
            // 
            this.btn_Mascara.Location = new System.Drawing.Point(252, 12);
            this.btn_Mascara.Name = "btn_Mascara";
            this.btn_Mascara.Size = new System.Drawing.Size(114, 48);
            this.btn_Mascara.TabIndex = 2;
            this.btn_Mascara.Text = "Mascara";
            this.btn_Mascara.UseVisualStyleBackColor = true;
            // 
            // btn_ValidaCPF
            // 
            this.btn_ValidaCPF.Location = new System.Drawing.Point(12, 66);
            this.btn_ValidaCPF.Name = "btn_ValidaCPF";
            this.btn_ValidaCPF.Size = new System.Drawing.Size(114, 48);
            this.btn_ValidaCPF.TabIndex = 3;
            this.btn_ValidaCPF.Text = "Valida CPF";
            this.btn_ValidaCPF.UseVisualStyleBackColor = true;
            // 
            // btn_ValidaCPF2
            // 
            this.btn_ValidaCPF2.Location = new System.Drawing.Point(132, 66);
            this.btn_ValidaCPF2.Name = "btn_ValidaCPF2";
            this.btn_ValidaCPF2.Size = new System.Drawing.Size(114, 48);
            this.btn_ValidaCPF2.TabIndex = 4;
            this.btn_ValidaCPF2.Text = "Valida CPF 2";
            this.btn_ValidaCPF2.UseVisualStyleBackColor = true;
            // 
            // btn_ValidaSenha
            // 
            this.btn_ValidaSenha.Location = new System.Drawing.Point(252, 66);
            this.btn_ValidaSenha.Name = "btn_ValidaSenha";
            this.btn_ValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.btn_ValidaSenha.TabIndex = 5;
            this.btn_ValidaSenha.Text = "Valida Senha";
            this.btn_ValidaSenha.UseVisualStyleBackColor = true;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 118);
            this.Controls.Add(this.btn_ValidaSenha);
            this.Controls.Add(this.btn_ValidaCPF2);
            this.Controls.Add(this.btn_ValidaCPF);
            this.Controls.Add(this.btn_Mascara);
            this.Controls.Add(this.btn_HelloWorld);
            this.Controls.Add(this.btn_DemonstracaoKey);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DemonstracaoKey;
        private System.Windows.Forms.Button btn_HelloWorld;
        private System.Windows.Forms.Button btn_Mascara;
        private System.Windows.Forms.Button btn_ValidaCPF;
        private System.Windows.Forms.Button btn_ValidaCPF2;
        private System.Windows.Forms.Button btn_ValidaSenha;
    }
}