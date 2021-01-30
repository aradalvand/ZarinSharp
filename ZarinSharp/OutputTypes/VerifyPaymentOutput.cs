using System.Text.Json.Serialization;

namespace ZarinSharp.OutputTypes
{
    /// <summary>
    /// کلاسی حاوی مقادیری که زرین‌پال در پاسخ درخواست تایید پرداخت باز می‌گرداند.
    /// </summary>
    public class VerifyPaymentOutput : OutputBase
    {

        /// <summary>
        /// شماره تراکنش خرید | شناسه یکتایی که زرین‌پال بعد از اتمام موفق تراکنش به پذیرنده ارائه می‌دهد. این شناسه جهت پیگیری‌های مالی استفاده می‌شود.
        /// </summary>
        [JsonPropertyName("RefID")]
        public int ReferenceId { get; set; }
    }
}
