using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AtivSem01
{
    public abstract class Cadastro : IOperacoesBD
    {
        public string Conexao { get; set; }
        //Quando eu deixo a string de conexão com Protected,
        //não consigo mais atribuir valores valores


    }
}
