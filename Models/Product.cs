namespace celuma_webapi_net.Models;

public class Product
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public string Content { get; set; }
    public string? Instructions { get; set; }
    public string? Precautions { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public int ModifiedBy { get; set; }
}