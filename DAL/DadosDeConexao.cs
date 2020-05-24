using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDeConexao
    {
        public static String StringDeConexao {
            get
            {
                return ("Persist Security Info=False; server=localhost;" +
                    "user id=root; password=''; database=exemplo; " +
                    "SslMode=none");
            }
        }
    }
}
