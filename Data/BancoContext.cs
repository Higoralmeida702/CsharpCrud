using CsharpCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CsharpCrud.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
