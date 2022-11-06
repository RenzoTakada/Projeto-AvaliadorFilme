using AvaliadorDeFilmes.Application.UserCase.AvaliarFilme;
using AvaliadorDeFilmes.Application.UserCase.CadastroDeFilmes;
using AvaliadorDeFilmes.Application.UserCase.EscolherFilmes;
using AvaliadorDeFilmes.Application.UserCase.Listar_De_Filmes;

namespace AvaliadorDeFilmes.Extensions
{
    public static class DomainExtensions
    {
        public static IServiceCollection AddDomainExtensions(this IServiceCollection services)
        {
            services.AddScoped<IuserCaseCadastraFilmes, UserCaseCadastroDeFilmes>();
            services.AddScoped<IuserCaseListarFilmes, UserCaseListarFilmes>();
            services.AddScoped<IuserCaseEscolherFilmes, UserCaseEscolherFilmes>();
            services.AddScoped<IuserCaseAvaliarFilmes, UserCaseAvaliarFilmes>();
            return services;
        }
    }
}
