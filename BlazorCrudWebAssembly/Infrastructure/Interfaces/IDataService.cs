namespace BlazorCrudWebAssembly.Infrastructure.Interfaces
{
    using BlazorCrudWebAssembly.Models;
    using BlazorCrudWebAssembly.Models.Response;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IDataService
    {
        public Task<Response<List<Persona>>> GetPeople();
    }
}
