using IntegrationTests.Models.API.Request;
using IntegrationTests.Models.API.Response;
using static RestAssuredNet.RestAssuredNet;


namespace IntegrationTests.Helpers;

public static class Helpers
{
   
    private const string? LoginApiBaseUrl = "https://login.microsoftonline.com/";

   

    public static Dictionary<string, object> CreateLeadData(LeadRequest lead)
    {
        Bogus.Faker? bogus = new Bogus.Faker();
        
        var data = new Dictionary<string, object>
        {
            {"email", bogus.Internet.Email()},
            {"firstName", bogus.Person.FirstName},
            {"lastname",bogus.Person.LastName},
            {"zip", "60563"},
            {"phoneNumber", bogus.Phone.PhoneNumber("##########")},
            {"phoneNumberType", "1"},
            {"preferredContactMethod", "1"},
            {"bestTime", "8:30 to 9:00"},
            {"requestorIp", bogus.Internet.Ip()},
            {"latitude", "1835641.224104464"},
            {"longitude", "-47704422.402680844"},
            {"branchId", lead.BranchId},
            {"leadGenerationMethod", "2"},
            {"birthDate", bogus.Person.DateOfBirth},
            {"isContactAgreedUpon", true},
            {"branchSlug", lead.BranchSlug}
        };



        return data;
    }
    
    public static Dictionary<string, object> CreateLeadPreQualificationData(LeadResponse? leadResponse, int estimatedExpenses, int estimatedHousing, int estimatedIncome, string ssn)
    {
        var data = new Dictionary<string, object>
        {
            {"branchId", leadResponse!.BranchId},
            {"creditBureauTypeId", 1},
            {"estimatedExpenses", estimatedExpenses},
            {"estimatedHousing", estimatedHousing},
            {"estimatedIncome", estimatedIncome},
            {"leadEmail", leadResponse.Email!},
            {"leadId", leadResponse.LeadId!},
            {"leadPhone", leadResponse.PhoneNumber!},
            {"leadZip", leadResponse.Zip!},
            {"lmsId", 1},
            {"ssn", ssn},
            {"leadDateOfBirth", leadResponse.DateOfBirth!},
            {"leadActiveDuty", true},
            {"leadFirstName", leadResponse.FirstName!},
            {"leadLastName", leadResponse.LastName!},
            {"branchProducts", new[]{3}}
        };
        return data;
    }

    public static string CreateToken()
    {
        return "token";
    }
}