using Admin.Models.Shopping;
using AutoMapper;
using Repository.Models;


namespace Travel.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentViewModel>();
            CreateMap<DepartmentViewModel, Department>();
            CreateMap<Category, CategoryViewModel>();


        }
    }
}
