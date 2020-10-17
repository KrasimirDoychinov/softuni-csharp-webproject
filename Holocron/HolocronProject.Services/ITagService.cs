using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface ITagService
    {
        Tag GetTagByName(string tagName);

        void IsTagNameTaken(string tagName);
    }
}
