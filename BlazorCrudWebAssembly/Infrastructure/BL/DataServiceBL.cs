namespace BlazorCrudWebAssembly.Infrastructure.BL
{
    using BlazorCrudWebAssembly.Infrastructure.Interfaces;
    using BlazorCrudWebAssembly.Infrastructure.Services;
    using BlazorCrudWebAssembly.Models;
    using Microsoft.AspNetCore.Components;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    public class DataServiceBL: IDataServiceBL
    {
        #region Constructor
        public DataServiceBL(IDataService _service)
        {
            this.Service = _service;
        }
        #endregion

        #region Services
        private IDataService Service { get; set; }
        #endregion

        #region Methods
        public async Task<List<Persona>> GetPeople()
        {
            List<Persona> personas = new List<Persona>();
            var x = await Service.GetPeople();
            if (x.StatusCode == HttpStatusCode.OK)
            {
                personas = x.Data;
            }
            return personas;
        } 
        #endregion
    }
}
