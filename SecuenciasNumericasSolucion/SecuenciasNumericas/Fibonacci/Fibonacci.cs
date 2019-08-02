using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoFibonacci.InterfacesGraficas;

namespace ProyectoFibonacci.SecuenciasNumericas
{

    public class Fibonacci
    {
        private int NumeroAnterior;
        private int NumeroSiguiente;
        private int NumeroActual;
        private int NumeroIncrementable;
        

        public Fibonacci()
        {
            
            this.NumeroAnterior = 0;
            this.NumeroSiguiente = 0;
            this.NumeroActual = 0;
            this.NumeroIncrementable = 0;
          

        }

        public void AvanzarSerieFibonacci()
        { 

            if (NumeroIncrementable > 1)
            {   
                NumeroSiguiente = NumeroAnterior + NumeroActual;
               // Imprime();
                NumeroAnterior = NumeroActual;
                NumeroActual = NumeroSiguiente;
                
            }
            else
            {
                NumeroIncrementable = NumeroIncrementable + 1;
                NumeroSiguiente = NumeroActual;
               // Imprime();
                NumeroActual = 1;
            }

        }


        public void RetrocederSerieFibonacci()
        {

            if (NumeroActual != 0)
            {

                NumeroSiguiente = NumeroActual;
                NumeroActual = NumeroAnterior;
                NumeroAnterior = NumeroSiguiente - NumeroActual;

                //Imprime();

            }
           

        }

        public void ImprimeNumeroSiguiente(Etiqueta etiqueta,Etiqueta binario)
        {

           

            String NumeroBinario = ConvertirBinario(this.NumeroSiguiente);


            string numero = this.NumeroSiguiente.ToString();
            binario.Text = NumeroBinario;
            etiqueta.Text = numero;
            

        }

        public void ImprimeNumeroAnterior(Etiqueta etiqueta)
        {


          

            String NumeroBinario = ConvertirBinario(this.NumeroAnterior);
            etiqueta.Text = NumeroBinario;
            

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
