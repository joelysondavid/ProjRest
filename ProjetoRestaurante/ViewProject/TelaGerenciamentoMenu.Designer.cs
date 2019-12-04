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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGerenciamentoMenu));
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.panelCardapio = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelCamposCardapio = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.panelCardapio.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCamposCardapio.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.dgvItens);
            this.panelGrid.Location = new System.Drawing.Point(13, 385);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(577, 223);
            this.panelGrid.TabIndex = 0;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dgvItens.Location = new System.Drawing.Point(4, 3);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(568, 215);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellClick);
            // 
            // panelCardapio
            // 
            this.panelCardapio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardapio.Controls.Add(this.panel11);
            this.panelCardapio.Controls.Add(this.pictureBox1);
            this.panelCardapio.Controls.Add(this.btnProcurar);
            this.panelCardapio.Controls.Add(this.txtProcurar);
            this.panelCardapio.Controls.Add(this.btnSalvar);
            this.panelCardapio.Controls.Add(this.btnExcluir);
            this.panelCardapio.Controls.Add(this.btnNovo);
            this.panelCardapio.Controls.Add(this.btnVoltar);
            this.panelCardapio.Controls.Add(this.panelCamposCardapio);
            this.panelCardapio.Controls.Add(this.panelGrid);
            this.panelCardapio.Location = new System.Drawing.Point(12, 12);
            this.panelCardapio.Name = "panelCardapio";
            this.panelCardapio.Size = new System.Drawing.Size(607, 613);
            this.panelCardapio.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(15, 362);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(99, 2);
            this.panel11.TabIndex = 18;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel12.Location = new System.Drawing.Point(0, 40);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(182, 2);
            this.panel12.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.ForeColor = System.Drawing.Color.Black;
            this.btnProcurar.Location = new System.Drawing.Point(122, 339);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 30);
            this.btnProcurar.TabIndex = 8;
            this.btnProcurar.TabStop = false;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtProcurar
            // 
            this.txtProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtProcurar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcurar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.ForeColor = System.Drawing.Color.White;
            this.txtProcurar.Location = new System.Drawing.Point(14, 346);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(101, 15);
            this.txtProcurar.TabIndex = 7;
            this.txtProcurar.TabStop = false;
            this.toolTip1.SetToolTip(this.txtProcurar, "Procura pela descrição do item");
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(515, 340);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(379, 340);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 30);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Habilitatar/Desabilitar";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Black;
            this.btnNovo.Location = new System.Drawing.Point(298, 339);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 30);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(217, 339);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 30);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panelCamposCardapio
            // 
            this.panelCamposCardapio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCamposCardapio.Controls.Add(this.panel9);
            this.panelCamposCardapio.Controls.Add(this.panel7);
            this.panelCamposCardapio.Controls.Add(this.panel5);
            this.panelCamposCardapio.Controls.Add(this.panel3);
            this.panelCamposCardapio.Controls.Add(this.panel2);
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
            this.panelCamposCardapio.Location = new System.Drawing.Point(3, 3);
            this.panelCamposCardapio.Name = "panelCamposCardapio";
            this.panelCamposCardapio.Size = new System.Drawing.Size(599, 323);
            this.panelCamposCardapio.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(445, 266);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(145, 2);
            this.panel9.TabIndex = 17;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel10.Location = new System.Drawing.Point(0, 40);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(182, 2);
            this.panel10.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(248, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(173, 2);
            this.panel7.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel8.Location = new System.Drawing.Point(0, 40);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(182, 2);
            this.panel8.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(114, 238);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 2);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(182, 2);
            this.panel6.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(69, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 2);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 2);
            this.panel4.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(69, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 2);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 2);
            this.panel1.TabIndex = 13;
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.ForeColor = System.Drawing.SystemColors.Control;
            this.txtUrl.Location = new System.Drawing.Point(445, 250);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(145, 15);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.TabStop = false;
            this.toolTip1.SetToolTip(this.txtUrl, "Opcional: deve conter no máximo 250 caracteres.");
            // 
            // btnImagem
            // 
            this.btnImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnImagem.Enabled = false;
            this.btnImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagem.ForeColor = System.Drawing.Color.Black;
            this.btnImagem.Location = new System.Drawing.Point(475, 278);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(104, 33);
            this.btnImagem.TabIndex = 9;
            this.btnImagem.Text = "Selecionar Foto";
            this.btnImagem.UseVisualStyleBackColor = false;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // pctImagem
            // 
            this.pctImagem.Location = new System.Drawing.Point(445, 102);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(146, 141);
            this.pctImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagem.TabIndex = 8;
            this.pctImagem.TabStop = false;
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetalhes.Enabled = false;
            this.txtDetalhes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalhes.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDetalhes.Location = new System.Drawing.Point(248, 104);
            this.txtDetalhes.Multiline = true;
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(173, 141);
            this.txtDetalhes.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtDetalhes, "Opicional: Detalhes do item, alguns ingredientes e etc, com até 100 caracteres.");
            // 
            // txtTempoPrep
            // 
            this.txtTempoPrep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtTempoPrep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTempoPrep.Enabled = false;
            this.txtTempoPrep.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempoPrep.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTempoPrep.Location = new System.Drawing.Point(114, 224);
            this.txtTempoPrep.Name = "txtTempoPrep";
            this.txtTempoPrep.Size = new System.Drawing.Size(39, 15);
            this.txtTempoPrep.TabIndex = 2;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPreco.Location = new System.Drawing.Point(70, 164);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(78, 15);
            this.txtPreco.TabIndex = 1;
            // 
            // txtDescr
            // 
            this.txtDescr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDescr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescr.Enabled = false;
            this.txtDescr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescr.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDescr.Location = new System.Drawing.Point(71, 104);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(76, 15);
            this.txtDescr.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(10, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Preço R$:";
            this.toolTip1.SetToolTip(this.label5, "Obrigatório: Informe o preço do item em reais.");
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "Tempo de preparo em minutos";
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(7, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tempo de Preparo:";
            this.toolTip1.SetToolTip(this.label4, "Obrigatório: Informe o tempo de preparo do item.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(189, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Detalhes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição:";
            this.toolTip1.SetToolTip(this.label2, "Obrigatório: Informe o nome do produto ou descrição com até 100 caracteres.");
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(631, 637);
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
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCamposCardapio.ResumeLayout(false);
            this.panelCamposCardapio.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}