namespace SushiRestaurant
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.dtgItens = new System.Windows.Forms.DataGridView();
            this.lblItens = new System.Windows.Forms.Label();
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            //
            // pnlMenu
            //
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnAtualizar);
            this.pnlMenu.Controls.Add(this.btnImportar);
            this.pnlMenu.Location = new System.Drawing.Point(883, 12);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(275, 640);
            this.pnlMenu.TabIndex = 17;
            //
            // btnSair
            //
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(14, 551);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(244, 73);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            //
            // btnAtualizar
            //
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(19)))));
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(14, 111);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(244, 73);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            //
            // btnImportar
            //
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(19)))));
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.White;
            this.btnImportar.Location = new System.Drawing.Point(14, 13);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(244, 73);
            this.btnImportar.TabIndex = 9;
            this.btnImportar.Text = "Importar JSON";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            //
            // pnlDados
            //
            this.pnlDados.BackColor = System.Drawing.Color.White;
            this.pnlDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDados.Controls.Add(this.dtgItens);
            this.pnlDados.Controls.Add(this.lblItens);
            this.pnlDados.Controls.Add(this.dtgPedidos);
            this.pnlDados.Controls.Add(this.lblPedidos);
            this.pnlDados.Controls.Add(this.lblTitulo);
            this.pnlDados.Controls.Add(this.pctLogo);
            this.pnlDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDados.Location = new System.Drawing.Point(9, 12);
            this.pnlDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(867, 640);
            this.pnlDados.TabIndex = 16;
            //
            // dtgItens
            //
            this.dtgItens.BackgroundColor = System.Drawing.Color.White;
            this.dtgItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItens.Location = new System.Drawing.Point(13, 455);
            this.dtgItens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgItens.Name = "dtgItens";
            this.dtgItens.RowHeadersWidth = 51;
            this.dtgItens.RowTemplate.Height = 24;
            this.dtgItens.Size = new System.Drawing.Size(838, 170);
            this.dtgItens.TabIndex = 9;
            //
            // lblItens
            //
            this.lblItens.AutoSize = true;
            this.lblItens.Location = new System.Drawing.Point(8, 425);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(157, 25);
            this.lblItens.TabIndex = 3;
            this.lblItens.Text = "Itens do pedido:";
            //
            // dtgPedidos
            //
            this.dtgPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Location = new System.Drawing.Point(13, 164);
            this.dtgPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.RowHeadersWidth = 51;
            this.dtgPedidos.RowTemplate.Height = 24;
            this.dtgPedidos.Size = new System.Drawing.Size(838, 250);
            this.dtgPedidos.TabIndex = 8;
            this.dtgPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPedidos_CellClick);
            //
            // lblPedidos
            //
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(8, 134);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(451, 25);
            this.lblPedidos.TabIndex = 2;
            this.lblPedidos.Text = "Pedidos (clique em um pedido para ver os itens):";
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(19)))));
            this.lblTitulo.Location = new System.Drawing.Point(285, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(378, 38);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Pedidos do restaurante";
            //
            // pctLogo
            //
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(13, 10);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(252, 110);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 10;
            this.pctLogo.TabStop = false;
            //
            // FrmPedidos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1167, 664);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlDados);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos - YouNid Sushi Restaurant";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.DataGridView dtgItens;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}
