namespace FterDev.Easy.FizzBuzz.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void FizzBuzz_Given15_ReturnsCorrectList()
    {
        var expectedList = new List<string>()
        {
          "1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"  
        };

        var res = Program.FizzBuzz(15);

        Assert.Equal(expectedList, res);
    }

    [Fact]
    public void FizzBuzzGeneral_Given15_ReturnsCorrectList()
    {
        var expectedList = new List<string>()
        {
          "1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"  
        };
        Dictionary<int, string> rules = new Dictionary<int, string>
        {
            {3, "Fizz"},
            {5, "Buzz"}
        };

        var res = Program.FizzBuzzGeneral(15, rules);

        Assert.Equal(expectedList, res);
    }

    [Fact]
    public void FizzBuzzGeneral_ZeroRule_ThrowsArgumentException()
    {
    
        Dictionary<int, string> rules = new Dictionary<int, string>
        {
            {0, "Fizz"},
        };

        Assert.Throws<ArgumentException>(() => Program.FizzBuzzGeneral(15, rules));
    }

    [Fact]
    public void FizzBuzzGeneral_EmptyRule_ThrowsArgumentException()
    {
    
        Dictionary<int, string> rules = new Dictionary<int, string>
        {
            {1, ""},
        };

        Assert.Throws<ArgumentException>(() => Program.FizzBuzzGeneral(15, rules));
    }
}
