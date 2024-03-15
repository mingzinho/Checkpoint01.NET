namespace Checkpoint01.Models
{
    public class Autor
    {
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }

        public Autor(string nome, string nacionalidade)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
        }
    }
}
