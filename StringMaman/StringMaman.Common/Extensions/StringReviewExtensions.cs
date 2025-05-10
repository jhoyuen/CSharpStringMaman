namespace StringMaman.Common.Extensions;

public static class StringReviewExtensions
{
    public static int WordCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;

        // Split by whitespace and filter out empty entries  
        return str.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
