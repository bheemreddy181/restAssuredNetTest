namespace IntegrationTests.Models.API.Request;

public class LeadRequest
{
    public LeadRequest(int branchId, string branchSlug)
    {
        BranchId = branchId;
        BranchSlug = branchSlug;
    }

    public int BranchId { get; set; }
    public string BranchSlug { get; set; }

}