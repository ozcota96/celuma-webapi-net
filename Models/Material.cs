namespace celuma_webapi_net.Models;

public class Material
{
    public int Id { get; set; }
    public int ProviderId { get; set; }
    public string Name { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int Quantity { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public int ModifiedBy { get; set; }
}