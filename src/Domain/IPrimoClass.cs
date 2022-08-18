namespace Primo.Aplication.Domain
{
    public interface IPrimoClass
    {
        bool CheckNumeroEstaIntervalo(double numero);

        bool CheckPrimo(double numero);
    }
}