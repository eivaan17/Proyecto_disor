using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFibonacci.TipoDeNumero
{
   public  class NumeroCapicua
    {
        public NumeroCapicua() { }

        public Boolean InvertirNumero(String numero)
        {
            string NumeroInvertido = "";
            for (int i=numero.Length-1;i>=0;i--)
            {
                NumeroInvertido += numero.Substring(i,1);
            }

            return numero.CompareTo(NumeroInvertido) == 0;
        }

    }
}
