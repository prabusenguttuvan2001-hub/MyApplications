namespace BankingGateway.Domain.RequestModel
{
    public class TransferRequest
    {
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public int Amount { get; set; }
    }
}
