using System.Text;

namespace UserService.Api.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Inspired by https://github.com/JamesNK/Newtonsoft.Json/blob/509643a8952ce731e0207710c429ad6e67dc43db/Src/Newtonsoft.Json/Utilities/StringUtils.cs#L200
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToSnakeCase(this string value)
        {
            if (string.IsNullOrEmpty(value)) return value;

            var sb = new StringBuilder();
            var state = SnakeCaseState.Start;

            for (var i = 0; i < value.Length; i++)
                if (value[i] == ' ')
                {
                    if (state != SnakeCaseState.Start) state = SnakeCaseState.NewWord;
                }
                else if (char.IsUpper(value[i]))
                {
                    switch (state)
                    {
                        case SnakeCaseState.Upper:
                            var hasNext = i + 1 < value.Length;
                            if (i > 0 && hasNext)
                            {
                                var nextChar = value[i + 1];
                                if (!char.IsUpper(nextChar) && nextChar != '_') sb.Append('_');
                            }

                            break;
                        case SnakeCaseState.Lower:
                        case SnakeCaseState.NewWord:
                            sb.Append('_');
                            break;
                    }

                    char c;
#if HAVE_CHAR_TO_LOWER_WITH_CULTURE
                    c = char.ToLower(value[i], CultureInfo.InvariantCulture);
#else
                    c = char.ToLowerInvariant(value[i]);
#endif
                    sb.Append(c);

                    state = SnakeCaseState.Upper;
                }
                else if (value[i] == '_')
                {
                    sb.Append('_');
                    state = SnakeCaseState.Start;
                }
                else
                {
                    if (state == SnakeCaseState.NewWord) sb.Append('_');

                    sb.Append(value[i]);
                    state = SnakeCaseState.Lower;
                }

            return sb.ToString();
        }

        internal enum SnakeCaseState
        {
            Start,
            Lower,
            Upper,
            NewWord
        }
    }
}