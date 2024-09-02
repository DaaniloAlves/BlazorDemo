using BlazorDemo.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.Shared.Interfaces
{
	public interface IClienteRepositorio
	{
		Task<Cliente> AddClienteAsync(Cliente cliente);
		Task<Cliente> UpdateClienteAsync(Cliente cliente);
		Task<Cliente> DeleteClienteAsync(int id);
		Task<List<Cliente>> GetAllClientesAsync();
		Task<Cliente> GetClienteByIdAsync(int id);
	}
}
