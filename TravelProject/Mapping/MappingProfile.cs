using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Models;
using Travel.Models.Account;
using Travel.Models.Product;

namespace Travel.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap <Category, CategoryViewModel > ();
            CreateMap<Department, DepartmentViewModel>();         
            CreateMap<Label, LabelViewModel>();
            CreateMap<Discount, DiscountViewModel>();
            CreateMap<Product, ProductViewModel>()
                      .ForMember(d => d.Photos, opt => opt.MapFrom(src => src.Photos.OrderBy(p => p.OrderBy).Select(p => p.Image)))
                      .ForMember(d => d.Discount, opt => opt.MapFrom(src => src.Discounts
                                                                         .Where(d => d.Discount.StartDate <= DateTime.Now && d.Discount.EndDate >= DateTime.Now)
                                                                         .OrderByDescending(d => d.Discount.AddedDate)
                                                                         .FirstOrDefault().Discount));

            CreateMap<RegisterViewModel, User>();
            CreateMap<ProductReview, LeaveReviewViewModel>();
        }
    }
}
