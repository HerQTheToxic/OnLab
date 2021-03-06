using System.Net.Http.Json;

namespace Mozi.Client.Services.TeremService
{
    public class TeremService : ITeremService
    {
        private readonly HttpClient _http;

        public TeremService(HttpClient http)
        {
            _http = http;
        }
        public List<Terem> Termek { get ; set ; }= new List<Terem>();
        public List<Szek> Szekek { get ; set ; }=new List<Szek>();
        public List<Szek> FoglaltSzekek { get; set; }=new List<Szek>();
        public List<Szek> UresSzekek { get; set; } = new List<Szek>();

        public async Task CreateTerem(Terem terem)
        {
            var result = await _http.PostAsJsonAsync("api/terem", terem);
            var response = await result.Content.ReadFromJsonAsync<List<Terem>>();
            Termek = response;
        }

        public async Task DeleteTerem(int id)
        {
            var result = await _http.DeleteAsync($"api/terem/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Terem>>();
            Termek = response;
        }

        public async Task<Terem> GetSingleTerem(int id)
        {
            var result = await _http.GetFromJsonAsync<Terem>($"api/terem/{id}");
            if (result != null)
                return result;
            throw new Exception("Nem található a terem");
        }

        public async Task GetTeremSzekek(int id)
        {
            var result = await _http.GetFromJsonAsync<List<Szek>>($"api/terem/{id}/szekek");
            if (result != null)
            {
                FoglaltSzekek = new List<Szek>();
                UresSzekek = new List<Szek>();
                Szekek = result;
                foreach (var szek in result)
                {
                    if (szek.Foglalt)
                    {
                        FoglaltSzekek.Add(szek);
                    }
                    else
                    {
                        UresSzekek.Add(szek);
                    }
                }
            }

        }

        public async Task GetTermek()
        {
            var result = await _http.GetFromJsonAsync<List<Terem>>("api/terem");
            if (result != null)
                Termek = result;
        }

        public async Task UpdateTerem(Terem terem)
        {
            var result = await _http.PutAsJsonAsync($"api/terem/{terem.Id}", terem);
            var response = await result.Content.ReadFromJsonAsync<List<Terem>>();
            Termek = response;
        }

        public async Task UpdateTeremSzek(Szek szek)
        { 
            var result = await _http.PutAsJsonAsync($"api/szek/{szek.Id}", szek);
            var response = await result.Content.ReadFromJsonAsync<List<Szek>>();
            Szekek = response;
        }
    }
}
