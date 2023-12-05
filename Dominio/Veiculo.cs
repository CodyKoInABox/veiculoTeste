namespace Dominio
{
    public class Veiculo
    {
        public string chassi;
        public string placa;
        public string marca;
        public string modelo;
        public string cor;
        public int ano;
        public int km;
        public float multiplicador;
        public bool alugado;

        public Veiculo(string chassi, string placa, string marca, string modelo, string cor, int ano, int km, float multiplicador, bool alugado)
        {
            this.chassi = chassi;
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
            this.km = km;
            this.multiplicador = multiplicador;
            this.alugado = alugado;
        }
    }
}