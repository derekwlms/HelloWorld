using System;
using System.Net.Http;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace Tn_Next.IntegrationTests
{    
    public class HelloWorldControllerTests
    {
        private readonly HttpClient _client;
        
        public HelloWorldControllerTests()
        {
            var builder = new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<TnNext.Web.Startup>();

            var testServer = new TestServer(builder);
            testServer.BaseAddress = new Uri("http://127.0.0.1:21233");
            _client = testServer.CreateClient();
        }
        
        [Fact]
        public void Should_return_hello_world()
        {
            var result = _client.GetAsync("/api/hello").Result.Content.ReadAsStringAsync().Result;

            result.Should().Be("Hello World.");

        }
    }
}