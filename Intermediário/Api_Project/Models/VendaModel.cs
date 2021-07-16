using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Project.Models
{
    public class VendaModel
    {
        [Key]
        public Guid Codigo { get; set; }
        public int Quantidade { get; set; }
        [ForeignKey("Produto")]
        public Guid Codigo_Produto { get; set; }
        public ProdutoModel Produto { get; set; }
    }
}
