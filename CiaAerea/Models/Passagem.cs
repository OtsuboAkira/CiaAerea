
namespace CiaAerea.Models
{
    public class Passagem
    {
        public int Id { get; set; }
        public double ValorPassagem { get; set; }
        public int Reserve { get; set; }
        public Voo Voo { get; set; }

        public Passagem(int idPassagem, double valorPassagem, int reserve, Voo voo)
        {
            this.Id = idPassagem;
            this.ValorPassagem = valorPassagem;
            this.Reserve = reserve;
            this.Voo = voo;
        }       
        
        public Passagem() { }
    }
}
