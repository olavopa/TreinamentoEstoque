using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class Categoria: GenericModel
    {
        [Key]
        public long IdCategoria { get; set; }

        public string Descricao { get; set; }
    }
}
