using System.Net.Http.Json;

namespace Mozi.Client.Services.SzekService
{
    public class SzekService : ISzekService
    {
        private readonly HttpClient _http;

        public SzekService(HttpClient http)
        {
            _http = http;
        }

        public List<Szek> Szekek { get; set; } = new List<Szek>();

        public async Task CreateSzek(Szek szek)
        {
            var result = await _http.PostAsJsonAsync("api/szek", szek);
            var response = await result.Content.ReadFromJsonAsync<List<Szek>>();
            Szekek = response;
        }

        public async Task DeleteSzek(int id)
        {
            var result = await _http.DeleteAsync($"api/szek/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Szek>>();
            Szekek = response;
        }

        public async Task<Szek> GetSingleSzek(int id)
        {
            var result = await _http.GetFromJsonAsync<Szek>($"api/szek/{id}");
            if (result != null)
                return result;
            throw new Exception("Nem található a szek");
        }

        public async Task GetSzekek()
        {
            var result = await _http.GetFromJsonAsync<List<Szek>>("api/szek");
            if (result != null)
                Szekek = result;
        }


        public async Task UpdateSzek(Szek szek)
        {
            var result = await _http.PutAsJsonAsync($"api/szek/{szek.Id}", szek);
            var response = await result.Content.ReadFromJsonAsync<List<Szek>>();
            Szekek = response;
        }
    }
}