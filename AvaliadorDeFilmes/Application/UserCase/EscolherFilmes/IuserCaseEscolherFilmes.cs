using AvaliadorDeFilmes.Domain.Models.Escolher_Filmes;

namespace AvaliadorDeFilmes.Application.UserCase.EscolherFilmes
{
    public interface IuserCaseEscolherFilmes
    {
        public ValueTask<ResponseFilmeEscolhido> USCEscolheFilme();
    }
}
