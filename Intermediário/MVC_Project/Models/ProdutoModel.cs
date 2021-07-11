using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project.Models
{
    public class ProdutoModel
    {
        [Key]
        public Guid Codigo { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Valor { get; set; }
        List<VendaModel> Vendas { get; set; }
    }
}
