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
        public IList<Reserva> GetReservasByStatus(bool status)
        {
            return daoReserva.GetReservasByStatus(status);
        }
        public IList<Reserva> GetReservaByNomeCli(string nome)
        {
            return daoReserva.GetByNome(nome);
        }
        public Reserva GetById(int id)
        {
            return daoReserva.GetById(id);
        }

        public Reserva Save(Reserva reserva)
        {
            return daoReserva.Save(reserva);
        }

        public bool Delete(int id)
        {
            return daoReserva.Delete(id);
        }

        public bool Finalizar(int id, bool finalizado)
        {
            return daoReserva.Finalizar(id, finalizado);
        }
    }
}
