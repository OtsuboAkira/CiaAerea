namespace CiaAerea.Models
{
    private class Passageiros
    {
        public int idPassageiro { get; set; }
        public string primeiroNome { get; set; }
        public string ultimoSobrenome { get; set; }
        public int idade {  get; set; }
        public int documento { get; set; }

        private Passageiro (int idPassageiro, string primeiroNome, string ultimoSobrenome, int idade, int documento)
        {
            this.idPassageiro = idPassageiro;
            this.primeiroNome = primeiroNome;
            this.ultimoSobrenome = ultimoSobrenome;
            this.idade = idade;
            this.documento = documento;
        }

    }
}
