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
            ClearControls();
            GetAll();
        }

        // GET ALL
        private void GetAll()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = reservaController.GetAll();
            cbxMesa.DataSource = mesaController.GetMesasDisponiveis();
            cbxMesa.SelectedIndex = -1;
            string data = DateTime.Now.ToShortDateString();
            mtbData.Text = data;
            txtDescricaoMesa.Clear();
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
            cbxMesa.SelectedIndex = -1;
            Util.ClearTxt(panelReserva);
            reservaAtual = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                string horario = (mtbHora.Text).Replace(":", "").Trim();
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
                ClearControls();
                GetAll();

            }
            else
            {
                MessageBox.Show("Todos os campos devem estar preenchidos corretamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearControls();
            GetAll();
        }

        private bool VerificaCampos()
        {
            // verificação da hora
            if (txtNomeCliente.Text != string.Empty && cbxMesa.SelectedIndex != -1 && mtbHora.Text.Replace(":", "").Trim() != string.Empty)
            {
                if(Util.VerificaNome(txtNomeCliente.Text))
                    return true;
            }

            return false;
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int qtdL = dgvReservas.Rows.Count; // qtd linahs
            int qtlC = dgvReservas.Columns.Count; // qtd colunas

            if ((e.RowIndex < 0 || e.ColumnIndex < 0) || (e.RowIndex > qtdL || e.ColumnIndex > qtlC))
                return;

            int idReserva = (int)dgvReservas.Rows[e.RowIndex].Cells[0].Value;
            reservaAtual = reservaController.GetById(idReserva);
            SetCampos(reservaAtual);
        }

        private void SetCampos(Reserva reserva)
        {
            if (reserva != null)
            {
                mtbData.Text = reserva.ReservaInicio;
                mtbHora.Text = reserva.ReservaInicio.Substring(11);
                txtNomeCliente.Text = reserva.NomeCliente;
                txtCPF.Text = reserva.CpfCliente;
                IList<Mesa> mesasDisp = mesaController.GetMesasDisponiveis(); // mesas disponiveis
                if (!mesasDisp.Contains(mesaController.GetByNum(reserva.NumMesa)))
                {
                    mesasDisp.Add(mesaController.GetByNum(reserva.NumMesa));
                    cbxMesa.DataSource = null;
                }
                Mesa mesa = mesaController.GetByNum(reserva.NumMesa);
                cbxMesa.DataSource = mesasDisp;
                cbxMesa.SelectedItem = mesa;
                txtDescricaoMesa.Text = mesa.Descricao;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (reservaAtual != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja realmente apagar a reserva?", "Confimação", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    bool deletado = reservaController.Delete((int)reservaAtual.Id);
                    if (deletado == true)
                    {
                        MessageBox.Show("Reserva apagada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                        GetAll();
                    } else
                        MessageBox.Show("Erro ao deletar reserva!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

        }
    }
}

