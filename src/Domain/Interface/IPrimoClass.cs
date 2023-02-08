namespace Primo.Aplication.Domain.Interface;

public interface IPrimoClass
{
    bool CheckLimiteInferior(double numero);

    bool CheckLimiteSuperior(double numero);

    bool CheckNumeroEstaIntervalo(double numero);

    /// <summary>
    ///     Verifica se o número é primo ou não.
    ///     Ela começa verificando se o número é menor ou igual a 1, o que significa que não é primo.
    ///     Em seguida, verifica se o número é divisível por algum número entre 2 e a raiz quadrada do número.
    ///     Se o número for divisível por algum desses números, retorna falso, o que significa que o número não é primo.
    ///     Se o número não for divisível por nenhum desses números, retorna verdadeiro, o que significa que o número é primo.
    /// </summary>
    /// <param name="numero"></param>
    /// <returns>bool</returns>
    bool CheckPrimo(double numero);
}