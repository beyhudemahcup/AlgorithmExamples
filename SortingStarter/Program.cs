using BubbleSort;
using InsertionSort;
using MergeSort;
using Microsoft.Extensions.DependencyInjection;
using QuickSort;
using SelectionSort;
using ShellSort;
using System.Timers;

namespace SortingStarter
{
    class Program
    {
        public static void Main(string[] args)
        {
            //lets do the DI configurations
            var serviceProvider = new ServiceCollection()
                 .AddTransient<IQuickSort, QuickSort.QuickSort>()
                 .AddTransient<IMergeSort, MergeSort.MergeSort>()
                 .AddTransient<IInsertionSort, InsertionSort.InsertionSort>()
                 .AddTransient<IBubbleSort, BubbleSort.BubbleSort>()
                 .AddTransient<ISelectionSort, SelectionSort.SelectionSort>()
                 .AddTransient<IShellSort, ShellSort.ShellSort>()
                 .AddTransient<SortingService>()
                 .BuildServiceProvider();

            var sortingService = serviceProvider.GetRequiredService<SortingService>();

            //now calculate which sorting algorithm faster :)

            int length = 1000;

            int[] orderedArray1 = SortingService.CreateOrderedArray(length);
            int[] randomArray1 = SortingService.CreateArray(length);

            int[] randomArray2 = randomArray1;
            int[] randomArray3 = randomArray1;
            int[] randomArray4 = randomArray1;
            int[] randomArray5 = randomArray1;
            int[] randomArray6 = randomArray1;

            int[] orderedArray2 = orderedArray1;
            int[] orderedArray3 = orderedArray1;
            int[] orderedArray4 = orderedArray1;
            int[] orderedArray5 = orderedArray1;
            int[] orderedArray6 = orderedArray1;


            //time calculations 

            Console.WriteLine($"The number of the variables in the array is {length}");
            long startTime = DateTime.Now.Ticks;

            // Run QuickSort
            sortingService.RunQuickSort(randomArray1);
            //sortingService.RunQuickSort(orderedArray1);

            long endTime = DateTime.Now.Ticks;
            SortingService.TimeCalculator(startTime, endTime);

            startTime = DateTime.Now.Ticks;
            // Run MergeSort
            sortingService.RunMergeSort(randomArray2);
            //sortingService.RunQuickSort(orderedArray2);

            endTime = DateTime.Now.Ticks;
            SortingService.TimeCalculator(startTime, endTime);

            startTime = DateTime.Now.Ticks;
            // Run BubbleSort
            sortingService.RunBubbleSort(randomArray3);
            //sortingService.RunQuickSort(orderedArray3);

            endTime = DateTime.Now.Ticks;
            SortingService.TimeCalculator(startTime, endTime);

            startTime = DateTime.Now.Ticks;
            // Run InsertionSort
            sortingService.RunInsertionSort(randomArray4);
            //sortingService.RunQuickSort(orderedArray4);

            endTime = DateTime.Now.Ticks;
            SortingService.TimeCalculator(startTime, endTime);

            startTime = DateTime.Now.Ticks;
            // Run SelectionSort
            sortingService.RunSelectionSort(randomArray5);
            //sortingService.RunQuickSort(orderedArray5);

            endTime = DateTime.Now.Ticks;
            SortingService.TimeCalculator(startTime, endTime);

            startTime = DateTime.Now.Ticks;
            // Run ShellSort
            sortingService.RunShellSort(randomArray6);
            //sortingService.RunQuickSort(orderedArray6);

            endTime = DateTime.Now.Ticks;
            SortingService.TimeCalculator(startTime, endTime);
     
            Console.Read();
        }
    }
}