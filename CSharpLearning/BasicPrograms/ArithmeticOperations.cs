using System;

namespace CSharpLearning.BasicPrograms
{
    /// <summary>
    /// Basic Arithmetic Operations
    /// </summary>
    public class ArithmeticOperations
    {
        /// <summary>
        /// Perform basic arithmetic operations
        /// </summary>
        public static void BasicOperations()
        {
            Console.WriteLine("=== Basic Arithmetic Operations ===");
            
            int num1 = 15;
            int num2 = 4;
            
            Console.WriteLine($"Number 1: {num1}");
            Console.WriteLine($"Number 2: {num2}");
            Console.WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"Division: {num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"Modulus (Remainder): {num1} % {num2} = {num1 % num2}");
        }

        /// <summary>
        /// Calculate area and perimeter of a rectangle
        /// </summary>
        public static void RectangleCalculations()
        {
            Console.WriteLine("\n=== Rectangle Calculations ===");
            
            double length = 10.5;
            double width = 5.5;
            
            double area = length * width;
            double perimeter = 2 * (length + width);
            
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }

        /// <summary>
        /// Calculate simple interest
        /// </summary>
        public static void SimpleInterest()
        {
            Console.WriteLine("\n=== Simple Interest Calculation ===");
            
            double principal = 10000;
            double rate = 5.5;  // 5.5%
            double time = 2;    // 2 years
            
            double interest = (principal * rate * time) / 100;
            double amount = principal + interest;
            
            Console.WriteLine($"Principal: ${principal}");
            Console.WriteLine($"Rate: {rate}%");
            Console.WriteLine($"Time: {time} years");
            Console.WriteLine($"Interest: ${interest}");
            Console.WriteLine($"Total Amount: ${amount}");
        }

        /// <summary>
        /// Run all arithmetic examples
        /// </summary>
        public static void RunAll()
        {
            BasicOperations();
            RectangleCalculations();
            SimpleInterest();
        }
    }
}
