using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace Tn_Next.IntegrationTests
{    
    public class HelloWorldControllerTests
    {
        private readonly TestServer _server;
        
        public HelloWorldControllerTests()
        {
            var builder = new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<TnNext.Web.Startup>();

            _server = new TestServer(builder);
        }
        
        [Fact]
        public async Task Should_return_hello_world()
        {
            var client = _server.CreateClient();
            var result = await client.GetAsync("/api/hello").Result.Content.ReadAsStringAsync();
            
            result.Should().Be("Hello World.");

        }
    }
}