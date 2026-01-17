using System;
using System.Linq;

namespace CSharpLearning.DSAQuestions
{
    /// <summary>
    /// Array-based Data Structures and Algorithms problems
    /// </summary>
    public class ArrayProblems
    {
        /// <summary>
        /// Problem 1: Find the largest element in an array
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        public static int FindLargest(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array is empty or null");
            
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        /// <summary>
        /// Problem 2: Find the second largest element in an array
        /// </summary>
        public static int FindSecondLargest(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                throw new ArgumentException("Array must have at least 2 elements");
            
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            
            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }
            
            return secondLargest;
        }

        /// <summary>
        /// Problem 3: Reverse an array
        /// </summary>
        public static void ReverseArray(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;
            
            int left = 0;
            int right = arr.Length - 1;
            
            while (left < right)
            {
                // Swap elements
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                
                left++;
                right--;
            }
        }

        /// <summary>
        /// Problem 4: Find if array contains duplicates
        /// </summary>
        public static bool ContainsDuplicates(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return false;
            
            System.Collections.Generic.HashSet<int> seen = new System.Collections.Generic.HashSet<int>();
            
            foreach (int num in arr)
            {
                if (seen.Contains(num))
                    return true;
                seen.Add(num);
            }
            
            return false;
        }

        /// <summary>
        /// Problem 5: Move all zeros to end of array
        /// </summary>
        public static void MoveZerosToEnd(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;
            
            int nonZeroIndex = 0;
            
            // Move all non-zero elements to the front
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[nonZeroIndex] = arr[i];
                    nonZeroIndex++;
                }
            }
            
            // Fill remaining positions with zeros
            while (nonZeroIndex < arr.Length)
            {
                arr[nonZeroIndex] = 0;
                nonZeroIndex++;
            }
        }

        /// <summary>
        /// Problem 6: Find missing number in array (1 to n)
        /// </summary>
        public static int FindMissingNumber(int[] arr, int n)
        {
            int expectedSum = n * (n + 1) / 2;
            int actualSum = arr.Sum();
            return expectedSum - actualSum;
        }

        /// <summary>
        /// Problem 7: Find two numbers that sum to target
        /// Returns indices of two numbers that add up to target
        /// </summary>
        public static int[] TwoSum(int[] arr, int target)
        {
            System.Collections.Generic.Dictionary<int, int> map = new System.Collections.Generic.Dictionary<int, int>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[arr[i]] = i;
            }
            
            return new int[] { -1, -1 }; // Not found
        }

        /// <summary>
        /// Problem 8: Rotate array to the right by k positions
        /// </summary>
        public static void RotateArray(int[] arr, int k)
        {
            if (arr == null || arr.Length <= 1 || k == 0)
                return;
            
            k = k % arr.Length; // Handle k > array length
            ReverseArray(arr, 0, arr.Length - 1);
            ReverseArray(arr, 0, k - 1);
            ReverseArray(arr, k, arr.Length - 1);
        }

        private static void ReverseArray(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        /// <summary>
        /// Problem 9: Find maximum subarray sum (Kadane's Algorithm)
        /// </summary>
        public static int MaxSubarraySum(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;
            
            int maxSum = arr[0];
            int currentSum = arr[0];
            
            for (int i = 1; i < arr.Length; i++)
            {
                currentSum = Math.Max(arr[i], currentSum + arr[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            
            return maxSum;
        }

        /// <summary>
        /// Problem 10: Find peak element (element greater than neighbors)
        /// </summary>
        public static int FindPeakElement(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return -1;
            
            if (arr.Length == 1)
                return 0;
            
            // Check first element
            if (arr[0] > arr[1])
                return 0;
            
            // Check last element
            if (arr[arr.Length - 1] > arr[arr.Length - 2])
                return arr.Length - 1;
            
            // Check middle elements
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    return i;
            }
            
            return -1; // No peak found
        }

        /// <summary>
        /// Run all array problem examples
        /// </summary>
        public static void RunAll()
        {
            Console.WriteLine("=== Array DSA Problems ===\n");
            
            // Problem 1
            int[] arr1 = { 3, 5, 1, 9, 2, 7 };
            Console.WriteLine($"Problem 1 - Largest element: {FindLargest(arr1)}");
            
            // Problem 2
            Console.WriteLine($"Problem 2 - Second largest: {FindSecondLargest(arr1)}");
            
            // Problem 3
            int[] arr3 = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Problem 3 - Original: [{string.Join(", ", arr3)}]");
            ReverseArray(arr3);
            Console.WriteLine($"Problem 3 - Reversed: [{string.Join(", ", arr3)}]");
            
            // Problem 4
            int[] arr4 = { 1, 2, 3, 2, 4 };
            Console.WriteLine($"Problem 4 - Contains duplicates: {ContainsDuplicates(arr4)}");
            
            // Problem 5
            int[] arr5 = { 0, 1, 0, 3, 12 };
            Console.WriteLine($"Problem 5 - Original: [{string.Join(", ", arr5)}]");
            MoveZerosToEnd(arr5);
            Console.WriteLine($"Problem 5 - After moving zeros: [{string.Join(", ", arr5)}]");
            
            // Problem 6
            int[] arr6 = { 1, 2, 4, 5, 6 };
            Console.WriteLine($"Problem 6 - Missing number: {FindMissingNumber(arr6, 6)}");
            
            // Problem 7
            int[] arr7 = { 2, 7, 11, 15 };
            int[] result = TwoSum(arr7, 9);
            Console.WriteLine($"Problem 7 - Two sum indices: [{result[0]}, {result[1]}]");
            
            // Problem 8
            int[] arr8 = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Problem 8 - Original: [{string.Join(", ", arr8)}]");
            RotateArray(arr8, 2);
            Console.WriteLine($"Problem 8 - Rotated by 2: [{string.Join(", ", arr8)}]");
            
            // Problem 9
            int[] arr9 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine($"Problem 9 - Max subarray sum: {MaxSubarraySum(arr9)}");
            
            // Problem 10
            int[] arr10 = { 1, 3, 2, 5, 4 };
            int peakIndex = FindPeakElement(arr10);
            Console.WriteLine($"Problem 10 - Peak element at index: {peakIndex}");
        }
    }
}
