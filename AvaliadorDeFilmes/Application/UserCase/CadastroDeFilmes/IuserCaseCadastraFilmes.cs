using AvaliadorDeFilmes.Domain.Models.Cadastrar_Filmes;

namespace AvaliadorDeFilmes.Application.UserCase.CadastroDeFilmes
{
    public interface IuserCaseCadastraFilmes
    {
        public ValueTask<ResponseCadastroFilme> USCCadastroFilme(RequestCadastroFilmes request);
    }
}
