namespace Dominio
{
    public class StatusVeiculo
    {
        public int id;
        public DateOnly data;
        public int km;
        public int litros;

        public StatusVeiculo(int id, DateOnly data, int km, int litros)
        {
            this.id = id;
            this.data = data;
            this.km = km;
            this.litros = litros;
        }
    }
}