using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negocio.Models
{
    public class Movimento:GenericModel
    {
        [Key]
        public long IdMovimento { get; set; }
        public long IdProduto { get; set; }
        public char Tipo { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        [ForeignKey("IdProduto")]
        public Produto Produto { get; set; }

    }
}
