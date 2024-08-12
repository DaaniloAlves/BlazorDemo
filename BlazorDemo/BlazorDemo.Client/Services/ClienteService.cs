using BlazorDemo.Shared.Entities;
using BlazorDemo.Shared.Interfaces;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorDemo.Client.Services
{
    public class ClienteService : IClienteRepository
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options;

        public ClienteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions();
        }

        public async Task<Cliente> AddClienteAsync(Cliente cliente)
        {
            var model = await _httpClient.PostAsJsonAsync("api/Cliente/Add-Cliente", cliente);
            var response = await model.Content.ReadFromJsonAsync<Cliente>();
            return response!;
        }

        public async Task<Cliente> DeleteClienteAsync(int id)
        {
            var model = await _httpClient.DeleteAsync($"api/Cliente/Delete-Cliente/{id}");
            var response = await model.Content.ReadFromJsonAsync<Cliente>();
            return response!;
        }

        public async Task<List<Cliente>> GetAllClientesAsync()
        {
            var listaClientes = await _httpClient.GetAsync("api/Cliente/Clientes");
            var response = await listaClientes.Content.ReadFromJsonAsync<List<Cliente>>();
            return response!;
        }

        public async Task<Cliente> GetClienteByIdAsync(int id)
        {
            var model = await _httpClient.GetAsync($"api/Cliente/Cliente/{id}");
            var response = await model.Content.ReadFromJsonAsync<Cliente>();
            return response!;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            var model = await _httpClient.PostAsJsonAsync("api/Clinete/Update-Cliente", cliente);
            var response = await model.Content.ReadFromJsonAsync<Cliente>();
            return response!;
        }
    }
}
