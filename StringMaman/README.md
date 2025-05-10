# StringTimeMaman
A library of extension methods to assist with some common string manipulation operations

## JSM-1: Add `Word Count` extension method
- Word Count
```
public static int WordCount(this string str)
{
    if (string.IsNullOrWhiteSpace(str))
        return 0;

    // Split by whitespace and filter out empty entries  
    return str.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
}
```