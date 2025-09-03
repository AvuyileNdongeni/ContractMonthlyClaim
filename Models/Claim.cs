namespace ContractMonthlyClaimSystemWPF.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public string LecturerName { get; set; }
        public string Programme { get; set; }
        public string MonthYear { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
    }
}
