﻿using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate validate = new Validate();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option to execute\n 1.Validate First Name\n " +
                    "2.Validate Last Name\n 3.Validate Email\n 4.Validate Phone Number\n " +
                    "5.Validate minimum character length\n 6.Validate for atleast one upper case also\n " +
                    "7.Validate for atleast one numeric also\n 8.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the first name to validate:");
                        string FirstName = Console.ReadLine();
                        validate.ValidateWithRegex(FirstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter the last name to validate:");
                        string LastName = Console.ReadLine();
                        validate.ValidateLastName(LastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter the email to validate:");
                        string Email = Console.ReadLine();
                        validate.ValidateEmail(Email);
                        break;
                    case 4:
                        Console.WriteLine("Enter the phone number to validate:");
                        string PhoneNumber = Console.ReadLine();
                        validate.ValidatePhoneNumber(PhoneNumber);
                        break;
                    case 5:
                        Console.WriteLine("Enter the password to validate:");
                        string Character = Console.ReadLine();
                        validate.ValidateCheckCharacter(Character);
                        break;
                    case 6:
                        Console.WriteLine("Enter the password to validate:");
                        string UpperCase = Console.ReadLine();
                        validate.ValidateUpperCase(UpperCase);
                        break;
                    case 7:
                        Console.WriteLine("Enter the password to validate:");
                        string Numeric = Console.ReadLine();
                        validate.ValidateNumeric(Numeric);
                        break;
                    case 8:
                        Console.WriteLine("Enter the password to validate:");
                        string SpecialCharacter = Console.ReadLine();
                        validate.ValidateSpecialCharacter(SpecialCharacter);
                        break;
                    case 9:
                        flag = false;
                        break;
                }

            }

        }
    }
}