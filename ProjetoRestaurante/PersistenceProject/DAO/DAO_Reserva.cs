using ModelProject;
using PersistenceProject.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceProject.DAO
{
    public class DAO_Reserva
    {
        private SqlConnection conn = DBConnection.DB_Connection; // variavel de conexão
        private SqlCommand cmd; // variavel para comandos sql
        private DAO_Mesa daoMesa = new DAO_Mesa();

        // GET: AllReservas
        // método repsonsavel por obter todas as reservas cadastradas
        public IList<Reserva> GetAll()
        {
            IList<Reserva> reservas = new List<Reserva>(); // lista de reservas

            try
            {
                // comando que irá realizar select em todas as reservas
                cmd = new SqlCommand("SELECT Id, NomeCliente, CpfCliente, NumMesa, ReservaInicio, Finalizada FROM Reservas", conn);
                conn.Open(); // abre a conexão
                using (SqlDataReader reader = cmd.ExecuteReader()) // comando que irá executar o comando e passar tudo quefoi lido para variavel reader
                {
                    while (reader.Read()) // enquanto houver leitura
                    {
                        // nova instancia de reserva passando os dados recebidos na leitura
                        Reserva reserva = new Reserva
                        {
                            Id = reader.GetInt32(0),
                            NomeCliente = reader.GetString(1),
                            CpfCliente = reader.GetString(2),
                            NumMesa = reader.GetString(3),
                            ReservaInicio = reader.GetDateTime(4).ToString(),
                            Finalizada = reader.GetBoolean(5)
                        };
                        // adiciona o item lido na lista de reservas
                        reservas.Add(reserva);
                    }
                }
                conn.Close(); // apos terminar a leitura encerra a conexão
            }
            catch (Exception err)
            {
                Console.WriteLine("Erro ao buscar todas as reservas!\nErro: " + err);
            }
            return reservas;
        }

        // GET: ReservaById
        // método repsonsavel por obter uma reserva através do Id
        public Reserva GetById(int id)
        {
            Reserva reserva = null; // cria uma variavel para armazenar a reserva obtida
            try
            {
                // comando que irá realizar select
                cmd = new SqlCommand("SELECT Id, NomeCliente, CpfCliente, NumMesa, ReservaInicio, Finalizada FROM Reservas WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id); // passa o parametro recebido para sqlparam
                conn.Open(); // abre a conexão
                using (SqlDataReader reader = cmd.ExecuteReader()) // comando que irá executar o comando e passar tudo quefoi lido para variavel reader
                {
                    while (reader.Read()) // enquanto houver leitura
                    {
                        // nova instancia de reserva passando os dados recebidos na leitura
                        reserva = new Reserva
                        {
                            Id = reader.GetInt32(0),
                            NomeCliente = reader.GetString(1),
                            CpfCliente = reader.GetString(2),
                            NumMesa = reader.GetString(3),
                            ReservaInicio = reader.GetDateTime(4).ToString(),
                            Finalizada=reader.GetBoolean(5)
                        };
                    }
                }
                conn.Close(); // apos terminar a leitura encerra a conexão
            }
            catch (Exception err)
            {
                Console.WriteLine("Erro ao buscar todas as reservas!\nErro: " + err);
            }
            return reserva;
        }

        // GET: ReservaByNome
        // método repsonsavel por obter uma reserva através do nome
        public IList<Reserva> GetByNome(string nome)
        {
            IList<Reserva> reservas = null; // cria uma variavel para armazenar a reserva obtida
            try
            {
                // comando que irá realizar select
                cmd = new SqlCommand("SELECT Id, NomeCliente, CpfCliente, NumMesa, ReservaInicio, Finalizada FROM Reservas WHERE NomeCliente LIKE @NomeCliente", conn);
                cmd.Parameters.AddWithValue("@NomeCliente", nome); // passa o parametro recebido para sqlparam
                conn.Open(); // abre a conexão
                using (SqlDataReader reader = cmd.ExecuteReader()) // comando que irá executar o comando e passar tudo quefoi lido para variavel reader
                {
                    while (reader.Read()) // enquanto houver leitura
                    {
                        // nova instancia de reserva passando os dados recebidos na leitura
                        reservas.Add(new Reserva
                        {
                            Id = reader.GetInt32(0),
                            NomeCliente = reader.GetString(1),
                            CpfCliente = reader.GetString(2),
                            NumMesa = reader.GetString(3),
                            ReservaInicio = reader.GetDateTime(4).ToString(),
                            Finalizada = reader.GetBoolean(5)
                        });
                    }
                }
                conn.Close(); // apos terminar a leitura encerra a conexão
            }
            catch (Exception err)
            {
                Console.WriteLine("Erro ao buscar todas as reservas do cliente!\nErro: " + err);
            }
            return reservas;
        }

        // GET: ReservaByCpf
        // método repsonsavel por obter uma reserva através do cpf
        public Reserva GetByCpf(string cpf)
        {
            Reserva reserva = null; // cria uma variavel para armazenar a reserva obtida
            try
            {
                // comando que irá realizar select
                cmd = new SqlCommand("SELECT Id, NomeCliente, CpfCliente, NumMesa, ReservaInicio, Finalizada FROM Reservas WHERE CpfCliente = @Cpf", conn);
                cmd.Parameters.AddWithValue("@Cpf", cpf); // passa o parametro recebido para sqlparam
                conn.Open(); // abre a conexão
                using (SqlDataReader reader = cmd.ExecuteReader()) // comando que irá executar o comando e passar tudo quefoi lido para variavel reader
                {
                    while (reader.Read()) // enquanto houver leitura
                    {
                        // nova instancia de reserva passando os dados recebidos na leitura
                        reserva = new Reserva
                        {
                            Id = reader.GetInt32(0),
                            NomeCliente = reader.GetString(1),
                            CpfCliente = reader.GetString(2),
                            NumMesa = reader.GetString(3),
                            ReservaInicio = reader.GetDateTime(4).ToString(),
                            Finalizada = reader.GetBoolean(5)
                        };
                    }
                }
                conn.Close(); // apos terminar a leitura encerra a conexão
            }
            catch (Exception err)
            {
                Console.WriteLine("Erro ao buscar todas as reservas!\nErro: " + err);
            }
            return reserva;
        }
        // GET: LastReserva
        // Responsavel por obter a ultima inserção
        public Reserva GetLast()
        {
            Reserva reserva = null; // cria uma variavel para armazenar a reserva obtida
            try
            {
                // comando que irá realizar select
                cmd = new SqlCommand("SELECT TOP 1 Id, NomeCliente, CpfCliente, NumMesa, ReservaInicio, Finalizada FROM Reservas ORDER BY Id DESC", conn);
                conn.Open(); // abre a conexão
                using (SqlDataReader reader = cmd.ExecuteReader()) // comando que irá executar o comando e passar tudo quefoi lido para variavel reader
                {
                    while (reader.Read()) // enquanto houver leitura
                    {
                        // nova instancia de reserva passando os dados recebidos na leitura
                        reserva = new Reserva
                        {
                            Id = reader.GetInt32(0),
                            NomeCliente = reader.GetString(1),
                            CpfCliente = reader.GetString(2),
                            NumMesa = reader.GetString(3),
                            ReservaInicio = reader.GetDateTime(4).ToString(),
                            Finalizada = reader.GetBoolean(5)
                        };
                    }
                }
                conn.Close(); // apos terminar a leitura encerra a conexão
            }
            catch (Exception err)
            {
                Console.WriteLine("Erro ao buscar todas as reservas!\nErro: " + err);
            }
            return reserva;
        }

        // SAVE: método responsavel por verificar se o comando a executar será uma inserção ou um update
        public Reserva Save(Reserva reserva)
        {
            if (reserva.Id != null) // verificação do id
                return Update(reserva);

            // else omitido, pois caso ele entre no primeiro if já será retornado
            return Insert(reserva);
        }

        // INSERT: InsertReserva
        // Responsável por cadastrar uma nova reserva
        private Reserva Insert(Reserva rsv)
        {
            Reserva reserva = null; // cria novo objeto reserva
            try
            {
                cmd = new SqlCommand("INSERT INTO Reservas (NomeCliente, CpfCliente, NumMesa, ReservaInicio, Finalizada) VALUES (@NomeCliente, @CpfCliente, @NumMesa, @ReservaInicio, @Finalizada)", conn);
                // referenciando os parametros
                cmd.Parameters.AddWithValue("@NomeCliente", rsv.NomeCliente);
                cmd.Parameters.AddWithValue("@CpfCliente", rsv.CpfCliente);
                cmd.Parameters.AddWithValue("@NumMesa", rsv.NumMesa);
                cmd.Parameters.AddWithValue("@ReservaInicio", DateTime.ParseExact(rsv.ReservaInicio, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@Finalizada", false);
                conn.Open(); // abertura da conexão
                cmd.ExecuteNonQuery(); // executa o comando
                conn.Close(); // encerra a conexão
                daoMesa.UpdateStatus(rsv.NumMesa, false);
                reserva = GetLast(); // obtem o ultimo registro
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao inserir nova reserva!\nErro: " + e);
            }
            return reserva;
        }

        // UPDATE: UpdateReserva
        // Responsável por atualizar uma reserva
        private Reserva Update(Reserva rsv)
        {
            Reserva reserva = null; // cria um objeto reserva
            try
            {
                cmd = new SqlCommand("UPDATE Reservas SET NomeCliente=@NomeCliente, CpfCliente=@CpfCliente, NumMesa=@NumMesa, ReservaInicio=@ReservaInicio, Finalizada=@Finalizada WHERE Id = @Id", conn);
                // referenciando os parametros
                cmd.Parameters.AddWithValue("@Id", rsv.Id);
                cmd.Parameters.AddWithValue("@NomeCliente", rsv.NomeCliente);
                cmd.Parameters.AddWithValue("@CpfCliente", rsv.CpfCliente);
                cmd.Parameters.AddWithValue("@NumMesa", rsv.NumMesa);
                cmd.Parameters.AddWithValue("@ReservaInicio", rsv.ReservaInicio);
                cmd.Parameters.AddWithValue("@Finalizada", rsv.Finalizada);
                conn.Open(); // abertura da conexão
                cmd.ExecuteNonQuery(); // executa o comando
                conn.Close(); // encerra a coenxão
                if (rsv.Finalizada == true)
                {
                    daoMesa.UpdateStatus(rsv.NumMesa, true);
                }
                reserva = GetById((int)rsv.Id); // da um get na reserva atualizada através de seu id
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao atualizar reserva!\nErro: " + e);
            }
            return reserva; // retorna a reserva
        }

        // DELETE: ById
        // meotdo responsavel por deletar a reserva através do id
        public bool Delete(int id)
        {
            Reserva reserva = GetById(id);
            bool deletado = false;
            if (reserva != null)
            {
                try
                {
                    cmd = new SqlCommand("DELETE Reservas WHERE Id = @Id", conn); // comand
                    cmd.Parameters.AddWithValue("@Id", id); // referenciando o sqlparam
                    conn.Open(); // abertura da conexão
                    cmd.ExecuteNonQuery(); // executa o comando de deleção;
                    conn.Close(); // encerra a conexão
                    daoMesa.UpdateStatus(reserva.NumMesa, true);
                    deletado = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao deletar Reserva!\nErro: " + e);
                }
            }
            else
            {
                Console.WriteLine($"Reserva id: {id} não encontrada!");
            }
            return deletado;
        }
    }
}
