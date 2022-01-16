using System;
using System.Globalization;

namespace excercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dolar?: ");
            double vlr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?: ");
            double qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = metodo_estatico.ConversorDeMoedas.Moeda(vlr, qtd);

            Console.Write("Valor a ser pago em reais: R$ " + valor.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}