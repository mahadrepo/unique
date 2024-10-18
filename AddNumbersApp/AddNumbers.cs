using System;

namespace AddNumbersApp
{
    public class AddNumbers
    {
        public static void Main(string[] args)
        {
            // Example usage of functions
            int sum = AddTwoNumbers(5, 10);
            Console.WriteLine($"The sum is: {sum}");

            int difference = SubtractTwoNumbers(10, 5);
            Console.WriteLine($"The difference is: {difference}");

            int product = MultiplyTwoNumbers(5, 10);
            Console.WriteLine($"The product is: {product}");

            double quotient = DivideTwoNumbers(10, 5);
            Console.WriteLine($"The quotient is: {quotient}");
        }

       
        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
            //test
        public static int SubtractTwoNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        // Function to multiply two numbers
        public static int MultiplyTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        // Function to divide two numbers
        public static double DivideTwoNumbers(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)num1 / num2;
        }
    }
}
