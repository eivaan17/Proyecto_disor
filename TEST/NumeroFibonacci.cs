using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFibonacci.SecuenciasNumericas;


namespace TEST
{
    [TestClass]
    public class NumeroFibonacci
    {
        Fibonacci f = new Fibonacci();

        [TestMethod]
        public void SiguienteNumeroFibonacci()
        {
             int NumeroFibonacciEsperado = 2;
             int NumeroFibonacci=0;
             f.AvanzarSerieFibonacci();
            f.AvanzarSerieFibonacci();
            f.AvanzarSerieFibonacci();
            f.AvanzarSerieFibonacci();
          
            Assert.AreEqual(NumeroFibonacciEsperado,NumeroFibonacci);
        }
    }
}
