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

    [Fact]
    public void ReverseString_GivenSimpleString_ReversedString()
    {
        var input = "hello";
        var output = "olleh";

        var res = _stringReverser.ReverseString(input);

        Assert.Equal(output, res);
    }

    [Fact]
    public void ReverseString_GivenMultipleWords_ReversedStringWithCorrectWordOrder()
    {
        var input = "Hello World";
        var output = "olleH dlroW";

        var res = _stringReverser.ReverseString(input);

        Assert.Equal(output, res);
    }

    [Fact]
    public void ReverseString_GivenMultipleWordsWithMultipleSpaces_ReversedStringWithCorrectWordOrder()
    {
        var input = "Hello   World";
        var output = "olleH   dlroW";

        var res = _stringReverser.ReverseString(input);

        Assert.Equal(output, res);
    }
}
