namespace Aluguel.Models
{
    public class EmprestimoModels
    {
        public int Id { get; set; }

        public string Recebedor { get; set; }

        public string Fornecedor { get; set; }

        public int FitaAlugada { get; set; }

        public DateTime DataAluguel { get; set; } = DateTime.Now;
    }
}
