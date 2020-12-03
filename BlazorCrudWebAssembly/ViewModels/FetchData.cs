namespace BlazorCrudWebAssembly.Pages
{
    using BlazorCrudWebAssembly.Infrastructure.BL;
    using BlazorCrudWebAssembly.Models;
    using Microsoft.AspNetCore.Components;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public partial class FetchData
    {
        [Inject]
        IDataServiceBL bl { get; set; }
        public List<Persona> Personas { get; set; } = new List<Persona>();
        public string Id { get; set; }


        public void VerPersona(Persona persona)
        {
            //Id = persona.Id.ToString();
            Console.WriteLine(persona.Id.ToString());
        }

        protected override async Task OnInitializedAsync()
        {
            Personas = await bl.GetPeople();
        }

    }
}
