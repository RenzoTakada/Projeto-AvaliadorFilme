using AvaliadorDeFilmes.Domain.Models.Avaliar_Filmes;
using AvaliadorDeFilmes.Domain.Models.Cadastrar_Filmes;
using AvaliadorDeFilmes.Domain.Models.Listar_Filmes;

namespace AvaliadorDeFilmes.Adapter.SQLAdapter.Repository
{
    public interface Irepository
    {
        public ValueTask<string> CadastraFilmeSQL(RequestCadastroFilmes request);
        public ValueTask<ResponseListaDeFilmes> ListaFilmeSQL();
        public ValueTask<string> AvaliarFilmeSQL(RequestAvaliarFilme request);
    }
}
