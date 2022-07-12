using RestApiModelDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModelDDD.Domain.Entitys;

namespace RestApiModelDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
