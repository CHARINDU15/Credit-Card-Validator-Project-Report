using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardValidatorAPI.Services;

namespace CreditCardValidatorAPI.Tests
{
    [TestClass]
    public class CardValidatorTests
    {
        private readonly CardValidationService _service = new CardValidationService();

        [TestMethod]
        public void TestValidVisaCard()
        {
            var result = _service.Validate("4111111111111111");
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("Card is valid. Type: Visa", result.Message);
        }

        [TestMethod]
        public void TestInvalidCardNumber()
        {
            var result = _service.Validate("1234567890123456");
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Invalid card number.", result.Message);
        }
    }
}
