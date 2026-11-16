namespace SushiRestaurant
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pEDIDOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRDoProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pEDIDOSToolStripMenuItem,
            this.sAIRDoProgramaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // pEDIDOSToolStripMenuItem
            //
            this.pEDIDOSToolStripMenuItem.Name = "pEDIDOSToolStripMenuItem";
            this.pEDIDOSToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.pEDIDOSToolStripMenuItem.Text = "PEDIDOS";
            this.pEDIDOSToolStripMenuItem.Click += new System.EventHandler(this.pEDIDOSToolStripMenuItem_Click);
            //
            // sAIRDoProgramaToolStripMenuItem
            //
            this.sAIRDoProgramaToolStripMenuItem.Name = "sAIRDoProgramaToolStripMenuItem";
            this.sAIRDoProgramaToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.sAIRDoProgramaToolStripMenuItem.Text = "SAIR do programa";
            this.sAIRDoProgramaToolStripMenuItem.Click += new System.EventHandler(this.sAIRDoProgramaToolStripMenuItem_Click);
            //
            // pctLogo
            //
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(12, 40);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(367, 160);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            //
            // FrmPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "YouNid - Sushi Restaurant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pEDIDOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRDoProgramaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}
