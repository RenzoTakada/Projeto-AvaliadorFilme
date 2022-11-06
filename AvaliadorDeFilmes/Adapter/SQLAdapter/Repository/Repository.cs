using AvaliadorDeFilmes.Adapter.SQLAdapter.Models.Connection;
using AvaliadorDeFilmes.Domain.Models.Avaliar_Filmes;
using AvaliadorDeFilmes.Domain.Models.Cadastrar_Filmes;
using AvaliadorDeFilmes.Domain.Models.Listar_Filmes;
using Dapper;


namespace AvaliadorDeFilmes.Adapter.SQLAdapter.Repository
{
    public class Repositorys : Irepository
    {
        private readonly SQLDbContext _context;


        public Repositorys(SQLDbContext context)
        {
            _context = context;

        }

        public async ValueTask<string> CadastraFilmeSQL(RequestCadastroFilmes request)
        {
            using (var connection = _context.CreateConnection())
            {
                string CadastroNaTabela = $"INSERT [fILMES] ([NomeDoFilme],[NotaDoFilme]) VALUES('{request.nomeFilme}',{0})";
                try
                {
                    await connection.QueryAsync(CadastroNaTabela);
                }
                catch (Exception ex)
                {
                    return "Erro ao realizar Cadastro";
                }
                return "Cadastro Efetuado Com Sucesso!";
            }
        }

        public async ValueTask<ResponseListaDeFilmes> ListaFilmeSQL()
        {
            using (var connection = _context.CreateConnection())
            {
                string ListaNaTabela = $"SELECT * FROM [fILMES] ";

                var ret = await connection.QueryAsync<ObjetoFilme>(ListaNaTabela);
                var retLista = new ResponseListaDeFilmes();
                foreach (var item in ret)
                {

                    retLista.ListaDeFilmes.Add(item);

                }
                return retLista;
            }
        }
        public async ValueTask<string> AvaliarFilmeSQL(RequestAvaliarFilme request)
        {
            using (var connection = _context.CreateConnection())
            {
                string AlteraNaTabela = $"UPDATE  [fILMES]  SET [NotaDoFilme] = {(int)request.notaDoFilme} WHERE [NomeDoFilme] = '{request.nomeDoFilme}' ";

                try
                {
                    var ret = await connection.QueryAsync(AlteraNaTabela);
                }
                catch (Exception ex)
                {
                    return "Erro ao realizar Avalaliação";
                }

                return "";

            }

        }
    }
}
