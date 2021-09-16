using System;
using System.Globalization; 

namespace Excercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas a, b;
            a = new Pessoas();
            b = new Pessoas();

            Console.WriteLine("Dados primeira pessoa: ");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados segunda pessoa: ");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());
            
            if(a.Idade > b.Idade)
            {
                Console.Write("Pessoa mais velha:"+a.Nome);
            }
            else
            {
                Console.Write("Pessoa mais velha:" + b.Nome);
            }
           
        }
    }
}
