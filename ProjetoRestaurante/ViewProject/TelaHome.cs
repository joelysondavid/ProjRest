using ControllerProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewProject.Itens;

namespace ViewProject
{
    public partial class TelaHome : Form
    {
        ItemController itemController = new ItemController();
        MesaController mesaController = new MesaController();
        PedidoController pedidoController = new PedidoController();
        ReservaController reservaController = new ReservaController();
        UsuarioController usuarioController = new UsuarioController();

        public TelaHome()
        {
            InitializeComponent();
        }

        private void cadastroDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaPedidos().ShowDialog();
        }

        private void cardapioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaGerenciamentoMenu().ShowDialog();
        }
        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaMesas().ShowDialog();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaLogin login = new TelaLogin();
            login.Show();
        }

        private void pedidosFinalizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaPedidosFinalizados().ShowDialog();
        }

        private void reservasAbertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaReservas().ShowDialog();
        }

        private void reservasFinalizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaReservasFinalizadas().ShowDialog();
        }
        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaCadastroUsuario().ShowDialog();
        }
    }
}
