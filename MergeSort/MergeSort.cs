namespace MergeSort
{
    public class MergeSort : IMergeSort
    {

        public void Merge(int[] arr, int left, int middle, int right)
        {
            //left side of the partitial array always has one more variable in it
            //also it can be the right but I choose it like this

            int low = (middle - left) + 1; //the size of the left side array
            int high = right - middle; //the size of the right side array

            //created left and right array according to the int value is taken from existing array
            int[] leftArray = new int[low];
            int[] rightArray = new int[high];

            int i = 0, j = 0;

            for (; i < low; i++)//saves memory via preventing to create i variable every for loop
            {
                leftArray[i] = arr[left + i];//copys variables to the left array 
            }

            for (; j < high; j++)
            {
                rightArray[j] = arr[middle + 1 + j];//copys variables to the right array 
            }


            int k = left;
            i = 0; j = 0;

            while (i < low && j < high)//merging process
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }

                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }

                k++;
            }

            while (i < low)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < high)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
        }

        public void MergeSorting(int[] arr, int left, int right)
        {
            int middle;
            if (right > left)
            {
                middle = (left + right) / 2;

                MergeSorting(arr, left, middle); //left array

                MergeSorting(arr, middle + 1, right); //right array

                Merge(arr, left, middle, right);//merging with right and left array
            }
        }
    }
}