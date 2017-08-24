using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class Produto: GenericModel
    {
        [Key]
        public long IdProduto { get; set; }
        public long IdCategoria { get; set; }
        public string Descricao { get; set; }
        [ForeignKey(name:"IdCategoria")]
        public Categoria Categoria { get; set; }

    }
}
