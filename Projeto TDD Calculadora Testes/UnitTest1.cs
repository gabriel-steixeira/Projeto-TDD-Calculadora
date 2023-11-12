using Projeto_TDD_Calculadora;

namespace Projeto_TDD_Calculadora_Testes
{
    public class UnitTest1
    {
        public Calculadora CriarClasse()
        {
            string data = "12/11/2023";
            return new Calculadora(data);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 4, 8)]
        public void TesteSomar(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = CriarClasse();

            int resultadoSoma = calc.Somar(num1, num2);

            Assert.Equal(resultadoEsperado, resultadoSoma);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(16, 4, 12)]
        public void TesteSubtrair(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = CriarClasse();

            int resultadoSubtrair = calc.Subtrair(num1, num2);

            Assert.Equal(resultadoEsperado, resultadoSubtrair);
        }

        [Theory]
        [InlineData(7, 2, 14)]
        [InlineData(4, 4, 16)]
        public void TesteMultiplicar(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = CriarClasse();

            int resultadoMultiplicar = calc.Multiplicar(num1, num2);

            Assert.Equal(resultadoEsperado, resultadoMultiplicar);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(24, 3, 8)]
        public void TesteDividir(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = CriarClasse();

            int resultadoDividir = calc.Dividir(num1, num2);

            Assert.Equal(resultadoEsperado, resultadoDividir);
        }

        [Fact]
        public void TesteDividirPorZero() 
        {
            Calculadora calc = CriarClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TesteRetorna3Historico()
        {
            Calculadora calc = CriarClasse();

            calc.Somar(1, 5);
            calc.Dividir(10, 5);
            calc.Multiplicar(7, 5);

            var lista = calc.ListarHistorico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}