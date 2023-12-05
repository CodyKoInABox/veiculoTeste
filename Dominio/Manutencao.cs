namespace Dominio
{
    public class Manutencao
    {
        public int id;
        public int veiculo_id;
        public string motivo;
        public string descricao;
        public int km;
        public DateOnly data;

        public Manutencao(int id, int veiculo_id, string motivo, string descricao, int km, DateOnly data)
        {
            this.id = id;
            this.veiculo_id = veiculo_id;
            this.motivo = motivo;
            this.descricao = descricao;
            this.km = km;
            this.data = data;
        }
    }
}