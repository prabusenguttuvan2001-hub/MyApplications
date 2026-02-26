using BankingGateway.Domain.RequestModel;
using BankingGateway.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BankingGateway.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly IBankService _bankService;
        private readonly ILogger<TransferController> _logger;

        public TransferController(IBankService bankService, ILogger<TransferController> logger)
        {
            _bankService = bankService;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult MakeTransfer([FromBody] TransferRequest request)
        {
            _logger.LogInformation(
                "Processing transfer from {From} to {To}",
                request.FromAccount,
                request.ToAccount
            );

            var result = _bankService.Execute(request);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(new { Message = "Transfer Successful" });
        }
    }

}
