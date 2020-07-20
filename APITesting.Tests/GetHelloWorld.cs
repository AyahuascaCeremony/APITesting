using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace Tests
{
  [TestFixture]
    public class GetHelloWorld
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task ReturnsHelloJonnyBoyStatusOK()
        {
            var nameProvider = new TestNameProvider();
            
            var client = new TestClientProvider(nameProvider).Client;

            nameProvider.SetTestName("Jonny Boy");

            var response = await client.GetAsync("/HelloWorld");

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(await response.Content.ReadAsStringAsync(), Is.EqualTo("Hello Jonny Boy"));
            ;
        }
    }
}