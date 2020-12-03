namespace BlazorCrudWebAssembly
{
    using BlazorCrudWebAssembly.Infrastructure.BL;
    using BlazorCrudWebAssembly.Infrastructure.Interfaces;
    using BlazorCrudWebAssembly.Infrastructure.Services;
    using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { 
                    BaseAddress = new Uri("https://192.168.56.1:45456/api/")
                });
            builder.Services.AddScoped<IDataService, DataService>();
            builder.Services.AddScoped<IDataServiceBL, DataServiceBL>();
            builder.Services.AddScoped<IWebApiClient, WebApiClient>();


            await builder.Build().RunAsync();
        }
    }
}
