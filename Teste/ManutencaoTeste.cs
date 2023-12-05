using Dominio;
using Xunit;

namespace Teste
{
    public class ManutencaoTeste
    {
        [Fact]
        public void idAcima0()
        {
            // Arrange
            var manutencao = new Manutencao(1, 2, "Troca de óleo", "Descrição da manutenção", 10000, new DateOnly(2023, 1, 1));

            // Act

            // Assert
            Assert.True(manutencao.id > 0);
        }

        [Fact]
        public void veiculoIdAcima0()
        {
            // Arrange
            var manutencao = new Manutencao(1, 2, "Troca de óleo", "Descrição da manutenção", 10000, new DateOnly(2023, 1, 1));

            // Act

            // Assert
            Assert.True(manutencao.veiculo_id > 0);
        }

        [Fact]
        public void motivoExiste()
        {
            // Arrange
            var manutencao = new Manutencao(1, 2, "Troca de óleo", "Descrição da manutenção", 10000, new DateOnly(2023, 1, 1));

            // Act

            // Assert
            Assert.False(string.IsNullOrEmpty(manutencao.motivo));
        }

        [Fact]
        public void descricaoExiste()
        {
            // Arrange
            var manutencao = new Manutencao(1, 2, "Troca de óleo", "Descrição da manutenção", 10000, new DateOnly(2023, 1, 1));

            // Act

            // Assert
            Assert.False(string.IsNullOrEmpty(manutencao.descricao));
        }

        [Fact]
        public void kmPositivoOu0()
        {
            // Arrange
            var manutencao = new Manutencao(1, 2, "Troca de óleo", "Descrição da manutenção", 10000, new DateOnly(2023, 1, 1));

            // Act

            // Assert
            Assert.True(manutencao.km >= 0);
        }

        [Fact]
        public void dataExiste()
        {
            // Arrange
            var manutencao = new Manutencao(1, 2, "Troca de óleo", "Descrição da manutenção", 10000, new DateOnly(2023, 1, 1));

            // Act

            // Assert
            Assert.NotNull(manutencao.data);
        }
    }
}
