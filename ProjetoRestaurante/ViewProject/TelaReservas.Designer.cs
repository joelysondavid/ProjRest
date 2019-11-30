namespace ViewProject
{
    partial class TelaReservas
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
            this.components = new System.ComponentModel.Container();
            this.panelCardapio = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelPedido = new System.Windows.Forms.Panel();
            this.mtbDataHora = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.cbxMesa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Reservas = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricaoMesa = new System.Windows.Forms.TextBox();
            this.panelCardapio.SuspendLayout();
            this.panelPedido.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCardapio
            // 
            this.panelCardapio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardapio.Controls.Add(this.btnProcurar);
            this.panelCardapio.Controls.Add(this.txtProcurar);
            this.panelCardapio.Controls.Add(this.btnSalvar);
            this.panelCardapio.Controls.Add(this.btnExcluir);
            this.panelCardapio.Controls.Add(this.btnLimpar);
            this.panelCardapio.Controls.Add(this.btnVoltar);
            this.panelCardapio.Controls.Add(this.panelPedido);
            this.panelCardapio.Controls.Add(this.Reservas);
            this.panelCardapio.Controls.Add(this.panelGrid);
            this.panelCardapio.Location = new System.Drawing.Point(11, 24);
            this.panelCardapio.Name = "panelCardapio";
            this.panelCardapio.Size = new System.Drawing.Size(607, 563);
            this.panelCardapio.TabIndex = 10;
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
            this.btnSalvar.Location = new System.Drawing.Point(515, 262);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 25);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(434, 262);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 25);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(353, 262);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 25);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
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
            // panelPedido
            // 
            this.panelPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPedido.Controls.Add(this.txtDescricaoMesa);
            this.panelPedido.Controls.Add(this.label5);
            this.panelPedido.Controls.Add(this.mtbDataHora);
            this.panelPedido.Controls.Add(this.label4);
            this.panelPedido.Controls.Add(this.label3);
            this.panelPedido.Controls.Add(this.label1);
            this.panelPedido.Controls.Add(this.txtCPF);
            this.panelPedido.Controls.Add(this.txtNomeCliente);
            this.panelPedido.Controls.Add(this.cbxMesa);
            this.panelPedido.Controls.Add(this.label2);
            this.panelPedido.Location = new System.Drawing.Point(3, 25);
            this.panelPedido.Name = "panelPedido";
            this.panelPedido.Size = new System.Drawing.Size(599, 231);
            this.panelPedido.TabIndex = 2;
            // 
            // mtbDataHora
            // 
            this.mtbDataHora.Location = new System.Drawing.Point(134, 19);
            this.mtbDataHora.Mask = "00/00/0000 90:00";
            this.mtbDataHora.Name = "mtbDataHora";
            this.mtbDataHora.Size = new System.Drawing.Size(121, 20);
            this.mtbDataHora.TabIndex = 12;
            this.mtbDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data e hora reserva:";
            this.toolTip1.SetToolTip(this.label4, "Obrigatório: Data e hora da Reserva");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(134, 187);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(121, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(134, 146);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(121, 20);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // cbxMesa
            // 
            this.cbxMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMesa.FormattingEnabled = true;
            this.cbxMesa.Location = new System.Drawing.Point(134, 105);
            this.cbxMesa.Name = "cbxMesa";
            this.cbxMesa.Size = new System.Drawing.Size(121, 21);
            this.cbxMesa.TabIndex = 1;
            this.cbxMesa.SelectedIndexChanged += new System.EventHandler(this.cbxMesa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mesas Diponíveis: ";
            // 
            // Reservas
            // 
            this.Reservas.AutoSize = true;
            this.Reservas.Location = new System.Drawing.Point(270, 0);
            this.Reservas.Name = "Reservas";
            this.Reservas.Size = new System.Drawing.Size(47, 13);
            this.Reservas.TabIndex = 1;
            this.Reservas.Text = "Reserva";
            // 
            // panelGrid
            // 
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.dgvReservas);
            this.panelGrid.Location = new System.Drawing.Point(13, 297);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(577, 206);
            this.panelGrid.TabIndex = 0;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(4, 3);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.Size = new System.Drawing.Size(568, 198);
            this.dgvReservas.TabIndex = 0;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(476, 598);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(142, 25);
            this.btnFinalizar.TabIndex = 11;
            this.btnFinalizar.Text = "Finalizar Reserva";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descrição da Mesa:";
            // 
            // txtDescricaoMesa
            // 
            this.txtDescricaoMesa.Location = new System.Drawing.Point(284, 47);
            this.txtDescricaoMesa.Multiline = true;
            this.txtDescricaoMesa.Name = "txtDescricaoMesa";
            this.txtDescricaoMesa.ReadOnly = true;
            this.txtDescricaoMesa.Size = new System.Drawing.Size(301, 168);
            this.txtDescricaoMesa.TabIndex = 14;
            // 
            // TelaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 635);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panelCardapio);
            this.Name = "TelaReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaReservas";
            this.panelCardapio.ResumeLayout(false);
            this.panelCardapio.PerformLayout();
            this.panelPedido.ResumeLayout(false);
            this.panelPedido.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCardapio;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.ComboBox cbxMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Reservas;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox mtbDataHora;
        private System.Windows.Forms.TextBox txtDescricaoMesa;
        private System.Windows.Forms.Label label5;
    }
}