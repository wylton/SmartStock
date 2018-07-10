using AutoMapper;
using SmartMvc.Admin.Models;
using SmartMvc.Domain.Entities;

namespace SmartMvc.Admin.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<MovimentBox, MovimentBoxViewModels>();
        }
    }
}