namespace Mozi.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasData(
                new Film { Id = 1, Ertekeles = 6.0, Gyarto = "ASD",  TeremId = 1, Nev = "elso nevu" },
                new Film { Id = 2, Ertekeles = 8.0, Gyarto = "ASDASD",  TeremId = 2, Nev = "masodik nevu" }
            );

            modelBuilder.Entity<Szek>().HasData(
                new Szek { Id = 1, Szam = 1, TeremId = 1, Foglalt = false },
                new Szek { Id = 2, Szam = 2, TeremId = 1, Foglalt = false },
                new Szek { Id = 3, Szam = 3, TeremId = 1, Foglalt = false },
                new Szek { Id = 4, Szam = 4, TeremId = 1, Foglalt = true },
                new Szek { Id = 5, Szam = 5, TeremId = 1, Foglalt = true },
                new Szek { Id = 6, Szam = 6, TeremId = 1, Foglalt = true },
                new Szek { Id = 7, Szam = 7, TeremId = 1, Foglalt = false },

                new Szek { Id = 11, Szam = 1, TeremId = 2, Foglalt = false },
                new Szek { Id = 12, Szam = 2, TeremId = 2, Foglalt = true },
                new Szek { Id = 13, Szam = 3, TeremId = 2, Foglalt = false },
                new Szek { Id = 14, Szam = 4, TeremId = 2, Foglalt = true },
                new Szek { Id = 15, Szam = 5, TeremId = 2, Foglalt = false },
                new Szek { Id = 16, Szam = 6, TeremId = 2, Foglalt = true },
                new Szek { Id = 17, Szam = 7, TeremId = 2, Foglalt = false }
            );

            modelBuilder.Entity<Terem>().HasData(
                new Terem
                {
                    Id = 1,
                    TeremNev = "elso",
                    FilmId = 1,

                },

                new Terem
                {
                    Id = 2,
                    TeremNev = "masodik",
                    FilmId = 2
                }
            ); ;

            modelBuilder.Entity<Szinesz>().HasData(
                new Szinesz { Id = 1, Nev = "Szinesz1", Ertekeles = 9.0, Kor = 24, FilmId=1 },
                new Szinesz { Id = 2, Nev = "Szinesz2", Ertekeles = 4.0, Kor = 54, FilmId = 1 },
                new Szinesz { Id = 3, Nev = "Szinesz3", Ertekeles = 1.0, Kor = 28, FilmId=2 }
            );

        }

        public DbSet<Film> Filmek { get; set; }
        public DbSet<Szinesz> Szineszek{ get; set; }
        public DbSet<Szek> Szekek { get; set; }
        public DbSet<Terem> Termek { get; set; }
    }
}
