using Api_Project.Models;
using System;

namespace Api_Project.Contracts
{
    public class VendaModelAdd
    {
        public int Quantidade { get; set; }
        public Guid Codigo_Produto { get; set; }
    }
}
