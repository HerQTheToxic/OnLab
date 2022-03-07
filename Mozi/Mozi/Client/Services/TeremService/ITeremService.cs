namespace Mozi.Client.Services.TeremService
{
    public interface ITeremService
    {
        List<Terem> Termek { get; set; }

        Task GetTermek();
        Task<Terem> GetSingleTerem(int id);
        Task CreateTerem(Terem terem);
        Task DeleteTerem(int id);
        Task UpdateTerem(Terem terem);
    }
}
