using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();

                if (d.FileName != "")
                {
                    string file = d.FileName;

                    DALConexao conexao = new DALConexao(DadosDeConexao.StringDeConexao);
                    string constring = conexao.StringConexao;

                    // Important Additional Connection Options
                    constring += "charset=latin1;convertzerodatetime=true;";

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conexao.ObjetoConexao;
                            conexao.conectar();
                            mb.ExportToFile(file);
                            conexao.desconectar();
                        }
                    }
                }
                MessageBox.Show("Backup gerado com sucesso!!!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("O sistema retornou o seguinte" + "erro: " + erro.Message);
            }
        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();

                if (d.FileName != "")
                {
                    DALConexao conexao = new DALConexao(DadosDeConexao.StringDeConexao);
                    string constring = conexao.StringConexao;

                    // Important Additional Connection Options
                    constring += "charset=latin1;convertzerodatetime=true;";

                    string file = d.FileName;

                    
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conexao.ObjetoConexao;
                            conexao.conectar();
                            mb.ImportFromFile(file);
                            conexao.desconectar();
                        }
                    }

                    MessageBox.Show("Backup restauradoz  com sucesso!!!", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch(Exception Erro)
            {
                MessageBox.Show("O sistema retornou o seguinte erro: \n" + Erro.Message);
            }
            
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {

        }
    }
}
