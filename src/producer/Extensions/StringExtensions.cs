namespace Producer.Extensions;

public static partial class StringExtensions
{
    [GeneratedRegex("[^a-zA-Z0-9 ]")]
    private static partial Regex NotAlphaNumeric();

    private static readonly char[] separator = [' '];

    public static bool IsNullOrEmpty(this string? value) =>
        string.IsNullOrEmpty(value);

    public static string NormalizeTitle(this string title)
    {
        var alphanumericTitle = NotAlphaNumeric().Replace(title, " ");

        var words = alphanumericTitle.Split(separator, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => word.ToLower());

        var normalizedTitle = string.Join(" ", words);

        return normalizedTitle;
    }
}
