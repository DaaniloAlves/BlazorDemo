using BlazorDemo.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.Shared.Interfaces
{
	public interface IClienteRepository
	{
		Task<Cliente> AddClienteAsync(Cliente cliente);
		Task<Cliente> UpdateClienteAsync(Cliente cliente);
		Task<Cliente> DeleteClienteAsync(Cliente cliente);
		Task<Cliente> GetAllClientesAsync(Cliente cliente);
		Task<Cliente> GetClienteByIdAsync(Cliente cliente);
	}
}
