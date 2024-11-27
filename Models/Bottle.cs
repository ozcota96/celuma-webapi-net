namespace celuma_webapi_net.Models;

public class Bottle
{
    public int Id { get; set; }
    public int Capacity { get; set; }
    public decimal Price { get; set; }
    public int ProviderId { get; set; }
    public string Model { get; set; }
    public int Quantity { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public int ModifiedBy { get; set; }
}