using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text.Json;
using ZarinSharp.InputTypes;
using ZarinSharp.OutputTypes;

namespace ZarinSharp
{
    /// <summary>
    /// کلاس اصلی، حاوی متدهای متناظر با عملیات‌های پرداخت زرین‌پال
    /// </summary>
    public class ZarinPalService
    {
        readonly ZarinPalUrls _urls;
        readonly HttpClient _httpClient;
        readonly ZarinSharpOptions _options;

        public ZarinPalService(HttpClient httpClient, ZarinSharpOptions options)
        {
            _options = options;
            _httpClient = httpClient;

            _urls = new(options.IsSandbox);
        }

        /// <summary>
        /// درخواست پرداخت جدید به زرین‌پال ارسال می‌کند.
        /// </summary>
        /// <param name="input">پارامترهای مورد نیاز برای درخواست پرداخت</param>
        /// <returns>نتیجه‌ی درخواست، که شامل «لینک ارجاع به درگاه پرداخت» می‌شود.</returns>
        public async Task<RequestPaymentOutput> RequestPaymentAsync(RequestPaymentInput input)
        {
            input.MerchantId ??= _options.MerchantId;

            if (string.IsNullOrEmpty(input.MerchantId))
                throw new InvalidOperationException("کد درگاه پرداخت الزامی است.");

            HttpResponseMessage response = await _httpClient.PostAsync(_urls.GetPaymentRequestUrl(), ToJsonContent(input));
            
            RequestPaymentOutput output = await response.Content.ReadFromJsonAsync<RequestPaymentOutput>();
            if (!string.IsNullOrEmpty(output.Authority))
                output.PaymentUrl = new Uri(_urls.GetPaymentGatewayUrl(output.Authority));

            return output;
        }

        /// <summary>
        /// درخواست تایید پرداخت به زرین‌پال ارسال می‌کند.
        /// </summary>
        /// <param name="input">پارامترهای مورد نیاز برای درخواست تایید پرداخت</param>
        /// <returns>نتیجه‌ی درخواست، که شامل «شماره تراکنش خرید» می‌شود.</returns>
        public async Task<VerifyPaymentOutput> VerifyPaymentAsync(VerifyPaymentInput input)
        {
            input.MerchantId ??= _options.MerchantId;

            if (string.IsNullOrEmpty(input.MerchantId))
                throw new InvalidOperationException("کد درگاه پرداخت الزامی است.");

            HttpResponseMessage response = await _httpClient.PostAsync(_urls.GetPaymentVerificationUrl(), ToJsonContent(input));

            VerifyPaymentOutput output = await response.Content.ReadFromJsonAsync<VerifyPaymentOutput>();

            return output;
        }

        // Private Helpers:
        static JsonContent ToJsonContent(object input)
        {
            return JsonContent.Create(input, options: new JsonSerializerOptions
            {
                PropertyNamingPolicy = null, // EXPLANATION: The default is camel case, but ZarinPal's API is case-sensitive and doesn't accept camel case, so we set the naming policy to null so that it would leave the property names unchanged.
            });
        }
    }
}
