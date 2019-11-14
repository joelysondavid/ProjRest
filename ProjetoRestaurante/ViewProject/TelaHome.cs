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
        public TelaHome()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaLogin login = new TelaLogin();
            login.Show();
        }

        private void cadastroDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaPedidos().ShowDialog();
        }

        private void cardapioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaGerenciamentoMenu().ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaCadastroUsuario().ShowDialog();
        }
    }
}
