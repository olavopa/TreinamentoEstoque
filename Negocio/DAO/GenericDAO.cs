using Negocio.Contexts;
using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DAO
{
    //GenericDAO implementa IDisposable para poder ter o método Dispose
    //utilizado no final de um bloco using que vai ser responsavel
    //por fechar suas dependencias 
    //<TEntity> = 

    //TEntity implementa Entidade Genérica
    public class GenericDAO <TEntity> : IDisposable where TEntity : GenericModel 
    {
        // Verificar como podemos fazer para que o projeto suporte mais de um contexto
        // Dessa maneira ficamos limitados a um contexto
        GenericContext context = new GenericContext();

        public void Insert(TEntity entity)
        {
            // SET é um método que representa o DbSet que logo representa a nossa tabela
            //DBSet são collections
            context.Set<TEntity>().Add(entity);

            // Nessa parte salvamos as mudanças no banco, caso contrário nada é feito
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            // Dizemos que o estado foi modificado para o valor que passamos no objeto entity
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            // Salvamos as mudanças no banco
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            //
            context.Set<TEntity>().Remove(entity);

        }

        public void Dispose()
        {

        }
    }
}
