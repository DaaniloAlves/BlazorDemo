using Microsoft.EntityFrameworkCore;
using BlazorDemo.Shared.Entities;

namespace BlazorDemo.Context
{
	public class ClienteContext : DbContext
	{
        public ClienteContext(DbContextOptions<ClienteContext> o) : base(o)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }


    }
}
