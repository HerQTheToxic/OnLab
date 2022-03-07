using System.Net.Http.Json;

namespace Mozi.Client.Services.FilmService
{
    public class FilmService : IFilmService
    {
        private readonly HttpClient _http;

        public FilmService(HttpClient http)
        {
            _http = http;
        }
        public List<Film> Filmek { get ; set ;} =new List<Film> ();

        public async Task GetFilmek()
        {
            var result = await _http.GetFromJsonAsync<List<Film>>("api/film");
            if(result != null)
                Filmek = result;
        }

        public async Task<Film> GetSingleFilm(int id)
        {
            var result = await _http.GetFromJsonAsync<Film>($"api/film/{id}");
            if (result != null)
                return result;
            throw new Exception("Nem található a film");
        }

    }
}
