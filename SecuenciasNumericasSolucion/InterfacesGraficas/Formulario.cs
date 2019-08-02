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
    class Formulario : Form
    {


        public Formulario()
        {


            Fibonacci fibo = new Fibonacci();
            NumeroSuertudo NS = new NumeroSuertudo();
            NumeroPadovan NP = new NumeroPadovan();


            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(700, 500);


            Label labelNumeroFeliz = new Label();
            labelNumeroFeliz.Left = 10;
            labelNumeroFeliz.Top = 20;
            labelNumeroFeliz.Text = "Es Numero Feliz?";
            labelNumeroFeliz.Location = new System.Drawing.Point(15, 175);

            Label labelNumeroCapicua = new Label();
            labelNumeroCapicua.Left = 10;
            labelNumeroCapicua.Top = 20;
            labelNumeroCapicua.Text = "Es Numero Capicua?";
            labelNumeroCapicua.Location = new System.Drawing.Point(15, 220);


            Etiqueta EtiquetaDecimal = new Etiqueta();
            Etiqueta EtiquetaBinario = new Etiqueta();
            Etiqueta EtiquetaHexadecimal = new Etiqueta();
            Etiqueta EtiquetaNumeroFeliz = new Etiqueta();
            Etiqueta EtiquetaNumeroCapicua = new Etiqueta();

            EtiquetaDecimal.Location = new System.Drawing.Point(15, 85);
            EtiquetaBinario.Location = new System.Drawing.Point(15, 120);
            EtiquetaHexadecimal.Location = new System.Drawing.Point(15,150);
            EtiquetaNumeroFeliz.Location = new System.Drawing.Point(15, 200);
            EtiquetaNumeroCapicua.Location = new System.Drawing.Point(15,250);


            BotonA BotonAvanzarFibonacci = new BotonA(fibo, EtiquetaDecimal,EtiquetaBinario);
            BotonAvanzarFibonacci.Text = "AVANZAR FIBONACCI";
            BotonAvanzarFibonacci.Location = new System.Drawing.Point(15, 50);
            BotonAvanzarFibonacci.Size = new Size(115,34);

            //-------------------------------------------------------------------


            Label labelNumeroFelizNSuerte = new Label();
            labelNumeroFelizNSuerte.Left = 10;
            labelNumeroFelizNSuerte.Top = 20;
            labelNumeroFelizNSuerte.Text = "Es Numero Feliz?";
            labelNumeroFelizNSuerte.Location = new System.Drawing.Point(140, 175);

            Label labelNumeroCapicuaNSuerte = new Label();
            labelNumeroCapicuaNSuerte.Left = 10;
            labelNumeroCapicuaNSuerte.Top = 20;
            labelNumeroCapicuaNSuerte.Text = "Es Numero Capicua?";
            labelNumeroCapicuaNSuerte.Location = new System.Drawing.Point(140, 220);


            Etiqueta EtiquetaDecimalNSuerte = new Etiqueta();
            Etiqueta EtiquetaBinarioNSuerte = new Etiqueta();
            Etiqueta EtiquetaHexadecimalNSuerte = new Etiqueta();
            Etiqueta EtiquetaNumeroFelizNSuerte = new Etiqueta();
            Etiqueta EtiquetaNumeroCapicuaNSuerte = new Etiqueta();

            EtiquetaDecimalNSuerte.Location = new System.Drawing.Point(140, 85);
            EtiquetaBinarioNSuerte.Location = new System.Drawing.Point(140, 120);
            EtiquetaHexadecimalNSuerte.Location = new System.Drawing.Point(140, 150);
            EtiquetaNumeroFelizNSuerte.Location = new System.Drawing.Point(140, 200);
            EtiquetaNumeroCapicuaNSuerte.Location = new System.Drawing.Point(140, 250);


            BotonS BotonAvanzarNSuerte = new BotonS(NS, EtiquetaDecimalNSuerte, EtiquetaBinarioNSuerte);
            BotonAvanzarNSuerte.Text = "AVANZAR No.SUERTE";
            BotonAvanzarNSuerte.Location = new System.Drawing.Point(140, 50);
            BotonAvanzarNSuerte.Size = new Size(115, 34);
            //-----------------------------------------------------------------
            Label labelNumeroFelizNPadovan = new Label();
            labelNumeroFelizNPadovan.Left = 10;
            labelNumeroFelizNPadovan.Top = 20;
            labelNumeroFelizNPadovan.Text = "Es Numero Feliz?";
            labelNumeroFelizNPadovan.Location = new System.Drawing.Point(260, 175);

            Label labelNumeroCapicuaNPadovan = new Label();
            labelNumeroCapicuaNPadovan.Left = 10;
            labelNumeroCapicuaNPadovan.Top = 20;
            labelNumeroCapicuaNPadovan.Text = "Es Numero Capicua?";
            labelNumeroCapicuaNPadovan.Location = new System.Drawing.Point(260, 220);


            Etiqueta EtiquetaDecimalNPadovan = new Etiqueta();
            Etiqueta EtiquetaBinarioNPadovan = new Etiqueta();
            Etiqueta EtiquetaHexadecimalNPadovan = new Etiqueta();
            Etiqueta EtiquetaNumeroFelizNPadovan = new Etiqueta();
            Etiqueta EtiquetaNumeroCapicuaNPadovan = new Etiqueta();

            EtiquetaDecimalNPadovan.Location = new System.Drawing.Point(260, 85);
            EtiquetaBinarioNPadovan.Location = new System.Drawing.Point(260, 120);
            EtiquetaHexadecimalNPadovan.Location = new System.Drawing.Point(260, 150);
            EtiquetaNumeroFelizNPadovan.Location = new System.Drawing.Point(260, 200);
            EtiquetaNumeroCapicuaNPadovan.Location = new System.Drawing.Point(260, 250);


            BotonP BotonAvanzarNPadovan = new BotonP(NP, EtiquetaDecimalNPadovan, EtiquetaBinarioNPadovan);
            BotonAvanzarNPadovan.Text = "AVANZAR PADOVAN";
            BotonAvanzarNPadovan.Location = new System.Drawing.Point(260, 50);
            BotonAvanzarNPadovan.Size = new Size(115, 34);
            //-----------------------------------------------------------------
            Label labelNumeroFelizNUlam = new Label();
            labelNumeroFelizNUlam.Left = 10;
            labelNumeroFelizNUlam.Top = 20;
            labelNumeroFelizNUlam.Text = "Es Numero Feliz?";
            labelNumeroFelizNUlam.Location = new System.Drawing.Point(380, 175);

            Label labelNumeroCapicuaNUlam = new Label();
            labelNumeroCapicuaNUlam.Left = 10;
            labelNumeroCapicuaNUlam.Top = 20;
            labelNumeroCapicuaNUlam.Text = "Es Numero Capicua?";
            labelNumeroCapicuaNUlam.Location = new System.Drawing.Point(380, 220);


            Etiqueta EtiquetaDecimalNUlam = new Etiqueta();
            Etiqueta EtiquetaBinarioNUlam = new Etiqueta();
            Etiqueta EtiquetaHexadecimalNUlam = new Etiqueta();
            Etiqueta EtiquetaNumeroFelizNUlam = new Etiqueta();
            Etiqueta EtiquetaNumeroCapicuaNUlam = new Etiqueta();

            EtiquetaDecimalNUlam.Location = new System.Drawing.Point(380, 85);
            EtiquetaBinarioNUlam.Location = new System.Drawing.Point(380, 120);
            EtiquetaHexadecimalNUlam.Location = new System.Drawing.Point(380, 150);
            EtiquetaNumeroFelizNUlam.Location = new System.Drawing.Point(380, 200);
            EtiquetaNumeroCapicuaNUlam.Location = new System.Drawing.Point(380, 250);


            BotonA BotonAvanzarNUlam = new BotonA(fibo, EtiquetaDecimal,EtiquetaBinario);
            BotonAvanzarNUlam.Text = "AVANZAR ULAM";
            BotonAvanzarNUlam.Location = new System.Drawing.Point(380, 50);
            BotonAvanzarNUlam.Size = new Size(115, 34);
            //------------------------------------------------------------------
            this.Controls.Add(labelNumeroFelizNPadovan);
            this.Controls.Add(labelNumeroCapicuaNPadovan);

            this.Controls.Add(EtiquetaDecimalNPadovan);
            this.Controls.Add(EtiquetaBinarioNPadovan);
            this.Controls.Add(EtiquetaHexadecimalNPadovan);
            this.Controls.Add(EtiquetaNumeroFelizNPadovan);
            this.Controls.Add(EtiquetaNumeroCapicuaNPadovan);


            this.Controls.Add(BotonAvanzarNPadovan);
            //---------------------------------------------------------------
            this.Controls.Add(labelNumeroFeliz);
            this.Controls.Add(labelNumeroCapicua);

            this.Controls.Add(EtiquetaDecimal);
            this.Controls.Add(EtiquetaBinario);
            this.Controls.Add(EtiquetaHexadecimal);
            this.Controls.Add(EtiquetaNumeroFeliz);
            this.Controls.Add(EtiquetaNumeroCapicua);


            this.Controls.Add(BotonAvanzarFibonacci);

            //-----------------------------------------

            this.Controls.Add(labelNumeroFelizNSuerte);
            this.Controls.Add(labelNumeroCapicuaNSuerte);

            this.Controls.Add(EtiquetaDecimalNSuerte);
            this.Controls.Add(EtiquetaBinarioNSuerte);
            this.Controls.Add(EtiquetaHexadecimalNSuerte);
            this.Controls.Add(EtiquetaNumeroFelizNSuerte);
            this.Controls.Add(EtiquetaNumeroCapicuaNSuerte);


            this.Controls.Add(BotonAvanzarNSuerte);

            //--------------------------------------------------

            this.Controls.Add(labelNumeroFelizNUlam);
            this.Controls.Add(labelNumeroCapicuaNUlam);

            this.Controls.Add(EtiquetaDecimalNUlam);
            this.Controls.Add(EtiquetaBinarioNUlam);
            this.Controls.Add(EtiquetaHexadecimalNUlam);
            this.Controls.Add(EtiquetaNumeroFelizNUlam);
            this.Controls.Add(EtiquetaNumeroCapicuaNUlam);


            this.Controls.Add(BotonAvanzarNUlam);


        }

        private void InitializeComponent()
        {
           
            this.SuspendLayout();
            // 
            // textBox1
            // 
           
            // 
            // Formulario
            // 
           // this.ClientSize = new System.Drawing.Size(800, 400);
            
            this.Name = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }
    }
}
