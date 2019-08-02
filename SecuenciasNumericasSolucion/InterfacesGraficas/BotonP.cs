using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFibonacci.SecuenciasNumericas;
using System.Drawing;

namespace ProyectoFibonacci.InterfacesGraficas
{
    class BotonP : Button
    {
        public NumeroPadovan NP = new NumeroPadovan();
        public Etiqueta etiqueta;
        public Etiqueta etiquetaBinario;
        public BotonP(NumeroPadovan f, Etiqueta e, Etiqueta binario)
        {
            this.NP = f;
            this.etiqueta = e;
            this.etiquetaBinario = binario;
            BackColor = Color.WhiteSmoke;

        }


        protected override void OnMouseDown(MouseEventArgs mevent)
        {

            NP.Siguiente();
            NP.ImprimirSiguiente(etiqueta,etiquetaBinario);
            
            base.OnMouseDown(mevent);

        }

    }
}
