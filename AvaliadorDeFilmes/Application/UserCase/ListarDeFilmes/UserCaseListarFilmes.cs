using AvaliadorDeFilmes.Adapter.SQLAdapter.Repository;
using AvaliadorDeFilmes.Domain.Models.Listar_Filmes;
using AvaliadorDeFilmes.Domain.Shared.Base;

namespace AvaliadorDeFilmes.Application.UserCase.Listar_De_Filmes
{
    public class UserCaseListarFilmes : BaseUserCase, IuserCaseListarFilmes
    {
        public UserCaseListarFilmes(Irepository repositorySQL) : base(repositorySQL)
        {
        }

        public async ValueTask<ResponseListaDeFilmes> USCListarFilmes()
        {
            return await repositorySQL.ListaFilmeSQL();

        }
    }
}
