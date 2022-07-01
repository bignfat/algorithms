namespace src;
public class Mergesort
{
    // 1. Split on two arrays
    // 2. Sort two parts separately
    // 3. Merge two sorted part into one array
    public static void Sort(int[] array)
    {
        var aux = new int[array.Length];

        Sort(array, aux, 0, array.Length - 1);
    }

    private static void Merge(int[] array, int[] aux, int start, int middle, int end)
    {
        for (var z = start; z <= end; z++)
            aux[z] = array[z];

        var i = start;
        var j = middle + 1;

        for (var k = start; k <= end; k++)
        {
            if (i > middle)
            {
                array[k] = aux[j++];
                continue;
            }

            if (j > end)
            {
                array[k] = aux[i++];
                continue;
            }

            if (aux[i] <= aux[j])
                array[k] = aux[i++];
            else
                array[k] = aux[j++];
        }
    }

    private static void Sort(int[] array, int[] aux, int start, int end)
    {
        if (start >= end)
            return;

        var middle = Math.Abs((end - start) / 2) + start;

        Sort(array, aux, start, middle);
        Sort(array, aux, middle + 1, end);
        Merge(array, aux, start, middle, end);
    }
}
