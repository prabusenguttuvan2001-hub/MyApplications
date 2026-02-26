using System.Text.RegularExpressions;

namespace BankingGateway.Helper
{
    public static class SensitiveDataMasker
    {
        public static string Mask(string message)
        {
            return Regex.Replace(
                message,
                @"\b(\d{4})(\d{4})(\d{4})(\d{4})\b",
                "***-****-****-$4"
            );
        }
    }
}
