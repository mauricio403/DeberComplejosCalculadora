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

        [TestMethod]

        public void MultiplicacionComplejos()
        {
            var primerComplejo = new Complejo(5, 2);
            var segundoComplejo = new Complejo(4, 4);
            var resultadoEsperado = new Complejo(12, 28);

            var micalculadora = new Calculadora();

            var resultadoObtenido = micalculadora.Multiplicar(primerComplejo, segundoComplejo);

            Assert.AreEqual(resultadoEsperado.Real, resultadoObtenido.Real);

            Assert.AreEqual(resultadoEsperado.Imaginaria, resultadoObtenido.Imaginaria);
        }

        [TestMethod]

        /*public void DivisionComplejos()
        {
            var primerComplejo = new Complejo(6, 5);
            var segundoComplejo = new Complejo(5, 4);
            var resultadoEsperado = new Complejo(50/29, 1/29);

            var miCalculadora = new Calculadora();

            var resultadoObtenido = miCalculadora.Dividir(primerComplejo, segundoComplejo);
            
            Assert.AreEqual(resultadoEsperado.Real, resultadoObtenido.Real);

            Assert.AreEqual(resultadoEsperado.Imaginaria, resultadoObtenido.Imaginaria);
        }*/

        public void multiplicacionPorescalar()
        {
            var escalar = 2;

            var complejo = new Complejo(4, 6);

            var resultadoEsperado = new Complejo(8, 12);

            var micalculadora = new Calculadora();

            var resultadoObtenido = micalculadora.multiplicacionEscalar(escalar, complejo);

            Assert.AreEqual(resultadoEsperado.Real, resultadoObtenido.Real);

            Assert.AreEqual(resultadoEsperado.Imaginaria, resultadoObtenido.Imaginaria);

        }
    }
}
