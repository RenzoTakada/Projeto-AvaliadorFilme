using AvaliadorDeFilmes.Adapter.SQLAdapter.Repository;
using AvaliadorDeFilmes.Domain.Models.Escolher_Filmes;
using AvaliadorDeFilmes.Domain.Shared.Base;

namespace AvaliadorDeFilmes.Application.UserCase.EscolherFilmes
{
    public class UserCaseEscolherFilmes : BaseUserCase, IuserCaseEscolherFilmes
    {

        public UserCaseEscolherFilmes(Irepository repositorySQL) : base(repositorySQL)
        {

        }

        public async ValueTask<ResponseFilmeEscolhido> USCEscolheFilme()
        {
            var retSql = await repositorySQL.ListaFilmeSQL();
            var tamanhoLista = retSql.ListaDeFilmes.Count();
            Random numeroAleatorio = new Random();
            return new ResponseFilmeEscolhido()
            {
                Filme = retSql.ListaDeFilmes[numeroAleatorio.Next(0, tamanhoLista)].NomeDoFilme

            };
        }
    }
}
