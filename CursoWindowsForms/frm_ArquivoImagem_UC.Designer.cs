
namespace CursoWindowsForms
{
    partial class frm_ArquivoImagem_UC
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
            this.lbl_ArquivoImagem = new System.Windows.Forms.Label();
            this.pic_ArquivoImagem = new System.Windows.Forms.PictureBox();
            this.btn_Cor = new System.Windows.Forms.Button();
            this.btn_Fonte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ArquivoImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ArquivoImagem
            // 
            this.lbl_ArquivoImagem.AutoSize = true;
            this.lbl_ArquivoImagem.Location = new System.Drawing.Point(17, 36);
            this.lbl_ArquivoImagem.Name = "lbl_ArquivoImagem";
            this.lbl_ArquivoImagem.Size = new System.Drawing.Size(46, 17);
            this.lbl_ArquivoImagem.TabIndex = 0;
            this.lbl_ArquivoImagem.Text = "label1";
            // 
            // pic_ArquivoImagem
            // 
            this.pic_ArquivoImagem.Location = new System.Drawing.Point(20, 78);
            this.pic_ArquivoImagem.Name = "pic_ArquivoImagem";
            this.pic_ArquivoImagem.Size = new System.Drawing.Size(209, 156);
            this.pic_ArquivoImagem.TabIndex = 1;
            this.pic_ArquivoImagem.TabStop = false;
            // 
            // btn_Cor
            // 
            this.btn_Cor.Location = new System.Drawing.Point(20, 4);
            this.btn_Cor.Name = "btn_Cor";
            this.btn_Cor.Size = new System.Drawing.Size(75, 23);
            this.btn_Cor.TabIndex = 2;
            this.btn_Cor.Text = "Cor";
            this.btn_Cor.UseVisualStyleBackColor = true;
            this.btn_Cor.Click += new System.EventHandler(this.btn_Cor_Click);
            // 
            // btn_Fonte
            // 
            this.btn_Fonte.Location = new System.Drawing.Point(116, 4);
            this.btn_Fonte.Name = "btn_Fonte";
            this.btn_Fonte.Size = new System.Drawing.Size(75, 23);
            this.btn_Fonte.TabIndex = 3;
            this.btn_Fonte.Text = "Fonte";
            this.btn_Fonte.UseVisualStyleBackColor = true;
            this.btn_Fonte.Click += new System.EventHandler(this.btn_Fonte_Click);
            // 
            // frm_ArquivoImagem_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Fonte);
            this.Controls.Add(this.btn_Cor);
            this.Controls.Add(this.pic_ArquivoImagem);
            this.Controls.Add(this.lbl_ArquivoImagem);
            this.Name = "frm_ArquivoImagem_UC";
            this.Size = new System.Drawing.Size(514, 382);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ArquivoImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ArquivoImagem;
        private System.Windows.Forms.PictureBox pic_ArquivoImagem;
        private System.Windows.Forms.Button btn_Cor;
        private System.Windows.Forms.Button btn_Fonte;
    }
}
