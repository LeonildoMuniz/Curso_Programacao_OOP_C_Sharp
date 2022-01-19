using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());

            ex_vetor.Reserva[] vet = new ex_vetor.Reserva[10];
                
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i+1}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vet[quarto] = new ex_vetor.Reserva(nome, email);

            }
            for (int i = 0; i < 10; i++)
            {
                if (vet[i]!=null)
                {
                    Console.Write($"{i}: "+vet[i]);
                    Console.WriteLine();
                }
            }

        }

    }
}
