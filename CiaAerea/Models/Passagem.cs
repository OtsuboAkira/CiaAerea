
namespace CiaAerea.Models
{
    public class Passagem : Voo
    {
        public double ValorPassagem { get; set; }
        public int Reserve { get; set; }

        public Passagem(int numeroVoo, string origem, string destino, DateTime horarioPartida, int numeroTotalAssentos, double valorPassagem, int reserve) : base(numeroVoo, origem, destino, horarioPartida, numeroTotalAssentos)
        {
            this.ValorPassagem = valorPassagem;
            this.Reserve = reserve;
        }        
    }
}
