using Dominio;
using Xunit;

namespace Teste
{
    public class AluguelTeste
    {
        [Fact]
        public void idAcima0()
        {
            // Arrange
            var aluguel = new Aluguel(1, 2, "123456789012345", 1, 2, 3, new DateOnly(2023, 1, 1), 100.0f, 100.0f, 0);

            // Act

            // Assert
            Assert.True(aluguel.id > 0);
        }

        [Fact]
        public void clienteIdAcima0()
        {
            // Arrange
            var aluguel = new Aluguel(1, 2, "123456789012345", 1, 2, 3, new DateOnly(2023, 1, 1), 100.0f, 100.0f, 0);

            // Act

            // Assert
            Assert.True(aluguel.cliente_id > 0);
        }

        [Fact]
        public void veiculoChassiTamanho15()
        {
            // Arrange
            var aluguel = new Aluguel(1, 2, "123456789012345", 1, 2, 3, new DateOnly(2023, 1, 1), 100.0f, 100.0f, 0);

            // Act

            // Assert
            Assert.Equal(15, aluguel.veiculo_chassi.Length);
        }

        [Fact]
        public void retiradaStatusIdAcima0()
        {
            // Arrange
            var aluguel = new Aluguel(1, 2, "123456789012345", 1, 2, 3, new DateOnly(2023, 1, 1), 100.0f, 100.0f, 0);

            // Act

            // Assert
            Assert.True(aluguel.retirada_status_id > 0);
        }

        [Fact]
        public void devolucaoStatusIdAcima0()
        {
            // Arrange
            var aluguel = new Aluguel(1, 2, "123456789012345", 1, 2, 3, new DateOnly(2023, 1, 1), 100.0f, 100.0f, 0);

            // Act

            // Assert
            Assert.True(aluguel.devolucao_status_id > 0);
        }

        [Fact]
        public void diasPositivoOu0()
        {
            // Arrange
            var aluguel = new Aluguel(1, 2, "123456789012345", 1, 2, 0, new DateOnly(2023, 1, 1), 100.0f, 100.0f, 0);

            // Act

            // Assert
            Assert.True(aluguel.dias >= 0);
        }

        [Fact]
        public void dataPrevistaExsite()
        {
            // Arrange
            var aluguel = new Aluguel(1, 2, "123456789012345", 1, 2, 3, new DateOnly(2023, 1, 1), 100.0f, 100.0f, 0);

            // Act

            // Assert
            Assert.NotNull(aluguel.data_prevista);
        }

        [Fact]
        public void valorPrevistoAcima0()
        {
            // Arrange
            var aluguel = new Aluguel(1, 2, "123456789012345", 1, 2, 3, new DateOnly(2023, 1, 1), 100.0f, 100.0f, 0);

            // Act

            // Assert
            Assert.True(aluguel.valor_previsto > 0);
        }

        [Theory]
        [InlineData(500, 200)] // menor que o valor previsto
        [InlineData(500, 500)] // igual ao valor previsto
        [InlineData(500, 800)] // maior ao valor previsto
        public void valorRealMaiorIgualValorPrevisto(int valorPrevisto, int valorReal)
        {
            // Arrange
            var aluguel = new Aluguel(1, 2, "123456789012345", 1, 2, 3, new DateOnly(2023, 1, 1), valorPrevisto, valorReal, 0);

            // Act

            // Assert
            Assert.True(aluguel.valor_real >= aluguel.valor_previsto);
        }

        [Theory]
        [InlineData(-5)] // negativo
        [InlineData(0)] // zero
        [InlineData(20)] // positivo
        public void atrasoPositivoOu0(int atraso)
        {
            // Arrange
            var aluguel = new Aluguel(1, 2, "123456789012345", 1, 2, 3, new DateOnly(2023, 1, 1), 100.0f, 100.0f, atraso);

            // Act

            // Assert
            Assert.True(aluguel.atraso >= 0);
        }
    }
}
