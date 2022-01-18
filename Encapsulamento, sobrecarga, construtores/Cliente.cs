using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Sec_05
{
    internal class Cliente
    {
        public string _nome { get; private set; }
        public int _conta { get; private set; }
        public double Saldo { get; set; }


        public Cliente(string nome, int conta, double saldo)
        {
            _nome = nome;
            _conta = conta;
            Saldo = 0;

        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value !=null && value.Length >1)
                {
                    _nome = value;
                }

            }
        }

        public double AtSaldo( double saldo)
        {
            return Saldo += saldo;
        }

        public double AtSaque(double saldo)
        {
            return Saldo -= saldo+5;
        }


        public override string ToString()
        {
            return "Conta "
                + _conta
                + ", "
                + "Titular: "
                + _nome
                + ", "
                + "Saldo: "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
            
        }


    }
}
