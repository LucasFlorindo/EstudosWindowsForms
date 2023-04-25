
namespace CursoWindowsFormsAlura
{
    partial class frm_HelloWorld_UC
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
            this.txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.btn_ModificaLabel = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ConteudoLabel
            // 
            this.txt_ConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ConteudoLabel.Location = new System.Drawing.Point(119, 212);
            this.txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            this.txt_ConteudoLabel.Size = new System.Drawing.Size(406, 22);
            this.txt_ConteudoLabel.TabIndex = 6;
            this.txt_ConteudoLabel.TextChanged += new System.EventHandler(this.txt_ConteudoLabel_TextChanged);
            // 
            // btn_ModificaLabel
            // 
            this.btn_ModificaLabel.Location = new System.Drawing.Point(119, 140);
            this.btn_ModificaLabel.Name = "btn_ModificaLabel";
            this.btn_ModificaLabel.Size = new System.Drawing.Size(285, 45);
            this.btn_ModificaLabel.TabIndex = 5;
            this.btn_ModificaLabel.Text = "Modificar o texto da Label";
            this.btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.btn_ModificaLabel.Click += new System.EventHandler(this.btn_ModificaLabel_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(137, 113);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(257, 24);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Visual Studio.NET Version";
            this.lbl_Titulo.Click += new System.EventHandler(this.lbl_Titulo_Click);
            // 
            // frm_HelloWorld_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_ConteudoLabel);
            this.Controls.Add(this.btn_ModificaLabel);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "frm_HelloWorld_UC";
            this.Size = new System.Drawing.Size(773, 432);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ConteudoLabel;
        private System.Windows.Forms.Button btn_ModificaLabel;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}
