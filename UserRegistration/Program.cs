using System;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate validate = new Validate();
            Console.WriteLine("Enter the first name to validate:");
            string FirstName = Console.ReadLine();
            validate.FirstName(FirstName);
        }
    }
}