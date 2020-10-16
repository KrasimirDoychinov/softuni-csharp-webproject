using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolocronProject.Services.Implementations
{
    public class ClassService : IClassService
    {
        private HolocronDbContext context;

        public ClassService(HolocronDbContext context)
        {
            this.context = context;
        }

        public Class GetClassByName(string className)
            => this.context.Classes.FirstOrDefault(x => x.Name == className);

        public IEnumerable<Class> GetMostPlayedCasses()
            => this.context.Classes
            .OrderByDescending(x => x.Characters.Count())
            .ToList();
    }
}
