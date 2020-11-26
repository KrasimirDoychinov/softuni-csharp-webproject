using System.Collections.Generic;
using System.Linq;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Services.Implementations
{
    public class ClassesService : IClassesService
    {
        private readonly HolocronDbContext context;

        public ClassesService(HolocronDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll<T>()
            => this.context.Classes
            .OrderBy(x => x.Name)
            .To<T>()
            .ToList();

        public Class GetClassById(string classId)
            => this.context.Classes.FirstOrDefault(x => x.Id == classId);

    }
}
