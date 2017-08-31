using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DAO
{
    public class CategoriaDAO: GenericDAO<Categoria>
    {
        public CategoriaDAO(): base(new Contexts.GenericContext())
        {

        }

    }
}
