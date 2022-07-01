namespace test;
public class TestMergesort
{
    [Fact]
    public void CheckNumbersSort()
    {
        var notsorted = new int[50];
        var sorted = new int[50];

        for (int i = 0; i < notsorted.Length; i++)
        {
            notsorted[i] = Random.Shared.Next(100);
            sorted[i] = notsorted[i];
        }

        Array.Sort(sorted);
        Mergesort.Sort(notsorted);

        Assert.Equal(sorted, notsorted);
    }

    [Fact]
    public void CheckNumbersWithNegativeSort()
    {
        var notsorted = new int[50];
        var sorted = new int[50];

        for (int i = 0; i < notsorted.Length; i++)
        {
            notsorted[i] = Random.Shared.Next(100) - 50;
            sorted[i] = notsorted[i];
        }

        Array.Sort(sorted);
        Mergesort.Sort(notsorted);

        Assert.Equal(sorted, notsorted);
    }

    [Fact]
    public void CheckReverseNumbersSort()
    {
        var notsorted = new int[50];
        var sorted = new int[50];

        for (int i = 0; i < notsorted.Length; i++)
        {
            notsorted[i] = 50 - i;
            sorted[i] = notsorted[i];
        }

        Array.Sort(sorted);
        Mergesort.Sort(notsorted);

        Assert.Equal(sorted, notsorted);
    }
}
