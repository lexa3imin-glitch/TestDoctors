using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDoctors.Infrastructure.Context;

namespace TestDoctors.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DiseaseController : ControllerBase
{
    private readonly BDContext _context;
    public DiseaseController(BDContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetDiseaseList() 
        => Ok( await _context.Diseases.ToArrayAsync() );
}
