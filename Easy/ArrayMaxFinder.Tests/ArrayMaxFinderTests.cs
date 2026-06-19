
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
    public void FindMax_AllIdentical_ShoulddReturnTheIdentical()
    {
        int[] nums = [6, 6, 6, 6, 6];
        int expected = 6;

        var arrayMaxFinder = new ArrayMaxFinder();
        var max = arrayMaxFinder.FindMax(nums);

        Assert.Equal(expected, max);
    }

    [Fact]
    public void FindTopTwo_FiveGiven_ShoulddReturnTheTopTwo()
    {
        int[] nums = [6, 9, 2, 0, 1];
        int expectedMax = 9;
        int expectedSecond = 6;

        var arrayMaxFinder = new ArrayMaxFinder();
        (var max, var second) = arrayMaxFinder.FinddTopTwo(nums);

        Assert.Equal(expectedMax, max);
        Assert.Equal(expectedSecond, second);
    }
}