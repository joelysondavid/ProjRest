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
    public partial class TelaCadastroUsuario : Form
    {
        private UsuarioController controller;
        private Usuario userAtual;
        public TelaCadastroUsuario()
        {
            InitializeComponent();
            controller = new UsuarioController();
            GetAll();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!VerificaCampos())
            {
                Usuario user = new Usuario
                {
                    Nome = txtNome.Text
                    ,
                    Cpf = txtCpf.Text
                    ,
                    Login = txtLogin.Text
                    ,
                    Senha = txtSenha.Text
                    ,
                    TipoUsr = cbxTipo.SelectedItem.ToString()
                };
                Usuario usuario = controller.Salvar(user, null, null);
                if (usuario.Id != null)
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAll();
                }
                else
                {
                    MessageBox.Show("Erro ao inserir Usuário!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Todos os Campos com asterisco devem ser preenchidos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // método auxiliar verifica se os campos estão vázios
        private bool VerificaCampos()
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                return true;
            }
            return false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Util.ClearTxt(panelUsuario);
            cbxTipo.SelectedIndex = -1;
            userAtual = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (userAtual == null)
            {
                MessageBox.Show("Usuário não selecionado ou não encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("Deseja realmete apagar este usuario?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bool deletado=controller.Delete((int)userAtual.Id);
                if (deletado == true)
                {
                    MessageBox.Show("Usuario deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userAtual = null;
                    GetAll();
                }
                else
                    MessageBox.Show("Erro ao deletar usuario!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Erro ao deletar usuario!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAll()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = controller.GetAll();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int qtdL = dgvUsuarios.Rows.Count; // qtd de linhas
            int qtdC = dgvUsuarios.Columns.Count; // qtd colunas

            if ((e.RowIndex < 0 || e.ColumnIndex < 0) || (e.RowIndex > qtdL || e.ColumnIndex > qtdC)) return;

            int userId = (int)dgvUsuarios.Rows[e.RowIndex].Cells[0].Value;
            userAtual = controller.GetById(userId);
            SetCampos(userAtual);
            dgvUsuarios.ClearSelection();
        }

        private void SetCampos(Usuario user)
        {
            txtNome.Text = user.Nome;
            txtLogin.Text = user.Login;
            txtCpf.Text = user.Cpf;
            cbxTipo.SelectedItem = user.TipoUsr;
        }
    }
}
