using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;

namespace Zhang.Blog.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    public class ZhangBlogMigrationsDbContext:AbpDbContext<ZhangBlogMigrationsDbContext>
    {
        public ZhangBlogMigrationsDbContext(DbContextOptions<ZhangBlogMigrationsDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure();
        }
    }
}
