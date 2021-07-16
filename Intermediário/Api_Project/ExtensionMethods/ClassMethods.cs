using Api_Project.Contracts;
using Api_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Project.ExtensionMethods
{
    public static class ClassMethods
    {
        public static ProdutoModel ConvertToProd(this ProdutoModelAdd prod)
        {
            ProdutoModel produto = new();
            produto.Descricao = prod.Descricao;
            produto.Estoque = prod.Estoque;
            produto.Valor = prod.Valor;
            return produto;
        }
    }
}
