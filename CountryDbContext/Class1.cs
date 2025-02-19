using Microsoft.EntityFrameworkCore;
using 

namespace CountryDbContext
{
    public class CountryDbContext:DbContext
    {
        public CountryDbContext()
        {
            if (Database.EnsureCreated())
            {
                SaveChanges();
            }
        }

        public DbSet<Country> AcademyGroups { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // метод UseLazyLoadingProxies() делает доступной ленивую загрузку.

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=KRIS;Database=AcademyGroupDB;Integrated Security=SSPI;TrustServerCertificate=true");


            //optionsBuilder.UseLazyLoadingProxies().UseSqlite("Data Source=AcademyGroup.db");
            //optionsBuilder.UseLazyLoadingProxies().UseMySql("server=localhost;user=root;password=;database=AcademyGroupDB;",
            //new MySqlServerVersion(new System.Version(10, 4, 27))); // SELECT VERSION(); команда получения версии в среде MySQL Workbench
        }
    }
}
