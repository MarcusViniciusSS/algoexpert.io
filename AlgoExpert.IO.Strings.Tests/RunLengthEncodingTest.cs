using Xunit;

namespace AlgoExpert.IO.Strings.Tests;

public class RunLengthEncodingTest
{
    [Fact]
    public void Apply() => Assert.Equal("8.6_9=4A3 3A4B3 3B" ,new RunLengthEncoding().Apply("........______=========AAAA   AAABBBB   BBB"));
}