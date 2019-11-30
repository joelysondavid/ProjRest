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
    public partial class TelaReservas : Form
    {
        private MesaController mesaController;
        private ReservaController reservaController;
        public TelaReservas()
        {
            InitializeComponent();
            mesaController = new MesaController();
            reservaController = new ReservaController();
            string data = DateTime.Now.ToString();
            mtbDataHora.Text = data;
            GetAll();
        }

        // GET ALL
        private void GetAll()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = reservaController.GetAll();
            cbxMesa.DataSource = mesaController.GetMesasDisponiveis();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numMesa=cbxMesa.SelectedItem.ToString();
            Mesa mesa = mesaController.GetByNum(numMesa);
            txtDescricaoMesa.Text = mesa.Descricao;
        }
    }
}

