using AvaliadorDeFilmes.Adapter.SQLAdapter.Repository;
using AvaliadorDeFilmes.Domain.Models.Cadastrar_Filmes;
using AvaliadorDeFilmes.Domain.Shared.Base;

namespace AvaliadorDeFilmes.Application.UserCase.CadastroDeFilmes
{
    public class UserCaseCadastroDeFilmes : BaseUserCase, IuserCaseCadastraFilmes
    {
        public UserCaseCadastroDeFilmes(Irepository repositorySQL) : base(repositorySQL)
        {
        }

        public async ValueTask<ResponseCadastroFilme> USCCadastroFilme(RequestCadastroFilmes request)
        {
            var ret = await repositorySQL.CadastraFilmeSQL(request);
            return new ResponseCadastroFilme() { mensagem = ret };
        }
    }
}
