using CreditCardValidatorAPI.Models;
using CreditCardValidatorAPI.Utils;
using System.Text.RegularExpressions;

namespace CreditCardValidatorAPI.Services
{
    public interface ICardValidationService
    {
        ValidationResult Validate(string cardNumber);
    }

    public class CardValidationService : ICardValidationService
    {
        public ValidationResult Validate(string cardNumber)
        {
            if (string.IsNullOrWhiteSpace(cardNumber))
                return new ValidationResult { IsValid = false, Message = "Card number is required." };

            if (cardNumber.Length < 13 || cardNumber.Length > 19)
                return new ValidationResult { IsValid = false, Message = "Card number must be between 13 and 19 digits." };

            if (!Regex.IsMatch(cardNumber, @"^\d+$"))
                return new ValidationResult { IsValid = false, Message = "Card number must contain only digits." };

            var cardType = LuhnAlgorithm.GetCardType(cardNumber);
            if (cardType == null || !LuhnAlgorithm.IsValid(cardNumber))
                return new ValidationResult { IsValid = false, Message = "Invalid card number." };

            return new ValidationResult { IsValid = true, Message = $"Card is valid. Type: {cardType}" };
        }
    }
}