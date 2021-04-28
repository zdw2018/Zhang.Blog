using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Zhang.Blog.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    public class ZhangBlogMigrationsDbContextFactory: IDesignTimeDbContextFactory<ZhangBlogMigrationsDbContext>
    {
        public ZhangBlogMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ZhangBlogMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("SqlServer"));

            return new ZhangBlogMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
