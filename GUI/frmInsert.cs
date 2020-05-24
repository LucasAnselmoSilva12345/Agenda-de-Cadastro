using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace GUI
{
    public partial class frmInsert : Form
    {
        //limpar todos os campos do formulário
        //disponibilizar os botões de acordo com a operação
        String operacao = "";
        public frmInsert()
        {
            InitializeComponent();
        }

        public void atualizaForm(int op)
        {
            //adicionar, localizar, alterar, excluir, salvar, cancelar
            btAdicionar.Enabled = false;
            btLocalizar.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btSalvar.Enabled = false;
            btCancela.Enabled = false;
            pnDados.Enabled = false;

            

            //1: inserir, localizar, cancelar
            //2: alterar, salvar no banco
            //3: excluir/alterar

            switch (op)
            {
                case 1:
                    btAdicionar.Enabled = true;
                    btLocalizar.Enabled = true;
                    btCancela.Enabled = true;
                    limpaCampos();
                    break;

                case 2:
                    btSalvar.Enabled = true;
                    btCancela.Enabled = true;
                    btLocalizar.Enabled = true;
                    pnDados.Enabled = true;
                    break;

                //3: excluir/alterar
                case 3:
                    btAlterar.Enabled = true;
                    btExcluir.Enabled = true;
                    btCancela.Enabled = true;
                    break;

                default:
                    break;
            }
        }

        public void limpaCampos()
        {
            txtCodigo.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            rbCelular.Checked = false;
            rbFixo.Checked = false;
        }

        private void frmInsert_Load(object sender, EventArgs e)
        {
            atualizaForm(1);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            atualizaForm(2);
            this.operacao = "inserir";
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsulta f = new frmConsulta();
            f.ShowDialog();
            this.Show();
            //this.ShowDialog();
            
            txtCodigo.Text = f.obj.ID.ToString();
            txtNome.Text = f.obj.NOME;
            txtEmail.Text = f.obj.EMAIL;
            

            int tamanho = f.obj.TELEFONE.Length;

            if (tamanho == 14)
            {
                rbFixo.Checked = true;
            }
            else
            {
                rbCelular.Checked = true;
            }

            txtTelefone.Text = f.obj.TELEFONE;

            atualizaForm(3);

            /* 
            try
            {
                DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);
                BLLContato bll = new BLLContato(cx);
                ModeloContato modelo =
                    bll.CarregaModeloContato(Convert.ToInt32(txtCodigo.Text));
                //preencher o forumulário com o objeto/modelo
                txtNome.Text = modelo.NOME;
                txtEmail.Text = modelo.EMAIL;
                txtTelefone.Text = modelo.TELEFONE;

            }
            catch (Exception erro)
            {
                MessageBox.Show("O sistema retornou o seguinte erro:\n[ " 
                    + erro.Message + "]\nPor favor entre em contato com o" +
                    "Administrador do sistema! :(", "Erro de Sistema", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }
            
            */
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            atualizaForm(2);
            this.operacao = "alterar";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //excluir
            try
            {
                DialogResult d = MessageBox.Show("Tem certeza que deseja " + "excluir o registro ? ", "ATENÇÃO", MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Exclamation);

                if (d.ToString() == "Yes")
                {
                    //instanciar um objeto e preencher comos valores do form
                    ModeloContato obj = new ModeloContato();

                    //criando conexao com o bd
                    DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);
                    BLLContato bll = new BLLContato(cx);

                    obj.ID = Convert.ToInt32(txtCodigo.Text);
                    atualizaForm(1);


                    bll.Excluir(obj);

                    MessageBox.Show("Dados excluidos com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("O sistema retornou o seguinte erro: \n[" + erro.Message + "]\n Por favor contate o administradoe do sistema",
                    "Erro de execução", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //add - altera no banco
            try
            {
                //instanciar um objeto e preencher com os valores do form
                ModeloContato obj = new ModeloContato();
                obj.NOME = txtNome.Text;
                obj.EMAIL = txtEmail.Text;
                obj.TELEFONE = txtTelefone.Text;

                //criando a conexão com o banco de dados
                DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);
                BLLContato bll = new BLLContato(cx);

                //verificar se é uma operação de alteração ou inserção
                if (this.operacao == "inserir")
                {
                    //insere no banco
                    bll.Incluir(obj);
                    MessageBox.Show(" Cadastro efetuado com sucesso !"  + obj.ID.ToString()+"\nNome: " + obj.NOME , "Aviso" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    atualizaForm(1);
                }
                else
                {
                    //alterar no banco
                    obj.ID = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(obj);
                    MessageBox.Show("Contato alterado com sucesso !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("O sistema retornou o seguinte erro: " + "\n[" + erro.Message + "]\nPor Favor contate o administrador do sistema" + 
                                "Erro de Execução" + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }

            limpaCampos();
        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            atualizaForm(1);
        }

        private void rbFixo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFixo.Checked)
            {
                txtTelefone.Text = "";
                txtTelefone.Enabled = true;
                txtTelefone.Mask = "(00) 0000-0000";
                txtTelefone.Focus();
            }
            else
            {
                txtTelefone.Text = "";
                txtTelefone.Enabled = true;
                txtTelefone.Mask = "(00) 00000-0000";
                txtTelefone.Focus();
            }
        }

        private void rbCelular_CheckedChanged(object sender, EventArgs e)
        {
            rbFixo_CheckedChanged(sender, e);
        }

        private void btFrmBackup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBackup f = new frmBackup();
            f.ShowDialog();
            this.Show();
        }

        private void btCEP_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBuscaEndereco f = new FrmBuscaEndereco();
            f.ShowDialog();
            this.Show();
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void btNote_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void btNav_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome");
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        /*
create database exemplo
create table if not exixtis usuario (int cod ...)
*/
    }
}
