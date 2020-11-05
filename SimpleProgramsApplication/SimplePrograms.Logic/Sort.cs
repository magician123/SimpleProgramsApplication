namespace SimplePrograms.Logic
{
    public class Sort
    {
        public int[] SortArray(int[] array)
        {
          
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {

                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }

            }

            return array;


        }
    }
}
