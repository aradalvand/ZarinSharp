namespace ZarinSharp.Enum
{
    public enum ResultStatus
    {
        /// <summary>
        /// اطلاعات ارسال‌شده ناقص است.
        /// </summary>
        IncompleteInformation = -1,

        /// <summary>
        /// آی‌پی و یا مرچنت کد پذیرنده صحیح نیست.
        /// </summary>
        IncorrectMecharntId = -2,

        /// <summary>
        /// با توجه به محدودیت‌های شاپرک امکان پرداخت با رقم درخواست‌شده میسر نمی‌باشد.
        /// </summary>
        InvalidAmount = -3,

        /// <summary>
        /// سطح پذیرنده پایین‌تر از سطح نقره‌ای است.
        /// </summary>
        AcceptorLevelIsLowerThanSilver = -4,

        /// <summary>
        /// درخواست مورد نظر یافت نشد.
        /// </summary>
        RequestNotFound = -11,

        /// <summary>
        /// امکان ویرایش درخواست میسر نمی‌باشد.
        /// </summary>
        ModificationNotPossible = -12,

        /// <summary>
        /// هیچ نوع عملیات مالی برای این تراکنش یافت نشد.
        /// </summary>
        FinancialOperationNotFoundForTransaction = -21,

        /// <summary>
        /// تراکنش ناموفق می‌باشد.
        /// </summary>
        UnsuccessfulTransaction = -22,

        /// <summary>
        /// رقم تراکنش با رقم پرداخت‌شده مطابقت ندارد.
        /// </summary>
        AmountsDoNotMatch = -33,

        /// <summary>
        /// سقف تقسیم تراکنش از لحاظ تعداد یا رقم عبور نموده است.
        /// </summary>
        MaxTransactionsExceeded = -34,

        /// <summary>
        /// اجازه دسترسی به متد مربوطه وجود ندارد.
        /// </summary>
        MethodAccessForbidden = -40,

        /// <summary>
        /// اطلاعات ارسال شده مربوط به AdditionalData غیرمعتبر می‌باشد.
        /// </summary>
        AdditionalDataInvalid = -41,

        /// <summary>
        /// مدت زمان معتبر طول عمر شناسه پرداخت بین ۳۰ دقیقه تا ۴۵ روز می‌باشد.
        /// </summary>
        PaymentIdNoLongerValid = -42,

        /// <summary>
        /// درخواست مورد نظر آرشیو شده است.
        /// </summary>
        RequestArchived = -54,

        /// <summary>
        /// عملیات با موفقیت انجام گردیده است.
        /// </summary>
        Successful = 100,

        /// <summary>
        /// عملیات پرداخت موفق بوده، و قبلا تایید پرداخت انجام گردیده است.
        /// </summary>
        AlreadyVerified = 101,
    }
}
