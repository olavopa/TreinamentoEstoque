using Negocio.Contexts;
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
    public class GenericDAO <TEntity> : IDisposable
    {
        //
        GenericContext context = 

        public void Insert(TEntity entity)
        {

        }

        public void Update(TEntity entity)
        {

        }

        public void Delete()
        {

        }

        public void Dispose()
        {

        }
    }
}
