using Dominio;
using Xunit;

namespace Teste
{
    public class PrecisaManutencaoTeste
    {
        [Fact]
        public void idAcima0()
        {
            // Arrange
            var precisaManutencao = new PrecisaManutencao(1, "123456789012345");

            // Act

            // Assert
            Assert.True(precisaManutencao.id > 0);
        }

        [Fact]
        public void veiculoChassiTamanho15()
        {
            // Arrange
            var precisaManutencao = new PrecisaManutencao(1, "123456789012345");

            // Act

            // Assert
            Assert.Equal(15, precisaManutencao.veiculo_chassi.Length);
        }
    }
}
