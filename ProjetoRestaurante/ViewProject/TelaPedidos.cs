using ControllerProject;
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
        ItemPedido itemPedAtual;
        public TelaPedidos()
        {
            InitializeComponent();
            mesaController = new MesaController();
            pedidoController = new PedidoController();
            itemController = new ItemController();
            GetAll(); // get all pedidos
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // verificar os campos
            if (CamposValidos())
            {
                Pedido pedido = new Pedido
                {
                    NumMesa = cbxMesa.SelectedItem.ToString(),
                    NomeCliente = txtNomeCliente.Text,
                    CpfCliente = txtCPF.Text,
                    ValorTotal = Convert.ToDecimal(txtValorTotal.Text)
                };
                pedidoAtual = pedidoController.Save(pedido);
                GetAll();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
            AlterControls(true);
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // quantidade de linhas e colunas
            int qtdL = dgvPedidos.Rows.Count;
            int qtdC = dgvPedidos.Columns.Count;

            // verifica se o item selecionado é valido, caso contrário ele retorna sem fazer ação
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > qtdL || e.ColumnIndex > qtdC) return;

            // passa o id do item selecionado
            int pedId = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells[0].Value);

            // chamando antes do set campos
            // quando eu clicar recebo todos os itens deste pedido
            itensPed = pedidoController.GetAllItensPedido(pedId);

            // chama o metodo para setar os campos
            SetCamposPed(pedId);


            // chama o metodo alter controls
            AlterControls(true);
            btnExcluir.Enabled = true;
            dgvPedidos.ClearSelection();
        }

        // --- ITEMS ---
        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            if (pedidoAtual != null)
            {
                ControlsItem(true);
                cbxStatus.SelectedIndex= 0;
            }
        }

        // excluir pedido
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (pedidoAtual.Id != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir o pedido?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    int idPed = (int)pedidoAtual.Id;
                    pedidoController.DeleteById(idPed);
                    GetAll();
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
            SetCamposItensPed(itemPedId);
            cbxStatus.Enabled = true;
            btnConfirmar.Enabled = true;
        }

        // seta os campos
        private void SetCamposItensPed(int itemPedId)
        {
            itemPedAtual = pedidoController.GetItemById(itemPedId);
            if (itemPedAtual != null)
            {
                txtIdItem.Text = itemPedAtual.ItemId.ToString();
                txtQtd.Text = itemPedAtual.Quantidade.ToString();
                txtValorItens.Text = itemPedAtual.ValorItens.ToString();
                cbxStatus.SelectedItem = itemPedAtual.Status;
            }
        }

        // carrega dgvItensPed
        private void CarregaItensPed()
        {
            dgvItensPed.DataSource = 0;
            dgvItensPed.DataSource = itensPed;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // verifica se o pedido atual é nulo
            if (itemPedAtual != null)
            {
                for (int i = 0; i < itensPed.Count; i++)
                {
                    if (itensPed[i].Id == itemPedAtual.Id)
                    {
                        itensPed[i].Status = cbxStatus.SelectedItem.ToString();
                    }
                }
            }
            pedidoAtual.ItensDePedido = itensPed;
            pedidoController.Save(pedidoAtual);
            GetAll();
            dgvItensPed.DataSource = pedidoController.GetAllItensPedido(pedidoAtual.Id);
        }

        private void btnProcurarItem_Click(object sender, EventArgs e)
        {
            dgvItens.DataSource = itemController.GetItemsByDescr("%" + txtProcurarItem.Text + "%");
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            ControlsItem(false);
            ClearControlsItem();
            btnConfirmar.Enabled = false;
        }


        // --- METODOS AUXILIARES ---

        // metodo get all
        private void GetAll()
        {
            dgvItens.DataSource = null;
            dgvPedidos.DataSource = pedidoController.GetAll();
            dgvItens.DataSource = itemController.GetAll();
            cbxMesa.DataSource = mesaController.GetAll();
            if (pedidoAtual == null)
                cbxMesa.SelectedIndex = -1;
        }

        // clear controls
        private void ClearControls()
        {
            cbxMesa.SelectedIndex = -1;
            txtNomeCliente.Clear();
            txtCPF.Clear();
            txtValorTotal.Clear();
            dgvPedidos.ClearSelection();
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
            decimal dec = 0.0m;
            if (cbxMesa.SelectedIndex != -1 && txtNomeCliente.Text != string.Empty && txtValorTotal.Text != string.Empty)
            {
                if (decimal.TryParse(txtValorTotal.Text, out dec))
                    valido = true;
                else
                    MessageBox.Show("Valor deve ser decimal!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Os campos devem estar preenchidos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            }
        }

        // limpar campos itens
        private void ClearControlsItem()
        {
            txtIdItem.Clear();
            txtQtd.Clear();
            txtValorItens.Clear();
            cbxStatus.SelectedIndex = -1;
        }
        private void ControlsBasicos(bool chav)
        {
            btnNovoItem.Enabled = chav;
            btnCancelarItem.Enabled = chav;
        }

        // Seta os campos
        private void SetCamposPed(int idPed)
        {
            ClearControls(); // limpa os campos
            pedidoAtual = pedidoController.GetById(idPed); // obtem o pedido atual
            if (pedidoAtual != null) // caso o pedido atual seja diferente de null
            {
                IList<Mesa> mesas = mesaController.GetAll();
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

            // passa o id do item selecionado
            int itemId = Convert.ToInt32(dgvItens.Rows[e.RowIndex].Cells[0].Value);
            txtIdItem.Text = itemId.ToString();

            ControlsItem(true);
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
            if (CamposItensValidos() == true)
            {
                Item item = itemController.GetById(Convert.ToInt32(txtIdItem.Text));

                ItemPedido itemPed = new ItemPedido
                {
                    PedidoId = Convert.ToInt32(txtIdPedido.Text),
                    ItemId = Convert.ToInt32(txtIdItem.Text),
                    Quantidade = Convert.ToInt32(txtQtd.Text),
                    ValorItens = Convert.ToInt32(txtQtd.Text) * item.Preco,
                    Status = cbxStatus.SelectedItem.ToString()
                };
                itensPed.Add(itemPed);
                CarregaItensPed();
                ClearControlsItem();
                ControlsItem(false);
                btnConfirmar.Enabled = true;
            }
        }
    }
}
