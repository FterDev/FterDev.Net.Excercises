namespace FterDev.Easy.StringReverser.Tests;

public class StringReverserTests
{

    private readonly StringReverser _stringReverser;
    public StringReverserTests()
    {
        _stringReverser = new StringReverser();
    }

    [Fact]
    public void ReverseString_GivenEmptyString_ThrowArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => _stringReverser.ReverseString(""));
    }

    [Fact]
    public void ReverseString_GivenoneCharString_ThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _stringReverser.ReverseString("a"));
    }
}
