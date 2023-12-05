using Dominio;
using Xunit;

namespace Teste
{
    public class VeiculoTeste
    {
        [Theory]
        [InlineData("735ha91i7h")] // tamanho 10
        [InlineData("6iah451jn953oa5")] // tamanho 15
        [InlineData("7dn8236j4kod7836nbop")] // tamanho 20
        public void chassiTamanho15(string chassi)
        {
            // Arrange
            var veiculo = new Veiculo(chassi, "ABC1234", "Marca", "Modelo", "Cor", 2023, 10000, 1.0f, false);

            // Act

            // Assert
            Assert.Equal(15, veiculo.chassi.Length);
        }

        [Fact]
        public void placaTamanho7()
        {
            // Arrange
            var veiculo = new Veiculo("123456789012345", "ABC1234", "Marca", "Modelo", "Cor", 2023, 10000, 1.0f, false);

            // Act

            // Assert
            Assert.Equal(7, veiculo.placa.Length);
        }

        [Fact]
        public void marcaExiste()
        {
            // Arrange
            var veiculo = new Veiculo("123456789012345", "ABC1234", "Marca", "Modelo", "Cor", 2023, 10000, 1.0f, false);

            // Act

            // Assert
            Assert.False(string.IsNullOrEmpty(veiculo.marca));
        }

        [Fact]
        public void modeloExiste()
        {
            // Arrange
            var veiculo = new Veiculo("123456789012345", "ABC1234", "Marca", "Modelo", "Cor", 2023, 10000, 1.0f, false);

            // Act

            // Assert
            Assert.False(string.IsNullOrEmpty(veiculo.modelo));
        }

        [Fact]
        public void corExiste()
        {
            // Arrange
            var veiculo = new Veiculo("123456789012345", "ABC1234", "Marca", "Modelo", "Cor", 2023, 10000, 1.0f, false);

            // Act

            // Assert
            Assert.False(string.IsNullOrEmpty(veiculo.cor));
        }

        [Theory]
        [InlineData(92)] // tamanho 2
        [InlineData(2023)] // tamanho 4
        [InlineData(202232)] // tamanho 6
        public void anoTamanho4(int ano)
        {
            // Arrange
            var veiculo = new Veiculo("123456789012345", "ABC1234", "Marca", "Modelo", "Cor", ano, 10000, 1.0f, false);

            // Act

            // Assert
            Assert.True(veiculo.ano >= 1000 && veiculo.ano <= 9999);
        }

        [Theory]
        [InlineData(-5)] // negativo
        [InlineData(0)] // zero
        [InlineData(20)] // positivo
        public void kmPositivoOu0(int km)
        {
            // Arrange
            var veiculo = new Veiculo("123456789012345", "ABC1234", "Marca", "Modelo", "Cor", 2023, km, 1.0f, false);

            // Act

            // Assert
            Assert.True(veiculo.km >= 0);
        }

        [Fact]
        public void multiplicadorMaiorQue0()
        {
            // Arrange
            var veiculo = new Veiculo("123456789012345", "ABC1234", "Marca", "Modelo", "Cor", 2023, 10000, 1.0f, false);

            // Act

            // Assert
            Assert.True(veiculo.multiplicador > 0);
        }

        [Fact]
        public void alugadoNaoNull()
        {
            // Arrange
            var veiculo = new Veiculo("123456789012345", "ABC1234", "Marca", "Modelo", "Cor", 2023, 10000, 1.0f, false);

            // Act

            // Assert
            Assert.NotNull(veiculo.alugado);
        }
    }
}
