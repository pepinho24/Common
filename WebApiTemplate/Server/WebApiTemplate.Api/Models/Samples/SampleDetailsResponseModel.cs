namespace WebApiTemplate.Api.Models.Samples
{
    using System;
    using AutoMapper;
    using WebApiTemplate.Api.Infrastructure.Mapping;
    using WebApiTemplate.Models;

    public class SampleDetailsResponseModel : IMapFrom<SampleClass>, IHaveCustomMappings
    {
        public int SampleId { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public void CreateMappings(IConfiguration config)
        {
            config.CreateMap<SampleClass, SampleDetailsResponseModel>()
               .ForMember(s => s.Username, opts => opts.MapFrom(s => s.User.UserName));
        }
    }
}