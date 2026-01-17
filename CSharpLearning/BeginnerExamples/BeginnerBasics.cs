using System;

namespace CSharpLearning.BeginnerExamples
{
    /// <summary>
    /// Beginner-friendly examples to understand basic programming concepts
    /// </summary>
    public class BeginnerBasics
    {
        /// <summary>
        /// Example 1: Variables and Data Types
        /// Variables are like containers that store data
        /// </summary>
        public static void VariablesAndDataTypes()
        {
            Console.WriteLine("=== Variables and Data Types ===");
            
            // Integer - stores whole numbers
            int age = 25;
            Console.WriteLine($"Age: {age}");
            
            // Double - stores decimal numbers
            double price = 99.99;
            Console.WriteLine($"Price: ${price}");
            
            // String - stores text
            string name = "John";
            Console.WriteLine($"Name: {name}");
            
            // Boolean - stores true or false
            bool isStudent = true;
            Console.WriteLine($"Is Student: {isStudent}");
            
            // Char - stores single character
            char grade = 'A';
            Console.WriteLine($"Grade: {grade}");
        }

        /// <summary>
        /// Example 2: If-Else Statements
        /// Making decisions in code
        /// </summary>
        public static void IfElseExample()
        {
            Console.WriteLine("\n=== If-Else Statements ===");
            
            int score = 85;
            
            if (score >= 90)
            {
                Console.WriteLine($"Score: {score} - Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine($"Score: {score} - Grade: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine($"Score: {score} - Grade: C");
            }
            else
            {
                Console.WriteLine($"Score: {score} - Grade: F");
            }
        }

        /// <summary>
        /// Example 3: For Loop
        /// Repeating actions multiple times
        /// </summary>
        public static void ForLoopExample()
        {
            Console.WriteLine("\n=== For Loop ===");
            Console.WriteLine("Counting from 1 to 5:");
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Count: {i}");
            }
        }

        /// <summary>
        /// Example 4: While Loop
        /// Repeating until a condition is met
        /// </summary>
        public static void WhileLoopExample()
        {
            Console.WriteLine("\n=== While Loop ===");
            Console.WriteLine("Counting down from 5:");
            
            int count = 5;
            while (count > 0)
            {
                Console.WriteLine($"Count: {count}");
                count--;  // Decrease count by 1
            }
            Console.WriteLine("Blast off!");
        }

        /// <summary>
        /// Example 5: Arrays
        /// Storing multiple values in one variable
        /// </summary>
        public static void ArrayExample()
        {
            Console.WriteLine("\n=== Arrays ===");
            
            // Array of numbers
            int[] numbers = { 10, 20, 30, 40, 50 };
            
            Console.WriteLine("Numbers in array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }
            
            // Array of names
            string[] names = { "Alice", "Bob", "Charlie" };
            Console.WriteLine("\nNames in array:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Example 6: Methods/Functions
        /// Reusable blocks of code
        /// </summary>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void MethodExample()
        {
            Console.WriteLine("\n=== Methods/Functions ===");
            
            int result1 = Add(5, 3);
            int result2 = Add(10, 20);
            
            Console.WriteLine($"5 + 3 = {result1}");
            Console.WriteLine($"10 + 20 = {result2}");
        }

        /// <summary>
        /// Example 7: String Operations
        /// Working with text
        /// </summary>
        public static void StringOperations()
        {
            Console.WriteLine("\n=== String Operations ===");
            
            string firstName = "John";
            string lastName = "Doe";
            
            // Concatenation (joining strings)
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Full Name: {fullName}");
            
            // String interpolation (modern way)
            string greeting = $"Hello, {fullName}!";
            Console.WriteLine(greeting);
            
            // String length
            Console.WriteLine($"Length of '{fullName}': {fullName.Length} characters");
            
            // Convert to uppercase
            Console.WriteLine($"Uppercase: {fullName.ToUpper()}");
            
            // Convert to lowercase
            Console.WriteLine($"Lowercase: {fullName.ToLower()}");
        }

        /// <summary>
        /// Example 8: User Input (Simulated)
        /// Getting data from user
        /// </summary>
        public static void UserInputExample()
        {
            Console.WriteLine("\n=== User Input Example ===");
            Console.WriteLine("(This is a simulated example)");
            
            // In real program, you would use: Console.ReadLine()
            string userName = "Alice";  // Simulated input
            int userAge = 25;           // Simulated input
            
            Console.WriteLine($"Hello {userName}, you are {userAge} years old!");
        }

        /// <summary>
        /// Example 9: Simple Calculator
        /// Combining multiple concepts
        /// </summary>
        public static void SimpleCalculator()
        {
            Console.WriteLine("\n=== Simple Calculator ===");
            
            double num1 = 10;
            double num2 = 5;
            char operation = '+';
            
            double result = 0;
            
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }
            
            Console.WriteLine($"{num1} {operation} {num2} = {result}");
        }

        /// <summary>
        /// Example 10: Finding Maximum in Array
        /// </summary>
        public static void FindMaximum()
        {
            Console.WriteLine("\n=== Finding Maximum in Array ===");
            
            int[] numbers = { 5, 12, 8, 25, 3, 15 };
            
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            
            Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
            Console.WriteLine($"Maximum: {max}");
        }

        /// <summary>
        /// Run all beginner examples
        /// </summary>
        public static void RunAll()
        {
            VariablesAndDataTypes();
            IfElseExample();
            ForLoopExample();
            WhileLoopExample();
            ArrayExample();
            MethodExample();
            StringOperations();
            UserInputExample();
            SimpleCalculator();
            FindMaximum();
        }
    }
}
