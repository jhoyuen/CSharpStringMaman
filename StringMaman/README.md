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

## JSM-2: Add `String Email Validation` via an `IsValidEmail` extension method
- Is Valid Email
```
public static EmailValidationResult IsValidEmail(this string email)
{
    return email switch
    {
        null => EmailValidationResult.EmptyOrWhitespace,
        { } s when string.IsNullOrEmpty(s) => EmailValidationResult.EmptyOrWhitespace,
        { } s when string.IsNullOrWhiteSpace(s) => EmailValidationResult.EmptyOrWhitespace,
        { } s when !new EmailAddressAttribute().IsValid(s) => EmailValidationResult.InvalidFormat,
        { } s => ValidateMailAddress(s)
    };
}
```