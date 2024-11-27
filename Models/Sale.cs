namespace celuma_webapi_net.Models;

public class Sale
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public bool IsPayed { get; set; }
    public decimal Total { get; set; }
    public string DestinyAccount { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public int ModifiedBy { get; set; }
}