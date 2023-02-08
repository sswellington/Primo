using Primo.Aplication.Class;
using Primo.Aplication.Domain.Util;
using Xunit;

namespace Primo.UnitTests;

public class PrimoClassTest
{
    [Theory(DisplayName = "Verifica se o n?mero ? primo tudo certo retorna verdadeiro")]
    [InlineData(2.0)]
    [InlineData(3.0)]
    [InlineData(5.0)]
    [InlineData(7.0)]
    [InlineData(31.0)]
    public void CheckPrimo_Okay_ReturnTrue(double numero)
    {
        //arrange 
        var primo = new PrimoClass();

        //act 
        var result = primo.CheckPrimo(numero);

        //assert 
        Assert.True(result);
    }

    [Theory(DisplayName = "Verifica se o n?mero ? primo tudo certo retorna ? Primo")]
    [InlineData(2.0)]
    [InlineData(3.0)]
    [InlineData(5.0)]
    [InlineData(7.0)]
    [InlineData(31.0)]
    public void ToString_Okay_ReturnPrimo(double numero)
    {
        //arrange 
        var primo = new PrimoClass();

        //act 
        var result = primo.ToString(numero);

        //assert 
        Assert.Equal(Mensagem.Primo, result);
    }

    [Theory(DisplayName = "Verifica se o n?mero n?o ? primo tudo certo retorna falso")]
    [InlineData(4.0)]
    [InlineData(9.0)]
    [InlineData(21.0)]
    [InlineData(42.0)]
    [InlineData(145.0)]
    public void CheckPrimo_Okay_ReturnFalse(double numero)
    {
        //arrange 
        var primo = new PrimoClass();

        //act 
        var result = primo.CheckPrimo(numero);

        //assert 
        Assert.False(result);
    }

    [Theory(DisplayName = "Verifica se o n?mero n?o ? primo tudo certo retorna N?o ? primo")]
    [InlineData(4.0)]
    [InlineData(9.0)]
    [InlineData(21.0)]
    [InlineData(42.0)]
    [InlineData(145.0)]
    public void ToString_Okay_ReturnNaoPrimo(double numero)
    {
        //arrange 
        var primo = new PrimoClass();

        //act 
        var result = primo.ToString(numero);

        //assert 
        Assert.Equal(Mensagem.NaoEhPrimo, result);
    }

    [Theory(DisplayName = "Verifica se o n?mero est? no intervalor tudo certo retorna verdadeiro")]
    [InlineData(2.0)]
    [InlineData(3.0)]
    [InlineData(4.0)]
    [InlineData(5.0)]
    [InlineData(9.0)]
    [InlineData(21.0)]
    [InlineData(42.0)]
    [InlineData(145.0)]
    public void CheckNumeroEstaIntervalo_Okay_ReturnTrue(double numero)
    {
        //arrange 
        var primo = new PrimoClass();

        //act 
        var result = primo.CheckNumeroEstaIntervalo(numero);

        //assert 
        Assert.True(result);
    }

    [Theory(DisplayName = "Verifica se o n?mero n?o est? no intervalor tudo certo retorna False")]
    [InlineData(-2.0)]
    [InlineData(1000000001.0)]
    public void CheckNumeroEstaIntervalo_Okay_ReturnFalse(double numero)
    {
        //arrange 
        var primo = new PrimoClass();

        //act 
        var result = primo.CheckNumeroEstaIntervalo(numero);

        //assert 
        Assert.False(result);
    }
}