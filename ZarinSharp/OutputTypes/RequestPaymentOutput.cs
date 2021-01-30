using System;

namespace ZarinSharp.OutputTypes
{
    /// <summary>
    /// کلاسی حاوی مقادیری که زرین‌پال در پاسخ درخواست پرداخت باز می‌گرداند.
    /// </summary>
    public class RequestPaymentOutput : OutputBase
    {
        /// <summary>
        /// شناسه مرجع درخواست | درصورت موفق بودن درخواست، این فیلد حاوی یک رشته دارای طول ۳۶ كاراكتر و در غیر این صورت خالی خواهد بود.
        /// </summary>
        public string Authority { get; set; }

        /// <summary>
        /// لینک ارجاع به درگاه پرداخت | از این برای ارجاع کاربر به درگاه پرداخت استفاده نمایید.
        /// </summary>
        public Uri PaymentUrl { get; set; }
    }
}
