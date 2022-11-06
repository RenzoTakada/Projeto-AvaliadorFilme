using AvaliadorDeFilmes.Domain.Shared.Enums;
using System.Text.Json.Serialization;

namespace AvaliadorDeFilmes.Domain.Models.Cadastrar_Filmes
{
    public struct RequestCadastroFilmes
    {
        public string nomeFilme { get; set; }
        [JsonIgnore]
        public EnumAvaliacaoFilme notaDoFilme { get; set; }

    }
}
