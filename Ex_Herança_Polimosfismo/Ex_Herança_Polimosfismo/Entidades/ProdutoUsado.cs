using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Herança_Polimosfismo.Entidades
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome,preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string Valor()
        {
            return base.Valor() + " Data de fabricação: " + DataFabricacao;
        }
    }
}
