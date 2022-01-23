using System;
using System.Collections.Generic;

namespace exercicio
{
    class Programa
    {
        static void Main(string[] args)
        {

            List<Ex_Herança_Polimosfismo.Entidades.Produto> lista = new List<Ex_Herança_Polimosfismo.Entidades.Produto>();

            Console.Write("Informe o numero de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com o #{i} produto: ");
                Console.Write("Escolha o tipo do produto (N (novo) - U (usado) - I (importado): ");
                char tipo = char.Parse(Console.ReadLine());

                if (tipo == 'N' || tipo == 'n')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());

                    lista.Add(new Ex_Herança_Polimosfismo.Entidades.Produto(nome, preco));
                   
                }
                else if (tipo == 'U' || tipo == 'u')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    lista.Add(new Ex_Herança_Polimosfismo.Entidades.ProdutoUsado(nome, preco, data));
                }
                else
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Valor do frete: ");
                    double frete = double.Parse(Console.ReadLine());

                    lista.Add(new Ex_Herança_Polimosfismo.Entidades.ProdutoImportado(nome, preco, frete));
                }

            }

            Console.WriteLine();

            foreach (Ex_Herança_Polimosfismo.Entidades.Produto item in lista)
            {
                Console.WriteLine(item.Valor());
            }

        }
    }
}
