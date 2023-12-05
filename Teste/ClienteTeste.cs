using Dominio;

namespace Teste
{
    public class ClienteTeste
    {
        [Theory]
        [InlineData(0)] // zero
        [InlineData(null)] // null
        [InlineData(10)] // 10
        public void idMaiorQueZero(int id)
        {
            // Arrange
            var cliente = new Cliente(id, "Nome", "12345678901", "12345678901", "123456789");

            // Act

            // Assert
            Assert.True(cliente.id > 0);
        }

        [Theory]
        [InlineData("")] // string vazia
        [InlineData(null)] // null
        [InlineData("Manseira")] // nome
        public void nomeExiste(string nome)
        {
            // Arrange
            var cliente = new Cliente(1, nome, "12345678901", "12345678901", "123456789");

            // Act

            // Assert
            Assert.False(string.IsNullOrEmpty(cliente.nome));
        }

        [Fact]
        public void cpfTamanho11()
        {
            // Arrange
            var cliente = new Cliente(1, "Nome", "12345678901", "12345678901", "123456789");

            // Act

            // Assert
            Assert.Equal(11, cliente.cpf.Length);
        }

        [Fact]
        public void telefoneTamanho11()
        {
            // Arrange
            var cliente = new Cliente(1, "Nome", "12345678901", "12345678901", "123456789");

            // Act

            // Assert
            Assert.Equal(11, cliente.telefone.Length);
        }

        [Theory]
        [InlineData("173928402")] // 9 digitos
        [InlineData("827")] // 3 digitos
        [InlineData("0194538753876")] // 12 digitos
        public void cnhTamanho9(string cnh)
        {
            // Arrange
            var cliente = new Cliente(1, "Nome", "12345678901", "12345678901", cnh);

            // Act

            // Assert
            Assert.Equal(9, cliente.cnh.Length);
        }
    }
}
