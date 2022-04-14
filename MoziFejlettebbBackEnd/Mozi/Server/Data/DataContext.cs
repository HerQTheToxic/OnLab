namespace Mozi.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Szinesz elsoSzinesz = new Szinesz { Id = 1, Nev = "Szinesz1", Ertekeles = 9.0, Kor = 24, FilmId = 1 };
            Szinesz masodikSzinesz = new Szinesz { Id = 2, Nev = "Szinesz2", Ertekeles = 4.0, Kor = 54, FilmId = 1 };
            Szinesz harmadikSzinesz = new Szinesz { Id = 3, Nev = "Szinesz3", Ertekeles = 1.0, Kor = 28, FilmId = 2 };


            Szek s1 = new Szek { Id = 1, Szam = 1, TeremId = 1, Foglalt = false };
            Szek s2 = new Szek { Id = 2, Szam = 2, TeremId = 1, Foglalt = false };
            Szek s3 = new Szek { Id = 3, Szam = 3, TeremId = 1, Foglalt = false };
            Szek s4 = new Szek { Id = 4, Szam = 4, TeremId = 1, Foglalt = true };
            Szek s5 = new Szek { Id = 5, Szam = 5, TeremId = 1, Foglalt = true };
            Szek s6 = new Szek { Id = 6, Szam = 6, TeremId = 1, Foglalt = true };
            Szek s7 = new Szek { Id = 7, Szam = 7, TeremId = 1, Foglalt = false };
            Szek s8 = new Szek { Id = 9, Szam = 9, TeremId = 1, Foglalt = false };
            Szek s9 = new Szek { Id = 10, Szam = 10, TeremId = 1, Foglalt = false };
            Szek s10 = new Szek { Id = 11, Szam = 11, TeremId = 1, Foglalt = false };
            Szek s11 = new Szek { Id = 12, Szam = 12, TeremId = 1, Foglalt = false };
            Szek s12 = new Szek { Id = 13, Szam = 13, TeremId = 1, Foglalt = false };
            Szek s13 = new Szek { Id = 14, Szam = 14, TeremId = 1, Foglalt = true };
            Szek s14 = new Szek { Id = 15, Szam = 15, TeremId = 1, Foglalt = true };
            Szek s15 = new Szek { Id = 16, Szam = 16, TeremId = 1, Foglalt = true };
            Szek s16 = new Szek { Id = 17, Szam = 17, TeremId = 1, Foglalt = false };
            Szek s17 = new Szek { Id = 18, Szam = 18, TeremId = 1, Foglalt = false };
            Szek s18 = new Szek { Id = 19, Szam = 19, TeremId = 1, Foglalt = false };
            Szek s19 = new Szek { Id = 20, Szam = 20, TeremId = 1, Foglalt = false };
            Szek s20 = new Szek { Id = 8, Szam = 8, TeremId = 1, Foglalt = false };

            Szek s21 = new Szek { Id = 21, Szam = 1, TeremId = 2, Foglalt = false };
            Szek s22 = new Szek { Id = 22, Szam = 2, TeremId = 2, Foglalt = false };
            Szek s23 = new Szek { Id = 23, Szam = 3, TeremId = 2, Foglalt = false };
            Szek s24 = new Szek { Id = 24, Szam = 4, TeremId = 2, Foglalt = true };
            Szek s25 = new Szek { Id = 25, Szam = 5, TeremId = 2, Foglalt = true };
            Szek s26 = new Szek { Id = 26, Szam = 6, TeremId = 2, Foglalt = true };
            Szek s27 = new Szek { Id = 27, Szam = 7, TeremId = 2, Foglalt = false };
            Szek s28 = new Szek { Id = 28, Szam = 8, TeremId = 2, Foglalt = false };
            Szek s29 = new Szek { Id = 29, Szam = 9, TeremId = 2, Foglalt = true };
            Szek s30 = new Szek { Id = 30, Szam = 10, TeremId = 2, Foglalt = false };
            Szek s31 = new Szek { Id = 31, Szam = 11, TeremId = 2, Foglalt = false };
            Szek s32 = new Szek { Id = 32, Szam = 12, TeremId = 2, Foglalt = false };
            Szek s33 = new Szek { Id = 33, Szam = 13, TeremId = 2, Foglalt = false };
            Szek s34 = new Szek { Id = 34, Szam = 14, TeremId = 2, Foglalt = true };
            Szek s35 = new Szek { Id = 35, Szam = 15, TeremId = 2, Foglalt = true };
            Szek s36 = new Szek { Id = 36, Szam = 16, TeremId = 2, Foglalt = true };
            Szek s37 = new Szek { Id = 37, Szam = 17, TeremId = 2, Foglalt = false };
            Szek s38 = new Szek { Id = 38, Szam = 18, TeremId = 2, Foglalt = false };
            Szek s39 = new Szek { Id = 39, Szam = 19, TeremId = 2, Foglalt = true };
            Szek s40 = new Szek { Id = 40, Szam = 20, TeremId = 2, Foglalt = true };

            Szek s41 = new Szek { Id = 41, Szam = 1, TeremId = 3, Foglalt = false };
            Szek s42 = new Szek { Id = 42, Szam = 2, TeremId = 3, Foglalt = false };
            Szek s43 = new Szek { Id = 43, Szam = 3, TeremId = 3, Foglalt = false };
            Szek s44 = new Szek { Id = 44, Szam = 4, TeremId = 3, Foglalt = true };
            Szek s45 = new Szek { Id = 45, Szam = 5, TeremId = 3, Foglalt = true };
            Szek s46 = new Szek { Id = 46, Szam = 6, TeremId = 3, Foglalt = true };
            Szek s47 = new Szek { Id = 47, Szam = 7, TeremId = 3, Foglalt = false };
            Szek s48 = new Szek { Id = 48, Szam = 8, TeremId = 3, Foglalt = false };
            Szek s49 = new Szek { Id = 49, Szam = 9, TeremId = 3, Foglalt = true };
            Szek s50 = new Szek { Id = 50, Szam = 10, TeremId = 3, Foglalt = false };
            Szek s51 = new Szek { Id = 51, Szam = 11, TeremId = 3, Foglalt = false };
            Szek s52 = new Szek { Id = 52, Szam = 12, TeremId = 3, Foglalt = false };
            Szek s53 = new Szek { Id = 53, Szam = 13, TeremId = 3, Foglalt = false };
            Szek s54 = new Szek { Id = 54, Szam = 14, TeremId = 3, Foglalt = true };
            Szek s55 = new Szek { Id = 55, Szam = 15, TeremId = 3, Foglalt = true };
            Szek s56 = new Szek { Id = 56, Szam = 16, TeremId = 3, Foglalt = true };
            Szek s57 = new Szek { Id = 57, Szam = 17, TeremId = 3, Foglalt = false };
            Szek s58 = new Szek { Id = 58, Szam = 18, TeremId = 3, Foglalt = false };
            Szek s59 = new Szek { Id = 59, Szam = 19, TeremId = 3, Foglalt = true };
            Szek s60 = new Szek { Id = 60, Szam = 20, TeremId = 3, Foglalt = true } ;

            Terem elsoTerem = new Terem
            {
                Id = 1,
                TeremNev = "Elso",
                FilmId = 1,


            };

            Terem masodikTerem = new Terem
            {
                Id = 2,
                TeremNev = "Masodik",
                FilmId = 2,

            };
            Terem harmadikTerem = new Terem
            {
                Id = 3,
                TeremNev = "Harmadik",
                FilmId = 2,

            };

            Film elsoFilm = new Film
            {
                Id = 1,
                Ertekeles = 6.0,
                Gyarto = "Lászlo és a fia",
                Nev = "Elso film"
                
               

            };
            Film masodikFilm = new Film
            {
                Id = 2,
                Ertekeles = 8.0,
                Gyarto = "Profi gyártó",
                Nev = "Masodik film"
                

            };



            modelBuilder.Entity<Film>().HasData(
                elsoFilm, masodikFilm
            );

            modelBuilder.Entity<Szek>().HasData(
                s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12, s13,s14,s15,s16,s17,s18,s19,s20,
                s21,s22,s23,s24,s25,s26,s27,s28,s29,s30,s31,s32,s33,s34,s35,s36,s37,s38,s39,s40,
                s41,s42,s43,s44,s45,s46,s47,s48,s49,s50,s51,s52,s53,s54,s55,s56,s57,s58,s59,s60
            );

            modelBuilder.Entity<Terem>().HasData(
                elsoTerem,masodikTerem,harmadikTerem
            ); ;

            modelBuilder.Entity<Szinesz>().HasData(
                elsoSzinesz, masodikSzinesz, harmadikSzinesz
            );

        }

        public DbSet<Film> Filmek { get; set; }
        public DbSet<Szinesz> Szineszek{ get; set; }
        public DbSet<Szek> Szekek { get; set; }
        public DbSet<Terem> Termek { get; set; }
    }
}
