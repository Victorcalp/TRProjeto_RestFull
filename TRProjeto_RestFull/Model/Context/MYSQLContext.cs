using Microsoft.EntityFrameworkCore;

namespace TRProjeto_RestFull.Model.Context
{
    public class MYSQLContext : DbContext
    {
        public MYSQLContext() { }
        public MYSQLContext(DbContextOptions<MYSQLContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
