using ProjetoJWT.WebAPI.Domain.Entities;

namespace ProjetoJWT.WebAPI.Application.interfaces
{
    public interface IEmployeeService
    {
        Task Add(Employee employe);
        Task<IEnumerable<Employee>> GetAll();
        Task Delete(Guid id);
        Task Update(Employee employe, Guid id);
        Task<Employee> GetId(Guid id);
    }
}
