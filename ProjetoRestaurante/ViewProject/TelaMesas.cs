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
    public partial class TelaMesas : Form
    {
        MesaController mesaController;
        Mesa mesaAtual;
        public TelaMesas()
        {
            InitializeComponent();
            mesaController = new MesaController();
            GetAll();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                Mesa mesa = new Mesa { NumMesa = (txtNumMesa.Text).ToUpper(), Descricao = txtDescricaoMesa.Text, Disponivel = true };
                mesaController.Save(mesa);
                GetAll();
                Util.ClearTxt(panelMesas);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Util.ClearTxt(panelMesas);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int qtdL = dgvMesas.Rows.Count; // qtd de linhas
            int qtdC = dgvMesas.Columns.Count; // qtd de colunas

            // verifica se a linha e a coluna clicada são validas obs: as vezes dgv buga :(
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > qtdL || e.ColumnIndex > qtdC)
                return;

            // caso passe na verificação pega o numero da mesa clicada
            string mesaNum = (string)dgvMesas.Rows[e.RowIndex].Cells[0].Value;

            mesaAtual = mesaController.GetByNum(mesaNum); // busca a mesa no banco pelo numero

            SetCampos(mesaAtual); // invoca o metodo setcampos
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string numM = txtNumMesa.Text;
            if (numM != string.Empty)
            {
                Mesa mes = mesaController.GetByNum(numM);
                if (mes.NumMesa != null)
                {

                    if (mes.Disponivel == false)
                    {
                        mesaController.UpdateStatus(numM, true);
                        MessageBox.Show($"Mesa {numM} habilitada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    { 
                        mesaController.UpdateStatus(numM, false);
                        MessageBox.Show($"Mesa {numM} desabilitada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    GetAll();


                }
                else
                {
                    MessageBox.Show("Mesa não encontrada!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // MÉTODOS AUXILIARES

        private void GetAll()
        {
            dgvMesas.DataSource = 0;
            dgvMesas.DataSource = mesaController.GetAll();
        }
        private bool VerificaCampos()
        {
            bool valido = false;
            string txtNum = txtNumMesa.Text;
            string txtDesc = txtNumMesa.Text;
            if (txtNum != string.Empty)
            {
                if (txtNum.Length <= 5 && txtDesc.Length <= 200)
                {
                    valido = true;
                }
                else
                {
                    MessageBox.Show("A quandtidade de caractere não pode ser excedida!\nNumero mesa pode conter no máx. 5 caracters e a Descrição deve ter no máx. 200 caracters", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return valido;
        }
        private void SetCampos(Mesa mesa)
        {
            mesaAtual = null;
            txtNumMesa.Text = mesa.NumMesa;
            txtDescricaoMesa.Text = mesa.Descricao;
        }
    }
}
