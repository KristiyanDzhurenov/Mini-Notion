using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PkpHub.Api.Data;

[ApiController]
[Route("api/[controller]")]
public class BlocksController : ControllerBase
{
    private readonly AppDbContext _context;

    public BlocksController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("page/{pageId}")]
    public async Task<IActionResult> GetBlocksForPage(int pageId)
    {
        var blocks = await _context.Blocks
        .Where(b => b.PageId == pageId)
        .OrderBy(b => b.Position)
        .ToListAsync();

        return Ok(blocks);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBlock([FromBody] Block block)
    {
        _context.Blocks.Add(block);
        await _context.SaveChangesAsync();
        return Ok(block);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateBlock(int id, [FromBody] Block updatedBlock)
    {
        var block = await _context.Blocks.FindAsync(id);
        if (block == null) return NotFound();

        block.Content = updatedBlock.Content;
        block.Type = updatedBlock.Type;
        block.Position = updatedBlock.Position;

        await _context.SaveChangesAsync();
        return Ok(block);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBlock(int id)
    {
        var block = await _context.Blocks.FindAsync(id);
        if (block == null) return NotFound();

        _context.Blocks.Remove(block);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}