namespace CasaDoCodigo
{
    public partial class Startup
    {
        class DataService : IDataService
        {
            private readonly ApplicationContext contexto;

            public DataService(ApplicationContext contexto)
            {
                this.contexto = contexto;
            }
            public void InicializarDB()
            {
                contexto.Database.EnsureCreated();
            }
        }
    }
}
