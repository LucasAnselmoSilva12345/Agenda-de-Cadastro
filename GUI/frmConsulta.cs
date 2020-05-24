using BLL;
using DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.qrcode;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsulta : Form
    {
        string pesquisar = "Nome";
        /*public int codigo = 0;
        public String nome = null;
        public String email = null;
        public String telefone = null; --> Enviando o codigo para o frminsert*/ 

        public ModeloContato obj = new ModeloContato();

        public frmConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
               

                DALConexao conexao = new DALConexao(DadosDeConexao.StringDeConexao);
                BLLContato bll = new BLLContato(conexao);


                if (cbOpcao.Text == "Id")
                {
                    dgvDados.DataSource = bll.LocalizarId(txtValor.Text);
                }

                else if (cbOpcao.Text == "Nome")
                {
                    dgvDados.DataSource = bll.LocalizarNome(txtValor.Text);
                }

                else if (cbOpcao.Text == "Telefone")
                {
                    dgvDados.DataSource = bll.LocalizarTelefone(txtValor.Text);
                }

                else if (cbOpcao.Text == "Email")
                {
                    dgvDados.DataSource = bll.LocalizarEmail(txtValor.Text);
                }
                else
                {
                    dgvDados.DataSource = bll.Localizar();

                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("O sistema retornou o seguinte erro: " + "\n[" + erro.Message + "]\nPor Favor contate o administrador do sistema" +
                                "Erro de Execução" + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
            OrganizaDGV(sender, e);
        }

        public void OrganizaDGV(object sender, EventArgs e) 
        {
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 60;
            dgvDados.Columns[1].HeaderText = "Nome do Contato";
            dgvDados.Columns[1].Width = 180;
            dgvDados.Columns[2].HeaderText = "E-mail";
            dgvDados.Columns[2].Width = 120;
            dgvDados.Columns[3].HeaderText = "Telephone";
            dgvDados.Columns[3].Width = 100;

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            btPesquisar_Click(sender, e);
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            btPesquisar_Click(sender, e);
        }

        private void cbOpcao_TextChanged(object sender, EventArgs e)
        {
            txtValor.Text = "";
            if (cbOpcao.Text == "Telefone")
            {
                txtValor.Mask = "(00) 00000-0000";
            }
            else
            {
                txtValor.Mask = null;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back) && (cbOpcao.Text == "Id" || cbOpcao.Text == "Telefone"))
            {
                e.Handled = true;
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.nome = Convert.ToString(dgvDados.Rows[e.RowIndex].Cells[1].Value);
                this.email = Convert.ToString(dgvDados.Rows[e.RowIndex].Cells[2].Value);
                this.telefone = Convert.ToString(dgvDados.Rows[e.RowIndex].Cells[3].Value);*/
                this.obj.ID = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.obj.NOME = Convert.ToString(dgvDados.Rows[e.RowIndex].Cells[1].Value);
                this.obj.EMAIL = Convert.ToString(dgvDados.Rows[e.RowIndex].Cells[2].Value);
                this.obj.TELEFONE = Convert.ToString(dgvDados.Rows[e.RowIndex].Cells[3].Value);
                this.Close();
            }
        }

        private void btPdf_Click(object sender, EventArgs e)
        {
            try
            {

                /* ============ PRIMEIRA FORMA ============
                //var retangulo = new iTextSharp.text.Rectangle(765, 765);
                var documento = new Document(PageSize.A4, 10, 10, 10, 10);

                var writer = PdfWriter.GetInstance(documento, new FileStream(@"c:\teste\teste.pdf", FileMode.Create));

                documento.Open();

                var imagem = iTextSharp.text.Image.GetInstance(@"C:\teste\robin.png");
                imagem.SetAbsolutePosition(10,60);
                documento.Add(imagem);

                PdfContentByte cb = writer.DirectContent;
                BaseFont fonte = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, false, false);

                cb.BeginText();
                cb.SetFontAndSize(fonte, 12);
                cb.SetColorFill(new BaseColor(51, 51, 51));
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Damian Wayne\nTeste", 20, 800, 0);

                int linhas = dgvDados.RowCount;
                int colunas = dgvDados.ColumnCount;

                for (int i = 0; i < linhas; i++)
                {
                    for (int x = 0; x < colunas; x++)
                    {
                        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Convert.ToString(dgvDados.Rows[i].Cells[x].Value), 20, 400, 0);
                    }
                }

                cb.EndText();
                documento.Close();

                MessageBox.Show("PDF gerado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                */

                /*========== SEGUNDA FORMA ==========
                  CHUNK: é a menor parte de um texto a ser inserido (palavra) 
                  PHRASE: é um conjunto de palavras (frases)
                  PARAGRAPH: é um paragrafo (conjunto de frases)
                */
                var documento = new Document(PageSize.A4, 10, 10, 10, 10);

                Stream str;

                SaveFileDialog salvarRelatorioPDF = new SaveFileDialog();

                salvarRelatorioPDF.Filter = "PDF (*.pdf) | *.pdf";

                salvarRelatorioPDF.FilterIndex = 2;
                salvarRelatorioPDF.Title = "Salvar Relatorio em PDF";
                salvarRelatorioPDF.RestoreDirectory = true;
                var salvar_dir = "";


                if (salvarRelatorioPDF.ShowDialog() == DialogResult.OK)
                {
                    if ((str = salvarRelatorioPDF.OpenFile()) != null)
                    {
                        salvar_dir = salvarRelatorioPDF.FileName;
                    }
                    else
                    {
                        DialogResult x = MessageBox.Show("Não Foi possivel salvar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    str.Close();
                }


                var writer = PdfWriter.GetInstance(documento, new FileStream(salvar_dir, FileMode.Create));

                documento.Open();

                var imagem = iTextSharp.text.Image.GetInstance(@"../../../image.png");
                imagem.SetAbsolutePosition(20, 775);
                documento.Add(imagem);

                var imagem2 = iTextSharp.text.Image.GetInstance(@"../../../image2.png");
                imagem2.SetAbsolutePosition(500, 775);
                documento.Add(imagem2);


                // Definindo as fontes
                var titulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, 2,BaseColor.RED);

                var fonte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 12, 0, BaseColor.BLACK);

                var letra = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 10, 0, BaseColor.BLACK);

                var rodape = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.SYMBOL, 13, 0, BaseColor.BLUE);

                documento.Add(new Paragraph(""));
                documento.Add(new Paragraph(""));
                documento.Add(new Paragraph(""));
                //criando parágrafo
                var paragrafo1 = new Paragraph("R E L A T O R Í O", titulo);
                paragrafo1.Alignment = Element.ALIGN_CENTER;
                documento.Add(paragrafo1);

                var nome1 = new Paragraph("Lucas Anselmo", fonte);
                nome1.Alignment = Element.ALIGN_CENTER;
                documento.Add(nome1);

                var nome2 = new Paragraph("João Vinicius" + "\n" + "_____________________________________________________________________________", fonte);
                nome2.Alignment = Element.ALIGN_CENTER;
                documento.Add(nome2);

                //data do relatorio 
                var paragrafo2 = new Paragraph("ITU, " + DateTime.Now.ToLongDateString());
                paragrafo2.Alignment = Element.ALIGN_RIGHT;
                documento.Add(paragrafo2);

                int linhas = dgvDados.RowCount;
                int colunas = dgvDados.ColumnCount;
                var frase = new Phrase();
                bool flag = false;

                for (int i = 0; i < linhas; i++)
                {
                    for (int x = 0; x < colunas; x++)
                    {
                        frase = new Phrase(Convert.ToString(dgvDados.Rows[i].Cells[x].Value) + " - ",letra);
                        //documento.Add(frase);
                        flag = documento.Add(frase);
                    }
                    frase = new Phrase("\n");
                    flag = documento.Add(frase);
                }

                //gerar codigo de barras
                PdfContentByte cb = writer.DirectContent;
                cb.BeginText();
                iTextSharp.text.Image imgBarCode;

                BarcodeEAN codeEAN = null;
                codeEAN = new BarcodeEAN();
                codeEAN.CodeType = Barcode.EAN13;
                codeEAN.ChecksumText = true;
                codeEAN.GenerateChecksum = true;
                codeEAN.BarHeight = 12;
                codeEAN.Code = "1234567890123";
                imgBarCode = codeEAN.CreateImageWithBarcode(cb, null, null);
                imgBarCode.SetAbsolutePosition(20, 350);
                imgBarCode.Alignment = iTextSharp.text.Image.TEXTWRAP;
                documento.Add(imgBarCode);
                cb.EndText();

                //Gerar QRCODE
                var paramQR = new Dictionary<EncodeHintType, object>();
                paramQR.Add(EncodeHintType.CHARACTER_SET, CharacterSetECI.GetCharacterSetECIByName("UTF-8"));
                BarcodeQRCode qrcodigo = new BarcodeQRCode("http://www.etecitu.com.br", 150, 150, paramQR);
                iTextSharp.text.Image imgQrCode = qrcodigo.GetImage();
                imgQrCode.SetAbsolutePosition(410, 300);
                documento.Add(imgQrCode);
                
                documento.Close(); 

                if (flag == true)
                {
                    DialogResult d = MessageBox.Show("Relatorio gerado com sucesso!\nDeseja abri-lo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(d.ToString() == "Yes")
                    {
                        System.Diagnostics.Process.Start(@salvar_dir);
                    }
                }
                else
                {
                    MessageBox.Show("Não foi gerado");
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            

            
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}