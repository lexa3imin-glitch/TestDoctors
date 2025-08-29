using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDoctors.Domain.Dbo;
using TestDoctors.Infrastructure.Context;

namespace TestDoctors.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DoctorController : ControllerBase
{
    private readonly BDContext _context;
    public DoctorController(BDContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetDiseaseList()
        => Ok(await _context.Doctors.Include(x => x.Specialization).Select(x => new DoctorDto(x.FirstName + " " + x.LastName + " " + x.MiddleName, x.Specialization.Name)).ToArrayAsync());
}

public record DoctorDto (string FullName, string Specialization);