using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{   
    public delegate void CuentaDelegado(float dinero);
    public class Cuenta
    {
        public float saldo;
        public void SacarDinero(float dinero) 
        {
            if (dinero > this.saldo) 
            {
                //si estubieramos en aplicacion de consola es Console.write
                //si estubieramos en windows forms es Messagefox.show
                //si estubieramos en una pagina web seria un alert
                SaldoNegativo(dinero);
            }
        }
        public event CuentaDelegado SaldoNegativo;
    }
}
