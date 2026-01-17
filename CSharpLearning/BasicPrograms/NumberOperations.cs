using System;

namespace CSharpLearning.BasicPrograms
{
    /// <summary>
    /// Number Operations - Check even/odd, prime, factorial, etc.
    /// </summary>
    public class NumberOperations
    {
        /// <summary>
        /// Check if a number is even or odd
        /// </summary>
        public static void CheckEvenOdd()
        {
            Console.WriteLine("=== Check Even or Odd ===");
            
            int[] numbers = { 5, 10, 15, 20, 25 };
            
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is Even");
                }
                else
                {
                    Console.WriteLine($"{num} is Odd");
                }
            }
        }

        /// <summary>
        /// Check if a number is prime
        /// </summary>
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Check prime numbers
        /// </summary>
        public static void CheckPrime()
        {
            Console.WriteLine("\n=== Check Prime Numbers ===");
            
            int[] numbers = { 2, 3, 4, 5, 17, 20, 29 };
            
            foreach (int num in numbers)
            {
                Console.WriteLine($"{num} is {(IsPrime(num) ? "Prime" : "Not Prime")}");
            }
        }

        /// <summary>
        /// Calculate factorial of a number
        /// </summary>
        public static long Factorial(int number)
        {
            if (number <= 1)
                return 1;
            
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Display factorial examples
        /// </summary>
        public static void FactorialExamples()
        {
            Console.WriteLine("\n=== Factorial Examples ===");
            
            int[] numbers = { 0, 1, 5, 7, 10 };
            
            foreach (int num in numbers)
            {
                Console.WriteLine($"Factorial of {num} = {Factorial(num)}");
            }
        }

        /// <summary>
        /// Reverse a number
        /// </summary>
        public static int ReverseNumber(int number)
        {
            int reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            return reversed;
        }

        /// <summary>
        /// Display reverse number examples
        /// </summary>
        public static void ReverseNumberExamples()
        {
            Console.WriteLine("\n=== Reverse Number Examples ===");
            
            int[] numbers = { 123, 4567, 100, 98765 };
            
            foreach (int num in numbers)
            {
                Console.WriteLine($"Reverse of {num} = {ReverseNumber(num)}");
            }
        }

        /// <summary>
        /// Check if a number is palindrome
        /// </summary>
        public static bool IsPalindrome(int number)
        {
            return number == ReverseNumber(number);
        }

        /// <summary>
        /// Display palindrome examples
        /// </summary>
        public static void PalindromeExamples()
        {
            Console.WriteLine("\n=== Palindrome Examples ===");
            
            int[] numbers = { 121, 123, 1331, 12321, 456 };
            
            foreach (int num in numbers)
            {
                Console.WriteLine($"{num} is {(IsPalindrome(num) ? "Palindrome" : "Not Palindrome")}");
            }
        }

        /// <summary>
        /// Run all number operation examples
        /// </summary>
        public static void RunAll()
        {
            CheckEvenOdd();
            CheckPrime();
            FactorialExamples();
            ReverseNumberExamples();
            PalindromeExamples();
        }
    }
}
