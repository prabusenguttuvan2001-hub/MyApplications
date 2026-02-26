using BankingGateway.Domain.RequestModel;
using BankingGateway.Domain.ResponseModel;

namespace BankingGateway.Interfaces
{
    public interface IBankService
    {
        Result Execute(TransferRequest req);
    }
}
