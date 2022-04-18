namespace Mozi.Client.Services.TeremService
{
    public interface ITeremService
    {
        List<Terem> Termek { get; set; }
        List<Szek> Szekek { get; set; }

        List<Szek> FoglaltSzekek { get; set; }
        List<Szek> UresSzekek { get; set; }
        Task GetTermek();
        Task<Terem> GetSingleTerem(int id);
        Task CreateTerem(Terem terem);
        Task DeleteTerem(int id);
        Task UpdateTerem(Terem terem);
        Task GetTeremSzekek(int id);
        Task UpdateTeremSzek(Szek szek );
    }
}
