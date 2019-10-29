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
        public bool GetLogin(string login, string senha)
        {
            return this.daoUser.GetLogin(login, senha);
        }
    }
}
