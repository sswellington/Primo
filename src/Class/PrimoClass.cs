using System;
using Primo.Aplication.Domain.Interface;
using Primo.Aplication.Domain.Util;

namespace Primo.Aplication.Class;

public class PrimoClass : IPrimoClass
{
    private readonly double LimiteInferior;
    private readonly double LimiteSuperior;

    public PrimoClass()
    {
        LimiteInferior = 0.0;
        LimiteSuperior = Math.Pow(10, 9);
    }

    public bool CheckLimiteInferior(double numero)
    {
        return numero > LimiteInferior;
    }

    public bool CheckLimiteSuperior(double numero)
    {
        return numero < LimiteSuperior;
    }

    public bool CheckNumeroEstaIntervalo(double numero)
    {
        return CheckLimiteInferior(numero) && CheckLimiteSuperior(numero);
    }

    public bool CheckPrimo(double numero)
    {
        for (var i = 2; i <= (int)Math.Sqrt(numero); i++)
            if (numero % i == 0)
                return false;
        return true;
    }

    public string ToString(double numero)
    {
        return CheckPrimo(numero) ? Mensagem.Primo : Mensagem.NaoEhPrimo;
    }
}