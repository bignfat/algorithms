namespace src;

public class MergesortBottomUp : ISortAlgorithm<int>
{
    public void Sort(int[] array)
    {
        var aux = new int[array.Length];

        for (var length = 1; length < array.Length; length = length * 2)
        {
            for (var start = 0; start < array.Length; start += length)
            {
                var end = start + 2 * length - 1;
                var middle = start + length;
                Merge(array, aux, start, middle, end);
            }
        }
    }

    private void Merge(int[] array, int[] aux, int start, int middle, int end)
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
}
