namespace Checkpoint01.Models
{
    public class Livro : IExemplar
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
        }

        public virtual string GetDetalhes()
        {
            return $"Título: {Titulo}, Autor: {Autor}, Ano de Publicação: {AnoPublicacao}";
        }

        public override string ToString()
        {
            return $"{Titulo} - {Autor}";
        }
    }
}
