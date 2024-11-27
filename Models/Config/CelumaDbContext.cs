using Microsoft.EntityFrameworkCore;

namespace celuma_webapi_net.Models.Config;

public class CelumaDbContext : DbContext
{
    public CelumaDbContext()
    {
        
    }

    public CelumaDbContext(DbContextOptions<CelumaDbContext> options) :
        base(options)
    {

    }
}