using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    //databasedeki tüm işlemlerimziden sorumlu calssımız
    public class BtkAkademiDbContext : DbContext
    {
        //bu sayede ikide bir context aç context kapat ile uğraşmayacağız
        public BtkAkademiDbContext(DbContextOptions<BtkAkademiDbContext> options) : base(options) 
        {
        
        }

        //oluşturulacak tablonun adı
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
