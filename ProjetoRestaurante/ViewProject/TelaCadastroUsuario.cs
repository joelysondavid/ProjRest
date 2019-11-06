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
        public TelaCadastroUsuario()
        {
            InitializeComponent();
            controller = new UsuarioController();
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
                controller.Salvar(user, null, null);
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
    }
}
