using Microsoft.EntityFrameworkCore;
using SisecomClient.Models;

namespace SisecomClient.Data
{
    public class BankContext : DbContext
    {
       public BankContext(DbContextOptions<BankContext> options) : base(options) 
        {
        }

        public DbSet<ClientModel> Clients { get; set; }
    }
}
