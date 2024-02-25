using AutoMapper;
using expenseTracker.Dto;
using expenseTracker.Model;

namespace expenseTracker.Helper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
        }
    }
}
