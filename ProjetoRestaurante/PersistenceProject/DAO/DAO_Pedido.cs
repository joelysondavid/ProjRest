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
        private SqlConnection conn = DBConnection.DB_Connection; // variavel com conexão
        SqlCommand cmd;
        IList<Pedido> pedidos = new List<Pedido>();

        // método get by id
        public Pedido GetById(int id)
        {
            Pedido pedido = null;
            try
            {
                // query com comando para buscar pedido por id
                cmd = new SqlCommand("SELECT Id, NumMesa, NomeCliente, CpfCliente, ValorTotal FROM Pedidos WHERE Id = @Id", conn);
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
                            ValorTotal = reader.GetDecimal(4),
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
            try
            {
                // query com comando para buscar todos os pedidos
                cmd = new SqlCommand("SELECT Id, NumMesa, NomeCliente, CpfCliente, ValorTotal FROM Pedidos", conn);
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
                        });
                    }
                }
                conn.Close(); // encerra a conexão
                
                // após encerrar a conexão e obter todos os pedidos é necessário buscar também os itens destes pedidos
                for (int i = 0; i < pedidos.Count; i++)
                {
                    // desta forma estaremos buscando todos os itens de cada pedido
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
                cmd = new SqlCommand("SELECT TOP 1 Id, NumMesa, NomeCliente, CpfCliente, ValorTotal FROM Pedidos ORDER BY Id Desc", conn);
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

        // método para inserção de pedidos
        public Pedido Insert(Pedido pedido)
        {
            try
            {
                // comando
                cmd = new SqlCommand("INSERT INTO Pedidos (NumMesa, NomeCliente, CpfCliente, ValorTotal) VALUES (@NumMesa, @NomeCli, @CpfCli, @ValorTotal)", conn);
                // referenciando os sqlparameters com os parametros do pedido
                cmd.Parameters.AddWithValue("@NumMesa", pedido.NumMesa);
                cmd.Parameters.AddWithValue("@NomeCli", pedido.NomeCliente);
                cmd.Parameters.AddWithValue("@CpfCli", pedido.CpfCliente);
                cmd.Parameters.AddWithValue("@ValorTotal", pedido.CalcValorTotal());
                conn.Open(); // abertura da conexão
                cmd.ExecuteNonQuery(); // executa o comando para salvar o pedido
                conn.Close(); // encerra a conexão
                              // após a inserção do novo pedido é necessário também cadastrar os pedidos deste pedido pois estão em tableas separadas
                daoItensPed.Insert(pedido.ItensDePedido);
            } catch(Exception e)
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
                cmd = new SqlCommand("UPDATE Pedidos (Id, NumMesa, NomeCliente, CpfCliente, ValorTotal) VALUES (@NumMesa, @NomeCli, @CpfCli, @ValorTotal)", conn);
                // referenciando os sqlparameters com os parametros do pedido
                cmd.Parameters.AddWithValue("@Id", pedido.Id);
                cmd.Parameters.AddWithValue("@NumMesa", pedido.NumMesa);
                cmd.Parameters.AddWithValue("@NomeCli", pedido.NomeCliente);
                cmd.Parameters.AddWithValue("@CpfCli", pedido.CpfCliente);
                cmd.Parameters.AddWithValue("@ValorTotal", pedido.CalcValorTotal());
                conn.Open(); // abertura da conexão
                cmd.ExecuteNonQuery(); // executa o comando para salvar o pedido
                conn.Close(); // encerra a conexão
                              // após a inserção do novo pedido é necessário também cadastrar os pedidos deste pedido pois estão em tableas separadas
                daoItensPed.Update(pedido.ItensDePedido);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao inserir Pedido!" + e);
            }
            return GetLastPed();
        }
    }
}
