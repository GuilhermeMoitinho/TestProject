using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoJWT.WebAPI.Application.interfaces;
using ProjetoJWT.WebAPI.Domain.Entities;

namespace ProjetoJWT.WebAPI.Controllers
{
    [Route("api/funcionarios")]
    [Authorize(Roles = "Employee")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public FuncionarioController(IEmployeeService employeeService)
            => _employeeService = employeeService;

        [Authorize(Roles = "Manager")]
        [HttpGet]
        public async Task<IActionResult> GetAllAsync(int PaginaNumeros, int QuantidadeDeNumeros)
            => Ok(await _employeeService.GetAll(PaginaNumeros, QuantidadeDeNumeros));

        [ActionName("GetByIdAsync")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            if (id == null) return NotFound();

            return Ok(await _employeeService.GetId(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            if (employee == null) return NotFound();

            await _employeeService.Add(employee);

            var Object = new
            {
                Sucesso = true,
                Id = employee.Id,
            };

            return CreatedAtAction(nameof(GetByIdAsync), new {id = employee.Id}, Object);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Employee employee, Guid id)
        {
            if (employee == null) return NotFound();

            await _employeeService.Update(employee, id); 

            return NoContent();
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            if (id == null) return NotFound();

            await _employeeService.Delete(id);

            return NoContent();
        }

        [AllowAnonymous]
        [HttpPut("id")]
        public async Task<IActionResult> PutFuncionario()
        {
            throw new Exception("Erro");
        }

    }
}
