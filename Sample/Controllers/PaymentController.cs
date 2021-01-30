using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ZarinSharp;

namespace WebTest.Controllers
{
    [ApiController]
    [Route("payment")]
    public class PaymentController : ControllerBase
    {
        readonly ZarinPalService _zarinpal;

        public PaymentController(ZarinPalService zarinpal)
        {
            _zarinpal = zarinpal;
        }

        [Route("request")]
        public async Task<IActionResult> RequestPayment()
        {
            var requestResult = await _zarinpal.RequestPaymentAsync(new()
            {
                Amount = 10000,
                CallbackUrl = new Uri("https://localhost:44394/payment/verify"),
                Description = "فلان"
            });

            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            return new JsonResult(requestResult, options);
        }

        [Route("verify")]
        public async Task<IActionResult> VerifyPayment(string authority, string status)
        {
            var verificationResult = await _zarinpal.VerifyPaymentAsync(new()
            {
                Amount = 10000,
                Authority = authority,
            });

            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            return new JsonResult(verificationResult, options);
        }
    }
}
