namespace Mozi.Client.Services.FilmService
{
    public interface IFilmService
    {
        List<Film> Filmek { get; set; }
        Task GetFilmek();
        Task<Film> GetSingleFilm(int id);
    }
}
