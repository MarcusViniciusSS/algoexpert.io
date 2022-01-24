using Xunit;

namespace AlgoExpert.IO.Strings.Tests;

public class FirstNonRepeatingCharacterTest
{
    [Theory]
    [InlineData(-1, "aaaaaaaaaaaaaaaaaaaabbbbbbbbbbcccccccccccdddddddddddeeeeeeeeffghgh")]
    [InlineData(1,"abcdcaf")]
    [InlineData(6,"faadabcbbebdf")]
    public void Check(int expected, string str) => Assert.Equal(expected, new FirstNonRepeatingCharacter().GetIndexCharacter(str));
}