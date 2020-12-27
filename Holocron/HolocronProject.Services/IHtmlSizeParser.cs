namespace HolocronProject.Services
{
    public interface IHtmlSizeParser
    {
        string Parse(string input, int widthInPercent, int heightInPercent);
    }
}
