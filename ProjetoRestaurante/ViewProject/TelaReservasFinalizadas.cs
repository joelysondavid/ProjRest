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
    public partial class TelaReservasFinalizadas : Form
    {
        private ReservaController reservaController;
        public TelaReservasFinalizadas()
        {
            InitializeComponent();
            reservaController = new ReservaController();
            GetAll();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetAll()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = reservaController.GetReservasByStatus("%%",true);
        }
    }
}
