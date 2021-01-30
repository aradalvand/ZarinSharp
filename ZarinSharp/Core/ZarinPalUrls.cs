namespace ZarinSharp
{
    class ZarinPalUrls
    {
        readonly string _baseAddress;

        public ZarinPalUrls(bool isSandbox)
        {
            _baseAddress = $"https://{(isSandbox ? "sandbox" : "www")}.zarinpal.com/pg";
        }

        public string GetPaymentRequestUrl()
        {
            return $"{_baseAddress}/rest/WebGate/PaymentRequest.json";
        }

        public string GetPaymentVerificationUrl()
        {
            return $"{_baseAddress}/rest/WebGate/PaymentVerification.json";
        }

        public string GetPaymentGatewayUrl(string authority, bool zarinGate = true)
        {
            return $"{_baseAddress}/StartPay/{authority}" + (zarinGate ? "/ZarinGate" : "");
        }
    }
}
