using System.Net.Http.Json;

namespace Mozi.Client.Services.SzineszService
{
    public class SzineszService : ISzineszService
    {
        private readonly HttpClient _http;

        public SzineszService(HttpClient http)
        {
            _http = http;
        }

        public List<Szinesz> Szineszek { get; set; } = new List<Szinesz>();
        

        public async Task GetSzineszek()
        {
            var result = await _http.GetFromJsonAsync<List<Szinesz>>("api/szinesz");
            if (result != null)
                Szineszek = result;
        }

        public async Task<Szinesz> GetSingleSzinesz(int id)
        {
            var result = await _http.GetFromJsonAsync<Szinesz>($"api/szinesz/{id}");
            if (result != null)
                return result;
            throw new Exception("Nem található a szinesz");
        }

        public async Task CreateSzinesz(Szinesz szinesz)
        {
            var result = await _http.PostAsJsonAsync("api/szinesz", szinesz);
            var response = await result.Content.ReadFromJsonAsync<List<Szinesz>>();
            Szineszek = response;
        }

        public async Task DeleteSzinesz(int id)
        {
            var result = await _http.DeleteAsync($"api/szinesz/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Szinesz>>();
            Szineszek = response;
        }

        public async Task UpdateSzinesz(Szinesz szinesz)
        {
            var result = await _http.PutAsJsonAsync($"api/szinesz/{szinesz.Id}", szinesz);
            var response = await result.Content.ReadFromJsonAsync<List<Szinesz>>();
            Szineszek = response;
        }
    }
}
