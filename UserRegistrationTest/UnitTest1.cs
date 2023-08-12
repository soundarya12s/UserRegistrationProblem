

using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {

        [Test]
        public void TestFirstName()
        {
            string input = "Soundarya";
            Validate firstName = new Validate();
            bool result = firstName.ValidateWithRegex(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestLastName()
        {
            string input = "Sathya";
            Validate lastName = new Validate();
            bool result = lastName.ValidateLastName(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.IsTrue(result);
        }
        [Test]
        public void TestEmail()
        {
            string input = "soundaryasathya@gmail.com";
            Validate email = new Validate();
            bool result = email.ValidateEmail(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.IsTrue(result);
        }
        [Test]
        public void TestPhoneNumber()
        {
            string input = "91 1234567890";
            Validate phonenumber = new Validate();
            bool result = phonenumber.ValidatePhoneNumber(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.IsTrue(result);
        }
        [Test]
        public void TestCheckCharacter()
        {
            string input = "Soundarya@1205";
            Validate character = new Validate();
            bool result = character.ValidateCheckCharacter(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.IsTrue(result);
        }
        [Test]
        public void TestUpperCase()
        {
            string input = "Soundarya1205";
            Validate uppercase = new Validate();
            bool result = uppercase.ValidateUpperCase(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.IsTrue(result);
        }
        [Test]
        public void TestNumeric()
        {
            string input = "Soundarya1205";
            Validate numeric = new Validate();
            bool result = numeric.ValidateNumeric(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.IsTrue(result);
        }
        [Test]
        public void TestSpecialCharacter()
        {
            string input = "Soundarya@1205";
            Validate special = new Validate();
            bool result = special.ValidateSpecialCharacter(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.IsTrue(result);
        }
        [Test]
        public void TestAllTrueEmails()
        {
            string[] input = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com",
                "abc-100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            Validate trueEmails = new Validate();
            foreach (var item in input)
            {
                bool result = trueEmails.ValidateEmail(item);
                Assert.IsTrue(result);
            }
        }
    }
}