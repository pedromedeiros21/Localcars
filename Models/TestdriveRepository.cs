using System;
using System.Collections.Generic;
using MySqlConnector;

namespace PI_MVC_SQL.Models
{
    public class TestdriveRepository
    {
        private const string DadosConexao = "Database=localcars;Data Source=localhost;User Id=root;";

            public Testdrive BuscarPorId(int Id){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "select * from Testdrive where Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",Id);
            MySqlDataReader Reader = Comando.ExecuteReader();
            Testdrive TdEncontrado = new Testdrive();
            if (Reader.Read())
            {
                TdEncontrado.Id = Reader.GetInt32("Id");
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("nome")))
                TdEncontrado.nome = Reader.GetString("nome");
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                TdEncontrado.email = Reader.GetString("email");

                if (!Reader.IsDBNull(Reader.GetOrdinal("tel")))
                TdEncontrado.tel = Reader.GetInt16("tel");

                if (!Reader.IsDBNull(Reader.GetOrdinal("horas")))
                TdEncontrado.horas = Reader.GetInt16("horas");

                TdEncontrado.data = Reader.GetDateTime("data");
            }
            Conexao.Close();
            return TdEncontrado;
        }

        public List<Testdrive> listar(){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "select * from Testdrive";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            MySqlDataReader Reader = Comando.ExecuteReader();
            List<Testdrive> Lista = new List<Testdrive>();
            while (Reader.Read())
            {
                Testdrive TdEncontrado = new Testdrive();
                TdEncontrado.Id = Reader.GetInt32("Id");
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("nome")))
                TdEncontrado.nome = Reader.GetString("nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                TdEncontrado.email = Reader.GetString("email");

                if (!Reader.IsDBNull(Reader.GetOrdinal("tel")))
                TdEncontrado.tel = Reader.GetInt32("tel");
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("horas")))
                TdEncontrado.horas = Reader.GetInt16("horas");

                TdEncontrado.data = Reader.GetDateTime("data");
                Lista.Add(TdEncontrado);
            }
            Conexao.Close();
            return Lista;
        }

        public void Cadastrar(Testdrive user){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "Insert into Testdrive (nome,email,tel,horas,data) values (@nome,@email,@tel,@horas,@data)";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",user.Id);
            Comando.Parameters.AddWithValue("@nome",user.nome);
            Comando.Parameters.AddWithValue("@email",user.email);
            Comando.Parameters.AddWithValue("@tel",user.tel);
            Comando.Parameters.AddWithValue("@horas",user.horas);
            Comando.Parameters.AddWithValue("@data",user.data);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public void Editar(Testdrive user){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "update Testdrive set nome=@nome, email=@email, tel=@tel, horas=@horas, data=@data where Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",user.Id);
            Comando.Parameters.AddWithValue("@nome",user.nome);
            Comando.Parameters.AddWithValue("@email",user.email);
            Comando.Parameters.AddWithValue("@tel",user.tel);
            Comando.Parameters.AddWithValue("@horas",user.horas);
            Comando.Parameters.AddWithValue("@data",user.data);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public void Excluir(Testdrive user){
          MySqlConnection Conexao = new MySqlConnection(DadosConexao);
          Conexao.Open();
          String Query = "delete from Testdrive where Id=@Id";
          MySqlCommand Comando = new MySqlCommand(Query,Conexao);
          Comando.Parameters.AddWithValue("@Id",user.Id);
          Comando.ExecuteNonQuery();
          Conexao.Close();
        }
    }
}