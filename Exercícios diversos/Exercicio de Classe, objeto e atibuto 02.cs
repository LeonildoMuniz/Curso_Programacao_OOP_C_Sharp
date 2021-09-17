using System;
using System.Globalization;

namespace Exercico_Classe_Obj_At_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1, p2;
            p1 = new Pessoas();
            p2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Digite o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite o salaro da primeira pessoa: ");
            p1.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Digite o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Digite o salaro da segunda pessoa: ");
            p2.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float salariomedio;

            salariomedio = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine("Salario médio: "+salariomedio.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
