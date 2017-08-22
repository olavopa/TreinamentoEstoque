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
        public GenericContext() : base ("TreinamentoEstoque")
        {
            
        }
        //O contexto é um espelho/reflexo do Banco de Dados

        //Tabelas do BD
        //Public - ficará acessivel em todo projeto

       public DbSet<Produto> Produto;

       public DbSet<Categoria> Categoria;

       public DbSet<Movimento> Movimento;

    }
}
