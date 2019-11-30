using ModelProject;
using PersistenceProject.Connection;
using PersistenceProject.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class ReservaController
    {
        private DAO_Reserva daoReserva = new DAO_Reserva();

        // Todas as reservas
        public IList<Reserva> GetAll()
        {
            return daoReserva.GetAll();
        }
    }
}
