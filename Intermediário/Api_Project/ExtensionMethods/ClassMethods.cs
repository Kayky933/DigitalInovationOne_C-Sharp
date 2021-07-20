using Api_Project.Contracts;
using Api_Project.Models;

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

        public static VendaModel ConvertToVenda(this VendaModelAdd prod)
        {
            VendaModel venda = new();
            venda.Codigo_Produto = prod.Codigo_Produto;
            venda.Quantidade = prod.Quantidade;
            return venda;
        }
    }
}
