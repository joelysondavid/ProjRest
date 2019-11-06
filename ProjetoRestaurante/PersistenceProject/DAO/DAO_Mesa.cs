using ModelProject;
using PersistenceProject.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceProject.DAO
{
    public class DAO_Mesa
    {
        private SqlConnection conn = DBConnection.DB_Connection;
        private SqlCommand command;
        // método get Mesa pelo Numero
        public Mesa GetByNum(string num)
        {
            Mesa mesa = new Mesa(); // instancia um novo objeto mesa
            // query selecionar a mesa referente ao numero passado no param
            command = new SqlCommand("SELECT Numero, Descricao, ReservaInicio FROM Mesas WHERE Numero = @Num", conn);
            // atribuindo o numero ao parametro '@Num'
            command.Parameters.AddWithValue("@Num", num);
            conn.Open(); // abre a conexão
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    mesa.NumMesa = reader.GetString(0);
                    mesa.Descricao = reader.GetString(1);
                    mesa.DataReserva = reader.GetDateTime(2);
                }
            }
            conn.Close(); // encerra a conexão
            return mesa;
        }

        // get todas as mesas
        // método get Mesa pelo Numero
        public IList<Mesa> GetAll()
        {
            IList<Mesa> mesas = new List<Mesa>(); // instancia um novo objeto mesa
            command = new SqlCommand("SELECT Numero, Descricao, ReservaInicio FROM Mesas", conn);
            conn.Open(); // abre a conexão
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    mesas.Add(new Mesa
                    {
                        NumMesa = reader.GetString(0),
                        Descricao = reader.GetString(1),
                        DataReserva = reader.GetDateTime(2)
                    });
                }
            }
            conn.Close(); // encerra a conexão
            return mesas;
        }
    }
}
