namespace test;

public abstract class SortFacts<T, K> where T : ISortAlgorithm<K>
{
    [Theory, AutoRepositoryData]
    public void CheckSortAlgorithm(ISortAlgorithm<K> sortAlgorithm, K[] input)
    {
        var expected = new K[input.Length];
        
        Array.Copy(input, expected, input.Length);
        Array.Sort(expected);
        
        sortAlgorithm.Sort(input);

        Assert.Equal<K>(expected, input);
    }
}

public class MergesortNumbersFacts : SortFacts<Mergesort, int> { }
public class MergesortBottomUpNumbersFacts : SortFacts<MergesortBottomUp, int> { }

public class SortFacts
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
        new Mergesort().Sort(notsorted);

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
        new Mergesort().Sort(notsorted);

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
        new Mergesort().Sort(notsorted);

        Assert.Equal(sorted, notsorted);
    }
}
