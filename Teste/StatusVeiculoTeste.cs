using Dominio;
using Xunit;

namespace Teste
{
    public class StatusVeiculoTeste
    {
        [Fact]
        public void idAcima0()
        {
            // Arrange
            var statusVeiculo = new StatusVeiculo(1, new DateOnly(2023, 1, 1), 10000, 50);

            // Act

            // Assert
            Assert.True(statusVeiculo.id > 0);
        }

        [Fact]
        public void dataExiste()
        {
            // Arrange
            var statusVeiculo = new StatusVeiculo(1, new DateOnly(2023, 1, 1), 10000, 50);

            // Act

            // Assert
            Assert.NotNull(statusVeiculo.data);
        }

        [Fact]
        public void kmAcima0()
        {
            // Arrange
            var statusVeiculo = new StatusVeiculo(1, new DateOnly(2023, 1, 1), 10000, 50);

            // Act

            // Assert
            Assert.True(statusVeiculo.km > 0);
        }

        [Theory]
        [InlineData(-10)] // negativo
        [InlineData(0)] // zero
        [InlineData(32)] // positivo
        public void litrosPositivoOu0(int litros)
        {
            // Arrange
            var statusVeiculo = new StatusVeiculo(1, new DateOnly(2023, 1, 1), 10000, litros);

            // Act

            // Assert
            Assert.True(statusVeiculo.litros >= 0);
        }
    }
}
