namespace ViewProject.Itens
{
    partial class TelaGerenciamentoMenu
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
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.panelCardapio = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelCamposCardapio = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnImagem = new System.Windows.Forms.Button();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.txtTempoPrep = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.panelCardapio.SuspendLayout();
            this.panelCamposCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.dgvItens);
            this.panelGrid.Location = new System.Drawing.Point(13, 297);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(577, 206);
            this.panelGrid.TabIndex = 0;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(4, 3);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(568, 198);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellClick);
            // 
            // panelCardapio
            // 
            this.panelCardapio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardapio.Controls.Add(this.btnProcurar);
            this.panelCardapio.Controls.Add(this.txtProcurar);
            this.panelCardapio.Controls.Add(this.btnSalvar);
            this.panelCardapio.Controls.Add(this.btnExcluir);
            this.panelCardapio.Controls.Add(this.btnNovo);
            this.panelCardapio.Controls.Add(this.btnVoltar);
            this.panelCardapio.Controls.Add(this.panelCamposCardapio);
            this.panelCardapio.Controls.Add(this.label1);
            this.panelCardapio.Controls.Add(this.panelGrid);
            this.panelCardapio.Location = new System.Drawing.Point(12, 12);
            this.panelCardapio.Name = "panelCardapio";
            this.panelCardapio.Size = new System.Drawing.Size(607, 563);
            this.panelCardapio.TabIndex = 1;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(121, 264);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 25);
            this.btnProcurar.TabIndex = 8;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(14, 267);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(101, 20);
            this.txtProcurar.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(515, 262);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 25);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(434, 262);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 25);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(353, 262);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 25);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(272, 262);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 25);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panelCamposCardapio
            // 
            this.panelCamposCardapio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCamposCardapio.Controls.Add(this.txtUrl);
            this.panelCamposCardapio.Controls.Add(this.btnImagem);
            this.panelCamposCardapio.Controls.Add(this.pctImagem);
            this.panelCamposCardapio.Controls.Add(this.txtDetalhes);
            this.panelCamposCardapio.Controls.Add(this.txtTempoPrep);
            this.panelCamposCardapio.Controls.Add(this.txtPreco);
            this.panelCamposCardapio.Controls.Add(this.txtDescr);
            this.panelCamposCardapio.Controls.Add(this.label5);
            this.panelCamposCardapio.Controls.Add(this.label4);
            this.panelCamposCardapio.Controls.Add(this.label3);
            this.panelCamposCardapio.Controls.Add(this.label2);
            this.panelCamposCardapio.Location = new System.Drawing.Point(3, 25);
            this.panelCamposCardapio.Name = "panelCamposCardapio";
            this.panelCamposCardapio.Size = new System.Drawing.Size(599, 231);
            this.panelCamposCardapio.TabIndex = 2;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(448, 153);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(145, 20);
            this.txtUrl.TabIndex = 10;
            // 
            // btnImagem
            // 
            this.btnImagem.Enabled = false;
            this.btnImagem.Location = new System.Drawing.Point(478, 182);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(91, 25);
            this.btnImagem.TabIndex = 9;
            this.btnImagem.Text = "Selecionar Foto";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // pctImagem
            // 
            this.pctImagem.Location = new System.Drawing.Point(448, 6);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(146, 138);
            this.pctImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagem.TabIndex = 8;
            this.pctImagem.TabStop = false;
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Enabled = false;
            this.txtDetalhes.Location = new System.Drawing.Point(251, 6);
            this.txtDetalhes.Multiline = true;
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(173, 138);
            this.txtDetalhes.TabIndex = 7;
            // 
            // txtTempoPrep
            // 
            this.txtTempoPrep.Enabled = false;
            this.txtTempoPrep.Location = new System.Drawing.Point(117, 124);
            this.txtTempoPrep.Name = "txtTempoPrep";
            this.txtTempoPrep.Size = new System.Drawing.Size(39, 20);
            this.txtTempoPrep.TabIndex = 6;
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(117, 67);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(39, 20);
            this.txtPreco.TabIndex = 5;
            // 
            // txtDescr
            // 
            this.txtDescr.Enabled = false;
            this.txtDescr.Location = new System.Drawing.Point(83, 6);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(73, 20);
            this.txtDescr.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Preço R$: ";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "Tempo de preparo em minutos";
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tempo de Preparo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Detalhes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cardapio";
            // 
            // ofdImagem
            // 
            this.ofdImagem.DefaultExt = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            this.ofdImagem.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            // 
            // TelaGerenciamentoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(631, 587);
            this.Controls.Add(this.panelCardapio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaGerenciamentoMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cardapio";
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.panelCardapio.ResumeLayout(false);
            this.panelCardapio.PerformLayout();
            this.panelCamposCardapio.ResumeLayout(false);
            this.panelCamposCardapio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Panel panelCardapio;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelCamposCardapio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.TextBox txtTempoPrep;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private System.Windows.Forms.TextBox txtUrl;
    }
}