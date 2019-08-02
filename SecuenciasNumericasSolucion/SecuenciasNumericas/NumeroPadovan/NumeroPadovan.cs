using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFibonacci.InterfacesGraficas;

namespace ProyectoFibonacci.SecuenciasNumericas
{
    class NumeroPadovan
    {

       private int PenultimoAnterior = 0;
       private int  terminoAnterior = 1;
       private int terminoActual = 1;
       private int numeroVecesActualizador = 0;
       private int valor = 0;

        public void Siguiente()
        {
            this.numeroVecesActualizador += 1;
            if (this.numeroVecesActualizador == 0)
            {
                this.terminoActual = 1;
            }
            if (this.numeroVecesActualizador == 1)
            {
                this.terminoActual = 1;
            }
            if (this.numeroVecesActualizador == 2)
            {
                this.terminoActual = 1;
            }
            if (this.numeroVecesActualizador == 3)
            {
                this.terminoActual = 2;
            }
            if (this.numeroVecesActualizador == 4)
            {
                this.PenultimoAnterior = 1;
                this.terminoAnterior = 2;
                this.terminoActual = 2;
            }

            if (this.numeroVecesActualizador >= 5)
            {
                int respaldoTerminoAnteriorAnterior = this.PenultimoAnterior;
                this.PenultimoAnterior = this.terminoAnterior;
                this.terminoAnterior = this.terminoActual;
                this.terminoActual = this.PenultimoAnterior + respaldoTerminoAnteriorAnterior;
            }
            this.valor = this.terminoActual;

        }


        public void retroceder()
        {
            if (this.numeroVecesActualizador != 1)
            {
                this.numeroVecesActualizador -= 1;
            }
            if (this.numeroVecesActualizador == 1)
            {
                this.terminoActual = 1;
            }
            if (this.numeroVecesActualizador == 2)
            {
                this.terminoActual = 1;
            }
            if (this.numeroVecesActualizador == 3)
            {
                this.terminoActual = 2;
            }
            if (this.numeroVecesActualizador == 4)
            {
                this.PenultimoAnterior = 1;
                this.terminoAnterior = 2;
                this.terminoActual = 2;
            }
            if (this.numeroVecesActualizador >= 5)
            {
                int respaldoTerminoAnterior = this.terminoAnterior;
                int respaldoTerminoActual = this.terminoActual;
                this.terminoActual = this.terminoAnterior;
                this.terminoAnterior = this.PenultimoAnterior;
                this.PenultimoAnterior = respaldoTerminoActual -respaldoTerminoAnterior;
            }
            this.valor = this.terminoActual;
        }

        public int getNumeroPadovan()
        {

            return this.valor;
        }


        public void ImprimirSiguiente(Etiqueta e,Etiqueta binario) {
            string numero = getNumeroPadovan().ToString();
            e.Text = numero;
            String bi = ConvertirBinario(getNumeroPadovan());
            binario.Text = bi;
        }

        public void ImprimirAnterior(Etiqueta e)
        {
            string numero = getNumeroPadovan().ToString();
            e.Text = numero;
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