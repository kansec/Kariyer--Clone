using AutoMapper;
using KariyerClone.Models;
using KariyerClone.Models.Dtos;

namespace KariyerClone.Configurations
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<JobDto,Job>().ReverseMap();
            CreateMap<JobDetailsDto, Job>().ReverseMap();
            CreateMap<CompanyDetailsDto, Company>().ReverseMap();
            CreateMap<CompanyForJobDto, Company>().ReverseMap();
            CreateMap<CompanyDto, Company>().ReverseMap();
            CreateMap<ApplicantCriterias,ApplicantCriteriasDto>().ReverseMap();
            CreateMap<ApiUserDto, ApiUser>().ReverseMap();
        }
    }
}
