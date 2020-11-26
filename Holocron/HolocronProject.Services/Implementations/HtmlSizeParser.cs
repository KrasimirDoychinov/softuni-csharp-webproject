using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HolocronProject.Services.Implementations
{
    public class HtmlSizeParser : IHtmlSizeParser
    {
        public string Parse(string input, int widthInPercent, int heightInPercent)
        {
            var result = string.Empty;
            var match = Regex.Match(input,
                "width=\\\"([0-9]|[1-9][0-9]|[1-9][0-9][0-9])\\\" height=\\\"([0-9]|[1-9][0-9]|[1-9][0-9][0-9])\\\"");

            if (!match.Success)
            {
                result = Regex.Replace(input,
                "width=\\\"([0-9]{1,})\\\" height=\\\"([0-9]{1,})\\\"",
                $"width=\"{widthInPercent}%\" height=\"{heightInPercent}%\"");

                return result;
            }
            else
            {
                return input;
            }

        }
    }
}
