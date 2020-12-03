using BlazorCrudWebAssembly.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCrudWebAssembly.Infrastructure.BL
{
    interface IDataServiceBL
    {
        Task<List<Persona>> GetPeople();
    }
}
