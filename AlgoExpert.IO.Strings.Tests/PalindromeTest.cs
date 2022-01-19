using Xunit;

namespace AlgoExpert.IO.Strings.Tests;

public class PalindromeTest
{
    [Fact]
    public void Check() => Assert.True(new Palindrome().Is("abcdcba"));
}