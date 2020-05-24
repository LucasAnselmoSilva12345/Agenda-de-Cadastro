using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLContato
    {
        private DALConexao conexao;

        public BLLContato(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloContato obj)
        {
            if (obj.NOME.Trim().Length == 0)
            {
                throw new Exception("O campo NOME é obrigatório");
            }

            if (obj.TELEFONE.Trim().Length == 0)
            {
                throw new Exception("O campo Telefone é obrigatório");
            }

            if (obj.EMAIL.Trim().Length == 0)
            {
                throw new Exception("O campo Email é obrigatório");
            }

            DALContato DALobj = new DALContato(conexao);
            DALobj.Incluir(obj);
        }

        public void Alterar(ModeloContato obj)
        {
            if (obj.ID <= 0)
            {
                throw new Exception("O Codigo do usuario deve ser informado");
            }
            if (obj.NOME.Trim().Length == 0)
            {
                throw new Exception("O campo NOME é obrigatório");
            }

            if (obj.TELEFONE.Trim().Length == 0)
            {
                throw new Exception("O campo Telefone é obrigatório");
            }

            if (obj.EMAIL.Trim().Length == 0)
            {
                throw new Exception("O campo Email é obrigatório");
            }

            DALContato DALobj = new DALContato(conexao);
            DALobj.Alterar(obj);
        }

        public ModeloContato CarregaModeloContato(int codigo)
        {
            if (codigo != 0)
            {
                DALContato DALObj = new DALContato(conexao);
                return DALObj.CarregaModeloContato(codigo);
            }
            else
            {
                throw new Exception("Não foi possível localizar " +
                    "o contato pelos parâmetros informados");
            }
        }

        public DataTable LocalizarNome(string Valor)
        {
            DALContato obj = new DALContato(conexao);
            return obj.LocalizarNome(Valor);
        }

        public DataTable LocalizarId(string Valor)
        {
            DALContato obj = new DALContato(conexao);
            return obj.LocalizarId(Valor);
        }

        public DataTable LocalizarTelefone(string Valor)
        {
            DALContato obj = new DALContato(conexao);
            return obj.LocalizarTelefone(Valor);
        }

        public DataTable LocalizarEmail(string Valor)
        {
            DALContato obj = new DALContato(conexao);
            return obj.LocalizarEmail(Valor);
        }

        public DataTable Localizar()
        {
            DALContato obj = new DALContato(conexao);
            return obj.Localizar();
        }

        public void Excluir(ModeloContato obj)
        {
            DALContato DALobj = new DALContato(conexao);
            DALobj.Excluir(obj);
        }
    }
}
