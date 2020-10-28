﻿using System.Linq;

using HolocronProject.Data;
using HolocronProject.Data.Models;

namespace HolocronProject.Services.Implementations
{
    public class ClassService : IClassService
    {
        private readonly HolocronDbContext context;

        public ClassService(HolocronDbContext context)
        {
            this.context = context;
        }

        public Class GetClassById(string classId)
            => this.context.Classes.FirstOrDefault(x => x.Id == classId);

        public Class GetClassByName(string className)
            => this.context.Classes.FirstOrDefault(x => x.Name == className);
    }
}
