using System.Collections.Generic;
using System.Linq;

using HolocronProject.Data;
using HolocronProject.Data.Models;

namespace HolocronProject.Services.Implementations
{
    public class ClassServices : IClassService
    {
        private readonly HolocronDbContext context;

        public ClassServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Class> GetAll()
            => this.context.Classes
            .ToList();

        public Class GetClassById(string classId)
            => this.context.Classes.FirstOrDefault(x => x.Id == classId);

        public string GetClassIdByName(string className)
            => this.context.Classes
            .FirstOrDefault(x => x.Name == className).Id;
    }
}
