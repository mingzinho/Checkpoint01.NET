namespace Checkpoint01.Models
{
    public class Emprestimo
    {
        public Livro Livro { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataEmprestimo { get; set; }
        protected DateTime DataDevolucao { get; set; }

        public Emprestimo(Livro livro, Cliente cliente, DateTime dataEmprestimo)
        {
            Livro = livro;
            Cliente = cliente;
            DataEmprestimo = dataEmprestimo;
        }

        internal decimal CalcularMulta()
        {
            const decimal valorMultaDiaria = 0.50m;
            TimeSpan atraso = DateTime.Now - DataDevolucao;
            if (atraso.TotalDays > 0)
            {
                return Convert.ToDecimal(atraso.TotalDays) * valorMultaDiaria;
            }
            return 0;
        }
    }
}
