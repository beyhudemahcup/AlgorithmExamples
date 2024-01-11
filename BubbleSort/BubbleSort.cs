namespace BubbleSort
{
    public class BubbleSort:IBubbleSort
    {
        public void BubbleSorting(int[] arr)
        {
            bool swapped = false;

            do
            {
                swapped = false;//preventing infinite loop

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        //swapping process
                        int temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;

                        swapped = true;
                    }
                }
            }

            while (swapped);
        }
    }

}