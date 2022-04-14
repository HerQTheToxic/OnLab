namespace Mozi.Client.Services.FilmService
{
    public interface IFilmService
    {
        List<Film> Filmek { get; set; }
        List<Terem> Termek { get; set; }
        List<Szinesz> Szineszek { get; set; }
        Task GetFilmek();
        Task<Film> GetSingleFilm(int id);
        Task CreateFilm(Film film);
        Task DeleteFilm(int id);
        Task UpdateFilm(Film film);
        Task GetFilmTermek(int id);
        Task GetFilmSzineszek(int id);
    }
}
