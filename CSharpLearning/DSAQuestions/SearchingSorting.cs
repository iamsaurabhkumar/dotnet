using System;

namespace CSharpLearning.DSAQuestions
{
    /// <summary>
    /// Searching and Sorting Algorithms
    /// </summary>
    public class SearchingSorting
    {
        /// <summary>
        /// Linear Search - O(n)
        /// </summary>
        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Binary Search - O(log n) - Array must be sorted
        /// </summary>
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (arr[mid] == target)
                    return mid;
                
                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            
            return -1;
        }

        /// <summary>
        /// Bubble Sort - O(n²)
        /// </summary>
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Selection Sort - O(n²)
        /// </summary>
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                
                // Swap
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        /// <summary>
        /// Insertion Sort - O(n²)
        /// </summary>
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                
                arr[j + 1] = key;
            }
        }

        /// <summary>
        /// Quick Sort - O(n log n) average, O(n²) worst case
        /// </summary>
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;
            
            return i + 1;
        }

        /// <summary>
        /// Merge Sort - O(n log n)
        /// </summary>
        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];
            
            for (int i = 0; i < n1; i++)
                leftArr[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArr[j] = arr[mid + 1 + j];
            
            int i_idx = 0, j_idx = 0;
            int k = left;
            
            while (i_idx < n1 && j_idx < n2)
            {
                if (leftArr[i_idx] <= rightArr[j_idx])
                {
                    arr[k] = leftArr[i_idx];
                    i_idx++;
                }
                else
                {
                    arr[k] = rightArr[j_idx];
                    j_idx++;
                }
                k++;
            }
            
            while (i_idx < n1)
            {
                arr[k] = leftArr[i_idx];
                i_idx++;
                k++;
            }
            
            while (j_idx < n2)
            {
                arr[k] = rightArr[j_idx];
                j_idx++;
                k++;
            }
        }

        /// <summary>
        /// Run all searching and sorting examples
        /// </summary>
        public static void RunAll()
        {
            Console.WriteLine("=== Searching and Sorting Algorithms ===\n");
            
            // Searching
            int[] searchArr = { 2, 5, 8, 12, 16, 23, 38, 45, 67, 78 };
            int target = 23;
            Console.WriteLine($"Linear Search for {target}: Index {LinearSearch(searchArr, target)}");
            Console.WriteLine($"Binary Search for {target}: Index {BinarySearch(searchArr, target)}");
            
            // Sorting
            int[] sortArr1 = { 64, 34, 25, 12, 22, 11, 90 };
            int[] sortArr2 = (int[])sortArr1.Clone();
            int[] sortArr3 = (int[])sortArr1.Clone();
            int[] sortArr4 = (int[])sortArr1.Clone();
            int[] sortArr5 = (int[])sortArr1.Clone();
            
            Console.WriteLine($"\nOriginal array: [{string.Join(", ", sortArr1)}]");
            
            BubbleSort(sortArr1);
            Console.WriteLine($"Bubble Sort: [{string.Join(", ", sortArr1)}]");
            
            SelectionSort(sortArr2);
            Console.WriteLine($"Selection Sort: [{string.Join(", ", sortArr2)}]");
            
            InsertionSort(sortArr3);
            Console.WriteLine($"Insertion Sort: [{string.Join(", ", sortArr3)}]");
            
            QuickSort(sortArr4, 0, sortArr4.Length - 1);
            Console.WriteLine($"Quick Sort: [{string.Join(", ", sortArr4)}]");
            
            MergeSort(sortArr5, 0, sortArr5.Length - 1);
            Console.WriteLine($"Merge Sort: [{string.Join(", ", sortArr5)}]");
        }
    }
}
