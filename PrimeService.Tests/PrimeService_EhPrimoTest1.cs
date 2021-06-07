using Prime.Service;
using Xunit;

namespace Prime.UnitTests.Services
{
    public class PrimeService_EhPrimoTest
    {
        private readonly PrimeService _primeService;

        public PrimeService_EhPrimoTest()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void EhPrimo_ValorMenorQue2_RetornaFalso()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 não pode ser primo");
        }

        #region Sample_TestCode
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void EhPrimo_ValorMenorQue2_RetornaFalso2(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} não pode ser primo");
        }
        #endregion

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void EhPrimo_PrimoMenorQue10_RetornaVerdadeiro(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} deve ser primo");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void EhPrimo_PrimoMenorQue10_RetornaFalso(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} não deve ser primo");
        }
    }
}
