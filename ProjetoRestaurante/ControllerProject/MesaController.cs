using ModelProject;
using PersistenceProject.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class MesaController
    {
        DAO_Mesa daoMesa = new DAO_Mesa();

        // getAllMesas
        public IList<Mesa> GetAll()
        {
            return daoMesa.GetAll();
        }
        // getMesaByNum
        public Mesa GetByNum(string num)
        {
            return daoMesa.GetByNum(num);
        }
        // cadastro nova mesa

    }
}
