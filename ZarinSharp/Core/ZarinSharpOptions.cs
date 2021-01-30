namespace ZarinSharp
{
    public class ZarinSharpOptions
    {
        /// <summary>
        /// کد درگاه پرداخت | می‌تواند در هر تک درخواست اورراید شود.
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// از محیط سندباکس استفاده شود یا خیر | به طور پیش در حالت دیباگ فعال، و در حالت ریلیز غیرفعال خواهد بود.
        /// </summary>
#if DEBUG
        public bool IsSandbox { get; set; } = true;
#else
        public bool IsSandbox { get; set; } = false;
#endif
    }
}
