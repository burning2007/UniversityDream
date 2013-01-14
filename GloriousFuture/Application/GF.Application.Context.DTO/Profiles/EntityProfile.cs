using AutoMapper;
using GF.Domain.Context;

namespace GF.Application.Context.DTO.Profiles
{
    public class EntityProfile : Profile
    {
        protected override void Configure()
        {
            //var accountMappingExpression = Mapper.CreateMap<Account, AccountDTO>();
            //accountMappingExpression.ForMember(dto => dto.ACEENumber, mc => mc.MapFrom(account => account.Achievement.ACEENumber));
            //accountMappingExpression.ForMember(dto => dto.SpecialityType, mc => mc.MapFrom(account => account.Achievement.SpecialityType));
            //accountMappingExpression.ForMember(dto => dto.Score, mc => mc.MapFrom(account => account.Achievement.Score));
            //accountMappingExpression.ForMember(dto => dto.Province, mc => mc.MapFrom(account => account.Zone.Province));
            //accountMappingExpression.ForMember(dto => dto.City, mc => mc.MapFrom(account => account.Zone.City));
        }
    }
}
