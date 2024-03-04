using ProjetoJWT.WebAPI.Data.db;
using ProjetoJWT.WebAPI.Domain.interfaces;

namespace ProjetoJWT.WebAPI.Data.repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
