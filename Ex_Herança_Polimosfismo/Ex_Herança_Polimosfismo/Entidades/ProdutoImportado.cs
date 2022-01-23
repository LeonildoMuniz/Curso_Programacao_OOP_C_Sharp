using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Herança_Polimosfismo.Entidades
{
    internal class ProdutoImportado : Produto
    {
        public double Frete { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double frete) : base(nome,preco)
        {
            Frete = frete;
        }

        public override string Valor()
        {
            return base.Valor() + " Custo frete importado: R$ " + Frete;
        }

    }
}
