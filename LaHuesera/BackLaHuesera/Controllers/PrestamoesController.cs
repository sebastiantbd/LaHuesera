using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModeloLaHuesera.Entidades;
using BackLaHuesera.Data;

[Route("api/[controller]")]
[ApiController]
public class PrestamoesController : ControllerBase
{
    private readonly DataContext _context;
    public PrestamoesController(DataContext context)
    {
        _context = context;
    }

    // GET: api/Prestamo
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Prestamo>>> GetPrestamo()
    {
        return await _context.Prestamo.ToListAsync();
    }

    // GET: api/Prestamo/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Prestamo>> GetPrestamo(int id)
    {
        var prestamo = await _context.Prestamo.FindAsync(id);

        if (prestamo == null)
        {
            return NotFound();
        }

        return prestamo;
    }

    // PUT: api/Prestamo/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPrestamo(int? id, Prestamo prestamo)
    {
        if (id != prestamo.Id)
        {
            return BadRequest();
        }

        _context.Entry(prestamo).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PrestamoExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Prestamo
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Prestamo>> PostPrestamo(Prestamo prestamo)
    {
        _context.Prestamo.Add(prestamo);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetPrestamo", new { id = prestamo.Id }, prestamo);
    }

    // DELETE: api/Prestamo/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePrestamo(int? id)
    {
        var prestamo = await _context.Prestamo.FindAsync(id);
        if (prestamo == null)
        {
            return NotFound();
        }

        _context.Prestamo.Remove(prestamo);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PrestamoExists(int? id)
    {
        return _context.Prestamo.Any(e => e.Id == id);
    }
}
