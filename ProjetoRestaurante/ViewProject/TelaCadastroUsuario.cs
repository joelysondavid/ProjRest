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
            Usuario usuario;
            if (CamposValidos())
            {
                Usuario user = new Usuario
                {
                    Id = userAtual != null ? userAtual.Id : null,
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Login = txtLogin.Text,
                    Senha = string.IsNullOrWhiteSpace(txtNovaSenha.Text) ? txtSenha.Text : txtNovaSenha.Text,
                    TipoUsr = cbxTipo.SelectedItem.ToString()
                };
                if (userAtual != null)
                {
                    if (controller.GetLogin(user.Login, txtSenha.Text) != null)
                    {
                        usuario = controller.Salvar(user, userAtual.Login, txtSenha.Text);
                        if (txtNovaSenha.Text == string.Empty)
                        {
                            MessageBox.Show("O campo de nova senha deve estar preenchido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha antiga incompativel!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                else
                    usuario = controller.Salvar(user, null, null);

                if (usuario != null)
                {
                    MessageBox.Show("Usuario salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    GetAll();
                }
                else
                {
                    MessageBox.Show("Atenção o sistema não pode salvar o usuário, verifique se já não existe um usuário com mesmo login ou cpf!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        // método auxiliar verifica se os campos estão vázios
        private bool CamposValidos()
        {
            bool valido = false;
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtLogin.Text) && txtSenha.Text != string.Empty && cbxTipo.SelectedIndex != -1)
            {
                if (txtNome.Text.Length < 30 && txtLogin.Text.Length < 15 && txtSenha.Text.Length < 10)
                {
                    if (txtNome.Text.Contains(" ") || Util.VerificaNome(txtNome.Text))
                        valido = true;
                } else 
                    MessageBox.Show("Erro ao salvar Usuário!\nVerifique se todos os campos correspondem aos limites maximos respectivos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Erro ao salvar Usuário!\nVerifique se todos os campos estão preenchidos corretamente", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return valido;
        }

    private void btnSair_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        LimparCampos();
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
            bool deletado = controller.Delete((int)userAtual.Id);
            if (deletado == true)
            {
                MessageBox.Show("Usuario deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userAtual = null;
                GetAll();
                LimparCampos();
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
        lblNovaSenha.Visible = true;
        txtNovaSenha.Visible = true;
        lineNovaSenha.Visible = true;
    }

    private void LimparCampos()
    {
        Util.ClearTxt(panelUsuario);
        cbxTipo.SelectedIndex = -1;
        userAtual = null;
        lblNovaSenha.Visible = false;
        txtNovaSenha.Visible = false;
        lineNovaSenha.Visible = false;
    }
}
}
