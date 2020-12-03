using BlazorCrudWebAssembly.Infrastructure.Interfaces;
using BlazorCrudWebAssembly.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorCrudWebAssembly.Infrastructure.Services
{
    public class WebApiClient: IWebApiClient
    {
        private readonly HttpClient client;
        public WebApiClient(HttpClient _client)
        {
            client = _client;
        }

        public Task<(HttpStatusCode StatusCode, TResponse Content)> CallGetAsync<TResponse>(string url)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Persona>> GetAsync(string Controller)
        {
            List<Persona> personas = new List<Persona>();
            var response = await client.GetAsync("Values/Obtener").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync();
            var people = System.Text.Json.JsonSerializer.Deserialize<List<Persona>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            personas = new List<Persona>(people);
            return personas;
        }
    }
}
