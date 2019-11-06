using ModelProject;
using PersistenceProject.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class UsuarioController
    {
        // DAO Usuario
        private DAO_Usuario daoUser = new DAO_Usuario();
        // Lista de usuários
        IList<Usuario> usuarios;

        // get login
        public Usuario GetLogin(string login, string senha)
        {
            return this.daoUser.GetLogin(login, senha);
        }

        // get all users
        public IList<Usuario> GetAll()
        {
            return this.daoUser.GetAll();
        }

        public void Salvar(Usuario user, string login, string senha)
        {
            if (user != null)
                this.daoUser.Salvar(user, login, senha);
        }
    }
}
