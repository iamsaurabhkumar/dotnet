using System;

namespace CSharpLearning.BasicPrograms
{
    /// <summary>
    /// Swapping Programs - Learn how to swap two variables
    /// </summary>
    public class SwappingPrograms
    {
        /// <summary>
        /// Method 1: Swap using a temporary variable (Most Common)
        /// </summary>
        public static void SwapWithTemp()
        {
            Console.WriteLine("=== Swapping with Temporary Variable ===");
            int a = 10;
            int b = 20;
            
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            
            int temp = a;
            a = b;
            b = temp;
            
            Console.WriteLine($"After swap: a = {a}, b = {b}");
        }

        /// <summary>
        /// Method 2: Swap using arithmetic operations (without temp variable)
        /// </summary>
        public static void SwapWithArithmetic()
        {
            Console.WriteLine("\n=== Swapping with Arithmetic Operations ===");
            int a = 10;
            int b = 20;
            
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            
            a = a + b;  // a becomes 30
            b = a - b;  // b becomes 10 (original a)
            a = a - b;  // a becomes 20 (original b)
            
            Console.WriteLine($"After swap: a = {a}, b = {b}");
        }

        /// <summary>
        /// Method 3: Swap using XOR operation (Bitwise)
        /// </summary>
        public static void SwapWithXOR()
        {
            Console.WriteLine("\n=== Swapping with XOR Operation ===");
            int a = 10;
            int b = 20;
            
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            
            a = a ^ b;  // XOR operation
            b = a ^ b;  // XOR operation
            a = a ^ b;  // XOR operation
            
            Console.WriteLine($"After swap: a = {a}, b = {b}");
        }

        /// <summary>
        /// Method 4: Swap using C# tuple syntax (Modern C# way)
        /// </summary>
        public static void SwapWithTuple()
        {
            Console.WriteLine("\n=== Swapping with Tuple (Modern C#) ===");
            int a = 10;
            int b = 20;
            
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            
            (a, b) = (b, a);  // Tuple deconstruction
            
            Console.WriteLine($"After swap: a = {a}, b = {b}");
        }

        /// <summary>
        /// Run all swapping examples
        /// </summary>
        public static void RunAll()
        {
            SwapWithTemp();
            SwapWithArithmetic();
            SwapWithXOR();
            SwapWithTuple();
        }
    }
}
