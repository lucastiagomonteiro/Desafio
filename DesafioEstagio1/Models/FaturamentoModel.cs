namespace DesafioEstagio1.Models
{
    public class FaturamentoModel
    {
        public double valor { get; set; }
        public int dia { get; set; }
        public double MenorFatura { get; set; }
        public double MaiorFatura { get; set; }
        public int DiasAcimaDaMedia { get; set; }
        public double MediaMensal { get; set; }
        public string resposta { get; set; } = string.Empty;

    }
}
