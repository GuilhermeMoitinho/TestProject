using ProjetoJWT.WebAPI.Data.db;
using ProjetoJWT.WebAPI.Data.repositories.contracts;
using ProjetoJWT.WebAPI.Domain.Entities;
using ProjetoJWT.WebAPI.Domain.interfaces;

namespace ProjetoJWT.WebAPI.Data.repositories
{
    public class EmployeeRepository : baseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext db) : base(db)
        {
        }
    }
}
