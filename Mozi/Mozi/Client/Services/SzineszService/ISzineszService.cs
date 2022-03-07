namespace Mozi.Client.Services.SzineszService
{
    public interface ISzineszService
    {
        List<Szinesz> Szineszek { get; set; }
        Task GetSzineszek();
        Task<Szinesz> GetSingleSzinesz(int id);
    }
}
