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
            this.panelGeral = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelReserva = new System.Windows.Forms.Panel();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricaoMesa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
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
            this.panelGeral.SuspendLayout();
            this.panelReserva.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeral
            // 
            this.panelGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGeral.Controls.Add(this.btnProcurar);
            this.panelGeral.Controls.Add(this.txtProcurar);
            this.panelGeral.Controls.Add(this.btnSalvar);
            this.panelGeral.Controls.Add(this.btnExcluir);
            this.panelGeral.Controls.Add(this.btnLimpar);
            this.panelGeral.Controls.Add(this.btnVoltar);
            this.panelGeral.Controls.Add(this.panelReserva);
            this.panelGeral.Controls.Add(this.Reservas);
            this.panelGeral.Controls.Add(this.panelGrid);
            this.panelGeral.Location = new System.Drawing.Point(11, 24);
            this.panelGeral.Name = "panelGeral";
            this.panelGeral.Size = new System.Drawing.Size(607, 563);
            this.panelGeral.TabIndex = 10;
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
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            // panelReserva
            // 
            this.panelReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReserva.Controls.Add(this.mtbData);
            this.panelReserva.Controls.Add(this.txtDescricaoMesa);
            this.panelReserva.Controls.Add(this.label5);
            this.panelReserva.Controls.Add(this.mtbHora);
            this.panelReserva.Controls.Add(this.label4);
            this.panelReserva.Controls.Add(this.label3);
            this.panelReserva.Controls.Add(this.label1);
            this.panelReserva.Controls.Add(this.txtCPF);
            this.panelReserva.Controls.Add(this.txtNomeCliente);
            this.panelReserva.Controls.Add(this.cbxMesa);
            this.panelReserva.Controls.Add(this.label2);
            this.panelReserva.Location = new System.Drawing.Point(3, 25);
            this.panelReserva.Name = "panelReserva";
            this.panelReserva.Size = new System.Drawing.Size(599, 231);
            this.panelReserva.TabIndex = 2;
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(134, 19);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.ReadOnly = true;
            this.mtbData.Size = new System.Drawing.Size(67, 20);
            this.mtbData.TabIndex = 15;
            this.mtbData.ValidatingType = typeof(System.DateTime);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descrição da Mesa:";
            this.toolTip1.SetToolTip(this.label5, "Descrição da mesa");
            // 
            // mtbHora
            // 
            this.mtbHora.Location = new System.Drawing.Point(213, 19);
            this.mtbHora.Mask = "00:00";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(42, 20);
            this.mtbHora.TabIndex = 12;
            this.mtbHora.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data e hora reserva:";
            this.toolTip1.SetToolTip(this.label4, "Obrigatório: Hra da Reserva, Só agendamos para o mesmo dia");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente CPF:";
            this.toolTip1.SetToolTip(this.label3, "Opcional: CPF do cliente");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente:";
            this.toolTip1.SetToolTip(this.label1, "Obrigatório: Informe o nome do cliente");
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mesas Diponíveis: ";
            this.toolTip1.SetToolTip(this.label2, "Obrigatório: Seleciona uma mesa disponivel");
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // TelaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(628, 635);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panelGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaReservas";
            this.panelGeral.ResumeLayout(false);
            this.panelGeral.PerformLayout();
            this.panelReserva.ResumeLayout(false);
            this.panelReserva.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGeral;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelReserva;
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
        private System.Windows.Forms.MaskedTextBox mtbHora;
        private System.Windows.Forms.TextBox txtDescricaoMesa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbData;
    }
}