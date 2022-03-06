namespace Mozi.Client.Services.TeremService
{
    public interface ITeremService
    {
        List<Terem> Termek { get; set; }
        List<Szek> Szekek { get; set; }
        Task GetSzekek();
        Task GetTermek();
        Task<Terem> GetSingleTerem(int id);
        Task<Szek> GetSingleSzek(int id);
    }
}
