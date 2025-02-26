
namespace CiaAerea.Models
{
    public class Passagem : Voo
    {
        public double ValorPassagem { get; set; }

        public Passagem(int numeroVoo, string origem, string destino, DateTime horarioPartida, int numeroTotalAssentos) : base(numeroVoo, origem, destino, horarioPartida, numeroTotalAssentos)
        {
            this.ValorPassagem = valorPassagem;
        }        
    }
}
