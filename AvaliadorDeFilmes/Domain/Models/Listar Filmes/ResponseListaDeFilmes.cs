using AvaliadorDeFilmes.Domain.Shared.Enums;

namespace AvaliadorDeFilmes.Domain.Models.Listar_Filmes
{
    public record ResponseListaDeFilmes
    {
        public IList<ObjetoFilme> ListaDeFilmes { get; set; }
        public ResponseListaDeFilmes()
        {
            ListaDeFilmes = new List<ObjetoFilme>();

        }

    }
    public record ObjetoFilme
    {
        public string NomeDoFilme { get; set; }
        public EnumAvaliacaoFilme NotaDoFilme { get; set; }
    }
}
