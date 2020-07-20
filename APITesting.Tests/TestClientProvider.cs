using System.Net.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using APITesting.API;
using Microsoft.Extensions.DependencyInjection;

namespace Tests
{
    public class TestClientProvider
    {

      public HttpClient Client { get; private set; }

      public TestClientProvider(IProvideTheName nameProvider)
      {
          var webHostBuilder = new WebHostBuilder();
          webHostBuilder.ConfigureTestServices(services => { services.AddSingleton(nameProvider); });

          var server = new TestServer(webHostBuilder.UseStartup<Startup>());

          Client = server.CreateClient();
      }
    }
}