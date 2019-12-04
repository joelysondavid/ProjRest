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
            try
            {
                // query selecionar a mesa referente ao numero passado no param
                command = new SqlCommand("SELECT Numero, Descricao, Disponivel FROM Mesas WHERE Numero = @Num", conn);
                // atribuindo o numero ao parametro '@Num'
                command.Parameters.AddWithValue("@Num", num);
                conn.Open(); // abre a conexão
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mesa.NumMesa = reader.GetString(0);
                        mesa.Descricao = reader.GetString(1);
                        mesa.Disponivel = reader.GetBoolean(2);
                    }
                }
                conn.Close(); // encerra a conexão
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao buscar mesa!\nErro: " + e);
            }
            return mesa;
        }

        // get todas as mesas
        // método get Mesa pelo Numero
        public IList<Mesa> GetAll()
        {
            IList<Mesa> mesas = new List<Mesa>();
            try
            {
                // lembrando que deve se verificar sempre as mesas disponiveis
                command = new SqlCommand("SELECT Numero, Descricao, Disponivel FROM Mesas", conn);
                conn.Open(); // abre a conexão
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mesas.Add(new Mesa
                        {
                            NumMesa = reader.GetString(0),
                            Descricao = reader.GetString(1),
                            Disponivel = reader.GetBoolean(2)
                        });
                    }
                }
                conn.Close(); // encerra a conexão
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao buscar todas as mesas!\nErro: " + e);

            }
            return mesas;
        }

        // buscar mesa a partir da data da disponibilidade
        public IList<Mesa> GetMesasDisponiveis()
        {
            IList<Mesa> mesasDisponiveis = new List<Mesa>();
            command = new SqlCommand("SELECT M.* FROM Mesas AS M LEFT JOIN Reservas AS R ON M.Numero = R.NumMesa WHERE M.Disponivel='True'", conn);
            conn.Open(); // abre a conexão
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    mesasDisponiveis.Add(new Mesa
                    {
                        NumMesa = reader.GetString(0),
                        Descricao = reader.GetString(1),
                        Disponivel = reader.GetBoolean(2)
                    });
                }
            }
            conn.Close();
            return mesasDisponiveis;
        }

        // cadastro de mesas
        private Mesa Insert(Mesa mesa)
        {
            Mesa mes = null;
            if (!VerificaMesa(mesa))
            {
                try
                {
                    // query
                    command = new SqlCommand("INSERT INTO Mesas VALUES (@Numero, @Descricao, @Disponivel)", conn);
                    // referencia os paramtros da query com os parametros recebidos
                    command.Parameters.AddWithValue("@Numero", mesa.NumMesa);
                    command.Parameters.AddWithValue("@Descricao", mesa.Descricao);
                    command.Parameters.AddWithValue("@Disponivel", mesa.Disponivel);
                    conn.Open(); // abre a conexão
                    command.ExecuteNonQuery(); // executa o comando
                    conn.Close(); // encerra a conexão
                    mes = GetByNum(mesa.NumMesa); // retorna a mesa que acabará de criar
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao inserir mesa!\nErro: " + e);
                }
            }
            return mes;
        }
        // método atualiza mesa 
        private Mesa Update(Mesa mesa, string numMesa)
        {
            Mesa mes = null;
            if (!VerificaMesa(mesa))
            {
                try
                {
                    // query
                    command = new SqlCommand("UPDATE Mesas SET Descricao=@Descricao, Disponivel=@Disponivel WHERE Numero = @Num", conn);
                    // referencia os paramtros da query com os parametros recebidos
                    command.Parameters.AddWithValue("@Descricao", mesa.Descricao);
                    command.Parameters.AddWithValue("@Disponivel", mesa.Disponivel);
                    command.Parameters.AddWithValue("@Num", numMesa); // numero da mesa antes da atualização
                    conn.Open(); // abre a conexão
                    command.ExecuteNonQuery(); // executa o comando
                    conn.Close(); // encerra a conexão
                    mes = GetByNum(mesa.NumMesa); // retorna a mesa que acabará de criar
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao inserir mesa!\nErro: " + e);
                }
            }
            return mes;
        }

        // update status mesa
        public Mesa UpdateStatus(string numMesa, bool status)
        {
            Mesa mes = null;
            {
                try
                {
                    // query
                    command = new SqlCommand("UPDATE Mesas SET Disponivel=@Disponivel WHERE Numero = @Num", conn);
                    // referencia os paramtros da query com os parametros recebidos
                    command.Parameters.AddWithValue("@Disponivel", status);
                    command.Parameters.AddWithValue("@Num", numMesa); // numero da mesa antes da atualização
                    conn.Open(); // abre a conexão
                    command.ExecuteNonQuery(); // executa o comando
                    conn.Close(); // encerra a conexão
                    mes = GetByNum(numMesa); // retorna a mesa que acabará de criar
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao atualizar mesa!\nErro: " + e);
                }
            }
            return mes;
        }
        // metodo para deletar uma mesa
        public void Delete(string num)
        {
            try
            {
                // query para deletar mesa apartir do num
                command = new SqlCommand("DELETE Mesas WHERE Numero = @Num", conn);
                command.Parameters.AddWithValue("@Num", num); // referenciado o parametro
                conn.Open(); // abertura da conex
                command.ExecuteNonQuery(); // execução do comando
                conn.Close(); // encerrando a conexão
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao deletar mesa!\nErro: " + e);
            }
        }
        // SAVE
        public Mesa Save(Mesa mesa)
        {
            Mesa ms = GetByNum(mesa.NumMesa);
            if (ms.NumMesa != null)
                return Update(mesa, mesa.NumMesa);
            // else omitido
            return Insert(mesa);
        }

        // verifica mesas
        private bool VerificaMesa(Mesa mesa)
        {
            // verifica se o numero da mesa ja esta cadastrado
            foreach (Mesa ms in GetAll())
            {
                if (ms == mesa) // caso uma das mesas da lista for igual a mesa passada no parametro returna true
                    return true;
            }
            return false;
        }
    }
}
