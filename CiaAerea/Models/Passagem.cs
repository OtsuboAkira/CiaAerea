
namespace CiaAerea.Models
{
    public class Passagem : Voo
    {
        public double valorPassagem { get; set; }

        public Passagem(int numeroVoo, string Origem, string Destino, DateTime horarioPartida, int numeroTotalAssentos) : base(numeroVoo, Origem, Destino, horarioPartida, numeroTotalAssentos)
        {
            this.valorPassagem = valorPassagem;
        }        
    }
}
