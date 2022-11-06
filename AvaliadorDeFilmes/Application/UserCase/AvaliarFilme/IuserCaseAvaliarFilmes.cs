using AvaliadorDeFilmes.Domain.Models.Avaliar_Filmes;
using AvaliadorDeFilmes.Domain.Models.Listar_Filmes;

namespace AvaliadorDeFilmes.Application.UserCase.AvaliarFilme
{
    public interface IuserCaseAvaliarFilmes
    {
        public ValueTask<ResponseListaDeFilmes> USCAvaliarFilme(RequestAvaliarFilme request);
    }
}
