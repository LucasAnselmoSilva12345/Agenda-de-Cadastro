using Ferramentas;
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
    public partial class FrmBuscaEndereco : Form
    {
        public FrmBuscaEndereco()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (BuscaEndereco.verificaCEP(txtCep.Text) == true)
            {
                MessageBox.Show("Endereço encontrado com sucesso!");

                txtBairro.Text = BuscaEndereco.bairro;
                txtEstado.Text = BuscaEndereco.estado;
                txtCidade.Text = BuscaEndereco.cidade;
                txtEndereco.Text = BuscaEndereco.endereco;
            }

            if (txtEstado.Text == "")
            {
                MessageBox.Show("Não foi possível encontrar o endereço a partir do CEP Informado!\nTente novamente mais tarde!");
            }
        }

        private void FrmBuscaEndereco_Load(object sender, EventArgs e)
        {

        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
