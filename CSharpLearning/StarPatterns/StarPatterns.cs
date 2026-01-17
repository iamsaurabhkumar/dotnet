using System;

namespace CSharpLearning.StarPatterns
{
    /// <summary>
    /// Star Pattern Programs - Learn loops and pattern printing
    /// </summary>
    public class StarPatterns
    {
        /// <summary>
        /// Pattern 1: Right Triangle (Left Aligned)
        /// *
        /// **
        /// ***
        /// ****
        /// *****
        /// </summary>
        public static void RightTriangle(int rows = 5)
        {
            Console.WriteLine("=== Pattern 1: Right Triangle ===");
            
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pattern 2: Inverted Right Triangle
        /// *****
        /// ****
        /// ***
        /// **
        /// *
        /// </summary>
        public static void InvertedRightTriangle(int rows = 5)
        {
            Console.WriteLine("\n=== Pattern 2: Inverted Right Triangle ===");
            
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pattern 3: Right Triangle (Right Aligned)
        ///     *
        ///    **
        ///   ***
        ///  ****
        /// *****
        /// </summary>
        public static void RightAlignedTriangle(int rows = 5)
        {
            Console.WriteLine("\n=== Pattern 3: Right Aligned Triangle ===");
            
            for (int i = 1; i <= rows; i++)
            {
                // Print spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pattern 4: Pyramid
        ///     *
        ///    ***
        ///   *****
        ///  *******
        /// *********
        /// </summary>
        public static void Pyramid(int rows = 5)
        {
            Console.WriteLine("\n=== Pattern 4: Pyramid ===");
            
            for (int i = 1; i <= rows; i++)
            {
                // Print spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pattern 5: Inverted Pyramid
        /// *********
        ///  *******
        ///   *****
        ///    ***
        ///     *
        /// </summary>
        public static void InvertedPyramid(int rows = 5)
        {
            Console.WriteLine("\n=== Pattern 5: Inverted Pyramid ===");
            
            for (int i = rows; i >= 1; i--)
            {
                // Print spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pattern 6: Diamond
        /// </summary>
        public static void Diamond(int rows = 5)
        {
            Console.WriteLine("\n=== Pattern 6: Diamond ===");
            
            // Upper half
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            // Lower half
            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pattern 7: Square
        /// *****
        /// *****
        /// *****
        /// *****
        /// *****
        /// </summary>
        public static void Square(int rows = 5)
        {
            Console.WriteLine("\n=== Pattern 7: Square ===");
            
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pattern 8: Hollow Square
        /// *****
        /// *   *
        /// *   *
        /// *   *
        /// *****
        /// </summary>
        public static void HollowSquare(int rows = 5)
        {
            Console.WriteLine("\n=== Pattern 8: Hollow Square ===");
            
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (i == 1 || i == rows || j == 1 || j == rows)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pattern 9: Number Triangle
        /// 1
        /// 12
        /// 123
        /// 1234
        /// 12345
        /// </summary>
        public static void NumberTriangle(int rows = 5)
        {
            Console.WriteLine("\n=== Pattern 9: Number Triangle ===");
            
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pattern 10: Number Pyramid
        ///     1
        ///    123
        ///   12345
        ///  1234567
        /// 123456789
        /// </summary>
        public static void NumberPyramid(int rows = 5)
        {
            Console.WriteLine("\n=== Pattern 10: Number Pyramid ===");
            
            for (int i = 1; i <= rows; i++)
            {
                // Print spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                // Print numbers
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Run all star pattern examples
        /// </summary>
        public static void RunAll()
        {
            RightTriangle();
            InvertedRightTriangle();
            RightAlignedTriangle();
            Pyramid();
            InvertedPyramid();
            Diamond();
            Square();
            HollowSquare();
            NumberTriangle();
            NumberPyramid();
        }
    }
}
