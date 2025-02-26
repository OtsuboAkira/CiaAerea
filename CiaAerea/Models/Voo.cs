namespace CiaAerea.Models
{
    public class Voo
    {
        private int NumeroVoo { get; set; }
        private string Origem { get; set; }
        private string Destino { get; set; }
        private DateTime HorarioPartida { get; set; }
        private int NumeroTotalAssentos { get; set; }

        public Voo(int numeroVoo, string origem, string destino, DateTime horarioPartida, int numeroTotalAssentos)
        {
            this.NumeroVoo = numeroVoo;
            this.Origem = origem;
            this.Destino = destino;
            this.HorarioPartida = horarioPartida;
            this.NumeroTotalAssentos = numeroTotalAssentos;
        }
    }    
}
