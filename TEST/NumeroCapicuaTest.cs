using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFibonacci.TipoDeNumero;

namespace TEST
{
    [TestClass]
    public class NumeroCapicuaTest
    {
        NumeroCapicua NumeroC = new NumeroCapicua();
        String NumeroInvertidoEsperado = "524";

        [TestMethod]
        public void InvertirNumeroEntero()
        {

            // String NumeroGenerado  = NumeroC.InvertirNumero("425");
            Assert.IsTrue(NumeroC.InvertirNumero("121"));

        }
    }
}
