using System;
using System.Text.Json.Serialization;

namespace ZarinSharp.InputTypes
{
    /// <summary>
    /// کلاسی حاوی پارامترهای موردنیاز برای ارسال درخواست پرداخت
    /// </summary>
    public class RequestPaymentInput : InputBase
    {
        /// <summary>
        /// مبلغ تراکنش به تومان | الزامی
        /// </summary>
        public long Amount { get; set; }

        /// <summary>
        /// آدرس بازگشت مشتری پس از انجام عملیات | الزامی
        /// </summary>
        [JsonPropertyName("CallbackURL")]
        public Uri CallbackUrl { get; set; }

        /// <summary>
        /// توضیحات مربوط به تراکنش | الزامی
        /// </summary>
        public string Description { get; set; }
    }
}
