using AvaliadorDeFilmes.Adapter.SQLAdapter.Repository;

namespace AvaliadorDeFilmes.Domain.Shared.Base
{
    public abstract class BaseUserCase
    {
        protected Irepository repositorySQL;
        public BaseUserCase(Irepository repositorySQL)
        {
            this.repositorySQL = repositorySQL;
        }
    }
}
