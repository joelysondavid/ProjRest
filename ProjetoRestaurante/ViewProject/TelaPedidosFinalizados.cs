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
    public partial class TelaPedidosFinalizados : Form
    {
        private PedidoController pedidoController;
        public TelaPedidosFinalizados()
        {
            InitializeComponent();
            pedidoController = new PedidoController();
            GetAll();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetAll()
        {
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidoController.GetByStatus("%%","Finalizado");
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int qtdL = dgvPedidos.Rows.Count; // qtd Linhas
            int qtdC = dgvPedidos.Columns.Count; // qtd colunas

            if ((e.RowIndex < 0 || e.ColumnIndex < 0) || (e.RowIndex > qtdL || e.ColumnIndex > qtdC))
                return;

            int idPedido = (int)dgvPedidos.Rows[e.RowIndex].Cells[0].Value;
            Pedido pedido = pedidoController.GetById(idPedido);
            dgvItensDePedidos.DataSource = pedidoController.GetAllItensPedido(idPedido);
            lblPedidos.Text = $"Itens do pedido id: {idPedido}";
            lblPedido.Text = $"Pedido de total R$ {pedido.ValorTotal}";
        }
    }
}
