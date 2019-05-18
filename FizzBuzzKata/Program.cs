using System;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class FizzBuzzer
    {
        public string FizzBuzz(int input)
        {
            string result = String.Empty;

            if (input % 3 == 0)
            {
                result = "Fizz";
            }
            if (input % 5 == 0)
            {
                result = result + "Buzz";
            }
            if (result == String.Empty)
            {
                result = input.ToString();
            }
            return result;
        }
    }
}
