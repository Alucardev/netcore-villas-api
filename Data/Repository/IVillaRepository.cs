using Data.Models;

namespace Data.Repository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> Update(Villa villa);
    }
}
