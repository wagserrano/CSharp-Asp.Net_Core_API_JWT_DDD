using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<APIContext>
    {
        public APIContext CreateDbContext(string[] args)
        {
            // Using to create Migrations
            var connectionString = "Server = localhost; Port = 3306; Database = dbAPI; Uid = WagDev; Pwd = W@gD3v20200301";
            //var connectionString = "Server=.\\NZAKL;Database=dbAPI;User Id=WagDev;Password=W@gD3v20200301";

            var optionsBuilder = new DbContextOptionsBuilder<APIContext>();

            optionsBuilder.UseMySql(connectionString);
            //optionsBuilder.UseSqlServer (connectionString);

            return new APIContext(optionsBuilder.Options);
        }
    }
}
