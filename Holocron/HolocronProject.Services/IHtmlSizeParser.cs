using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Services
{
    public interface IHtmlSizeParser
    {
        string Parse(string input, int widthInPercent, int heightInPercent);
    }
}
