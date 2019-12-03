namespace ViewProject
{
    partial class TelaPedidos
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
            this.panelPedidos = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelPedido = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.cbxMesa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pedidos = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvarItem = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.panelItemPedido = new System.Windows.Forms.Panel();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorItens = new System.Windows.Forms.TextBox();
            this.txtProcurarItem = new System.Windows.Forms.TextBox();
            this.btnProcurarItem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtIdItem = new System.Windows.Forms.TextBox();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ItensPedido = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvItensPed = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelPedidos.SuspendLayout();
            this.panelPedido.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelItemPedido.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPedidos
            // 
            this.panelPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPedidos.Controls.Add(this.btnProcurar);
            this.panelPedidos.Controls.Add(this.txtProcurar);
            this.panelPedidos.Controls.Add(this.btnSalvar);
            this.panelPedidos.Controls.Add(this.btnExcluir);
            this.panelPedidos.Controls.Add(this.btnNovo);
            this.panelPedidos.Controls.Add(this.btnVoltar);
            this.panelPedidos.Controls.Add(this.panelPedido);
            this.panelPedidos.Controls.Add(this.Pedidos);
            this.panelPedidos.Controls.Add(this.panelGrid);
            this.panelPedidos.Location = new System.Drawing.Point(12, 12);
            this.panelPedidos.Name = "panelPedidos";
            this.panelPedidos.Size = new System.Drawing.Size(607, 563);
            this.panelPedidos.TabIndex = 2;
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
            // panelPedido
            // 
            this.panelPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPedido.Controls.Add(this.label4);
            this.panelPedido.Controls.Add(this.label3);
            this.panelPedido.Controls.Add(this.label1);
            this.panelPedido.Controls.Add(this.txtValorTotal);
            this.panelPedido.Controls.Add(this.txtCPF);
            this.panelPedido.Controls.Add(this.txtNomeCliente);
            this.panelPedido.Controls.Add(this.cbxMesa);
            this.panelPedido.Controls.Add(this.label2);
            this.panelPedido.Location = new System.Drawing.Point(3, 25);
            this.panelPedido.Name = "panelPedido";
            this.panelPedido.Size = new System.Drawing.Size(599, 231);
            this.panelPedido.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor total R$:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente CPF:";
            this.toolTip1.SetToolTip(this.label3, "Não obrigatório: CPF do Cliente");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente:";
            this.toolTip1.SetToolTip(this.label1, "Obrigatório: Nome do cliente");
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(117, 140);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(121, 20);
            this.txtValorTotal.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(117, 88);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(121, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(117, 47);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(121, 20);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // cbxMesa
            // 
            this.cbxMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMesa.Enabled = false;
            this.cbxMesa.FormattingEnabled = true;
            this.cbxMesa.Location = new System.Drawing.Point(117, 6);
            this.cbxMesa.Name = "cbxMesa";
            this.cbxMesa.Size = new System.Drawing.Size(121, 21);
            this.cbxMesa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nº Mesa:";
            this.toolTip1.SetToolTip(this.label2, "Obrigatório: Informe o número da mesa");
            // 
            // Pedidos
            // 
            this.Pedidos.AutoSize = true;
            this.Pedidos.Location = new System.Drawing.Point(270, 0);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(45, 13);
            this.Pedidos.TabIndex = 1;
            this.Pedidos.Text = "Pedidos";
            // 
            // panelGrid
            // 
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.dgvPedidos);
            this.panelGrid.Location = new System.Drawing.Point(13, 297);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(577, 206);
            this.panelGrid.TabIndex = 0;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(4, 3);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(568, 198);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalvarItem);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.btnRemoverItem);
            this.panel1.Controls.Add(this.btnNovoItem);
            this.panel1.Controls.Add(this.btnCancelarItem);
            this.panel1.Controls.Add(this.panelItemPedido);
            this.panel1.Controls.Add(this.ItensPedido);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(706, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 563);
            this.panel1.TabIndex = 9;
            // 
            // btnSalvarItem
            // 
            this.btnSalvarItem.Enabled = false;
            this.btnSalvarItem.Location = new System.Drawing.Point(516, 519);
            this.btnSalvarItem.Name = "btnSalvarItem";
            this.btnSalvarItem.Size = new System.Drawing.Size(75, 25);
            this.btnSalvarItem.TabIndex = 7;
            this.btnSalvarItem.Text = "Salvar";
            this.btnSalvarItem.UseVisualStyleBackColor = true;
            this.btnSalvarItem.Click += new System.EventHandler(this.btnSalvarItem_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(515, 262);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 25);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Enabled = false;
            this.btnRemoverItem.Location = new System.Drawing.Point(434, 262);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(75, 25);
            this.btnRemoverItem.TabIndex = 5;
            this.btnRemoverItem.Text = "Remover";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Enabled = false;
            this.btnNovoItem.Location = new System.Drawing.Point(353, 262);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(75, 25);
            this.btnNovoItem.TabIndex = 4;
            this.btnNovoItem.Text = "Novo";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.Enabled = false;
            this.btnCancelarItem.Location = new System.Drawing.Point(272, 262);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(75, 25);
            this.btnCancelarItem.TabIndex = 3;
            this.btnCancelarItem.Text = "Cancelar";
            this.btnCancelarItem.UseVisualStyleBackColor = true;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // panelItemPedido
            // 
            this.panelItemPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItemPedido.Controls.Add(this.cbxStatus);
            this.panelItemPedido.Controls.Add(this.label10);
            this.panelItemPedido.Controls.Add(this.label9);
            this.panelItemPedido.Controls.Add(this.txtValorItens);
            this.panelItemPedido.Controls.Add(this.txtProcurarItem);
            this.panelItemPedido.Controls.Add(this.btnProcurarItem);
            this.panelItemPedido.Controls.Add(this.panel4);
            this.panelItemPedido.Controls.Add(this.label5);
            this.panelItemPedido.Controls.Add(this.label6);
            this.panelItemPedido.Controls.Add(this.label7);
            this.panelItemPedido.Controls.Add(this.txtQtd);
            this.panelItemPedido.Controls.Add(this.txtIdItem);
            this.panelItemPedido.Controls.Add(this.txtIdPedido);
            this.panelItemPedido.Controls.Add(this.label8);
            this.panelItemPedido.Location = new System.Drawing.Point(3, 25);
            this.panelItemPedido.Name = "panelItemPedido";
            this.panelItemPedido.Size = new System.Drawing.Size(599, 231);
            this.panelItemPedido.TabIndex = 2;
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Enabled = false;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Aguardando",
            "Preparando",
            "Pronto",
            "Entregue",
            "Cancelado"});
            this.cbxStatus.Location = new System.Drawing.Point(117, 181);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Status Item:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Valor Itens R$:";
            // 
            // txtValorItens
            // 
            this.txtValorItens.Location = new System.Drawing.Point(117, 135);
            this.txtValorItens.Name = "txtValorItens";
            this.txtValorItens.ReadOnly = true;
            this.txtValorItens.Size = new System.Drawing.Size(121, 20);
            this.txtValorItens.TabIndex = 9;
            // 
            // txtProcurarItem
            // 
            this.txtProcurarItem.Enabled = false;
            this.txtProcurarItem.Location = new System.Drawing.Point(485, 29);
            this.txtProcurarItem.Name = "txtProcurarItem";
            this.txtProcurarItem.Size = new System.Drawing.Size(101, 20);
            this.txtProcurarItem.TabIndex = 7;
            // 
            // btnProcurarItem
            // 
            this.btnProcurarItem.Enabled = false;
            this.btnProcurarItem.Location = new System.Drawing.Point(349, 26);
            this.btnProcurarItem.Name = "btnProcurarItem";
            this.btnProcurarItem.Size = new System.Drawing.Size(75, 25);
            this.btnProcurarItem.TabIndex = 8;
            this.btnProcurarItem.Text = "Procurar";
            this.btnProcurarItem.UseVisualStyleBackColor = true;
            this.btnProcurarItem.Click += new System.EventHandler(this.btnProcurarItem_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgvItens);
            this.panel4.Location = new System.Drawing.Point(349, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 160);
            this.panel4.TabIndex = 8;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(3, 3);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(229, 152);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.Visible = false;
            this.dgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Item:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Pedido:";
            // 
            // txtQtd
            // 
            this.txtQtd.Enabled = false;
            this.txtQtd.Location = new System.Drawing.Point(117, 87);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(121, 20);
            this.txtQtd.TabIndex = 4;
            // 
            // txtIdItem
            // 
            this.txtIdItem.Enabled = false;
            this.txtIdItem.Location = new System.Drawing.Point(117, 50);
            this.txtIdItem.Name = "txtIdItem";
            this.txtIdItem.Size = new System.Drawing.Size(121, 20);
            this.txtIdItem.TabIndex = 3;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Location = new System.Drawing.Point(117, 13);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(121, 20);
            this.txtIdPedido.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cardapio:";
            // 
            // ItensPedido
            // 
            this.ItensPedido.AutoSize = true;
            this.ItensPedido.Location = new System.Drawing.Point(270, 0);
            this.ItensPedido.Name = "ItensPedido";
            this.ItensPedido.Size = new System.Drawing.Size(66, 13);
            this.ItensPedido.TabIndex = 1;
            this.ItensPedido.Text = "Itens Pedido";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvItensPed);
            this.panel3.Location = new System.Drawing.Point(13, 297);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 206);
            this.panel3.TabIndex = 0;
            // 
            // dgvItensPed
            // 
            this.dgvItensPed.AllowUserToAddRows = false;
            this.dgvItensPed.AllowUserToDeleteRows = false;
            this.dgvItensPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensPed.Location = new System.Drawing.Point(4, 3);
            this.dgvItensPed.Name = "dgvItensPed";
            this.dgvItensPed.ReadOnly = true;
            this.dgvItensPed.Size = new System.Drawing.Size(568, 198);
            this.dgvItensPed.TabIndex = 0;
            this.dgvItensPed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItensPed_CellClick);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(477, 598);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(142, 25);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // TelaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1335, 649);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaNovoPedido";
            this.panelPedidos.ResumeLayout(false);
            this.panelPedidos.PerformLayout();
            this.panelPedido.ResumeLayout(false);
            this.panelPedido.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelItemPedido.ResumeLayout(false);
            this.panelItemPedido.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPedidos;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.ComboBox cbxMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Pedidos;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProcurarItem;
        private System.Windows.Forms.TextBox txtProcurarItem;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Panel panelItemPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtIdItem;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ItensPedido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvItensPed;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorItens;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnSalvarItem;
    }
}