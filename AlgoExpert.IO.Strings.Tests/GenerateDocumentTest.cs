using Xunit;

namespace AlgoExpert.IO.Strings.Tests;

public class GenerateDocumentTest
{
    [Theory]
    [InlineData("Bste!hetsi ogEAxpelrt x ", "AlgoExpert is the Best!")]
    [InlineData("a", "a")]
    [InlineData("a hsgalhsa sanbjksbdkjba kjx", "")]
    [InlineData("     ", "     ")]
    public void Check(string characters, string document) => Assert.True(new GenerateDocument().CanCreate(characters, document));
}
