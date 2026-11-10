using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModeloLaHuesera.Entidades;
using BackLaHuesera.Data;

[Route("api/[controller]")]
[ApiController]
public class PeliculasController : ControllerBase
{
    private readonly DataContext _context;
    public PeliculasController(DataContext context)
    {
        _context = context;
    }

    // GET: api/Pelicula
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pelicula>>> GetPelicula()
    {
        return await _context.Peliculas.ToListAsync();
    }

    // GET: api/Pelicula/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Pelicula>> GetPelicula(int id)
    {
        var pelicula = await _context.Peliculas.FindAsync(id);

        if (pelicula == null)
        {
            return NotFound();
        }

        return pelicula;
    }

    // PUT: api/Pelicula/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPelicula(int? id, Pelicula pelicula)
    {
        if (id != pelicula.Id)
        {
            return BadRequest();
        }

        _context.Entry(pelicula).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PeliculaExists(id))
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

    // POST: api/Pelicula
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Pelicula>> PostPelicula(Pelicula pelicula)
    {
        _context.Peliculas.Add(pelicula);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetPelicula", new { id = pelicula.Id }, pelicula);
    }

    // DELETE: api/Pelicula/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePelicula(int? id)
    {
        var pelicula = await _context.Peliculas.FindAsync(id);
        if (pelicula == null)
        {
            return NotFound();
        }

        _context.Peliculas.Remove(pelicula);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PeliculaExists(int? id)
    {
        return _context.Peliculas.Any(e => e.Id == id);
    }
}
