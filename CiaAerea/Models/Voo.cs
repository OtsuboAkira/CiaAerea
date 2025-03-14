namespace CiaAerea.Models
{
    public class Voo
    {
        public int NumeroVoo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime HorarioPartida { get; set; }
        public int NumeroTotalAssentos { get; set; }

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
