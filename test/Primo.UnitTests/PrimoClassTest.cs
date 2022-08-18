using Primo.Aplication.Class;
using Xunit;

namespace Primo.UnitTests
{
    public class PrimoClassTest
    {
        [Theory(DisplayName = "Verifica se o número é primo tudo certo retorna verdadeiro")]
        [InlineData(2.0)]
        [InlineData(3.0)]
        [InlineData(5.0)]
        [InlineData(7.0)]
        [InlineData(31.0)]
        public void CheckPrimo_Okay_RetornTrue(double numero)
        {
            //arrange 
            var primo = new PrimoClass();

            //act 
            bool result = primo.CheckPrimo(numero);

            //assert 
            Assert.True(result);
        }

        [Theory(DisplayName = "Verifica se o número não é primo tudo certo retorna falso")]
        [InlineData(4.0)]
        [InlineData(9.0)]
        [InlineData(21.0)]
        [InlineData(42.0)]
        [InlineData(145.0)]
        public void CheckPrimo_Okay_RetornFalse(double numero)
        {
            //arrange 
            var primo = new PrimoClass();

            //act 
            bool result = primo.CheckPrimo(numero);

            //assert 
            Assert.False(result);
        }

        [Theory(DisplayName = "Verifica se o número está no intervalor tudo certo retorna verdadeiro")]
        [InlineData(2.0)]
        [InlineData(3.0)]
        [InlineData(4.0)]
        [InlineData(5.0)]
        [InlineData(9.0)]
        [InlineData(21.0)]
        [InlineData(42.0)]
        [InlineData(145.0)]
        public void CheckNumeroEstaIntervalo_Okay_RetornTrue(double numero)
        {
            //arrange 
            var primo = new PrimoClass();

            //act 
            bool result = primo.CheckNumeroEstaIntervalo(numero);

            //assert 
            Assert.True(result);
        }

        [Theory(DisplayName = "Verifica se o número não está no intervalor tudo certo retorna False")]
        [InlineData(-2.0)]
        [InlineData(1000000001.0)]
        public void CheckNumeroEstaIntervalo_Okay_RetornFalse(double numero)
        {
            //arrange 
            var primo = new PrimoClass();

            //act 
            bool result = primo.CheckNumeroEstaIntervalo(numero);

            //assert 
            Assert.False(result);
        }
    }
}