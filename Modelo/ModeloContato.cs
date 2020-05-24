using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloContato
    {
        private int id;
        private string nome;
        private string email;
        private string telefone;

        public ModeloContato()
        {
            this.id = 0;
            this.nome = "";
            this.email = "";
            this.telefone = "";
        }

        public ModeloContato(int _id, string _nome, string _email, 
            string _telefone)
        {
            this.id = _id;
            this.nome = _nome;
            this.email = _email;
            this.telefone = _telefone;
        }
        public int ID {
            get { return this.id; }
            set { this.id = value; }
        }
        public string NOME
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public string EMAIL
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string TELEFONE
        {
            get { return this.telefone; }
            set { this.telefone = value; }
        }
    }
}
