using ControllerProject;
using System;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class TelaLogin : Form
    {
        UsuarioController usrController;
        public TelaLogin()
        {
            InitializeComponent();
            // iniciando usr controller
            usrController = new UsuarioController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // textbox
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            if(usrController.GetLogin(login, senha) == true)
            {
                MessageBox.Show("Login realizado com sucesso!");
            } else
            {
                MessageBox.Show("Falha ao realizar login!");
            }
        }
    }
}
