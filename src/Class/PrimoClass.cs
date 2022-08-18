using System;
using Primo.Aplication.Domain;

namespace Primo.Aplication.Class
{
    public class PrimoClass : IPrimoClass
    {
        private const double LimiteInferior = 0.0;
        private readonly double LimiteSuperior;

        public PrimoClass()
        {
            LimiteSuperior = Math.Pow(10, 9);
        }

        public bool CheckNumeroEstaIntervalo(double numero)
        {
            return (numero > LimiteInferior && numero < LimiteSuperior);
        }

        public bool CheckPrimo(double numero)
        {
            return false;
        }
    }
}