using System;


namespace Exercicio_Classe_Obj_Atr_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas a, b;
            a = new Pessoas();
            b = new Pessoas();

            Console.Write("Digite da primeira pessoa: ");
            a.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            a.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite da segunda pessoa: ");
            b.nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            b.idade = int.Parse(Console.ReadLine());

            if(a.idade > b.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + b.nome);
            }

        }
    }
}
