using Microsoft.EntityFrameworkCore;
using SisecomClient.Models;

namespace SisecomClient.Data
{
    public class BankContext : DbContext
    {
       public BankContext(DbContextOptions<BankContext> options) : base(options) 
        {
        }
        //Banco de armazenamento de dados de Clientes!
        public DbSet<ClientModel> Clients { get; set; }
    }
}
