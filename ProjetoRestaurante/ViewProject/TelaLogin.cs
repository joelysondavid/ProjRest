using ControllerProject;
using ModelProject;
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
            Usuario user = usrController.GetLogin(login, senha);
            if (user.Id != null)
            {
                this.Hide(); // esconde a tela de login
                TelaHome home = new TelaHome(); // instancia a tela home
                MessageBox.Show("Login realizado com sucesso!");
                home.Show(); // abre a tela home
            } else
            {
                MessageBox.Show("Falha ao realizar login!");
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // encerra toda a aplicação
        }
    }
}
