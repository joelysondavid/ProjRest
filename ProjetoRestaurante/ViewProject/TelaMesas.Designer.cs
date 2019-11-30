namespace ViewProject
{
    partial class TelaMesas
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
            this.panelMesas = new System.Windows.Forms.Panel();
            this.panelGridMesas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumMesa = new System.Windows.Forms.TextBox();
            this.txtDescricaoMesa = new System.Windows.Forms.TextBox();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelMesas.SuspendLayout();
            this.panelGridMesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMesas
            // 
            this.panelMesas.Controls.Add(this.txtDescricaoMesa);
            this.panelMesas.Controls.Add(this.txtNumMesa);
            this.panelMesas.Controls.Add(this.label2);
            this.panelMesas.Controls.Add(this.label1);
            this.panelMesas.Location = new System.Drawing.Point(12, 12);
            this.panelMesas.Name = "panelMesas";
            this.panelMesas.Size = new System.Drawing.Size(460, 170);
            this.panelMesas.TabIndex = 0;
            // 
            // panelGridMesas
            // 
            this.panelGridMesas.Controls.Add(this.dgvMesas);
            this.panelGridMesas.Location = new System.Drawing.Point(12, 251);
            this.panelGridMesas.Name = "panelGridMesas";
            this.panelGridMesas.Size = new System.Drawing.Size(460, 231);
            this.panelGridMesas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº da Mesa:";
            this.toolTip1.SetToolTip(this.label1, "Obrigatório: Este campo deve conter no máx. 5 caracteres");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            this.toolTip1.SetToolTip(this.label2, "Não obrigatório: Este campo deve conter no máx.  200 caracteres");
            // 
            // txtNumMesa
            // 
            this.txtNumMesa.Location = new System.Drawing.Point(84, 23);
            this.txtNumMesa.Name = "txtNumMesa";
            this.txtNumMesa.Size = new System.Drawing.Size(72, 20);
            this.txtNumMesa.TabIndex = 2;
            // 
            // txtDescricaoMesa
            // 
            this.txtDescricaoMesa.Location = new System.Drawing.Point(253, 23);
            this.txtDescricaoMesa.Multiline = true;
            this.txtDescricaoMesa.Name = "txtDescricaoMesa";
            this.txtDescricaoMesa.Size = new System.Drawing.Size(195, 103);
            this.txtDescricaoMesa.TabIndex = 3;
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Location = new System.Drawing.Point(3, 3);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.Size = new System.Drawing.Size(454, 225);
            this.dgvMesas.TabIndex = 0;
            this.dgvMesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesas_CellClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(397, 207);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(316, 207);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(235, 207);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(154, 207);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // TelaMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 494);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panelGridMesas);
            this.Controls.Add(this.panelMesas);
            this.Name = "TelaMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaMesas";
            this.panelMesas.ResumeLayout(false);
            this.panelMesas.PerformLayout();
            this.panelGridMesas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMesas;
        private System.Windows.Forms.TextBox txtDescricaoMesa;
        private System.Windows.Forms.TextBox txtNumMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGridMesas;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}