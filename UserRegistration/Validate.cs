using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Validate
    {
        string firstName = "^[A-Z]{1}[a-z]{2,}$";
        string lastName = "^[A-Z]{1}[a-z]{2,}$";
        string email = "^[a-z]+[._+-]{0,1}[a-z]+[@]{1}[a-z]+[.]{1}[a-z]{2,3}([.]{1}[a-z]{2}){0,1}$";
        string phoneNumber = "^([0-9]{2})([ ]{1})([0-9]{10})$";
        string character = "^.{8,}$";
        string upperCase = "^(?=.*[A-Z]).{8,}$";
        string numeric = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        string specialCharacter = @"^(?=.*[\$\&\+\,\:\;\=\?\@\#\|\'\<\>\.\-\^\*\(\)\%\!])(?=.*[0-9])(?=.*[A-Z]).{8,}$";
        //public bool ValidateFirstName(string input)
        //{
        //    bool result = Regex.IsMatch(input, firstName);
        //    return result;
        //}
        public bool ValidateLastName(string input)
        {
            bool result = Regex.IsMatch(input, lastName);
            return result;
        }
        public bool ValidateEmail(string input)
        {
            bool result = Regex.IsMatch(input, email);
            return result;
        }
        public bool ValidatePhoneNumber(string input)
        {
            bool result = Regex.IsMatch(input, phoneNumber);
            return result;
        }
        public bool ValidateCheckCharacter(string input)
        {
            bool result = Regex.IsMatch(input, character);
            return result;
        }
        public bool ValidateUpperCase(string input)
        {
            bool result = Regex.IsMatch(input, upperCase);
            return result;
        }
        public bool ValidateNumeric(string input)
        {
            bool result = Regex.IsMatch(input, numeric);
            return result;
        }
        public bool ValidateSpecialCharacter(string input)
        {
            bool result = Regex.IsMatch(input, specialCharacter);
            return result;
        }
        public bool ValidateFirstNameRegex(string input) => Regex.IsMatch(input, firstName)
            ? true : false;
        public bool ValidateLastNameRegex(string input) => Regex.IsMatch(input, lastName) ? true : false;
        public bool ValidateEmailRegex(string input) => Regex.IsMatch(input, email) ? true : false;
        public bool ValidatePhoneNumberRegex(string input) => Regex.IsMatch(input, phoneNumber) ? true : false;
        public bool ValidatePasswordRegex(string input) => Regex.IsMatch(input, specialCharacter) ? true : false;
    }
}