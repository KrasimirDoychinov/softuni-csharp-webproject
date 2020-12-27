using NUnit.Framework;

using HolocronProject.Services;
using HolocronProject.Services.Implementations;

namespace HolocronProject.Tests.Services
{
    public class HtmlSizeParserTests
    {
        private IHtmlSizeParser htmlSizeParser;

        [Test]
        public void ParseParsesCorrectlyLargerHtmlImage()
        {
            this.htmlSizeParser = new HtmlSizeParser();
            var htmlToParse = "<img src=\"https://i.pinimg.com/originals/3b/8a/d2/3b8ad2c7b1be2caf24321c852103598a.jpg\" alt=\"\" width=\"3840\" height=\"2160\">";

            var actualParsedHtml = this.htmlSizeParser.Parse(htmlToParse, 100, 50);
            var expectedParsedHtml = "<img src=\"https://i.pinimg.com/originals/3b/8a/d2/3b8ad2c7b1be2caf24321c852103598a.jpg\" alt=\"\" width=\"100%\" height=\"50%\">";

            Assert.AreEqual(expectedParsedHtml, actualParsedHtml);
        }

        [Test]
        public void ParseParsesCorrectlySmallHtmlImage()
        {
            this.htmlSizeParser = new HtmlSizeParser();
            var htmlToParse = "<img src=\"https://i.pinimg.com/originals/3b/8a/d2/3b8ad2c7b1be2caf24321c852103598a.jpg\" alt=\"\" width=\"500\" height=\"500\">";

            var actualParsedHtml = this.htmlSizeParser.Parse(htmlToParse, 100, 50);
            var expectedParsedHtml = "<img src=\"https://i.pinimg.com/originals/3b/8a/d2/3b8ad2c7b1be2caf24321c852103598a.jpg\" alt=\"\" width=\"500\" height=\"500\">";

            Assert.AreEqual(expectedParsedHtml, actualParsedHtml);
        }

        [Test]
        public void ParseParsesCorrectlySmallAndLargeHtmlImage()
        {
            this.htmlSizeParser = new HtmlSizeParser();
            var htmlToParse = "<img src=\"https://i.pinimg.com/originals/3b/8a/d2/3b8ad2c7b1be2caf24321c852103598a.jpg\" alt=\"\" width=\"500\" height=\"500\"> <img src=\"https://i.pinimg.com/originals/3b/8a/d2/3b8ad2c7b1be2caf24321c852103598a.jpg\" alt=\"\" width=\"3000\" height=\"3000\">";

            var actualParsedHtml = this.htmlSizeParser.Parse(htmlToParse, 100, 50);
            var expectedParsedHtml = "<img src=\"https://i.pinimg.com/originals/3b/8a/d2/3b8ad2c7b1be2caf24321c852103598a.jpg\" alt=\"\" width=\"500\" height=\"500\"> <img src=\"https://i.pinimg.com/originals/3b/8a/d2/3b8ad2c7b1be2caf24321c852103598a.jpg\" alt=\"\" width=\"100%\" height=\"50%\">";

            Assert.AreEqual(expectedParsedHtml, actualParsedHtml);
        }

        [Test]
        public void ParseParsesCorrectlyLargeVideo()
        {
            this.htmlSizeParser = new HtmlSizeParser();
            var htmlToParse = "<iframe src=\"https://www.youtube.com/embed/5hJiWlClLiQ\" width=\"10000\" height=\"10000\" allowfullscreen=\"allowfullscreen\"></iframe>";

            var actualParsedHtml = this.htmlSizeParser.Parse(htmlToParse, 100, 50);
            var expectedParsedHtml = "<iframe src=\"https://www.youtube.com/embed/5hJiWlClLiQ\" width=\"100%\" height=\"50%\" allowfullscreen=\"allowfullscreen\"></iframe>";

            Assert.AreEqual(expectedParsedHtml, actualParsedHtml);
        }

        [Test]
        public void ParseParsesCorrectlySmallVideo()
        {
            this.htmlSizeParser = new HtmlSizeParser();
            var htmlToParse = "<iframe src=\"https://www.youtube.com/embed/5hJiWlClLiQ\" width=\"100\" height=\"100\" allowfullscreen=\"allowfullscreen\"></iframe>";

            var actualParsedHtml = this.htmlSizeParser.Parse(htmlToParse, 100, 50);
            var expectedParsedHtml = "<iframe src=\"https://www.youtube.com/embed/5hJiWlClLiQ\" width=\"100\" height=\"100\" allowfullscreen=\"allowfullscreen\"></iframe>";

            Assert.AreEqual(expectedParsedHtml, actualParsedHtml);
        }

        [Test]
        public void ParseParsesCorrectlySmallAndLargeVideo()
        {
            this.htmlSizeParser = new HtmlSizeParser();
            var htmlToParse = "<iframe src=\"https://www.youtube.com/embed/5hJiWlClLiQ\" width=\"100\" height=\"100\" allowfullscreen=\"allowfullscreen\"></iframe> <iframe src=\"https://www.youtube.com/embed/5hJiWlClLiQ\" width=\"10000\" height=\"10000\" allowfullscreen=\"allowfullscreen\"></iframe>";

            var actualParsedHtml = this.htmlSizeParser.Parse(htmlToParse, 100, 50);
            var expectedParsedHtml = "<iframe src=\"https://www.youtube.com/embed/5hJiWlClLiQ\" width=\"100\" height=\"100\" allowfullscreen=\"allowfullscreen\"></iframe> <iframe src=\"https://www.youtube.com/embed/5hJiWlClLiQ\" width=\"100%\" height=\"50%\" allowfullscreen=\"allowfullscreen\"></iframe>";

            Assert.AreEqual(expectedParsedHtml, actualParsedHtml);
        }

        [Test]
        public void ParseParsesCorrectlyLargeImageLargeVideoAndText()
        {
            this.htmlSizeParser = new HtmlSizeParser();
            var htmlToParse = "<p><img src=\"https://i.pinimg.com/originals/3b/8a/d2/3b8ad2c7b1be2caf24321c852103598a.jpg\" alt=\"\" width=\"3840\" height=\"2160\"></p>\n<p><iframe src=\"https://www.youtube.com/embed/GRRUu99y2nQ?list=RD5hJiWlClLiQ&amp;index=8\" width=\"560\" height=\"314\"></iframe></p>\n<p>dfhfdghsd</p>\n<p>fgh</p>\n<p>fsdg</p>\n<p>hd</p>\n<p>fgh</p>";
            
            var actualParsedHtml = this.htmlSizeParser.Parse(htmlToParse, 100, 50);
            var expectedParsedHtml = "<p><img src=\"https://i.pinimg.com/originals/3b/8a/d2/3b8ad2c7b1be2caf24321c852103598a.jpg\" alt=\"\" width=\"100%\" height=\"50%\"></p>\n<p><iframe src=\"https://www.youtube.com/embed/GRRUu99y2nQ?list=RD5hJiWlClLiQ&amp;index=8\" width=\"560\" height=\"314\"></iframe></p>\n<p>dfhfdghsd</p>\n<p>fgh</p>\n<p>fsdg</p>\n<p>hd</p>\n<p>fgh</p>";

            Assert.AreEqual(expectedParsedHtml, actualParsedHtml);
        }
    }
}
