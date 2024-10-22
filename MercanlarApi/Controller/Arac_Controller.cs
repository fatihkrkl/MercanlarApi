using MercanlarApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class Arac_Controller : ControllerBase
{
    private readonly MercanDB _context;

    public Arac_Controller(MercanDB context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<AracModel>> CreateArac(AracModel arac)
    {
        Console.WriteLine("dsdsadsadsadsadsads");
        try
        {
            _context.Araclar.Add(arac);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAraclar), new { id = arac.Plaka }, arac);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"sadsadsadsadsa{ex.Message}");
            // Log the exception (consider using a logging framework)
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AracModel>>> GetAraclar()
    {
        Console.WriteLine("dsdsadsadsadsadsads");
        return await _context.Araclar.ToListAsync();
    }

    // New endpoint to return "d500"
    [HttpGet("d500")]
    public ActionResult<string> GetD500()
    {
        Console.WriteLine("Returning 'd500'");
        return "d500";
    }
}