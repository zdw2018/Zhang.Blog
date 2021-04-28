using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Zhang.Blog.Domain.Blog;

namespace Zhang.Blog.EntityFrameworkCore
{
    [ConnectionStringName("SqlServer")]
    public  class ZhangBlogDbContext: AbpDbContext<ZhangBlogDbContext>
    {
        public ZhangBlogDbContext(DbContextOptions<ZhangBlogDbContext> options) : base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<PostTag> PostTags { get; set; }

        public DbSet<FriendLink> FriendLinks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configure();
        }
      // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      // {
      //     base.OnConfiguring(optionsBuilder);
      //
      //     optionsBuilder.EnableSensitiveDataLogging();
      // }
    }
}
