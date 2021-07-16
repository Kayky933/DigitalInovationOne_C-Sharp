using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Project.Contracts
{
    public class ProdutoModelAdd
    {
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public decimal Valor { get; set; }
    }
}
