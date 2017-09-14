using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DAO
{
    public class MovimentoDAO: GenericDAO<Movimento>
    {
        public MovimentoDAO():base(new Contexts.GenericContext())
        {

        }
    }
}
