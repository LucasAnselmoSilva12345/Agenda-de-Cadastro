using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        private String stringConexao;
        private MySqlConnection conexao;

        public DALConexao(String dadosConexao) {
            this.conexao = new MySqlConnection();
            this.stringConexao = dadosConexao;
            this.conexao.ConnectionString = dadosConexao;
        }
        public String StringConexao
        {
            get { return this.stringConexao; }
            set { this.stringConexao = value; }
        }

        public MySqlConnection ObjetoConexao
        {
            get { return this.conexao; }
            set { this.conexao = value; }
        }

        public void conectar()
        {
            this.conexao.Open();
        }

        public void desconectar()
        {
            this.conexao.Close();
        }
    }
}
