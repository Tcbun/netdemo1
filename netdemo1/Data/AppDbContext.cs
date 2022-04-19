using Microsoft.EntityFrameworkCore;
using netdemo1.Model;

namespace netdemo1.Data
{
    /// <summary>
    /// 第五步：创建DbContext
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<OneModel> OneModels { get; set; }

        //PS:如果表没有主键，一定要声明，否则会报错
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OneModel>().HasNoKey();
        }
    }
}
