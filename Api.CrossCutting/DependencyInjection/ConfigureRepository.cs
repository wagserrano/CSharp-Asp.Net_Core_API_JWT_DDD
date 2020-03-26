using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            serviceCollection.AddDbContext<APIContext>(
                options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=WagDev;Pwd=W@gD3v20200301")
            );

            //serviceCollection.AddDbContext<APIContext>(
            //    options => options.UseSqlServer("Server=.\\SQLEXPRESS2017;Database=dbAPI;User Id=sa;Password=mudar@123")
            //);
        }
    }
}
