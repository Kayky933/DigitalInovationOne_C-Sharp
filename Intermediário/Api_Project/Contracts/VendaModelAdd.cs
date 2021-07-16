using Api_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Project.Contracts
{
    public class VendaModelAdd
    {
        public int Quantidade { get; set; }
        public Guid Codigo_Produto { get; set; }
        public ProdutoModel Produto { get; set; }
    }
}
