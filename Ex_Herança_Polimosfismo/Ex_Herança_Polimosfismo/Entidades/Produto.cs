using System.Globalization;

namespace Ex_Herança_Polimosfismo.Entidades
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string Valor()
        {
            return Nome + " " + Preco;
        }

    }
}
