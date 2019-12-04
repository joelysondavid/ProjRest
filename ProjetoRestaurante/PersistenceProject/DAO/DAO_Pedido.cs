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
    public class DAO_Pedido
    {
        private DAO_ItensDePedido daoItensPed = new DAO_ItensDePedido(); // instancia de itens de pedido
        private DAO_Mesa daoMesa = new DAO_Mesa();
        private SqlConnection conn = DBConnection.DB_Connection; // variavel com conexão
        SqlCommand cmd;
        // IList<Pedido> pedidos = new List<Pedido>();

        // método get by id
        public Pedido GetById(int id)
        {
            Pedido pedido = null;
            try
            {
                // query com comando para buscar pedido por id
                cmd = new SqlCommand("SELECT Id, NumMesa, NomeCliente, CpfCliente, DataPed, Status, ValorTotal FROM Pedidos WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id); // referenciando parametro passado para query com parametro solicitado pelo metodo
                conn.Open(); // abre a conexão
                using (SqlDataReader reader = cmd.ExecuteReader()) // executa o comando de leitura
                {
                    while (reader.Read())
                    {
                        pedido = new Pedido
                        {
                            Id = reader.GetInt32(0),
                            NumMesa = reader.GetString(1),
                            NomeCliente = reader.GetString(2),
                            CpfCliente = reader.GetString(3),
                            DataPed = reader.GetDateTime(4).ToString(),
                            Status = reader.GetString(5),
                            ValorTotal = reader.GetDecimal(6),
                        };
                    }
                }
                conn.Close(); // encerra a conexão
                // após encerrar a conexão é necessário obter os itens deste pedido
                // caso contrário irá da conflito pois desta maneira não é possível executar 
                // uma abertura de conexão enquanto outra estiver sendo executada
                pedido.ItensDePedido = daoItensPed.GetByPed(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao buscar pedido!\nErro: " + e);
            }
            return pedido;
        }

        // método get all pedidos
        public IList<Pedido> GetAll()
        {
            IList<Pedido> pedidos = new List<Pedido>(); // trabalhar com uma list geral de pedidos estava dando erro
            try
            {
                // query com comando para buscar todos os pedidos
                cmd = new SqlCommand("SELECT Id, NumMesa, NomeCliente, CpfCliente, ValorTotal, DataPed, Status FROM Pedidos", conn);
                conn.Open(); // abre a conexão
                using (SqlDataReader reader = cmd.ExecuteReader()) // executa o comando de leitura
                {
                    while (reader.Read())
                    {
                        pedidos.Add(new Pedido
                        {
                            Id = reader.GetInt32(0),
                            NumMesa = reader.GetString(1),
                            NomeCliente = reader.GetString(2),
                            CpfCliente = reader.GetString(3),
                            ValorTotal = reader.GetDecimal(4),
                            DataPed = reader.GetDateTime(5).ToString(),
                            Status = reader.GetString(6)
                        });
                    }
                }
                conn.Close(); // encerra a conexão

                // após encerrar a conexão e obter todos os pedidos é necessário buscar também os itens destes pedidos
                for (int i = 0; i < pedidos.Count; i++)
                {
                    // desta forma estaremos buscando todos os itens de cada pedido
                    if (pedidos[i].ItensDePedido.Count > 0)
                        pedidos[i].ItensDePedido = daoItensPed.GetByPed(pedidos[i].Id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao buscar todos pedido!\nErro: " + e);
            }
            return pedidos;
        }

        // método get ultimo pedido
        private Pedido GetLastPed()
        {
            Pedido pedido = null;
            try
            {
                // query com comando para buscar o ultimo pedido inserido
                cmd = new SqlCommand("SELECT TOP 1 Id, NumMesa, NomeCliente, CpfCliente, ValorTotal, DataPed, Status FROM Pedidos ORDER BY Id Desc", conn);
                conn.Open(); // abre a conexão
                using (SqlDataReader reader = cmd.ExecuteReader()) // executa o comando de leitura
                {
                    while (reader.Read())
                    {
                        pedido = new Pedido
                        {
                            Id = reader.GetInt32(0),
                            NumMesa = reader.GetString(1),
                            NomeCliente = reader.GetString(2),
                            CpfCliente = reader.GetString(3),
                            ValorTotal = reader.GetDecimal(4),
                            Status = reader.GetString(6)
                        };
                    }
                }
                conn.Close(); // encerra a conexão
                // após encerrar a conexão é necessário obter os itens deste pedido
                // caso contrário irá da conflito pois desta maneira não é possível executar 
                // uma abertura de conexão enquanto outra estiver sendo executada
                pedido.ItensDePedido = daoItensPed.GetByPed(pedido.Id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao buscar pedido!\nErro: " + e);
            }
            return pedido;
        }

        public IList<Pedido> GetPedidoNomeCli(string nome)
        {
            IList<Pedido> pedidos = new List<Pedido>();
            cmd = new SqlCommand("SELECT Id, NumMesa, NomeCliente, CpfCliente, ValorTotal, DataPed, Status FROM Pedidos WHERE NomeCliente LIKE @NomeCliente", conn);
            cmd.Parameters.AddWithValue("@NomeCliente", nome);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    pedidos.Add(new Pedido
                    {
                        Id = reader.GetInt32(0),
                        NumMesa = reader.GetString(1),
                        NomeCliente = reader.GetString(2),
                        CpfCliente = reader.GetString(3),
                        ValorTotal = reader.GetDecimal(4),
                        Status = reader.GetString(6)
                    });
                }
            }
            conn.Close();
            return pedidos;
        }

        // método para inserção de pedidos
        public Pedido Insert(Pedido pedido)
        {
            try
            {
                // comando
                cmd = new SqlCommand("INSERT INTO Pedidos (NumMesa, NomeCliente, CpfCliente, DataPed, Status, ValorTotal) VALUES (@NumMesa, @NomeCli, @CpfCli, @DataPed, @Status, @ValorTotal)", conn);
                // referenciando os sqlparameters com os parametros do pedido
                cmd.Parameters.AddWithValue("@NumMesa", pedido.NumMesa);
                cmd.Parameters.AddWithValue("@NomeCli", pedido.NomeCliente);
                cmd.Parameters.AddWithValue("@CpfCli", pedido.CpfCliente);
                cmd.Parameters.AddWithValue("@DataPed", pedido.DataPed);
                cmd.Parameters.AddWithValue("@Status", pedido.Status);
                cmd.Parameters.AddWithValue("@ValorTotal", pedido.CalcValorTotal());
                conn.Open(); // abertura da conexão
                cmd.ExecuteNonQuery(); // executa o comando para salvar o pedido
                conn.Close(); // encerra a conexão
                              // após a inserção do novo pedido é necessário também cadastrar os pedidos deste pedido pois estão em tableas separadas
                              // daoItensPed.Insert(pedido.ItensDePedido);
                              // ao inserir um pedido tenho que avisar que a mesa esta indisponivel
                daoMesa.UpdateStatus(pedido.NumMesa, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao inserir Pedido!\nErro: " + e);
            }
            return GetLastPed();
        }

        // método update pedido
        public Pedido Update(Pedido pedido)
        {
            try
            {
                // comando
                cmd = new SqlCommand("UPDATE Pedidos SET NumMesa=@NumMesa, NomeCliente=@NomeCli, CpfCliente=@CpfCli, DataPed=@DataPed, Status=@Status, ValorTotal=@ValorTotal WHERE Id=@Id", conn);
                // referenciando os sqlparameters com os parametros do pedido
                cmd.Parameters.AddWithValue("@Id", pedido.Id);
                cmd.Parameters.AddWithValue("@NumMesa", pedido.NumMesa);
                cmd.Parameters.AddWithValue("@NomeCli", pedido.NomeCliente);
                cmd.Parameters.AddWithValue("@CpfCli", pedido.CpfCliente);
                cmd.Parameters.AddWithValue("@DataPed", pedido.DataPed);
                cmd.Parameters.AddWithValue("@Status", pedido.Status);
                cmd.Parameters.AddWithValue("@ValorTotal", pedido.CalcValorTotal());
                conn.Open(); // abertura da conexão
                cmd.ExecuteNonQuery(); // executa o comando para salvar o pedido
                conn.Close(); // encerra a conexão
                              // após a inserção do novo pedido é necessário também cadastrar os pedidos deste pedido pois estão em tableas separadas
                              // é necessário verificar se já existem pedidos
                              // if(ped)
                daoItensPed.SaveItems(pedido.ItensDePedido);
                if (pedido.Status == "Finalizado")
                    daoMesa.UpdateStatus(pedido.NumMesa, true);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao inserir Pedido!" + e);
            }
            int idPed = (int)pedido.Id;
            return GetById(idPed);
        }

        // método delete By id
        public void DeleteById(int idPed, string numMesa)
        {
            try
            {
                // query
                cmd = new SqlCommand("DELETE Pedidos WHERE Id = @Id", conn);
                daoItensPed.DeleteByIdPed(idPed); // antes de executar o comando de deletar 
                                                  //// o pedido é necessário deletar os itens dele
                cmd.Parameters.AddWithValue("@Id", idPed); // referencia do id
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                daoMesa.UpdateStatus(numMesa, true);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao deletar pedido!\nErro: " + e);
            }
        }
    }
}
