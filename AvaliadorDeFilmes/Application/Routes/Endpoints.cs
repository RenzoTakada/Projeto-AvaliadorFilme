using AvaliadorDeFilmes.Application.UserCase.AvaliarFilme;
using AvaliadorDeFilmes.Application.UserCase.CadastroDeFilmes;
using AvaliadorDeFilmes.Application.UserCase.EscolherFilmes;
using AvaliadorDeFilmes.Application.UserCase.Listar_De_Filmes;
using AvaliadorDeFilmes.Domain.Models.Avaliar_Filmes;
using AvaliadorDeFilmes.Domain.Models.Cadastrar_Filmes;

namespace AvaliadorDeFilmes.Application.Routes
{
    public static class Endpoints
    {
        public static WebApplication AddEndpoints(this WebApplication app)
        {
            app.MapPost("Cadastrar Filme", EndpointCadastrarFilme);
            app.MapGet("Listar Filmes", EndpointListarFilme);
            app.MapGet("Escolher Filme", EndpointEscolherFilme);
            app.MapPut("Avaliar Filme", EndpointAvaliarFilme);

            return app;
        }
        public static async ValueTask<IResult> EndpointCadastrarFilme(IuserCaseCadastraFilmes cadastraFilmes, RequestCadastroFilmes request)
        {
            return Results.Ok(cadastraFilmes.USCCadastroFilme(request).Result);
        }
        public static async ValueTask<IResult> EndpointListarFilme(IuserCaseListarFilmes ListarFilmes)
        {
            return Results.Ok(ListarFilmes.USCListarFilmes().Result);
        }
        public static async ValueTask<IResult> EndpointEscolherFilme(IuserCaseEscolherFilmes EscolherFilmes)
        {
            return Results.Ok(EscolherFilmes.USCEscolheFilme().Result);
        }
        public static async ValueTask<IResult> EndpointAvaliarFilme(IuserCaseAvaliarFilmes AvaliarFilmes, RequestAvaliarFilme request)
        {
            return Results.Ok(AvaliarFilmes.USCAvaliarFilme(request).Result);
        }
    }
}
