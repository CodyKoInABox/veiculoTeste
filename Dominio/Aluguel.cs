namespace Dominio
{
    public class Aluguel
    {
        public int id;
        public string veiculo_chassi;
        public int cliente_id;
        public int retirada_status_id;
        public int devolucao_status_id;
        public int dias;
        public DateOnly data_prevista;
        public float valor_previsto;
        public float valor_real;
        public int atraso;

        public Aluguel(int id, int cliente_id, string veiculo_chassi, int retirada_status_id, int devolucao_status_id, int dias, DateOnly data_prevista, float valor_previsto, float valor_real, int atraso)
        {
            this.id = id;
            this.cliente_id = cliente_id;
            this.veiculo_chassi = veiculo_chassi;
            this.retirada_status_id = retirada_status_id;
            this.devolucao_status_id = devolucao_status_id;
            this.dias = dias;
            this.data_prevista = data_prevista;
            this.valor_previsto = valor_previsto;
            this.valor_real = valor_real;
            this.atraso = atraso;
        }
    }
}