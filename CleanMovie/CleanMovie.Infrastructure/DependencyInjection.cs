using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanMovie.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMovieDbContext(
            this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MovieDbContext>(opt =>
                opt.UseSqlServer(
                    connectionString,
                    b => b.MigrationsAssembly(typeof(MovieDbContext).Assembly.FullName))
            );

            return services;
        }
    }
}
