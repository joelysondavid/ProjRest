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
        private IList<Mesa> mesas = new List<Mesa>();
        // método get Mesa pelo Numero
        public Mesa GetByNum(string num)
        {
            Mesa mesa = new Mesa(); // instancia um novo objeto mesa
            try
            {
                // query selecionar a mesa referente ao numero passado no param
                command = new SqlCommand("SELECT Numero, Descricao FROM Mesas WHERE Numero = @Num", conn);
                // atribuindo o numero ao parametro '@Num'
                command.Parameters.AddWithValue("@Num", num);
                conn.Open(); // abre a conexão
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mesa.NumMesa = reader.GetString(0);
                        mesa.Descricao = reader.GetString(1);
                    }
                }
                conn.Close(); // encerra a conexão
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao buscar mesa!\nErro: "+e);
            }
            return mesa;
        }

        // get todas as mesas
        // método get Mesa pelo Numero
        public IList<Mesa> GetAll()
        {
            // lembrando que deve se verificar sempre as mesas disponiveis
            command = new SqlCommand("SELECT Numero, Descricao FROM Mesas", conn);
            conn.Open(); // abre a conexão
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    this.mesas.Add(new Mesa
                    {
                        NumMesa = reader.GetString(0),
                        Descricao = reader.GetString(1)
                    });
                }
            }
            conn.Close(); // encerra a conexão
            return this.mesas;
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
                    command = new SqlCommand("INSERT INTO Mesas VALUES (@Numero, @Descricao)", conn);
                    // referencia os paramtros da query com os parametros recebidos
                    command.Parameters.AddWithValue("@Numero", mesa.NumMesa);
                    command.Parameters.AddWithValue("@Descricao", mesa.Descricao);
                    conn.Open(); // abre a conexão
                    command.ExecuteNonQuery(); // executa o comando
                    conn.Close(); // encerra a conexão
                    mes = GetByNum(mesa.NumMesa); // retorna a mesa que acabará de criar
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao inserir mesa!\nErro: "+e);
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
                    command = new SqlCommand("UPDATE Mesas VALUES (@Numero, @Descricao) WHERE Numero = @Num", conn);
                    // referencia os paramtros da query com os parametros recebidos
                    command.Parameters.AddWithValue("@Numero", mesa.NumMesa);
                    command.Parameters.AddWithValue("@Descricao", mesa.Descricao);
                    command.Parameters.AddWithValue("@Num", numMesa); // numero da mesa antes da atualização
                    conn.Open(); // abre a conexão
                    command.ExecuteNonQuery(); // executa o comando
                    conn.Close(); // encerra a conexão
                    mes = GetByNum(mesa.NumMesa); // retorna a mesa que acabará de criar
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao inserir mesa!\nErro: "+e);
                }
            }
            return mes;
        }
        // metodo para deletar uma mesa
        public void Delete(int num)
        {
            try
            {
                // query para deletar mesa apartir do num
                command = new SqlCommand("DELETE Mesa WHERE Numero = @Num", conn);
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
