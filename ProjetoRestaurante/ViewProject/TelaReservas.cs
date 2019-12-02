using ControllerProject;
using ModelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private Reserva reservaAtual;
        public TelaReservas()
        {
            InitializeComponent();
            mesaController = new MesaController();
            reservaController = new ReservaController();
            string data = DateTime.Now.ToString();
            mtbData.Text = data;
            GetAll();
            ClearControls();
        }

        // GET ALL
        private void GetAll()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = reservaController.GetAll();
            cbxMesa.DataSource = mesaController.GetMesasDisponiveis();
            cbxMesa.SelectedIndex = -1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMesa.SelectedIndex > -1)
            {
                string numMesa = cbxMesa.SelectedItem.ToString();
                Mesa mesa = mesaController.GetByNum(numMesa);
                txtDescricaoMesa.Text = mesa.Descricao;
            }
        }

        private void ClearControls()
        {
            Util.ClearTxt(panelReserva);
            cbxMesa.SelectedIndex = -1;
            mtbHora.Clear();
            reservaAtual = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                string horario = (mtbHora.Text).Replace(":","").Trim();
                if (horario.Length < 4)
                {
                    MessageBox.Show("Horario informado incorreto!\nO horario deve conter 4 caracters.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int hora;
                int minutos;
                hora = Convert.ToInt32(horario.Substring(0, 2));
                minutos = Convert.ToInt32(horario.Substring(2, 2));

                if ((hora > 20 || hora < 12) || (minutos > 59 || minutos < 00))
                {
                    MessageBox.Show("Horário inválido!\nO horário de agendamento é entre 12:00 e 20:00.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string dataHora = mtbData.Text + " " + mtbHora.Text;
                Reserva reserva = new Reserva
                {
                    Id = reservaAtual != null ? reservaAtual.Id : null,
                    NomeCliente = txtNomeCliente.Text,
                    CpfCliente = txtCPF.Text,
                    NumMesa = cbxMesa.SelectedItem.ToString(),
                    ReservaInicio = dataHora
                };
                reservaController.Save(reserva);
                GetAll();
                ClearControls();

            }
            else
            {
                MessageBox.Show("Todos os campos devem estar preenchidos corretamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private bool VerificaCampos()
        {
            // verificação da hora
            if (txtNomeCliente.Text != string.Empty && txtCPF.Text != string.Empty && cbxMesa.SelectedIndex != -1 && mtbHora.Text.Replace(":", "").Trim() != string.Empty)
                return true;

            return false;
        }

    }
}

