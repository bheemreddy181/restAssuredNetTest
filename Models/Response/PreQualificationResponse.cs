namespace IntegrationTests.Models.API.Response;

public class PreQualificationResponse
{
    //CWH: the response should contain the Lead info, offer info, response from credit pull
    public PreQualificationResponse(bool qualified, int ficoScore, double aLoanUnsecuredOffer, double aLoanSecuredOffer, int statusCode, string errorMessage, int summitLeadId, bool isCurrentCustomer, int summitCreditInquiryId, object lmsIdentifier, string borrowerStatus, object keyReasons, bool hasExistingCreditPull, List<ScanIdRecord> scanIdRecords, object bLoanBorrowerContractData)
    {
        Qualified = qualified;
        FicoScore = ficoScore;
        ALoanUnsecuredOffer = aLoanUnsecuredOffer;
        ALoanSecuredOffer = aLoanSecuredOffer;
        StatusCode = statusCode;
        ErrorMessage = errorMessage;
        SummitLeadId = summitLeadId;
        IsCurrentCustomer = isCurrentCustomer;
        SummitCreditInquiryId = summitCreditInquiryId;
        LmsIdentifier = lmsIdentifier;
        BorrowerStatus = borrowerStatus;
        KeyReasons = keyReasons;
        HasExistingCreditPull = hasExistingCreditPull;
        ScanIdRecords = scanIdRecords;
        BLoanBorrowerContractData = bLoanBorrowerContractData;
    }

    public bool Qualified { get; set; }
    public int FicoScore { get; set; }
    public double ALoanUnsecuredOffer { get; set; }
    public double ALoanSecuredOffer { get; set; }
    public int StatusCode { get; set; }
    public string ErrorMessage { get; set; }
    public int SummitLeadId { get; set; }
    public bool IsCurrentCustomer { get; set; }
    public int SummitCreditInquiryId { get; set; }
    public object LmsIdentifier { get; set; }
    public string BorrowerStatus { get; set; }
    public object KeyReasons { get; set; }
    public bool HasExistingCreditPull { get; set; }
    public List<ScanIdRecord> ScanIdRecords { get; set; }
    public object BLoanBorrowerContractData { get; set; }
}

public class ScanIdRecord
{
    public ScanIdRecord(string code, string description)
    {
        Code = code;
        Description = description;
    }

    public string Code { get; set; }
    public string Description { get; set; }
}