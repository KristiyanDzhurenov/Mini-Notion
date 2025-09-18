using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PkpHub.Api.Data;

[ApiController]
[Route("api/[controller]")]
public class PagesController : ControllerBase
{
    private readonly AppDbContext _context;

    public PagesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetPages()
    {
        var pages = await _context.Pages.ToListAsync();
        return Ok(pages);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPage(int id)
    {
        var page = await _context.Pages.Include(p => p.Blocks).FirstOrDefaultAsync(p => p.Id == id);
        if (page == null) return NotFound();
        return Ok(page);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePage([FromBody] Page page)
    {
        _context.Pages.Add(page);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPage), new { id = page.Id }, page);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePage(int id, [FromBody] Page updatedPage)
    {
        var page = await _context.Pages.FindAsync(id);
        if (page == null) return NotFound();

        page.Title = updatedPage.Title;
        await _context.SaveChangesAsync();
        return Ok(page);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Deletepage(int id)
    {
        var page = await _context.Pages.Include(p => p.Blocks).FirstOrDefaultAsync(p => p.Id == id);
        if (page == null) return NotFound();

        _context.Blocks.RemoveRange(page.Blocks);
        _context.Pages.Remove(page);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}