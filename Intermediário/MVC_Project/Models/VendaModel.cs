using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project.Models
{
    public class VendaModel
    {
        [Key]
        public Guid Codigo { get; set; }
        public int Quantidade { get; set; }
        [ForeignKey("Produto")]
        public Guid Codigo_Produto { get; set; }
        public ProdutoModel Produto { get; set; }
        public int RedusProduto()
        {
            var a = this.Produto.Estoque -= this.Quantidade;
            return a;
        }
    }
}
