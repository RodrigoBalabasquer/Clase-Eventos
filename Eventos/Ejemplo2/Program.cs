using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Program
    {
        static void Main()
        {
            Biblioteca.Cuenta Cuenta1 = new Biblioteca.Cuenta();
            Cuenta1.SaldoNegativo += MostrarSaldo;
            Cuenta1.SaldoNegativo += MostrarSaldoNegativo;
            Cuenta1.SacarDinero(500);
            Console.ReadKey();
        }
        public static void MostrarSaldo(float dinero)
        {
            Console.Write(dinero);
        }
        public static void MostrarSaldoNegativo(float dinero) 
        {
            float negativo = dinero * -1;
            Console.Write(negativo);
        }
    }
}
