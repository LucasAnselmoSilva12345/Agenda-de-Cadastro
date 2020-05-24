using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class BuscaEndereco
    {
        static public String cep = "";
        static public String endereco = "";
        static public String cidade = "";
        static public String estado = "";
        static public String logradouro = "";
        static public String bairro = "";

        public static Boolean verificaCEP(String CEP)
        {
            bool confirma = false;

            try
            {
                DataSet ds = new DataSet();
                String xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@CEP&formato=xml".Replace("@CEP", CEP);
                ds.ReadXml(xml);

                cep = CEP;
                endereco = ds.Tables[0].Rows[0]["logradouro"].ToString();
                cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                estado = ds.Tables[0].Rows[0]["uf"].ToString();
                bairro = ds.Tables[0].Rows[0]["bairro"].ToString();

                confirma = true;
            }
            catch (Exception erro)
            {
                cep = "";
                endereco = "";
                cidade = "";
                estado = "";
                bairro = "";
            }

            return confirma;
        }
    }
}
