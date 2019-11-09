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
    public class DAO_Item
    {
        private SqlConnection conn = DBConnection.DB_Connection; // variavel que contém a conexão
        IList<Item> itens = new List<Item>(); // lista que conterá nossos itens

        SqlCommand cmd;

        // método save que definirá se é um insert ou 
        public Item Save(Item item)
        {
            if (item.Id != null)
            {
                Console.WriteLine(item.Id);
                return Update(item);
            }
            else
                return Insert(item);
        }

        // GetAll Itens
        public IList<Item> GetAll()
        {
            try
            {
                // query para seleção
                cmd = new SqlCommand("SELECT Id, Descricao, Detalhes, TempoPrep, Preco, URLImagem FROM Cardapio", conn);
                conn.Open(); // abertura da connec
                using (SqlDataReader reader = cmd.ExecuteReader()) // executa a query
                {
                    while (reader.Read()) // enquanto tiver leitura
                    {
                        itens.Add(new Item
                        {
                            Id = reader.GetInt32(0),
                            Descricao = reader.GetString(1),
                            Detalhes = reader.GetString(2),
                            TempoPreparo = reader.GetInt32(3),
                            Preco = reader.GetDecimal(4),
                            URLImagem = reader.GetString(5)
                        });
                    }
                }
                conn.Close(); // encerra a conexão
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao obter todos os itens!\nErro: " + e);
            }
            return itens;
        }

        // GETITEM by id
        public Item GetById(int? id)
        {
            Item item = null;
            try
            {
                // query para seleção
                cmd = new SqlCommand("SELECT Id, Descricao, Detalhes, TempoPrep, Preco, URLImagem FROM Cardapio  WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open(); // abertura da connec
                using (SqlDataReader reader = cmd.ExecuteReader()) // executa a query
                {
                    while (reader.Read()) // enquanto tiver leitura
                    {
                        item = new Item
                        {
                            Id = reader.GetInt32(0),
                            Descricao = reader.GetString(1),
                            Detalhes = reader.GetString(2),
                            TempoPreparo = reader.GetInt32(3),
                            Preco = reader.GetDecimal(4),
                            URLImagem = reader.GetString(5)
                        };
                    }
                }
                conn.Close(); // encerra a conexão
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao obter item por id!\nErro: " + e);
            }
            return item;
        }

        // método get last item
        public Item GetLast()
        {
            Item item = null;
            try
            {
                // query para seleção
                cmd = new SqlCommand("SELECT TOP 1 Id, Descricao, Detalhes, TempoPrep, Preco, URLImagem FROM Cardapio ORDER BY Id DESC", conn);
                conn.Open(); // abertura da connec
                using (SqlDataReader reader = cmd.ExecuteReader()) // executa a query
                {
                    while (reader.Read()) // enquanto tiver leitura
                    {
                        item = new Item
                        {
                            Id = reader.GetInt32(0),
                            Descricao = reader.GetString(1),
                            Detalhes = reader.GetString(2),
                            TempoPreparo = reader.GetInt32(3),
                            Preco = reader.GetDecimal(4),
                            URLImagem = reader.GetString(5)
                        };
                    }
                }
                conn.Close(); // encerra a conexão
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao obter ultimo item!\nErro: " + e);
            }
            return item;
        }

        // método insert
        private Item Insert(Item item)
        {
            try
            {
                // query
                cmd = new SqlCommand("INSERT INTO Cardapio (Descricao, Detalhes, TempoPrep, Preco, URLImagem) VALUES (@Descricao, @Detalhes, @TempoPrep, @Preco, @URLImagem)", conn);
                // SqlParameters
                cmd.Parameters.AddWithValue("@Descricao", item.Descricao);
                cmd.Parameters.AddWithValue("@Detalhes", item.Detalhes);
                cmd.Parameters.AddWithValue("@TempoPrep", item.TempoPreparo);
                cmd.Parameters.AddWithValue("@Preco", item.Preco);
                cmd.Parameters.AddWithValue("@URLImagem", item.URLImagem);
                conn.Open(); // abre a conexão
                cmd.ExecuteNonQuery(); // executa o comando
                conn.Close(); // encerra a conexão
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao incluir item!\nErro: " + e);
            }
            return GetLast();
        }

        // método insert
        private Item Update(Item item)
        {
            try
            {
                // query
                cmd = new SqlCommand("Update Cardapio (Id, Descricao, Detalhes, TempoPrep, Preco, URLImagem) VALUES (@Descricao, @Detalhes, @TempoPrep, @Preco, @URLImagem)");
                // SqlParameters
                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Descricao", item.Descricao);
                cmd.Parameters.AddWithValue("@Detalhes", item.Detalhes);
                cmd.Parameters.AddWithValue("@TempoPrep", item.TempoPreparo);
                cmd.Parameters.AddWithValue("@Preco", item.Preco);
                cmd.Parameters.AddWithValue("@URLImagem", item.URLImagem);
                conn.Open(); // abre a conexão
                cmd.ExecuteNonQuery(); // executa o comando
                conn.Close(); // encerra a conexão
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao incluir item!\nErro: " + e);
            }
            return GetById(item.Id);
        }

        // método deletebyid
    }
}
