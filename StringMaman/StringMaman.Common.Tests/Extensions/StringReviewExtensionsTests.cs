using StringMaman.Common.Extensions;

namespace StringMaman.Common.Tests.Extensions;

public class StringReviewExtensionsTests
{
    #region WordCount

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData(null)]
    public void WordCount_EmptyString_ReturnsZero(string str)
    {
        // Arrange / Act
        int result = str.WordCount();
        // Assert
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("Hello")]
    [InlineData("     Hello ")]
    [InlineData("12345")]
    [InlineData(" 12345")]
    [InlineData("!@#@!#!  ")]
    public void WordCount_SingleWord_ReturnsOne(string str)
    {
        // Arrange / Act
        int result = str.WordCount();
        // Assert
        Assert.Equal(1, result);
    }

    [Theory]
    [InlineData("Hello World! This is a test.")]
    [InlineData("       Hello   World!  This  is       a  test.  ")]
    [InlineData("Hello world!\r\nThis is a test.")]
    [InlineData("Hello world!\r\n\r\nThis is a test.")]
    public void WordCount_MultipleWords_ReturnsCorrectCount(string str)
    {
        // Arrange / Act
        int result = str.WordCount();
        // Assert
        Assert.Equal(6, result);
    }

    #endregion
}
