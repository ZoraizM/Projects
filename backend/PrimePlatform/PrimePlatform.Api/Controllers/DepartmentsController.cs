using Microsoft.AspNetCore.Mvc;
using PrimePlatform.Application.DTOs;
using PrimePlatform.Application.Interfaces;
using PrimePlatform.Application.Interfaces.Repositories;
using PrimePlatform.Domain.Entities;

namespace PrimePlatform.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var departments = await _departmentService.GetAllAsync();
            return Ok(departments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var department = await _departmentService.GetByIdAsync(id);

            if (department == null)
                return NotFound();

            return Ok(department);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDepartmentDto dto)
        {
            var department = await _departmentService.CreateAsync(dto);
            return Ok(department);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateDepartmentDto dto)
        {
            var department = await _departmentService.UpdateAsync(id, dto);

            if (department == null)
                return NotFound();

            return Ok(department);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _departmentService.DeleteAsync(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
