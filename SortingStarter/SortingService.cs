using BubbleSort;
using InsertionSort;
using MergeSort;
using QuickSort;
using SelectionSort;
using ShellSort;
using System.Diagnostics;

namespace SortingStarter
{
    internal class SortingService
    {
        private readonly IQuickSort _quickSort;
        private readonly IMergeSort _mergeSort;
        private readonly IBubbleSort _bubbleSort;
        private readonly IInsertionSort _insertionSort;
        private readonly IShellSort _shellSort;
        private readonly ISelectionSort _selectionSort;

        public SortingService(IQuickSort quickSort, IMergeSort mergeSort, IBubbleSort bubbleSort,
            IInsertionSort insertionSort, IShellSort shellSort, ISelectionSort selectionSort)
        {
            _insertionSort = insertionSort;
            _shellSort = shellSort;
            _selectionSort = selectionSort;
            _bubbleSort = bubbleSort;
            _quickSort = quickSort;
            _mergeSort = mergeSort;
        }

        public void RunQuickSort(int[] arr)
        {
            //it looks like finding a word in a vocabulary book :)

            //chooses random pivot number
            //orders smaller numbers to the left side of the pivot number, bigger numbers to the right side of the pivot number 
            //does this again

            //time complexity => worst case senario = O(n^2), but approximately = O(n*logn)
            //memory usage => worst case senario = O(n), also its recursive 

            //array before the quick sorting
            PrintArray("before", "quick", arr);

            _quickSort.QuickSorting(arr, 0, arr.Length - 1);

            //array after the quick sorting
            PrintArray("after", "quick", arr);
        }

        public void RunMergeSort(int[] arr)
        {
            //time complexity => approximately O(n*logn)
            //memory usage => O(n)

            //array before the merge sorting
            PrintArray("before", "merge", arr);

            _mergeSort.MergeSorting(arr, 0, arr.Length - 1);

            //array after the merge sorting
            PrintArray("after", "merge", arr);
        }

        public void RunBubbleSort(int[] arr)
        {
            //time complexity => O(n^2)
            //memory usage => O(1), one temp variable is enough 

            //bubble sort is better when the array has less data in it.


            //array before the bubble sorting
            PrintArray("before", "bubble", arr);

            _bubbleSort.BubbleSorting(arr);

            //array after the bubble sorting
            PrintArray("after", "bubble", arr);
        }

        public void RunInsertionSort(int[] arr)
        {
            //insertion sorting example
            //{ 2, 4, 5, 3, 1, 6}
            //this is the first version of the array. All I want to order all the numbers smaller to the bigger.
            //{ 2, 4, 5, 5, 1, 6}
            //{ 2, 4, 4, 5, 1, 6}
            //{ 2, 3, 4, 5, 1, 6}

            //{ 2, 3, 4, 5, 5, 6}
            //{ 2, 3, 4, 4, 5, 6}
            //{ 2, 3, 3, 4, 5, 6}
            //{ 2, 2, 3, 4, 5, 6}
            //{ 1, 2, 3, 4, 5, 6}

            //time complexity ranges from best O(n) to worst O(n^2) 
            //memory usage = 1

            //array before the insertion sorting
            PrintArray("before", "insertion", arr);

            _insertionSort.InsertionSorting(arr);

            //array after the insertion sorting
            PrintArray("after", "insertion", arr);

        }

        public void RunSelectionSort(int[] arr)
        {
            //compare every element of the data to each other 
            //if the element bigger than the rest of the list,
            //change the space with the smallest number

            //time complexity of this calculation is => O(n^2) (Quadratic Complexity)
            //memory usage => 1 because we only need 1 space for temp data.

            //int[] arr = [1, 3, 5, 4, 2, 7];

            // { 1, 3, 5, 4, 2, 7 }; 
            // { 1, 2, 5, 4, 2, 7 }; => temp = 3
            // { 1, 2, 5, 4, 3, 7 };

            // { 1, 2, 5, 4, 3, 7 };
            // { 1, 2, 3, 4, 3, 7 }; => temp = 5

            // { 1, 2, 3, 4, 5, 7 }; // now its done :)

            //array before the selection sorting
            PrintArray("before", "selection ", arr);

            _selectionSort.SelectionSorting(arr);

            //array after the selection sorting
            PrintArray("after", "selection ", arr);
        }

        public void RunShellSort(int[] arr)
        {
            /*
             * [6, 8, 3, 5, 1, 4, 2, 7]
             * 
             * gap = 4
             * 
             * creates sub-array according to the gap number and then sorts those numbers column by column
             * 
             * 6, 8, 3, 5 -->   1, 4, 2, 5
             * 1, 4, 2, 7       6, 8, 3, 7
             * 
             * [1, 4, 2, 5, 6, 8, 3, 7]
             * now it does the same thing with gap 2 (we decide this but even number would be better for dividing the work evenly)
             *
             * gap = 2
             *
             * 1, 4            1, 4 
             * 6, 8     -->    2, 5 
             * 2, 5            3, 7
             * 3, 7            6, 8
             * 
             * [1, 4, 2, 5, 3, 7, 6, 8]
             * 
             * it does the same thing again and again..
             */

            //time complexity => approximately O(n*logn)
            //memory usage => O(n)

            //array before the shell sorting
            PrintArray("before", "shell", arr);

            _shellSort.ShellSorting(arr);

            //array after the shell sorting
            PrintArray("after", "shell", arr);

        }

        public static int[] CreateArray(int listNumber)
        {
            int[] arr = new int[listNumber];
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10000);
            }

            return arr;
        }

        public static int[] CreateOrderedArray(int listNumber)
        {
            int[] arr = new int[listNumber];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            return arr;
        }

        public static void TimeCalculator(long startTime, long endTime)
        {
            long elapsedTimeTicks = endTime - startTime;

            TimeSpan elapsedTime = new TimeSpan(elapsedTimeTicks);

            Console.WriteLine("*****************************");
            Console.WriteLine($"Time elapsed: {elapsedTime.TotalMilliseconds} milliseconds");
        }

        public void PrintArray(string text, string text2, int[] arr)
        {
            Console.WriteLine("*****************************");
            //Console.WriteLine($"Array {text} the {text2} sorting: {string.Join(",", arr)}");
            Console.WriteLine($"Array {text} the {text2} sorting: ");
        }
    }
}
