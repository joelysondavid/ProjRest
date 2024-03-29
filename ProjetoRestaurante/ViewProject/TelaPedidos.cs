﻿using ControllerProject;
using ModelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class TelaPedidos : Form
    {
        MesaController mesaController;
        PedidoController pedidoController;
        ItemController itemController;
        Pedido pedidoAtual;
        IList<ItemPedido> itensPed = new List<ItemPedido>();
        IList<Mesa> mesas = new List<Mesa>();
        ItemPedido itemPedAtual;
        Item itemAtual;
        public TelaPedidos()
        {
            InitializeComponent();
            mesaController = new MesaController();
            pedidoController = new PedidoController();
            itemController = new ItemController();
            GetAll();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // verificar os campos
            if (CamposValidos())
            {
                Pedido pedido = new Pedido
                {
                    Id = pedidoAtual == null ? null : pedidoAtual.Id,
                    NumMesa = cbxMesa.SelectedItem.ToString(),
                    NomeCliente = txtNomeCliente.Text,
                    CpfCliente = txtCPF.Text,
                    DataPed = DateTime.Now.ToShortDateString(),
                    Status = "Em andamento",
                    ItensDePedido = pedidoAtual == null ? new List<ItemPedido>() : pedidoAtual.ItensDePedido
                };
                pedidoController.Save(pedido);
                AlterControls(false);
                ClearControls(panelPedido);
                GetAll();
                MessageBox.Show("Pedido inciado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AlterControls(true); // altera os campos que devem ser habilitados/desabilitados
            cbxMesa.DataSource = mesaController.GetMesasDisponiveis();
            btnExcluir.Enabled = false;
            ClearControlsItem(); // garante que os controles dos itens serão limpos
            ControlsBasicos(false); // caso os botoes dos itens estejam habilitadas ele desabilita
            ClearControls(panelPedido); // chama o metodo para limpar os campos
            pedidoAtual = null;
            cbxMesa.Focus();
            btnFinalizar.Enabled = false;
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // quantidade de linhas e colunas
            int qtdL = dgvPedidos.Rows.Count;
            int qtdC = dgvPedidos.Columns.Count;

            // verifica se o item selecionado é valido, caso contrário ele retorna sem fazer ação
            if ((e.RowIndex < 0 || e.ColumnIndex < 0) || (e.RowIndex > qtdL || e.ColumnIndex > qtdC)) return;

            // passa o id do item selecionado
            int pedId = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells[0].Value);
            pedidoAtual = pedidoController.GetById(pedId);
            // quando eu clicar recebo todos os itens deste pedido
            itensPed = pedidoController.GetAllItensPedido(pedId);

            // chama o metodo para setar os campos
            SetCamposPed(pedId);


            // chama o metodo alter controls
            AlterControls(true);
            btnExcluir.Enabled = true;
            dgvPedidos.ClearSelection();
            btnFinalizar.Enabled = true;
        }

        // --- ITEMS ---
        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            if (pedidoAtual != null)
            {
                Util.ClearTxt(panelItemPedido);
                txtIdPedido.Text = pedidoAtual.Id.ToString();
                ControlsItem(true);
                btnSalvarItem.Enabled = false;
                cbxStatus.SelectedIndex = 0;
                dgvItensPed.DataSource = null;
                dgvItensPed.DataSource = pedidoController.GetAllItensPedido(pedidoAtual.Id);
            }
        }

        // excluir pedido
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (pedidoAtual.Id != null)
            {
                if (pedidoAtual.ItensDePedido.Count > 0)
                {
                    MessageBox.Show("Pedido não pode ser apagado pois já contém itens!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir o pedido?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    int idPed = (int)pedidoAtual.Id;
                    string numMesa = pedidoAtual.NumMesa;
                    pedidoController.DeleteById(idPed, numMesa);
                    GetAll();
                    ClearControlsItem();
                    ClearControls(panelPedido);
                    MessageBox.Show("Pedido apagado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // itens ped 
        private void dgvItensPed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int qtdL = dgvItensPed.Rows.Count; // qtd linhas
            int qtdC = dgvItensPed.Columns.Count; // qtd colunas
            // se o indice da coluna ou de linha estiver invalido retornara
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > qtdL || e.ColumnIndex > qtdC) return;

            // os itens de pedidos serão constantemente alterados

            int itemPedId = Convert.ToInt32(dgvItensPed.Rows[e.RowIndex].Cells[0].Value);
            ItemPedido item = pedidoController.GetItemById(itemPedId);
            SetCamposItensPed(item);
            btnAdicionar.Enabled = false; // desabilita botao adicionar caso eu clique me um item de pedido
            cbxStatus.Enabled = true;
            btnSalvarItem.Enabled = true;
        }

        // seta os campos
        private void SetCamposItensPed(ItemPedido itemPedido)
        {
            if (itemPedido.Id != null)
            {
                Item item = itemController.GetById(itemPedido.ItemId);
                txtNomeItem.Text = item.Descricao;
                txtQtd.Text = itemPedido.Quantidade.ToString();
                txtValorItens.Text = itemPedido.ValorItens.ToString();
                cbxStatus.SelectedItem = itemPedido.Status;
                itemPedAtual = itemPedido;
            }
        }

        // carrega dgvItensPed
        private void CarregaItensPed()
        {
            dgvItensPed.DataSource = null;
            dgvItensPed.DataSource = pedidoController.GetAllItensPedido(pedidoAtual.Id);
        }

        private void btnProcurarItem_Click(object sender, EventArgs e)
        {
            dgvItens.DataSource = itemController.GetItemByDisponibilidade("%" + txtProcurarItem.Text + "%", true);
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            ControlsItem(false);
            ClearControlsItem();
            btnCancelarItem.Enabled = false;
            btnNovoItem.Enabled = false;
            dgvItensPed.DataSource = null;
            btnSalvarItem.Enabled = false;
        }


        // --- METODOS AUXILIARES ---

        // metodo get all
        private void GetAll()
        {
            dgvPedidos.ClearSelection();
            dgvPedidos.DataSource = pedidoController.GetByStatus("%%", "Em andamento");
            dgvItens.DataSource = itemController.GetItemByDisponibilidade("%%", true);
            mesas = mesaController.GetMesasDisponiveis();
            cbxMesa.DataSource = mesas;
            if (pedidoAtual == null)
                cbxMesa.SelectedIndex = -1;
        }

        // clear controls
        private void ClearControls(Panel panel)
        {

            cbxMesa.SelectedIndex = -1;
            Util.ClearTxt(panel);
            dgvPedidos.ClearSelection();
            pedidoAtual = null;
        }

        // alter controls
        private void AlterControls(bool chav)
        {
            cbxMesa.Enabled = chav;
            txtNomeCliente.Enabled = chav;
            txtCPF.Enabled = chav;
            txtValorTotal.Enabled = chav;
            btnSalvar.Enabled = chav;
        }

        // verifica campos
        private bool CamposValidos()
        {
            bool valido = false;
            if (cbxMesa.SelectedIndex != -1 && !String.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                if (txtNomeCliente.Text.Contains(" ") || Util.VerificaNome(txtNomeCliente.Text))
                    valido = true;
            }
            else
                MessageBox.Show("Os campos devem estar preenchidos corretamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return valido;
        }

        // alter controls de itens
        private void ControlsItem(bool chav)
        {
            if (pedidoAtual != null)
            {
                txtQtd.Enabled = chav;
                cbxStatus.Enabled = chav;
                dgvItens.Visible = chav;
                btnProcurarItem.Enabled = chav;
                txtProcurarItem.Enabled = chav;
                // caso eu click para adicionar um item a um pedido devo desabilitar a configiuração dos pedidos
                cbxMesa.Enabled = !chav;
                txtNomeCliente.Enabled = !chav;
                txtCPF.Enabled = !chav;
                dgvPedidos.Enabled = !chav;
                btnVoltar.Enabled = !chav;
                btnNovo.Enabled = !chav;
                btnExcluir.Enabled = !chav;
                btnSalvar.Enabled = !chav;
            }
        }

        // limpar campos itens
        private void ClearControlsItem()
        {
            Util.ClearTxt(panelItemPedido);
            cbxStatus.SelectedIndex = -1;
            dgvItensPed.DataSource = null;
        }
        private void ControlsBasicos(bool chav)
        {
            btnNovoItem.Enabled = chav;
            btnCancelarItem.Enabled = chav;
        }

        // Seta os campos
        private void SetCamposPed(int idPed)
        {
            ClearControls(panelItemPedido); // limpa os campos
            pedidoAtual = pedidoController.GetById(idPed); // obtem o pedido atual
            if (pedidoAtual != null) // caso o pedido atual seja diferente de null
            {
                // verificação da mesa
                IList<Mesa> mesasDisp = mesaController.GetMesasDisponiveis(); // mesas disponiveis
                if (!mesasDisp.Contains(mesaController.GetByNum(pedidoAtual.NumMesa))) // caso a mesa 
                {
                    mesasDisp.Add(mesaController.GetByNum(pedidoAtual.NumMesa));
                    cbxMesa.DataSource = null;
                }
                cbxMesa.DataSource = mesasDisp;
                cbxMesa.SelectedItem = mesaController.GetByNum(pedidoAtual.NumMesa);
                // mesaController.GetByNum(pedidoAtual.NumMesa); // verificar 
                txtNomeCliente.Text = pedidoAtual.NomeCliente;
                txtCPF.Text = pedidoAtual.CpfCliente;
                txtValorTotal.Text = pedidoAtual.ValorTotal.ToString();
                ControlsBasicos(true);
                txtIdPedido.Text = pedidoAtual.Id.ToString();
                dgvItensPed.DataSource = itensPed;
            }
        }

        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // quantidade de linhas e colunas
            int qtdL = dgvItens.Rows.Count;
            int qtdC = dgvItens.Columns.Count;

            // verifica se o item selecionado é valido, caso contrário ele retorna sem fazer ação
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > qtdL || e.ColumnIndex > qtdC) return;

            int itemId = (int)dgvItens.Rows[e.RowIndex].Cells[0].Value;
            itemAtual = itemController.GetById(itemId);
            txtNomeItem.Text = itemAtual.Descricao;

            ControlsItem(true);
            txtQtd.Focus();
            btnAdicionar.Enabled = true;
        }

        // campos itens valido
        private bool CamposItensValidos()
        {
            bool valido = false;
            int inteiro = 0;
            if ((txtIdPedido.Text != string.Empty & txtIdPedido.Text != string.Empty & txtQtd.Text != string.Empty) & (int.TryParse(txtQtd.Text, out inteiro) & cbxStatus.SelectedIndex != -1))
                valido = true;
            else
                MessageBox.Show("Preeecha os valores corretamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return valido;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (CamposItensValidos())
            {
                Item item = itemController.GetById((int)itemAtual.Id);

                ItemPedido itemPed = new ItemPedido
                {
                    PedidoId = Convert.ToInt32(txtIdPedido.Text),
                    ItemId = (int)item.Id,
                    Quantidade = Convert.ToInt32(txtQtd.Text),
                    ValorItens = Convert.ToInt32(txtQtd.Text) * item.Preco,
                    Status = cbxStatus.SelectedItem.ToString()
                };
                // itensPed.Add(itemPed);
                pedidoAtual.ItensDePedido.Add(itemPed); // adiciona o item a lista de itens de pedido
                pedidoAtual = pedidoController.Save(pedidoAtual); // salva o item
                GetAll();
                ClearControlsItem(); // limpa os campos do panel item
                txtIdPedido.Text = pedidoAtual.Id.ToString();
                ControlsItem(false); // desabilita os campos do item
                // ControlsBasicos(false); // desabilita o botao de adicionar e o botao de remover
                CarregaItensPed(); // carrega os itens
                btnAdicionar.Enabled = false;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (pedidoAtual != null)
            {
                if (pedidoAtual.ItensDePedido.Count > 0)
                {
                    foreach (var item in pedidoAtual.ItensDePedido)
                    {
                        if (item.Status != "Entregue" && item.Status != "Cancelado")
                        {
                            MessageBox.Show("Para finalziar o pedido não podem haver itens em aberto.\nOs itens devem ser entregues ou cancelados!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    if (DialogResult.Yes == MessageBox.Show("Deseja realmente finalizar este pedido?\nTotal de R$ " + pedidoAtual.ValorTotal + " Reais\nConfirmar Pagamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Pedido pedido = pedidoAtual;
                        pedido.DataPed = DateTime.Today.ToShortDateString();
                        pedido.Status = "Finalizado";
                        pedidoController.Save(pedido);
                        GetAll();
                        ClearControlsItem();
                        ClearControls(panelPedido);
                        MessageBox.Show("Pedido finalizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Pedido não pode ser finalizado, pois não contém itens!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Pedido não selecionado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvarItem_Click(object sender, EventArgs e)
        {
            itemPedAtual.Status = cbxStatus.SelectedItem.ToString();
            for (int i = 0; i < pedidoAtual.ItensDePedido.Count; i++)
            {
                if (pedidoAtual.ItensDePedido[i].Id == itemPedAtual.Id)
                {
                    pedidoAtual.ItensDePedido[i] = itemPedAtual;
                }
            }
            pedidoController.Save(pedidoAtual);
            btnSalvarItem.Enabled = false;
            dgvItensPed.DataSource = null;
            Util.ClearTxt(panelItemPedido);
            ControlsItem(false); // desabilita os campos do ite
            GetAll();
            cbxStatus.SelectedIndex = -1;
            txtIdPedido.Text = pedidoAtual.Id.ToString();
            dgvItensPed.DataSource = pedidoController.GetAllItensPedido(pedidoAtual.Id);
        }
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = pedidoController.GetByStatus("%" + txtProcurar.Text + "%", "Em andamento");
        }
    }
}
