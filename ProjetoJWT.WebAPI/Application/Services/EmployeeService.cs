using ProjetoJWT.WebAPI.Application.interfaces;
using ProjetoJWT.WebAPI.Domain.Entities;
using ProjetoJWT.WebAPI.Domain.interfaces;

namespace ProjetoJWT.WebAPI.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IEmployeeRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task Add(Employee employe)
        {
            await _repository.Add(employe);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var Employee = await _repository.GetId(id);

            await _repository.Delete(Employee); 
            
            await _unitOfWork.SaveChangesAsync();
        }

        public Task<IEnumerable<Employee>> GetAll()
            => _repository.GetAll();

        public Task<Employee> GetId(Guid id)
            => _repository.GetId(id);   

        public async Task Update(Employee employe, Guid id)
        {
            var Employee = await _repository.GetId(id);

            Employee.Nome = employe.Nome;
            Employee.Salario = employe.Salario;
            Employee.Ativo = employe.Ativo; 

            _repository.Update(Employee);

             _unitOfWork.SaveChangesAsync();
        }
 
    }
}
