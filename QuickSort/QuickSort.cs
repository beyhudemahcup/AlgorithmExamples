namespace QuickSort
{
    public class QuickSort : IQuickSort
    {
        public int Partition(int[] arr, int bottom, int top)
        {
            //last variable of the array will be choosen as a pivot number
            //it can be any number but I want to design like that

            int pivotNumber = arr[top];
            int i = bottom - 1;

            //now, smaller numbers go to left, bigger numbers go to right of the pivot number

            for (int j = bottom; j < top; j++)
            {
                if (arr[j] <= pivotNumber)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp2 = arr[i + 1];
            arr[i + 1] = arr[top];
            arr[top] = temp2;

            return i + 1;
        }

        public void QuickSorting(int[] arr, int bottom, int top)
        {
            if (bottom < top)
            {
                int _pivotNumber = Partition(arr, bottom, top);

                QuickSorting(arr, bottom, top - 1);//works recursive for the left side of the pivotNumber

                QuickSorting(arr, _pivotNumber + 1, top);//works recursive for the right side of the pivotNumber
            }

        }
    }
}