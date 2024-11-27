namespace celuma_webapi_net.Models;

public class Invoice
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string Name { get; set; }
    public string Rfc { get; set; }
    public string Zip { get; set; }
    public string FiscalRegime { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public int ModifiedBy { get; set; }
}