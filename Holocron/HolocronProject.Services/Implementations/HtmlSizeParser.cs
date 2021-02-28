using System.Text;
using System.Text.RegularExpressions;

using HtmlAgilityPack;

namespace HolocronProject.Services.Implementations
{
    public class HtmlSizeParser : IHtmlSizeParser
    {
        public string Parse(string input, int widthInPercent, int heightInPercent)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(input);
            var nodes = doc.DocumentNode.SelectNodes("//img | //iframe");

            var fullResult = new StringBuilder();

            var haveChangesOccured = false;
            var temp = string.Empty;
            if (nodes != null)
            {
                foreach (var item in nodes)
                {
                    var match = Regex.Match(item.OuterHtml,
                    "width=\\\"([0-9]|[1-9][0-9]|[1-9][0-9][0-9])\\\" height=\\\"([0-9]|[1-9][0-9]|[1-9][0-9][0-9])\\\"");
                    
                    if (!match.Success)
                    {
                        var result = Regex.Replace(item.OuterHtml,
                        "width=\\\"([0-9]{1,})\\\" height=\\\"([0-9]{1,})\\\"",
                        $"width=\"{widthInPercent}%\" height=\"{heightInPercent}%\"");

                        temp = input.Replace(item.OuterHtml, result);
                        fullResult.AppendLine(result);
                        haveChangesOccured = true;
                    }
                }
            }
            else
            {
                return input; 
            }

            if (!haveChangesOccured)
            {
                return input;
            }

            else
            {
                return temp;
            }
        }
    }
}
