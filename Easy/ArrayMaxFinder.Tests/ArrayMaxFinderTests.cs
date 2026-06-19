
namespace FterDev.Easy.ArrayMaxFinder.Tests;

public class ArrayMaxFinderTests
{
    
    [Fact]
    public void FindMax_GivenFiveNums_ShouldReturnHighest()
    {
        int[] nums = [6, 9, 2, 0, 1];
        int expected = 9;

        var arrayMaxFinder = new ArrayMaxFinder();
        var max = arrayMaxFinder.FindMax(nums);

        Assert.Equal(expected, max);
    }

    [Fact]
    public void FindMax_GivenFiveNumsNeg_ShouldReturnHighest()
    {
        int[] nums = [-6, -9, -2, 0, 1];
        int expected = 1;

        var arrayMaxFinder = new ArrayMaxFinder();
        var max = arrayMaxFinder.FindMax(nums);

        Assert.Equal(expected, max);
    }

    [Fact]
    public void FindMax_GivenSingle_ShoulddReturnFirst()
    {
        int[] nums = [6];
        int expected = 6;

        var arrayMaxFinder = new ArrayMaxFinder();
        var max = arrayMaxFinder.FindMax(nums);

        Assert.Equal(expected, max);
    }

    [Fact]
    public void FindMax_EmptyGiven_ShoulddReturnFirst()
    {
        int[] nums = [];
        
        var arrayMaxFinder = new ArrayMaxFinder();

        Assert.Throws<ArgumentException>(() => arrayMaxFinder.FindMax(nums));

        
    }

    [Fact]
    public void FindMax_AllIdentical_ShoulddReturnTheIdentical()
    {
        int[] nums = [6, 6, 6, 6, 6];
        int expected = 6;

        var arrayMaxFinder = new ArrayMaxFinder();
        var max = arrayMaxFinder.FindMax(nums);

        Assert.Equal(expected, max);
    }

    [Fact]
    public void FindTopTwo_FiveGivenfirstBiggest_ShoulddReturnTheTopTwo()
    {
        int[] nums = [10, 5, 1, 9, 3];
        int expectedMax = 10;
        int expectedSecond = 9;

        var arrayMaxFinder = new ArrayMaxFinder();
        (var max, var second) = arrayMaxFinder.FindTopTwo(nums);

        Assert.Equal(expectedMax, max);
        Assert.Equal(expectedSecond, second);
    }

    [Fact]
    public void FindTopTwo_FiveGivenLastBiggest_ShoulddReturnTheTopTwo()
    {
        int[] nums = [10, 5, 15, 9, 13];
        int expectedMax = 15;
        int expectedSecond = 13;

        var arrayMaxFinder = new ArrayMaxFinder();
        (var max, var second) = arrayMaxFinder.FindTopTwo(nums);

        Assert.Equal(expectedMax, max);
        Assert.Equal(expectedSecond, second);
    }

    [Fact]
    public void FindTopTwo_FirstSmallest_ShoulddReturnTheTopTwo()
    {
        int[] nums = [1, 2, 3, 4, 5];
        int expectedMax = 5;
        int expectedSecond = 4;

        var arrayMaxFinder = new ArrayMaxFinder();
        (var max, var second) = arrayMaxFinder.FindTopTwo(nums);

        Assert.Equal(expectedMax, max);
        Assert.Equal(expectedSecond, second);
    }

    [Fact]
    public void FindTopTwo_SecondSmallest_ShoulddReturnTheTopTwo()
    {
        int[] nums = [5, 1, 2, 3, 4];
        int expectedMax = 5;
        int expectedSecond = 4;

        var arrayMaxFinder = new ArrayMaxFinder();
        (var max, var second) = arrayMaxFinder.FindTopTwo(nums);

        Assert.Equal(expectedMax, max);
        Assert.Equal(expectedSecond, second);
    }

    [Fact]
    public void FindTopTwo_FiveGiven_ShoulddReturnTheTopTwo()
    {
        int[] nums = [1, 2, 1, 1, 1];
        int expectedMax = 2;
        int expectedSecond = 1;

        var arrayMaxFinder = new ArrayMaxFinder();
        (var max, var second) = arrayMaxFinder.FindTopTwo(nums);

        Assert.Equal(expectedMax, max);
        Assert.Equal(expectedSecond, second);
    }

    [Fact]
    public void FindTopTwo_FiveGivenNeg_ShoulddReturnTheTopTwo()
    {
        int[] nums = [-6, -9, -2, 0, 1];
        int expectedMax = 1;
        int expectedSecond = 0;

        var arrayMaxFinder = new ArrayMaxFinder();
        (var max, var second) = arrayMaxFinder.FindTopTwo(nums);

        Assert.Equal(expectedMax, max);
        Assert.Equal(expectedSecond, second);
    }

    [Fact]
    public void FindTopTwo_AllIdentical_ShoulddReturnTheTopTwo()
    {
        int[] nums = [5,5,5];
        int expectedMax = 5;
        int expectedSecond = 5;

        var arrayMaxFinder = new ArrayMaxFinder();
        (var max, var second) = arrayMaxFinder.FindTopTwo(nums);

        Assert.Equal(expectedMax, max);
        Assert.Equal(expectedSecond, second);
    }

    [Fact]
    public void FindTopTwo_OneGiven_ShouldThrow()
    {
        int[] nums = [1];

        var arrayMaxFinder = new ArrayMaxFinder();

        Assert.Throws<ArgumentException>(() => arrayMaxFinder.FindTopTwo(nums));
    }

    [Fact]
    public void FindTopTwo_EmptyGiven_ShouldThrow()
    {
        int[] nums = [];

        var arrayMaxFinder = new ArrayMaxFinder();

        Assert.Throws<ArgumentException>(() => arrayMaxFinder.FindTopTwo(nums));
    }
}