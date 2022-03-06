namespace Mozi.Client.Services.FilmService
{
    public interface IFilmService
    {
        List<Film> Filmek { get; set; }
        List<Szinesz> Szineszek { get; set; }
        List<Terem> Termek { get; set; }
        Task GetSzineszek();
        Task GetFilmek();
        Task GetTermek(); //Nem biztos, hogy fogom használni
        Task<Terem> GetSingleTerem(int id);
        Task<Film> GetSingleFilm(int id);
        Task<Szinesz> GetSingleSzinesz(int id);
    }
}
