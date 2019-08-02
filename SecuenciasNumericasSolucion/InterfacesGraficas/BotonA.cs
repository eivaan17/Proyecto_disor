using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ProyectoFibonacci.SecuenciasNumericas;

namespace ProyectoFibonacci.InterfacesGraficas
{
    public class BotonA : Button
    {
       public Fibonacci fibonacci;
       public Etiqueta etiqueta;
        public Etiqueta etiquetaBinario;
        public BotonA(Fibonacci f, Etiqueta e, Etiqueta binario) 
        {
            this.fibonacci = f;
            this.etiqueta = e;
            this.etiquetaBinario = binario;
            BackColor = Color.WhiteSmoke;
         
        }


        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            fibonacci.AvanzarSerieFibonacci();
            fibonacci.ImprimeNumeroSiguiente(etiqueta,etiquetaBinario);
            Console.Write("______");
            base.OnMouseDown(mevent);
         
        }


     

       
    }
}
