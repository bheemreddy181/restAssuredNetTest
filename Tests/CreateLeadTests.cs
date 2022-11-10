using IntegrationTests.Hooks;
using IntegrationTests.Models.API.Request;
using IntegrationTests.Models;
using NUnit.Framework;
using RestAssured.Net.RA.Builders;
using static RestAssuredNet.RestAssuredNet;

namespace IntegrationTests.Tests;

[TestFixture]
public class CreateLeadTests : TestBase
{
    [Test]
    public void CreateLeadTest()
    {
        
        string token = Helpers.Helpers.CreateToken();
        var lead = new LeadRequest(1005, "heights");
        var data =  Helpers.Helpers.CreateLeadData(lead);
        
        Given()
            .Spec(Context.RequestSpecification!)
            .Header("Authorization",$"Bearer {token}")
            .Body(data)
            .When()
            .Post("/lead")
            .Then()
            .Log().All()
            .StatusCode(200);
    }
}