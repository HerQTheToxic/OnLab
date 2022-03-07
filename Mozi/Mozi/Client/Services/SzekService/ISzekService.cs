namespace Mozi.Client.Services.SzekService
{
    public interface ISzekService
    {
        List<Szek> Szekek { get; set; }
        Task GetSzekek();
        Task<Szek> GetSingleSzek(int id);
    }
}
