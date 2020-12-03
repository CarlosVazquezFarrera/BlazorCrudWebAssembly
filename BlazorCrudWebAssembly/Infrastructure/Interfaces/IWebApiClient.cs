using BlazorCrudWebAssembly.Models;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace BlazorCrudWebAssembly.Infrastructure.Interfaces
{
    public interface IWebApiClient
    {
        public Task<(HttpStatusCode StatusCode, TResponse Content)> CallGetAsync<TResponse>(string url);

        Task<List<Persona>> GetAsync(string Controller);
    }
}
