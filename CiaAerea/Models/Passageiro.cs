namespace CiaAerea.Models
{
    public class Passageiro
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoSobrenome { get; set; }
        public int Idade { get; set; }
        public int Documento { get; set; }

        public Passageiro(int idPassageiro, string primeiroNome, string ultimoSobrenome, int idade, int documento)
        {
            this.Id = idPassageiro;
            this.PrimeiroNome = primeiroNome;
            this.UltimoSobrenome = ultimoSobrenome;
            this.Idade = idade;
            this.Documento = documento;
        }

        public Passageiro() { }
    }
}
