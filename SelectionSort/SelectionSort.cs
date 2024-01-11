
namespace SelectionSort
{
    public class SelectionSort : ISelectionSort
    {
        public void SelectionSorting(int[] arr)
        {
            int minNumber;

            for (int i = 0; i < arr.Length; i++)
            {
                minNumber = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minNumber])
                    {
                        minNumber = j;
                    }
                }

                //swap process
                int temp = arr[i];
                arr[i] = arr[minNumber];
                arr[minNumber] = temp;
            }
        }
    }
}