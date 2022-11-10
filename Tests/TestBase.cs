using IntegrationTests.Hooks;
using IntegrationTests.Models;
using NUnit.Framework;
using NUnit.Framework.Internal;
using RestAssured.Net.RA.Builders;

namespace IntegrationTests.Tests;

[TestFixture]
public class TestBase
{
   public RequestSpecification? RequestSpecification { get; set; }
   protected Context Context{ get;  set; }
   private const string Hostname= "api.zippopotam.us";
   

    [OneTimeSetUp]
    public void CreateRequestSpecifications()
    {
        Context.RequestSpecification = new RequestSpecBuilder()
            .WithScheme("https")
            .WithHostName(Hostname)
            .WithBasePath("us")
            .Build();
    }

    public TestBase()
    {
        Context = new Context();
    }
}