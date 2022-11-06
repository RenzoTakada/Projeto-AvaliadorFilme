namespace AvaliadorDeFilmes.Adapter.SQLAdapter.Models
{
    public class ConnectionString
    {
        public string Servidor { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }


        public string GetConnectionString()
        {
            return $"Data Source={Servidor};Initial Catalog={Banco};Persist Security Info=false;User ID={Usuario};Password={Senha}";

        }

    }
}
