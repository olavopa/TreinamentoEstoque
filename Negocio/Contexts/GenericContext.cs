using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contexts
{
    public class GenericContext : DbContext
    {
        //Construtor passando a connection string para a classe mãe DbContext (base)
        public GenericContext(string connectionString) : base (connectionString)
        {
            
        }

        //Valor Padrão da Connection String
        public GenericContext(): this("TreinamentoEstoque")
        {

        }

    }
}
