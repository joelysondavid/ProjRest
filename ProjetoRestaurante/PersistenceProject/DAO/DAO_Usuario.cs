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
    public class DAO_Usuario
    {
        // instancia da connectionstring criada na pasta Connection
        private SqlConnection conn = DBConnection.DB_Connection;
        private SqlCommand cmd;

        // método save
        public void Salvar(Usuario usuario, string loginA, string senhaA)
        {
            if (usuario.Id != null)
                this.Atualizar(usuario, loginA, senhaA);
            else
                this.Inserir(usuario);
        }
        // método getall
        public IList<Usuario> GetAll()
        {
            // Lista de usuarios
            IList<Usuario> usuarios = new List<Usuario>();
            cmd = new SqlCommand("SELECT Id, Nome, Cpf, Login, Senha, Tipo FROM Usuario", conn);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read()) // enquanto esta query estiver lendo
                {
                    usuarios.Add(new Usuario
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Cpf = reader.GetString(2),
                        Login = reader.GetString(3),
                        Senha = reader.GetString(4),
                        TipoUsr = reader.GetString(5)
                    }); // adicionando cada usuario na lista
                }
            }
            conn.Close();
            return usuarios;
        }


        // método getbyid
        public Usuario GetById(int id)
        {
            // cria um objeto
            Usuario usuario = new Usuario();
            // comando sql para execução da query
            cmd = new SqlCommand("SELECT Id, Nome, Cpf, Login, Senha, Tipo FROM Usuario WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id); // referenciando o parametro da query
            conn.Open(); // abre a conexão
            using (SqlDataReader reader = cmd.ExecuteReader()) // atraves do data reader executa o comando
            {
                while (reader.Read())
                {
                    usuario.Id = reader.GetInt32(0);
                    usuario.Nome = reader.GetString(1);
                    usuario.Cpf = reader.GetString(2);
                    usuario.Login = reader.GetString(3);
                    usuario.Senha = reader.GetString(4);
                    usuario.TipoUsr = reader.GetString(5);
                }
            }
            conn.Close(); // encerra a conexão (toda conexão aberta tem que ser encerrada!!!)
            return usuario; // retorna o usuário
        }
        // método login
        public bool GetLogin(string login, string senha)
        {
            // cria um objeto
            Usuario usuario = new Usuario();
            // comando sql para execução da query
            cmd = new SqlCommand("SELECT Id, Nome, Cpf, Login, Senha, Tipo FROM Usuario WHERE Login = @Login AND Senha = @Senha", conn);
            cmd.Parameters.AddWithValue("@Login", login); // referenciando o parametro da query
            cmd.Parameters.AddWithValue("@Senha", senha); // referenciando o parametro da query
            conn.Open(); // abre a conexão
            using (SqlDataReader reader = cmd.ExecuteReader()) // atraves do data reader executa o comando
            {
                while (reader.Read())
                {
                    usuario.Id = reader.GetInt32(0);
                    usuario.Nome = reader.GetString(1);
                    usuario.Cpf = reader.GetString(2);
                    usuario.Login = reader.GetString(3);
                    usuario.Senha = reader.GetString(4);
                    usuario.TipoUsr = reader.GetString(5);
                }
            }
            conn.Close(); // encerra a conexão (toda conexão aberta tem que ser encerrada!!!)
            if (usuario.Id != null)
                return true; ; // usuario encontrado
            return false; // usuário não encontrado
        }
        // método Insert
        private void Inserir(Usuario usr)
        {
            // 1- fazer validação verificar se o login já existe

            // 2- realizar o try e tentar pegar uam exeção
            // query
            cmd = new SqlCommand("INSERT INTO Usuario(Nome, Cpf, Login, Senha, Tipo) VALUES(@Nome, @Cpf, @Login, @Senha, @Tipo)", conn);
            // referenciando os parametros da query
            cmd.Parameters.AddWithValue("@Nome", usr.Nome);
            cmd.Parameters.AddWithValue("@Cpf", usr.Cpf);
            cmd.Parameters.AddWithValue("@Login", usr.Login);
            cmd.Parameters.AddWithValue("@Senha", usr.Senha);
            cmd.Parameters.AddWithValue("@Tipo", usr.TipoUsr);
            conn.Open(); // abre a conexão
            cmd.ExecuteNonQuery(); // executa o comando
            conn.Close(); // encerra a conexão
        }
        // método update
        private bool Atualizar(Usuario usr, string loginA, string senhaA)
        {
            if (GetLogin(loginA, senhaA) == false) // usuario não encontrado
                return false;
            try
            {
                // essa query funcionara como se o objeto passado fosse um novo login e uam nova senha
                // o login e senha com "A" funcionará como uma autenticação
                cmd = new SqlCommand("UPDATE Usuario SET Nome=@Nome, Cpf=@Cpf, Login=@LoginN, Senha=@SenhaN, Tipo=@Tipo WHERE Login=@LoginA AND Senha=@SenhaA", conn);
                cmd.Parameters.AddWithValue("@Nome", usr.Nome);
                cmd.Parameters.AddWithValue("@Cpf", usr.Cpf);
                cmd.Parameters.AddWithValue("@LoginN", usr.Login);
                cmd.Parameters.AddWithValue("@SenhaN", usr.Senha);
                cmd.Parameters.AddWithValue("@Tipo", usr.TipoUsr);
                // login e senha atuais para confirmação
                cmd.Parameters.AddWithValue("@LoginA", loginA);
                cmd.Parameters.AddWithValue("@SenhaA", senhaA);
                conn.Open(); // abertura da conxão
                cmd.ExecuteNonQuery(); // executar comando
                conn.Close(); // encerra conexão
                return true; // retorna true para atualização realizada
            }
            catch (Exception err)
            {
                // mostra o erro ocorrido
                Console.WriteLine("Erro: " + err);
                return false;
            }
        }
    }
}
