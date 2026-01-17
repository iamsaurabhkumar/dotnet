using System;
using System.Text;

namespace CSharpLearning.DSAQuestions
{
    /// <summary>
    /// String-based Data Structures and Algorithms problems
    /// </summary>
    public class StringProblems
    {
        /// <summary>
        /// Problem 1: Reverse a string
        /// </summary>
        public static string ReverseString(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Problem 2: Check if string is palindrome
        /// </summary>
        public static bool IsPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;
            
            str = str.ToLower().Replace(" ", "");
            int left = 0;
            int right = str.Length - 1;
            
            while (left < right)
            {
                if (str[left] != str[right])
                    return false;
                left++;
                right--;
            }
            
            return true;
        }

        /// <summary>
        /// Problem 3: Count vowels in a string
        /// </summary>
        public static int CountVowels(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;
            
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int count = 0;
            
            foreach (char c in str)
            {
                if (Array.IndexOf(vowels, c) >= 0)
                    count++;
            }
            
            return count;
        }

        /// <summary>
        /// Problem 4: Remove duplicates from string
        /// </summary>
        public static string RemoveDuplicates(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            
            System.Collections.Generic.HashSet<char> seen = new System.Collections.Generic.HashSet<char>();
            StringBuilder result = new StringBuilder();
            
            foreach (char c in str)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    result.Append(c);
                }
            }
            
            return result.ToString();
        }

        /// <summary>
        /// Problem 5: Find first non-repeating character
        /// </summary>
        public static char? FindFirstNonRepeating(string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;
            
            System.Collections.Generic.Dictionary<char, int> charCount = new System.Collections.Generic.Dictionary<char, int>();
            
            // Count occurrences
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }
            
            // Find first character with count 1
            foreach (char c in str)
            {
                if (charCount[c] == 1)
                    return c;
            }
            
            return null;
        }

        /// <summary>
        /// Problem 6: Check if two strings are anagrams
        /// </summary>
        public static bool AreAnagrams(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;
            
            if (str1.Length != str2.Length)
                return false;
            
            char[] arr1 = str1.ToLower().ToCharArray();
            char[] arr2 = str2.ToLower().ToCharArray();
            
            Array.Sort(arr1);
            Array.Sort(arr2);
            
            return new string(arr1) == new string(arr2);
        }

        /// <summary>
        /// Problem 7: Count words in a string
        /// </summary>
        public static int CountWords(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;
            
            string[] words = str.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        /// <summary>
        /// Problem 8: Reverse words in a string
        /// </summary>
        public static string ReverseWords(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return str;
            
            string[] words = str.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        /// <summary>
        /// Problem 9: Check if string contains only digits
        /// </summary>
        public static bool IsNumeric(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            
            return true;
        }

        /// <summary>
        /// Problem 10: Longest common prefix
        /// </summary>
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            
            if (strs.Length == 1)
                return strs[0];
            
            string prefix = strs[0];
            
            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix))
                        return "";
                }
            }
            
            return prefix;
        }

        /// <summary>
        /// Run all string problem examples
        /// </summary>
        public static void RunAll()
        {
            Console.WriteLine("=== String DSA Problems ===\n");
            
            // Problem 1
            string str1 = "Hello";
            Console.WriteLine($"Problem 1 - Original: {str1}, Reversed: {ReverseString(str1)}");
            
            // Problem 2
            string str2 = "racecar";
            Console.WriteLine($"Problem 2 - Is '{str2}' palindrome: {IsPalindrome(str2)}");
            
            // Problem 3
            string str3 = "Hello World";
            Console.WriteLine($"Problem 3 - Vowels in '{str3}': {CountVowels(str3)}");
            
            // Problem 4
            string str4 = "programming";
            Console.WriteLine($"Problem 4 - Original: {str4}, Without duplicates: {RemoveDuplicates(str4)}");
            
            // Problem 5
            string str5 = "programming";
            Console.WriteLine($"Problem 5 - First non-repeating in '{str5}': {FindFirstNonRepeating(str5)}");
            
            // Problem 6
            string str6a = "listen";
            string str6b = "silent";
            Console.WriteLine($"Problem 6 - Are '{str6a}' and '{str6b}' anagrams: {AreAnagrams(str6a, str6b)}");
            
            // Problem 7
            string str7 = "Hello World from C#";
            Console.WriteLine($"Problem 7 - Word count in '{str7}': {CountWords(str7)}");
            
            // Problem 8
            string str8 = "Hello World from C#";
            Console.WriteLine($"Problem 8 - Original: {str8}, Reversed words: {ReverseWords(str8)}");
            
            // Problem 9
            string str9a = "12345";
            string str9b = "123a45";
            Console.WriteLine($"Problem 9 - Is '{str9a}' numeric: {IsNumeric(str9a)}");
            Console.WriteLine($"Problem 9 - Is '{str9b}' numeric: {IsNumeric(str9b)}");
            
            // Problem 10
            string[] strs = { "flower", "flow", "flight" };
            Console.WriteLine($"Problem 10 - Longest common prefix: {LongestCommonPrefix(strs)}");
        }
    }
}
