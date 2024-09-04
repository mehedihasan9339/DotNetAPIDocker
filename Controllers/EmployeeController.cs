using DotNetAPIDocker.Context;
using DotNetAPIDocker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetAPIDocker.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController:ControllerBase
{
    private readonly ILogger<EmployeeController> _logger;
    private readonly dbContext _context;

    public EmployeeController(ILogger<EmployeeController> logger, dbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("/api/GetAllEmployees")]
    public async Task<IActionResult> Get()
    {
        //var employee = new Employee
        //{
        //    Id = 1,
        //    Name = "Mehedi",
        //    Phone = "132321321321321"
        //};

        //_context.Employees.Add(employee);
        //await _context.SaveChangesAsync();

        var list = await _context.Employees.AsNoTracking().ToListAsync();

        return Ok(list);
    }
}