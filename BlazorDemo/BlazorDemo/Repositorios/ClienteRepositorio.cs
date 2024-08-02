using BlazorDemo.Context;
using BlazorDemo.Shared.Entities;
using BlazorDemo.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Repositorios
{
	public class ClienteRepositorio : IClienteRepository
	{
		private readonly ClienteContext _context;

        public ClienteRepositorio(ClienteContext context)
        {
            _context = context;
        }
        public async Task<Cliente> AddClienteAsync(Cliente cliente)
		{
			if (cliente == null) return null!;
			var chk = await _context.Clientes.Where(x => x.Name.ToLower().Equals(cliente.Name.ToLower())).FirstOrDefaultAsync();
			if (chk != null) return null!;
			var novoCliente = _context.Clientes.Add(cliente).Entity;
			await _context.SaveChangesAsync();
			return novoCliente;
		}

		public async Task<Cliente> DeleteClienteAsync(int id)
		{
			var cliente = await _context.Clientes.Where(x => x.Id == id).FirstOrDefaultAsync();
			if (cliente == null) return null!;
			_context.Clientes.Remove(cliente);
			await _context.SaveChangesAsync();
			return cliente;
		}

		public async Task<List<Cliente>> GetAllClientesAsync()
		{
			List<Cliente> clientes = await _context.Clientes.ToListAsync();
			return clientes;
		}

		public async Task<Cliente> GetClienteByIdAsync(int id)
		{
			var cliente = await _context.Clientes.Where(x => x.Id == id).FirstOrDefaultAsync();
			if (cliente == null) return null!;
			return cliente;
		}

		public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
		{
			if (cliente == null) return null!;
			var chk = await _context.Clientes.Where(x => x.Id == cliente.Id).FirstOrDefaultAsync();
			if (chk == null) return null!;
			chk.Email = cliente.Email;
			chk.Name = cliente.Name;
			chk.Idade = cliente.Idade;
			await _context.SaveChangesAsync();
			return await _context.Clientes.FirstOrDefaultAsync(x => x.Id == cliente.Id)!;
		}
	}
}
