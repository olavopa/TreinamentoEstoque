﻿using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Services
{
    public class MovimentoService : GenericService<Movimento>
    {
        public MovimentoService():base(new DAO.MovimentoDAO())
        {

        }
    }
}
