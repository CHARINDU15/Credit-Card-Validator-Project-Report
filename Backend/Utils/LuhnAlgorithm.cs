namespace CreditCardValidatorAPI.Utils
{
    public static class LuhnAlgorithm
    {
        public static string GetCardType(string cardNumber)
        {
            if (cardNumber.StartsWith("34") || cardNumber.StartsWith("37")) return cardNumber.Length == 15 ? "AmEx" : null;
            if (cardNumber.StartsWith("4")) return cardNumber.Length == 16 ? "Visa" : null;
            if (cardNumber.StartsWith("22") || (cardNumber.StartsWith("51") && cardNumber.Length == 16)) return "Mastercard";
            if (cardNumber.StartsWith("6011")) return cardNumber.Length == 16 ? "Discover" : null;

            return null;
        }

        public static bool IsValid(string cardNumber)
        {
            int sum = 0;
            bool alternate = false;
            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(cardNumber[i].ToString());
                if (alternate)
                {
                    n *= 2;
                    if (n > 9) n -= 9;
                }
                sum += n;
                alternate = !alternate;
            }
            return sum % 10 == 0;
        }
    }
}
