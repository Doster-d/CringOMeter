using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CringOMeter.Wasm {
    public class Program {
        public static async Task Main(string[] args) {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp =>
            {
                var client = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
                client.DefaultRequestHeaders.UserAgent.ParseAdd("PostmanRuntime/7.28.0");
                client.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github.groot-preview+json");
                
                return client;
            });

            await builder.Build().RunAsync();
        }
    }
}
