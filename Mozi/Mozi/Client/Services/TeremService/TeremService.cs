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

        public Task<Szek> GetSingleSzek(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Terem> GetSingleTerem(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetSzekek()
        {
            throw new NotImplementedException();
        }

        public Task GetTermek()
        {
            throw new NotImplementedException();
        }
    }
}
