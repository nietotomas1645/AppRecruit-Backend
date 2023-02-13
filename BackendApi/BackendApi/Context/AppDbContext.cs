using BackendApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Context
{
    public class AppDbContext: DbContext
    {
        

         public AppDbContext()
               {
               }
        public AppDbContext(DbContextOptions<AppDbContext> options ): base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public virtual DbSet<FileData> FileDatas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Job>().ToTable("jobs");
            modelBuilder.Entity<Technology>().ToTable("Technologies");
            modelBuilder.Entity<FileData>().ToTable("FileDatas");
        }


    }
}
