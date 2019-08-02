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
    public class BotonS : Button
    {
       public NumeroSuertudo NumeroDeLaSuerte;
       public Etiqueta etiqueta;
        public Etiqueta c;
        public BotonS(NumeroSuertudo numero, Etiqueta e,Etiqueta c)
        {
            this.NumeroDeLaSuerte = numero;
            this.etiqueta = e;
            this.c = c;
            BackColor = Color.WhiteSmoke;
            NumeroDeLaSuerte.sucesion(1000);
        }


        protected override void OnMouseDown(MouseEventArgs mevent)
        {


            
            
            NumeroDeLaSuerte.Siguiente(etiqueta,c);
            base.OnMouseDown(mevent);
         
        }


     

       
    }
}
