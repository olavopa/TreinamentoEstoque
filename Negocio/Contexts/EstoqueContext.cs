using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contexts
{
    public class EstoqueContext : GenericContext
    {
        // ESTOQUE SE REFERE AO BANCO DE DADOS TREINAMENTO ESTOQUE E ESTÁ PASSANDO O CONTEXTO
        // PARA A GENERIC CONTEXT QUE ESPERA UM CONTEXTO ESPECÍFICO
        public EstoqueContext() : base ("TreinamentoEstoque"){
        
        }


        //O contexto é um espelho/reflexo do Banco de Dados

        //Tabelas do BD
        //Public - ficará acessivel em todo projeto

       public DbSet<Produto> Produto;

        public DbSet<Categoria> Categoria;

        public DbSet<Movimento> Movimento;
    }
}
