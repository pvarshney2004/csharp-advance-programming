using System;
using RegexQuestions.UserRegistrationSystem;
namespace RegexQuestions
{
    class Program
    {
        public static void Main(string[] args)
        {
            // UsernameValidation obj1 = new UsernameValidation();
            // string input = "user_123";
            // string input2 = "123user";
            // obj1.Validate(input);
            // obj1.Validate(input2);

            // LicensePlateNumberValidation obj2 = new LicensePlateNumberValidation();
            // System.Console.WriteLine("Enter Licence Plate Number: ");
            // string? input = Console.ReadLine();
            // obj2.Validate(input);

            // ValidateHexColorCode obj3 = new ValidateHexColorCode();
            // string input = "#ff4500";
            // obj3.Validate(input);

            // string input = "Contact us at support@example.com and info@company.org";
            // ExtractEmailAddresses obj4 = new ExtractEmailAddresses();
            // obj4.ValidateEmails(input);

            // string input = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
            // ExtractCapitalizedWords obj5 = new ExtractCapitalizedWords();
            // obj5.ExtractWords(input);

            // ValidateCreditcardNumber obj6 = new ValidateCreditcardNumber();
            // string cardNumber = "4678087827984564";
            // obj6.ValidateCards(cardNumber);
            // string masterCard = "5457957395479890";
            // obj6.ValidateCards(masterCard);

            // string input = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
            // ExtractProgrammingLang obj7 = new ExtractProgrammingLang();
            // obj7.ExtractWords(input);

            // string input = "123-45-6789";
            // ValidateSSN obj8 = new ValidateSSN();
            // obj8.Validate(input);

            // string input = "The price is $45.99, and the discount is $ 10.50.";
            // ExtractCurrency obj9 = new ExtractCurrency();
            // obj9.ExtractCurrencyValues(input);

            // ExtractValidPhoneEmail obj10 = new ExtractValidPhoneEmail();
            // obj10.Execute();

            UserMain.Execute();
        }
    }
}