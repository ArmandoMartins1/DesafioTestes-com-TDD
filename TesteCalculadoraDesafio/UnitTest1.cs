using DesafioDaCalculadora;
using Xunit;
using System;



namespace TesteCalculadoraDesafio
{
    public class UnitTest1
    {
        
        public CalculadoraDesafio construirClasse()
        {
            string data = "29/05/2024";
            CalculadoraDesafio calc = new CalculadoraDesafio("29/05/2024");

            return calc;
        }


        // [Fact] é quando é um fato
        [Theory]  //testes
        [InlineData(10, 5, 15)]
        [InlineData(6, 2, 8)]
        public void TesteSomar(int num1, int num2, int resultado)
        {
            CalculadoraDesafio calculator = construirClasse();

            int resultadoCalculadora = calculator.somar(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]  //testes
        [InlineData(5, 3, 15)]
        [InlineData(7, 2, 14)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            CalculadoraDesafio calculator = construirClasse();

            int resultadoCalculadora = calculator.multiplicar(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]  //testes
        [InlineData(12, 6, 2)]
        [InlineData(27, 3, 9)]
        public void TesteDividir(int num1, int num2, int resultado)
        {
            CalculadoraDesafio calculator = construirClasse();

            int resultadoCalculadora = calculator.dividir(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]  //testes
        [InlineData(12, 3, 9)]
        [InlineData(32, 12, 20)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            CalculadoraDesafio calculator = construirClasse();

            int resultadoCalculadora = calculator.subtrair(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            CalculadoraDesafio calculator = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calculator.dividir(3, 0)
             );
        }
        [Fact]
        public void TestarHistorico()
        {
            CalculadoraDesafio calculator = construirClasse();

            calculator.somar(4, 7);
            calculator.somar(5, 9);
            calculator.somar(2, 6);
            calculator.somar(1, 3);

            var lista = calculator.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }
    }
}