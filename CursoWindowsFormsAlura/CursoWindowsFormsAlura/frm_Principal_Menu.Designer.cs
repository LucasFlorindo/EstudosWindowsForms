
namespace CursoWindowsFormsAlura
{
    partial class frm_Principal_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal_Menu));
            this.mnu_Principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_Principal
            // 
            this.mnu_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.mnu_Principal.Location = new System.Drawing.Point(0, 0);
            this.mnu_Principal.Name = "mnu_Principal";
            this.mnu_Principal.Size = new System.Drawing.Size(800, 28);
            this.mnu_Principal.TabIndex = 0;
            this.mnu_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demonstraçãoKeyToolStripMenuItem,
            this.helloWorldToolStripMenuItem,
            this.mascaraToolStripMenuItem,
            this.validaCPFToolStripMenuItem,
            this.validaCPF2ToolStripMenuItem,
            this.validaSenhaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            this.demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            this.demonstraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.demonstraçãoKeyToolStripMenuItem.Text = "Demonstração Key";
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.helloWorldToolStripMenuItem.Text = "Hello World";
            // 
            // mascaraToolStripMenuItem
            // 
            this.mascaraToolStripMenuItem.Name = "mascaraToolStripMenuItem";
            this.mascaraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mascaraToolStripMenuItem.Text = "Mascara";
            // 
            // validaCPFToolStripMenuItem
            // 
            this.validaCPFToolStripMenuItem.Name = "validaCPFToolStripMenuItem";
            this.validaCPFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.validaCPFToolStripMenuItem.Text = "Valida CPF";
            // 
            // validaCPF2ToolStripMenuItem
            // 
            this.validaCPF2ToolStripMenuItem.Name = "validaCPF2ToolStripMenuItem";
            this.validaCPF2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.validaCPF2ToolStripMenuItem.Text = "Valida CPF 2";
            // 
            // validaSenhaToolStripMenuItem
            // 
            this.validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
            this.validaSenhaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.validaSenhaToolStripMenuItem.Text = "Valida Senha";
            // 
            // frm_Principal_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnu_Principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu_Principal;
            this.Name = "frm_Principal_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.mnu_Principal.ResumeLayout(false);
            this.mnu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_Principal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaCPF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
    }
}