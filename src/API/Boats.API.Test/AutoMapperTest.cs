using AutoMapper;
using AutoMapper.Configuration;
using Boats.Api.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Boats.Api.Test
{
    public class AutoMapperTest
    {
        [Theory]
        [MemberData(nameof(GetProfileTypes))]
        public void TestProfiles(Type profileType)
        {
            var profile = (MapperConfigurationExpression)Activator.CreateInstance(profileType);
            var config = new MapperConfiguration(profile);
            var mapper = new Mapper(config);

            (mapper as IMapper).ConfigurationProvider.AssertConfigurationIsValid();
        }

        public static IEnumerable<object[]> GetProfileTypes()
        {
            return GetSubclassesInAssembly(typeof(BoatProfile).Assembly, typeof(MapperConfigurationExpression))
                .OrderBy(type => type.Name)
                .Select(type => new object[] { type });
        }

        private static IEnumerable<Type> GetSubclassesInAssembly(Assembly assembly, Type parentType)
        {
            return assembly.GetTypes().Where(x => x.IsClass && !x.IsAbstract && x.IsSubclassOf(parentType));
        }
    }
}
