
namespace ShellSort
{
    public class ShellSort: IShellSort
    {
        public void ShellSorting(int[] arr)
        {
            int insert;
            int moveItem;

            for (int gap = arr.Length; gap > 0; gap /= 2)
            {
                for (int next = gap; next < arr.Length; next++)
                {
                    insert = arr[next];
                    moveItem = next;

                    while (moveItem >= gap && insert < arr[moveItem - gap])
                    {
                        arr[moveItem] = arr[moveItem - gap];
                        moveItem -= gap;
                    }
                    
                    arr[moveItem] = insert;
                }
            }
        }
    }
}
