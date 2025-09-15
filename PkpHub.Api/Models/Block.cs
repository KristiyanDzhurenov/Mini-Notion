public class Block
{
    public int Id { get; set; }
    public int PageId { get; set; }
    public string Type { get; set; } = "text";
    public string Content { get; set; } = string.Empty;
    public int Position { get; set; } = 0;

    public Page Page { get; set; } = null!;
}