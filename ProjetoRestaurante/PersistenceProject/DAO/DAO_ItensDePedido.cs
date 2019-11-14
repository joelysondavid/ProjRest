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
    public class DAO_ItensDePedido
    {
        private SqlConnection conn = DBConnection.DB_Connection;
        private SqlCommand cmd;

        // método para obter os itens do pedido apartir do id do ped
        public IList<ItemPedido> GetByPed(int? idPed)
        {
            IList<ItemPedido> itensPed = new List<ItemPedido>();
            try
            {

                // comando seleciona todos os itens a aprtir do pedido
                cmd = new SqlCommand("SELECT Id, PedidoId, ItemId, Quantidade, ValorItens, Status FROM ItensPedido WHERE PedidoId = @IdPed", conn);
                cmd.Parameters.AddWithValue("@IdPed", idPed); // referencia com parametro
                conn.Open(); // abertura da conexão
                using (SqlDataReader reader = cmd.ExecuteReader()) // executa o comando
                {
                    while (reader.Read()) // enquanto houver itens de pedido
                    {
                        itensPed.Add(new ItemPedido
                        {
                            Id = reader.GetInt32(0),
                            PedidoId = reader.GetInt32(1),
                            ItemId = reader.GetInt32(2),
                            Quantidade = reader.GetInt32(3),
                            ValorItens = reader.GetDecimal(4),
                            Status = reader.GetString(5)
                        });
                    }
                }
                conn.Close(); // após execução encerra a conexão
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao buscar itens de pedido!\nErro: " + e);
            }
            return itensPed;
        }
        // GET ALL

        // INSERT ItensPedido
        public IList<ItemPedido> Insert(IList<ItemPedido> itensPed) // esse método tem como objetivo inserir todos os itens do pedido
        {
            // IList<ItenPedido> itens = new List<ItenPedido>();
            try
            {

                foreach (ItemPedido item in itensPed) // cada pedido realizara o comando
                {
                    // verificar se tem id
                    if (item.Id == null) { 
                    // comando
                    cmd = new SqlCommand("INSERT INTO ItensPedido (PedidoId, ItemId, Quantidade, ValorItens, Status) VALUES (@PedidoId, @ItemId, @Quantidade, @ValorItens, @Status)", conn);
                    cmd.Parameters.AddWithValue("@PedidoId", item.PedidoId);
                    cmd.Parameters.AddWithValue("@ItemId", item.ItemId);
                    cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                    cmd.Parameters.AddWithValue("@ValorItens", item.ValorItens);
                    cmd.Parameters.AddWithValue("@Status", item.Status);
                    // O status do pedido sempre iniciará em "Aguardando"
                    conn.Open(); // abre a conexão
                    cmd.ExecuteNonQuery(); // executa o comando
                    conn.Close(); // encerra a conexão
                    }
                    else
                    {
                        cmd = new SqlCommand("UPDATE ItensPedido SET PedidoId=@PedidoId, ItemId=@ItemId, Quantidade=@Quantidade, ValorItens=@ValorItens, Status=@Status WHERE Id=@Id", conn);
                        cmd.Parameters.AddWithValue("Id", item.Id);
                        cmd.Parameters.AddWithValue("@PedidoId", item.PedidoId);
                        cmd.Parameters.AddWithValue("@ItemId", item.ItemId);
                        cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                        cmd.Parameters.AddWithValue("@ValorItens", item.ValorItens);
                        cmd.Parameters.AddWithValue("@Status", item.Status);
                        // O status do pedido sempre iniciará em "Aguardando"
                        conn.Open(); // abre a conexão
                        cmd.ExecuteNonQuery(); // executa o comando
                        conn.Close(); // encerra a conexão
                    }
                } // após a inserção dos itens                 
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao inserir itens de pedido\nErro: "+e);
            }
            return GetByPed(itensPed[0].PedidoId); // todos os itens deverão ser do mesmo pedido 
                                                   // então não importa o indice da lista todos tem o mesmo PedidoId
        }

        // metodo update Itens ped
        public IList<ItemPedido> Update(IList<ItemPedido> itensPed) // esse método tem como objetivo inserir todos os itens do pedido
        {
            // IList<ItenPedido> itens = new List<ItenPedido>();
            try
            {

                foreach (ItemPedido item in itensPed) // cada pedido realizara o comando
                {
                    // comando
                    cmd = new SqlCommand("UPDATE ItensPedido (Id, PedidoId, ItemId, Quantidade, ValorItens, Status) VALUES (@PedidoId, @ItemId, @Quantidade, @ValorItens, Aguardando)", conn);
                    cmd.Parameters.AddWithValue("Id", item.Id);
                    cmd.Parameters.AddWithValue("@PedidoId", item.PedidoId);
                    cmd.Parameters.AddWithValue("@ItemId", item.ItemId);
                    cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                    cmd.Parameters.AddWithValue("@ValorItens", item.ValorItens);
                    // O status do pedido sempre iniciará em "Aguardando"
                    conn.Open(); // abre a conexão
                    cmd.ExecuteNonQuery(); // executa o comando
                    conn.Close(); // encerra a conexão
                } // após a inserção dos itens                 
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao inserir itens de pedido\nErro: " + e);
            }
            return GetByPed(itensPed[0].PedidoId); // todos os itens deverão ser do mesmo pedido 
                                                   // então não importa o indice da lista todos tem o mesmo PedidoId
        }

        // delete itens pedido
        public void DeleteByIdPed(int idPed)
        {
            // query para deletar todos os itnes de um pedido
            cmd = new SqlCommand("DELETE ItensPedido WHERE PedidoId = @IdPed", conn);
            // parametros
            cmd.Parameters.AddWithValue("@IdPed", idPed);
            conn.Open(); // abertura da conexão
            cmd.ExecuteNonQuery(); // execução do comando
            conn.Close();
        }
    }
}
