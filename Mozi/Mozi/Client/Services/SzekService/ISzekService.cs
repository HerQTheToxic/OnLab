namespace Mozi.Client.Services.SzekService
{
    public interface ISzekService
    {
        List<Szek> Szekek { get; set; }
        Task GetSzekek();
        Task<Szek> GetSingleSzek(int id);
        Task CreateSzek(Szek szek);
        Task DeleteSzek(int id);
        Task UpdateSzek(Szek szek);

    }
}
