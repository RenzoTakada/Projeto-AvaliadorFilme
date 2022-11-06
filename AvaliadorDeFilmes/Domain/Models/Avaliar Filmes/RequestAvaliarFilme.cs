using AvaliadorDeFilmes.Domain.Shared.Enums;

namespace AvaliadorDeFilmes.Domain.Models.Avaliar_Filmes
{
    public struct RequestAvaliarFilme
    {
        public string nomeDoFilme { get; set; }
        public EnumAvaliacaoFilme notaDoFilme { get; set; }
    }
}
