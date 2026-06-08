using Microsoft.AspNetCore.Mvc;
using PrimePlatform.Application.DTOs;
using PrimePlatform.Application.Interfaces;
using PrimePlatform.Application.Interfaces.Repositories;
using PrimePlatform.Domain.Entities;

namespace PrimePlatform.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _employeeService.GetAllAsync();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var employee = await _employeeService.GetByIdAsync(id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeDto dto)
        {
            var employee = await _employeeService.CreateAsync(dto);
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateEmployeeDto dto)
        {
            var employee = await _employeeService.UpdateAsync(id, dto);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _employeeService.DeleteAsync(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }

    }
}
