using Microsoft.AspNetCore.Mvc;
using CreditCardValidatorAPI.Models;
using CreditCardValidatorAPI.Services;

namespace CreditCardValidatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardValidatorController : ControllerBase
    {
        private readonly ICardValidationService _service;

        public CardValidatorController(ICardValidationService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<ValidationResult> ValidateCard([FromBody] CardValidationRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.CardNumber))
            {
                return BadRequest("Invalid card number.");
            }

            var result = _service.Validate(request.CardNumber);
            return Ok(result);
        }
    }
}