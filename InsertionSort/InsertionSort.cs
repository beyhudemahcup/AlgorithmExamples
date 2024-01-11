namespace InsertionSort
{
    public class InsertionSort : IInsertionSort
    {
        public void InsertionSorting(int[] arr)
        {
            int temp;

            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    //swapping process
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
     
    }
}