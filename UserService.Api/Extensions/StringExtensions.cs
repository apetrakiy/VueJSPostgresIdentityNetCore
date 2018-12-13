using System.Text.RegularExpressions;

namespace UserService.Api.Extensions
{
    public static class StringExtensions
    {
        private static readonly Regex StartUnderscoresRegex = new Regex(@"^_+", RegexOptions.Compiled);
        private static readonly Regex ReplaceRegex = new Regex(@"^_+", RegexOptions.Compiled);

        public static string ToSnakeCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var startUnderscores = StartUnderscoresRegex.Match(input);
            return startUnderscores + ReplaceRegex.Replace(input, "$1_$2").ToLower();
        }
    }
}