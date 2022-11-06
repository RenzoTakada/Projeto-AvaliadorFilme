using AvaliadorDeFilmes.Adapter.SQLAdapter.Repository;
using AvaliadorDeFilmes.Domain.Models.Avaliar_Filmes;
using AvaliadorDeFilmes.Domain.Models.Listar_Filmes;
using AvaliadorDeFilmes.Domain.Shared.Base;

namespace AvaliadorDeFilmes.Application.UserCase.AvaliarFilme
{
    public class UserCaseAvaliarFilmes : BaseUserCase, IuserCaseAvaliarFilmes
    {
        public UserCaseAvaliarFilmes(Irepository repositorySQL) : base(repositorySQL)
        {
        }

        public async ValueTask<ResponseListaDeFilmes> USCAvaliarFilme(RequestAvaliarFilme request)
        {
            var ret = await repositorySQL.AvaliarFilmeSQL(request);
            if (ret != "")
            {
                throw new Exception("Erro ao avaliar Filme");
            }
            return await repositorySQL.ListaFilmeSQL();
        }
    }
}
