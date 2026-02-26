using BankingGateway.Domain.RequestModel;
using BankingGateway.Domain.ResponseModel;
using BankingGateway.Interfaces;
using Polly;
using Polly.Retry;
namespace BankingGateway.Implementations
{




    public class BankService : IBankService
    {
        private readonly IBankService _inner;
        private readonly RetryPolicy _policy;

        public BankService(IBankService inner)
        {
            _inner = inner;

            _policy = Policy
                .Handle<HttpRequestException>()
                .WaitAndRetry(
                    3,
                    retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))
                );
        }

        public Result Execute(TransferRequest req)
        {
            try
            {
                _policy.Execute(() => _inner.Execute(req));
                return Result.Success();
            }
            catch (HttpRequestException ex)
            {
                // Expected business failure (bank down)
                return Result.Failure(ex.Message);
            }
        }
    }

}
