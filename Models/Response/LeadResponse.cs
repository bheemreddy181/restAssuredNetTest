namespace IntegrationTests.Models.API.Response;

public class LeadResponse
{
    public LeadResponse(int branchId, string? dateOfBirth, string? firstName, string? lastName, string? email, string? zip, int? leadId, string? phoneNumber, string? bestTime)
    {
        BranchId = branchId;
        DateOfBirth = dateOfBirth;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Zip = zip;
        LeadId = leadId;
        PhoneNumber = phoneNumber;
        BestTime = bestTime;
    }

    public int BranchId { get; set; }
    public string? DateOfBirth { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Zip { get; set; }
    public int? LeadId { get; set; }
    public string? PhoneNumber { get; set; }
    public string? BestTime { get; set; }




}