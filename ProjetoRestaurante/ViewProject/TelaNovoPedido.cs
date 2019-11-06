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

namespace ViewProject
{
    public partial class TelaNovoPedido : Form
    {
        MesaController mesaController;
        public TelaNovoPedido()
        {
            InitializeComponent();
            mesaController = new MesaController();
            cbxNumMesa.DataSource = mesaController.GetAll();
            LimparCampos();
        }

        // limpeza dos campos
        private void LimparCampos()
        {
            this.cbxNumMesa.SelectedIndex = -1;
            this.txtNomeCliente.Clear();
            this.txtCPF.Clear();
            this.txtItens.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
