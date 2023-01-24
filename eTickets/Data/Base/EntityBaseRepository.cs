using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eTickets.Data.Base
{
    //this is basically a generic service from what i understood so instead of having multiple services for every model we have a generic one that fits them all.
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Set<T>().FirstOrDefault(x => x.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            var result = _context.Set<T>().ToList();
            return result;
        }

        public T GetById(int id)
        {
            var result = _context.Set<T>().FirstOrDefault(x => x.Id == id);
            return result;
        }

        public void Update(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
