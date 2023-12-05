namespace Dominio
{
    public class Cliente
    {
        public int id;
        public string nome;
        public string cpf;
        public string telefone;
        public string cnh;

        public Cliente(int id, string nome, string cpf, string telefone, string cnh)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.cnh = cnh;
        }
    }
}