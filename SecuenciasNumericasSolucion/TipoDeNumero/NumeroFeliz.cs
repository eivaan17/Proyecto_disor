using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFibonacci.TipoDeNumero
{
    class NumeroFeliz
    {

        int LlamadasDelMetodo = 0;

        public Boolean EsNumeroFeliz(int numero)
        {

            if (numero == 1)
            { 
                return true;
            }
            else
            {

                if (LlamadasDelMetodo < 20)
                {
                    List<int> ListaDeNumeros = new List<int>();
                    string NumeroCadena = numero.ToString();

                    for (int i = 0; i < NumeroCadena.Length; i++)
                    {
                        string a = NumeroCadena[i].ToString();
                        int number = System.Int32.Parse(a);
                        ListaDeNumeros.Add(number);
                    }

                    int suma = 0;
                    for (int i = 0; i < ListaDeNumeros.Count; i++)
                    {
                        int elevar = ListaDeNumeros[i] * ListaDeNumeros[i];

                        suma = suma + elevar;

                    }
                    LlamadasDelMetodo++;

                    return EsNumeroFeliz(suma);
                }
                else { return false; }
            }


        }
    }
}
