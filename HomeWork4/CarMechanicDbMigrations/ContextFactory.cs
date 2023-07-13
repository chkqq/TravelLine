using DatabaseProvider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CarMechanicDbMigrations
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            string connectionString =
                "Data Source=WIN-26JB6NF31I0\\SQLEXPRESS01;Initial Catalog=CarMechanicDb;TrustServerCertificate=True;Pooling=true;Integrated Security=SSPI";
            var optionBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionBuilder.UseSqlServer(connectionString, assembly => assembly.MigrationsAssembly("CarMechanicDbMigrations"));
            return new ApplicationContext(optionBuilder.Options);
        }
    } 
}
//WIN-26JB6NF31I0\\SQLEXPRESS01 (localdb)\\MSSQLLocalDB