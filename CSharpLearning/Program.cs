using System;
using CSharpLearning.BasicPrograms;
using CSharpLearning.StarPatterns;
using CSharpLearning.BeginnerExamples;
using CSharpLearning.DSAQuestions;

namespace CSharpLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║     C# Learning Project - From Basics to DSA            ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("\n═══════════════════════════════════════════════════════════");
                Console.WriteLine("Select a category to explore:");
                Console.WriteLine("═══════════════════════════════════════════════════════════");
                Console.WriteLine("1. Basic Programs (Swapping, Arithmetic, Number Operations)");
                Console.WriteLine("2. Star Patterns");
                Console.WriteLine("3. Beginner Examples (For Laymen)");
                Console.WriteLine("4. DSA Questions - Array Problems");
                Console.WriteLine("5. DSA Questions - String Problems");
                Console.WriteLine("6. DSA Questions - Searching & Sorting");
                Console.WriteLine("7. Run All Examples");
                Console.WriteLine("0. Exit");
                Console.WriteLine("═══════════════════════════════════════════════════════════");
                Console.Write("\nEnter your choice: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n╔══════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║              BASIC PROGRAMS                              ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════════════╝\n");
                        SwappingPrograms.RunAll();
                        Console.WriteLine("\n" + new string('-', 60) + "\n");
                        ArithmeticOperations.RunAll();
                        Console.WriteLine("\n" + new string('-', 60) + "\n");
                        NumberOperations.RunAll();
                        break;

                    case "2":
                        Console.WriteLine("\n╔══════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║              STAR PATTERNS                                ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════════════╝\n");
                        StarPatterns.StarPatterns.RunAll();
                        break;

                    case "3":
                        Console.WriteLine("\n╔══════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║         BEGINNER EXAMPLES (For Laymen)                   ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════════════╝\n");
                        BeginnerBasics.RunAll();
                        break;

                    case "4":
                        ArrayProblems.RunAll();
                        break;

                    case "5":
                        StringProblems.RunAll();
                        break;

                    case "6":
                        SearchingSorting.RunAll();
                        break;

                    case "7":
                        Console.WriteLine("\n╔══════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║              RUNNING ALL EXAMPLES                        ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════════════╝\n");
                        
                        Console.WriteLine("\n=== BASIC PROGRAMS ===");
                        SwappingPrograms.RunAll();
                        ArithmeticOperations.RunAll();
                        NumberOperations.RunAll();
                        
                        Console.WriteLine("\n\n=== STAR PATTERNS ===");
                        StarPatterns.StarPatterns.RunAll();
                        
                        Console.WriteLine("\n\n=== BEGINNER EXAMPLES ===");
                        BeginnerBasics.RunAll();
                        
                        Console.WriteLine("\n\n=== DSA QUESTIONS ===");
                        ArrayProblems.RunAll();
                        StringProblems.RunAll();
                        SearchingSorting.RunAll();
                        break;

                    case "0":
                        Console.WriteLine("Thank you for using C# Learning Project! Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
