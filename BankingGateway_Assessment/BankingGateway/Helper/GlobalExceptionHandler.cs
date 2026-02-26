using Microsoft.AspNetCore.Diagnostics;

namespace BankingGateway.Helper
{

    public class GlobalExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(
            HttpContext context,
            Exception exception,
            CancellationToken token)
        {
            var traceId = Guid.NewGuid().ToString();

            context.Response.StatusCode = 500;
            context.Response.ContentType = "application/problem+json";

            var problem = new
            {
                title = "Unexpected error occurred",
                status = 500,
                traceId = traceId
            };

            await context.Response.WriteAsJsonAsync(problem);
            return true;
        }
    }
}
