using Negocio.DAO;
using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Services
{
    /*
     * Na generic, é colocado o que é comum
     * DESAFIO PRÓXIMO TREINAMENTO - IMPLEMENTAR A GENERIC SERVICE
     * */

    /* 
    **  A GENERIC SERVICE ESTÁ RECEBENDO UMA ENTIDADE GENÉRICA (MODEL)
    **  IMPLEMENTANDO IDISPOSABLE 
    */
    public class GenericService<TEntity> : IDisposable where TEntity : GenericModel
    {
        private GenericDAO<TEntity> dao;

        public GenericService(TEntity entity)
        {

        }

        public void Insert(TEntity entity)
        {
            dao.Insert(entity);
        }

        public void Delete(TEntity entity)
        {
            dao.Delete(entity);
        }

        public void Update(TEntity entity)
        {
            dao.Update(entity);
        }

        public void FindById(int id)
        {
            dao.FindById(id);
        }

        public void ListAll()
        {
            dao.ListAll();
        }

        public void Dispose()
        {

        }
    }
}
