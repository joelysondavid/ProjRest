namespace ViewProject
{
    partial class TelaHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosFinalizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasAbertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasFinalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardapioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.menuStrip1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.cardapioToolStripMenuItem,
            this.mesasToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDePedidosToolStripMenuItem,
            this.pedidosFinalizadosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // cadastroDePedidosToolStripMenuItem
            // 
            this.cadastroDePedidosToolStripMenuItem.Name = "cadastroDePedidosToolStripMenuItem";
            this.cadastroDePedidosToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.cadastroDePedidosToolStripMenuItem.Text = "Pedidos Abertos";
            this.cadastroDePedidosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePedidosToolStripMenuItem_Click);
            // 
            // pedidosFinalizadosToolStripMenuItem
            // 
            this.pedidosFinalizadosToolStripMenuItem.Name = "pedidosFinalizadosToolStripMenuItem";
            this.pedidosFinalizadosToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.pedidosFinalizadosToolStripMenuItem.Text = "Pedidos finalizados";
            this.pedidosFinalizadosToolStripMenuItem.Click += new System.EventHandler(this.pedidosFinalizadosToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasAbertasToolStripMenuItem,
            this.reservasFinalizadasToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // reservasAbertasToolStripMenuItem
            // 
            this.reservasAbertasToolStripMenuItem.Name = "reservasAbertasToolStripMenuItem";
            this.reservasAbertasToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.reservasAbertasToolStripMenuItem.Text = "Reservas Abertas";
            this.reservasAbertasToolStripMenuItem.Click += new System.EventHandler(this.reservasAbertasToolStripMenuItem_Click);
            // 
            // reservasFinalizadasToolStripMenuItem
            // 
            this.reservasFinalizadasToolStripMenuItem.Name = "reservasFinalizadasToolStripMenuItem";
            this.reservasFinalizadasToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.reservasFinalizadasToolStripMenuItem.Text = "Reservas Finalizadas";
            this.reservasFinalizadasToolStripMenuItem.Click += new System.EventHandler(this.reservasFinalizadasToolStripMenuItem_Click);
            // 
            // cardapioToolStripMenuItem
            // 
            this.cardapioToolStripMenuItem.Name = "cardapioToolStripMenuItem";
            this.cardapioToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.cardapioToolStripMenuItem.Text = "Cardapio";
            this.cardapioToolStripMenuItem.Click += new System.EventHandler(this.cardapioToolStripMenuItem_Click);
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.mesasToolStripMenuItem.Text = "Mesas";
            this.mesasToolStripMenuItem.Click += new System.EventHandler(this.mesasToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.Location = new System.Drawing.Point(822, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(66, 27);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // TelaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardapioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripMenuItem pedidosFinalizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasAbertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasFinalizadasToolStripMenuItem;
    }
}