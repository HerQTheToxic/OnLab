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
        public List<Terem> Termek { get ; set; } = new List<Terem>();
        public List<Szinesz> Szineszek { get ; set; } = new List<Szinesz>();

        public async Task CreateFilm(Film film)
        {
            var result = await _http.PostAsJsonAsync("api/film", film);
            var response = await result.Content.ReadFromJsonAsync<List<Film>>();
            Filmek = response;
        }

        public async Task DeleteFilm(int id)
        {
            var result = await _http.DeleteAsync($"api/film/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Film>>();
            Filmek = response;
        }

        public async Task GetFilmek()
        {
            var result = await _http.GetFromJsonAsync<List<Film>>("api/film");
            if(result != null)
                Filmek = result;
        }

        public async Task GetFilmSzineszek(int id)
        {
            var result = await _http.GetFromJsonAsync<List<Szinesz>>($"api/film/{id}/szineszek");
            if (result != null)
                Szineszek = result;
        }

        public async Task GetFilmTermek(int id)
        {
            var result = await _http.GetFromJsonAsync<List<Terem>>($"api/film/{id}/termek");
            if (result != null)
                Termek = result;
        }

        public async Task<Film> GetSingleFilm(int id)
        {
            var result = await _http.GetFromJsonAsync<Film>($"api/film/{id}");
            if (result != null)
                return result;
            throw new Exception("Nem található a film");
        }

        public async Task UpdateFilm(Film film)
        {
            var result = await _http.PutAsJsonAsync($"api/film/{film.Id}", film);
            var response = await result.Content.ReadFromJsonAsync<List<Film>>();
            Filmek = response;
        }
    }
}
