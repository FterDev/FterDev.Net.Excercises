namespace FterDev.Easy.PalindromeChecker.Tests;

public class PalindromeCheckerTests
{
    [Fact]
    public void IsPalinddrome_SimplePalindromeGiven_ShouldReturnTrue()
    {
        string palindrome = "racecar";

        var res = PalindromeChecker.IsPalindrome(palindrome);

        Assert.True(res);
    }

    [Fact]
    public void IsPalinddrome_NoPalindromeGiven_ShouldReturnFalse()
    {
        string palindrome = "racecar";

        var res = PalindromeChecker.IsPalindrome(palindrome);

        Assert.False(res);
    }

    [Fact]
    public void IsPalinddrome_EmptyStringGiven_ShouldReturnTrue()
    {
        string palindrome = "racecar";

        var res = PalindromeChecker.IsPalindrome(palindrome);

        Assert.True(res);
    }

    [Fact]
    public void IsPalinddrome_PunctuationGiven_ShouldReturnTrue()
    {
        string palindrome = "..!!;;";

        var res = PalindromeChecker.IsPalindrome(palindrome);

        Assert.True(res);
    }
}
