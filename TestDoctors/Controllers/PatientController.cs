using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDoctors.Infrastructure.Context;

namespace TestDoctors.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PatientController : ControllerBase
{
    private readonly BDContext _context;

    public PatientController(BDContext context)
    {
        _context = context;
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetPatient(Guid id) 
        => Ok(await _context.Patients.Where(x => x.Id.ToString() == id.ToString()).FirstOrDefaultAsync());

    [HttpGet]
    public async Task<IActionResult> GetList()
        => Ok(await _context.Patients.ToArrayAsync());
}
