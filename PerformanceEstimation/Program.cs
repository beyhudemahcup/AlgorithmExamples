using Microsoft.Extensions.DependencyInjection;

namespace PerformanceEstimation
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = new ServiceCollection()
             .AddTransient<IQuickSort, QuickSort>()
             .AddTransient<IMergeSort, MergeSort>()
             .AddTransient<SortingService>()
             .BuildServiceProvider();

            var sortingService = serviceProvider.GetRequiredService<SortingService>();

            // Run QuickSort
            sortingService.RunQuickSort();

            // Run MergeSort
            sortingService.RunMergeSort();









            int length = 10000;

            int[] orderedArray = CreateOrderedArray(length);
            int[] randomArray1 = CreateArray(length);

            int[] randomArray2 = randomArray1;
            int[] randomArray3 = randomArray1;
            int[] randomArray4 = randomArray1;
            int[] randomArray5 = randomArray1;
            int[] randomArray6 = randomArray1;


            //lets do powering estimations

            DateTime moment = DateTime.Now;

            long startTime;
            long endTime;

            double estimatedTime;

            startTime = (long) Convert.ToDouble(moment);
            
            //sorting process
            
            endTime = (long) Convert.ToDouble(moment);
            estimatedTime = endTime - startTime;

            Console.Read();

        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(",", arr));
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
    }
}