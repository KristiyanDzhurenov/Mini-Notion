using System.Linq.Expressions;

public class Page
{
    public int Id { get; set; }
    public string Title { get; set; } = String.Empty;

    public int UserId { get; set; }

    public List<Block> Blocks { get; set; } = new();
}