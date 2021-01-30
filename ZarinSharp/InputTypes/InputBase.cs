using System.Text.Json.Serialization;

namespace ZarinSharp.InputTypes
{
    public abstract class InputBase
    {
        /// <summary>
        /// کد درگاه پرداخت ۳۶ کاراکتری | الزامی: اگر مقداری به این پراپرتی داده نشود، مقدار پیش‌فرض کد درگاه پرداخت وارد شده در تنظیمات خواهد بود.
        /// </summary>
        [JsonPropertyName("MerchantID")]
        public string MerchantId { get; set; }
    }
}
