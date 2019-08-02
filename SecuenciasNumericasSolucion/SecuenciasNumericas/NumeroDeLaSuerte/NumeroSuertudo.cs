using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFibonacci.InterfacesGraficas;

namespace ProyectoFibonacci.SecuenciasNumericas
{
   public  class NumeroSuertudo
    {

        private List<int> lista;
        public int valor=0;
        public int posicion = 0;
        

        public NumeroSuertudo()
        {
            lista = new List<int>();
        }


        public int getValor() {
            return this.valor;
        }

        
        public void sucesion(int limite)
        {
            for (int i = 0; i < limite; i++)
                if (i % 2 == 0)
                    lista.Add(i + 1);
            int pivote = 1;
            do
            {
                elimina_Multiplos_De(lista[pivote]);
                pivote++;

            } while (lista[pivote] <= lista.Count);
        }

        private void elimina_Multiplos_De(int p)
        {
            for (int i = 0; i < lista.Count; i++)
            {

                if ((i + 1) % p == 0)
                {

                    lista[i] = 0;
                }
            }

            lista.Sort();
            lista.RemoveRange(0, lista.Count / p);
        }





        public void printf()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine(lista[i]);
            }
        }

        public void Siguiente(Etiqueta e,Etiqueta c)
        {
            this.posicion += 1;
            this.valor = this.lista[this.posicion];
            string v = getValor().ToString();
            e.Text = v;
            
            c.Text= ConvertirBinario(getValor());
        }

     public void  retroceder(Etiqueta e)
        {
            this.posicion -= 1;
            this.valor = this.lista[this.posicion];
            string v = getValor().ToString();
            e.Text = v;

        }

        public string ConvertirBinario(int NumeroDecimal)
        {

            String NumeroBinario = "";

            while (true)
            {

                if ((NumeroDecimal % 2) != 0) NumeroBinario = "1" + NumeroBinario;
                else NumeroBinario = "0" + NumeroBinario;
                NumeroDecimal /= 2;

                if (NumeroDecimal <= 0) break;
            }

            return NumeroBinario;

        }
    }
}
