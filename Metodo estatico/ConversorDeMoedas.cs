using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_estatico
{
    internal class ConversorDeMoedas
    {
        double A, B;

        public static double Moeda(double A, double B)
        {
            return A * B;
        } 
    }
}
