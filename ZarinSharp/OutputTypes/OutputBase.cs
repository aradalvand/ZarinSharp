using ZarinSharp.Enum;

namespace ZarinSharp.OutputTypes
{
    public abstract class OutputBase
    {
        /// <summary>
        /// وضعیت نتیجه درخواست | در صورت موفقیت‌آمیز بودن برابر ۱۰۰ در غیر این صورت عددی منفی می‌باشد.
        /// </summary>
        public ResultStatus Status { get; set; }

        /// <summary>
        /// آیا عملیات موفقیت‌آمیز بود یا خیر.
        /// </summary>
        public bool WasSuccessful => Status >= ResultStatus.Successful;
    }
}
