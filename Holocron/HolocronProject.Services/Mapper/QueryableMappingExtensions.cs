using System;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace HolocronProject.Services.Mapper
{
    

    public static class QueryableMappingExtensions
    {
        public static IQueryable<TDestination> To<TDestination>(
            this IQueryable source, 
            IMapper mapper = null,
            params Expression<Func<TDestination, object>>[] membersToExpand
            )
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (mapper != null)
            {
                return source.ProjectTo(mapper.ConfigurationProvider, null, membersToExpand);
            }

            return source.ProjectTo(AutoMapperConfig.MapperInstance.ConfigurationProvider, null, membersToExpand);
        }

        public static IQueryable<TDestination> To<TDestination>(
            this IQueryable source,
            object parameters)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return source.ProjectTo<TDestination>(AutoMapperConfig.MapperInstance.ConfigurationProvider, parameters);
        }
    }
}
