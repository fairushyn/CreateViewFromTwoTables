using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class EntitiesViewController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public EntitiesViewController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.EntitiesView.ToList());
    }
}