using System;
using System.Collections.Generic;
using MySqlConnector;

namespace PI_MVC_SQL.Models
{
    public class ContatoRepository
    {
        private const string DadosConexao = "Database=localcars;Data Source=localhost;User Id=root;";

            public Contato BuscarPorId(int Id){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "select * from Contato where Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",Id);
            MySqlDataReader Reader = Comando.ExecuteReader();
            Contato CEncontrado = new Contato();
            if (Reader.Read())
            {
                CEncontrado.Id = Reader.GetInt32("Id");
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("nome")))
                CEncontrado.nome = Reader.GetString("nome");
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                CEncontrado.email = Reader.GetString("email");

                if (!Reader.IsDBNull(Reader.GetOrdinal("mensagem")))
                CEncontrado.mensagem = Reader.GetString("mensagem");
            }
            Conexao.Close();
            return CEncontrado;
        }

        public List<Contato> Listar()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "select * from Contato";
            MySqlCommand Comando = new(Query,Conexao);
            MySqlDataReader Reader = Comando.ExecuteReader();
            List<Contato> lista = new();
            while (Reader.Read())
            {
                Contato contato = new()
                {
                    Id = Reader.GetInt32("Id")
                };

                if (!Reader.IsDBNull(Reader.GetOrdinal("nome")))
                    contato.nome = Reader.GetString("nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                    contato.email = Reader.GetString("email");

                if (!Reader.IsDBNull(Reader.GetOrdinal("mensagem")))
                contato.mensagem = Reader.GetString("mensagem");

                lista.Add(contato);
            }

            Conexao.Close();
            return lista;
        }

        public void Cadastrar(Contato user){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "Insert into Contato (nome,email,mensagem) values (@nome,@email,@mensagem)";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",user.Id);
            Comando.Parameters.AddWithValue("@nome",user.nome);
            Comando.Parameters.AddWithValue("@email",user.email);
            Comando.Parameters.AddWithValue("@mensagem",user.mensagem);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public void Editar(Contato user){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "update Contato set nome=@nome, email=@email, mensagem=@mensagem where Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",user.Id);
            Comando.Parameters.AddWithValue("@nome",user.nome);
            Comando.Parameters.AddWithValue("@email",user.email);
            Comando.Parameters.AddWithValue("@mensagem",user.mensagem);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public void Excluir(Contato user){
          MySqlConnection Conexao = new MySqlConnection(DadosConexao);
          Conexao.Open();
          String Query = "delete from Contato where Id=@Id";
          MySqlCommand Comando = new MySqlCommand(Query,Conexao);
          Comando.Parameters.AddWithValue("@Id",user.Id);
          Comando.ExecuteNonQuery();
          Conexao.Close();
        }
    }
}