using Microsoft.EntityFrameworkCore;
using ProjetoJWT.WebAPI.Data.db;
using ProjetoJWT.WebAPI.Domain.Entities;
using ProjetoJWT.WebAPI.Domain.interfaces;

namespace ProjetoJWT.WebAPI.Data.repositories
{
    public abstract class baseRepository<T> : IbaseRepository<T> where T : class
    {
        protected DbSet<T> DB;

        protected baseRepository(AppDbContext db)
        {
            DB = db.Set<T>();
        }

        public virtual async Task Add(T employe)
        {
            await DB.AddAsync(employe);
        }

        public virtual async Task Delete(T generic)
        {
           DB.Remove(generic);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await DB
                .AsNoTracking()
                .ToListAsync();
        }

        public virtual async Task<T> GetId(Guid id)
        {
           return await DB.FindAsync(id);
        }

        public virtual void Update(T generic)
        {
            DB.Update(generic);
        }
    }
}
