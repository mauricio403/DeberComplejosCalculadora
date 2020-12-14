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
            var parteReal = primerNumero.Real - segundoNumero.Real;
            var parteImaginaria = primerNumero.Imaginaria - segundoNumero.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
        }

        public Complejo Multiplicar(Complejo primerNumero, Complejo segundoNumero)
        {
            var primerFactor = primerNumero.Real * segundoNumero.Real;
            var segundofactor = primerNumero.Real * segundoNumero.Imaginaria;
            var tercerFactor = primerNumero.Imaginaria * segundoNumero.Real;
            var cuartoFactor = primerNumero.Imaginaria * segundoNumero.Imaginaria;

            var cambioNegativo = cuartoFactor * -1;

            var parteReal = primerFactor + cambioNegativo;
            var parteImaginaria = segundofactor + tercerFactor;

            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
        }

        /*public Complejo Dividir(Complejo primerNumero, Complejo segundoNumero)
        {
            //Creacion de la expresion conjugada
            var imaginariaConjugada = segundoNumero.Imaginaria * -1;

            var expresionConjugada = new Complejo(segundoNumero.Real, imaginariaConjugada);
            
            //Parte del dividendo
            var primerFactor = primerNumero.Real * segundoNumero.Real;
            var segundoFactor = primerNumero.Real * expresionConjugada.Imaginaria;
            var tercerFactor = primerNumero.Imaginaria * segundoNumero.Real;
            var cuartoFactor = primerNumero.Imaginaria * expresionConjugada.Imaginaria;
            var cuartoCambio = cuartoFactor * -1;

            var primerDividendo = (primerFactor + cuartoCambio);
            var segundoDividendo = (segundoFactor + tercerFactor);

            //Parte del divisor
            var quintoFactor = segundoNumero.Real * segundoNumero.Real;
            var sextofactor = segundoNumero.Imaginaria * expresionConjugada.Imaginaria;

            var sextoCambio = sextofactor * -1;

            var divisor = quintoFactor + sextoCambio;



            var parteReal = primerDividendo / divisor;

            var parteImaginaria = segundoDividendo / divisor;

            var nuevocomplejo = new Complejo(parteReal, parteImaginaria);

            return nuevocomplejo;


        }*/

        public Complejo multiplicacionEscalar(double numero, Complejo primerNumero)
        {
            var parteReal = numero * primerNumero.Real;

            var parteImaginaria = numero * primerNumero.Imaginaria;

            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
        }

    }
}
