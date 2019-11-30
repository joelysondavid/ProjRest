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

        // delete
        public void DeleteByNum(string num)
        {
            daoMesa.Delete(num);
        }
        public IList<Mesa> GetMesasDisponiveis()
        {
            return daoMesa.GetMesasDisponiveis();
        }

        // cadastro ou atualização nova mesa
        public Mesa Save(Mesa mesa)
        {
            return daoMesa.Save(mesa);
        }
    }
}
