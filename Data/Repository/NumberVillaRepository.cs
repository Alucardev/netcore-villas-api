using Data.Models;

namespace Data.Repository
{
    public class NumberVillaRepository : Repository<NumberVilla>, INumberVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public NumberVillaRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }
        public async Task<NumberVilla> Update(NumberVilla entity)
        {
            entity.UpdateDate = DateTime.Now;
            _db.NumberVillas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
