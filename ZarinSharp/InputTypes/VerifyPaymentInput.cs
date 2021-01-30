namespace ZarinSharp.InputTypes
{
    /// <summary>
    /// کلاسی حاوی پارامترهای موردنیاز برای ارسال درخواست تایید پرداخت
    /// </summary>
    public class VerifyPaymentInput : InputBase
    {
        /// <summary>
        /// مبلغ تراکنش به تومان | الزامی
        /// </summary>
        public long Amount { get; set; }

        /// <summary>
        /// شناسه مرجع - شناسه یکتایی که در پاسخ به درخواست پرداخت بازگردانده شده بوده است. | الزامی
        /// </summary>
        public string Authority { get; set; }
    }
}
