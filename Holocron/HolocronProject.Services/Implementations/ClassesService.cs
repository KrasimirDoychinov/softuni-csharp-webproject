using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Services.Implementations
{
    public class ClassesService : IClassesService
    {
        private readonly ApplicationDbContext context;

        public ClassesService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll<T>(IMapper mapper)
            => this.context.Classes
            .OrderBy(x => x.Name)
            .To<T>(mapper)
            .ToList();

    }
}
