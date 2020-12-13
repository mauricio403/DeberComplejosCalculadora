using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraLogica;
using System;
namespace calculadoraComplejoTest
{
    [TestClass]
    public class ComplejosTest
    {
        [TestMethod]
        public void SumaNumerosComplejos()
        {
            var primerComlejo = new Complejo(4, 4);
            var segundoComplejo = new Complejo(6, 6);

            var resultadoEsperado = new Complejo(12, 12);

            var miCalculadora = new Calculadora();

            var resultadoObtenido = miCalculadora.Sumar(primerComlejo, segundoComplejo);

            Assert.AreEqual(resultadoEsperado.Real, resultadoObtenido.Real);

            Assert.AreEqual(resultadoEsperado.Imaginaria, resultadoObtenido.Imaginaria);

        }

        [TestMethod]
        public void RestaNumeroComplejos()
        {
            var primerComlejo = new Complejo(6, 8);
            var segundoComplejo = new Complejo(3, 5);

            var resultadoEsperado = new Complejo(3, 3);

            var miCalculadora = new Calculadora();

            var resultadoObtenido = miCalculadora.Restar(primerComlejo, segundoComplejo);

            Assert.AreEqual(resultadoEsperado.Real, resultadoObtenido.Real);

            Assert.AreEqual(resultadoEsperado.Imaginaria, resultadoObtenido.Imaginaria);

        }

        
    }
}
