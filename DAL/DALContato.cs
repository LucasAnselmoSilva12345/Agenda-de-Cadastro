using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALContato
    {
        private DALConexao conexao;

        public DALContato(DALConexao cx) {
            this.conexao = cx;
        }

        public void Incluir(ModeloContato obj)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into contatos (NOME, EMAIL, TELEFONE) values (@nome, @email, @telefone); select @@IDENTITY";
            cmd.Parameters.AddWithValue("@nome", obj.NOME);
            cmd.Parameters.AddWithValue("@email", obj.EMAIL);
            cmd.Parameters.AddWithValue("@telefone", obj.TELEFONE);

            conexao.conectar();
            obj.ID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.desconectar();
        }

        public void Alterar(ModeloContato obj)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update contatos set NOME = @nome, EMAIL = @email, TELEFONE = @telefone where ID = @id";
            cmd.Parameters.AddWithValue("@nome", obj.NOME);
            cmd.Parameters.AddWithValue("@email", obj.EMAIL);
            cmd.Parameters.AddWithValue("@telefone", obj.TELEFONE);
            cmd.Parameters.AddWithValue("@id", obj.ID);

            conexao.conectar();
            cmd.ExecuteNonQuery();
            conexao.desconectar();
        }

        public ModeloContato CarregaModeloContato(int id) {
            ModeloContato obj = new ModeloContato();
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from contatos where " +
                "id = @id";
            cmd.Parameters.AddWithValue("@id",id);
            conexao.conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                obj.ID = Convert.ToInt32(registro["id"]);
                obj.NOME = Convert.ToString(registro["nome"]);
                obj.EMAIL = Convert.ToString(registro["email"]);
                obj.TELEFONE = Convert.ToString(registro["telefone"]);
            }
            registro.Close();
            conexao.desconectar();
            return obj;
        }
        public DataTable LocalizarNome(String Valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from contatos where nome like '%" + Valor + "%';", conexao.StringConexao
                );
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarId(String Valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from contatos where id like '%" + Valor + "%';", conexao.StringConexao
                );
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarTelefone(String Valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from contatos where telefone like '%" + Valor + "%';", conexao.StringConexao
                );
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarEmail(String Valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from contatos where email like '%" + Valor + "%';", conexao.StringConexao
                );
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from contatos" , conexao.StringConexao
                );
            da.Fill(tabela);
            return tabela;
        }

        public void Excluir(ModeloContato obj)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM contatos WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", obj.ID);

            conexao.conectar();
            cmd.ExecuteNonQuery();
            conexao.desconectar();

        }
    }
}
