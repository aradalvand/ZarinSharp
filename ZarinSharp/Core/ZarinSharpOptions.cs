namespace ZarinSharp
{
    public class ZarinSharpOptions
    {
        /// <summary>
        /// کد درگاه پرداخت | می‌تواند در هر تک درخواست اورراید شود.
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// از محیط سندباکس استفاده شود یا خیر | به طور پیش‌فعال فعال خواهد بود.
        /// </summary>
        public bool IsSandbox { get; set; } = true;
    }
}
