using System;
using System.Diagnostics;

namespace SeleniumPracticeYouTube.StepDefinitions
{
    internal class ExceptionExample
    {
        int age;

        public void ValidateAge()
        {
            Debug.WriteLine("Enter your age: ");
            // For demonstration, you can set age here or get input from user
            age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                throw new CustomException("Age must be 18 or older.");
            }
        }

        public static void Main(string[] args)
        {
            ExceptionExample example = new ExceptionExample();
            try
            {
                example.ValidateAge();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
        }
    }

    // Custom exception class definition
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}