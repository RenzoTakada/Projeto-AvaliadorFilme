using AvaliadorDeFilmes.Domain.Models.Listar_Filmes;

namespace AvaliadorDeFilmes.Application.UserCase.Listar_De_Filmes
{
    public interface IuserCaseListarFilmes
    {
        public ValueTask<ResponseListaDeFilmes> USCListarFilmes();
    }
}
