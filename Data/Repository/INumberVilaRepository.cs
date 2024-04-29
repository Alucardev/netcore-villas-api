using Data.Models;

namespace Data.Repository
{
    public interface INumberVillaRepository : IRepository<NumberVilla>
    {
        Task<NumberVilla> Update(NumberVilla villa);
    }
}
