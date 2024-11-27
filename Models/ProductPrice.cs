namespace celuma_webapi_net.Models;

public class ProductPrice
{
    public int Id { get; set; }
    public int PriceTypeId { get; set; }
    public int ProductId { get; set; }
    public decimal Amount { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public int ModifiedBy { get; set; }
}