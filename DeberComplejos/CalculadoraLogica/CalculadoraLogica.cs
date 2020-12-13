using System;

namespace CalculadoraLogica
{
    public class Calculadora
    {
        public Complejo Sumar(Complejo primeroNumero, Complejo segundoNumero)
        {
            var parteReal = primeroNumero.Real + segundoNumero.Real;
            var parteImaginaria = primeroNumero.Imaginaria + segundoNumero.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
        }

        public Complejo Restar(Complejo primerNumero, Complejo segundoNumero)
        {
            var parteReal = primerNumero.Real + segundoNumero.Real;
            var parteImaginaria = primerNumero.Imaginaria + segundoNumero.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
        }
    }
}
