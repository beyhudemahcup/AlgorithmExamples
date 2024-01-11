
namespace PerformanceEstimation
{
    internal class SortingService
    {
        private readonly IQuickSort _quickSort;
        private readonly IMergeSort _mergeSort;

        public SortingService(IQuickSort quickSort, IMergeSort mergeSort)
        {
            _quickSort = quickSort;
            _mergeSort = mergeSort;
        }

        public void RunQuickSort()
        {
            int[] array = { /* your array values */ };
            _quickSort.QuickSorting(array, 0, array.Length - 1);
            Console.WriteLine("QuickSort: " + string.Join(",", array));
        }

        public void RunMergeSort()
        {
            int[] array = { /* your array values */ };
            _mergeSort.MergeSorting(array, 0, array.Length - 1);
            Console.WriteLine("MergeSort: " + string.Join(",", array));
        }
    }
}
