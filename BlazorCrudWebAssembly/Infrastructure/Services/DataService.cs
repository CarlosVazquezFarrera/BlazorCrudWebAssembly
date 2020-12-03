namespace BlazorCrudWebAssembly.Infrastructure.Services
{
    using BlazorCrudWebAssembly.Infrastructure.Interfaces;
    using BlazorCrudWebAssembly.Models;
    using BlazorCrudWebAssembly.Models.Response;
    using Microsoft.AspNetCore.Components;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    public class DataService : IDataService
    {
        [Inject]
        IWebApiClient WebApiClient { get; set; }

        public async Task<Response<List<Persona>>> GetPeople()
        {
            Response<List<Persona>> respuesta = new Response<List<Persona>>();
            try
            {

                respuesta.Data = await WebApiClient.GetAsync("Values/Obtener");
                respuesta.StatusCode = HttpStatusCode.OK;
            }
            catch (Exception)
            {
                respuesta.Data = new List<Persona>();
                respuesta.StatusCode = HttpStatusCode.BadRequest;
            }
           

            return respuesta;
        }
    }
}
