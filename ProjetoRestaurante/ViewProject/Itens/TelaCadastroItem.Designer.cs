namespace ViewProject.Itens
{
    partial class TelaCadastroItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelecionaImagem = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTempoPrep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.ptbImagem = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbImagem);
            this.panel1.Controls.Add(this.btnSelecionaImagem);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTempoPrep);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDetalhes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDescr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 180);
            this.panel1.TabIndex = 0;
            // 
            // btnSelecionaImagem
            // 
            this.btnSelecionaImagem.Location = new System.Drawing.Point(268, 138);
            this.btnSelecionaImagem.Name = "btnSelecionaImagem";
            this.btnSelecionaImagem.Size = new System.Drawing.Size(126, 20);
            this.btnSelecionaImagem.TabIndex = 10;
            this.btnSelecionaImagem.Text = "Selecionar Imagem";
            this.btnSelecionaImagem.UseVisualStyleBackColor = true;
            this.btnSelecionaImagem.Click += new System.EventHandler(this.btnSelecionaImagem_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(117, 138);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(100, 20);
            this.txtURL.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Imagem URL:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(117, 112);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço R$:";
            // 
            // txtTempoPrep
            // 
            this.txtTempoPrep.Location = new System.Drawing.Point(134, 86);
            this.txtTempoPrep.Name = "txtTempoPrep";
            this.txtTempoPrep.Size = new System.Drawing.Size(83, 20);
            this.txtTempoPrep.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tempo de Preparo:";
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Location = new System.Drawing.Point(117, 60);
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(100, 20);
            this.txtDetalhes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detalhes Item:";
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(117, 34);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(100, 20);
            this.txtDescr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição Item:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(254, 218);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(45, 218);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ofdImagem
            // 
            this.ofdImagem.DefaultExt = "*.png || *.jpg || *.jpeg";
            this.ofdImagem.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg";
            this.ofdImagem.Title = "Selecione a Imagem do Item";
            // 
            // ptbImagem
            // 
            this.ptbImagem.Location = new System.Drawing.Point(268, 22);
            this.ptbImagem.Name = "ptbImagem";
            this.ptbImagem.Size = new System.Drawing.Size(126, 106);
            this.ptbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagem.TabIndex = 11;
            this.ptbImagem.TabStop = false;
            this.ptbImagem.WaitOnLoad = true;
            // 
            // TelaCadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 272);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCadastroItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaCadastroItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTempoPrep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecionaImagem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private System.Windows.Forms.PictureBox ptbImagem;
    }
}