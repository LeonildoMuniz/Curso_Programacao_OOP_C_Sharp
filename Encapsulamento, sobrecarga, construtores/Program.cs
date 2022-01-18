using System;
using System.Globalization;

namespace Exercicio_Sec_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string tipo = Console.ReadLine();

            Cliente c = new Cliente(nome, conta, 0);


            if (tipo == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double operacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c.AtSaldo(operacao);

                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.Write(""+c);

                Console.WriteLine();
                Console.Write("Entre um valor para depósito: ");
                operacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c.AtSaldo(operacao);

                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados:");
                Console.Write("" + c);

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Entre um valor para saque: ");
                operacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c.AtSaque(operacao);

                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados:");
                Console.Write(""+c);



            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.Write("" + c);
            }





        }
    }
}