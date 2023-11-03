using App.Business.DTOs.CategoryDTOs;
using App.Business.DTOs.PageDTOs;
using App.Business.DTOs.PostDTOs;
using App.Business.DTOs.SettingDTOs;
using App.Business.DTOs.UserDTOs;
using App.Persistence.Data.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, ViewCategoryDto>().ReverseMap();
            CreateMap<Category, CreateOrEditCategoryDto>().ReverseMap();

            CreateMap<Post, CreateOrEditPostDto>().ReverseMap();
            CreateMap<Post, PostDto>().ReverseMap();
            CreateMap<Post, ViewPostDto>().ReverseMap();

            CreateMap<Page, CreateOrEditPageDto>().ReverseMap();
            CreateMap<Page, PageDto>().ReverseMap();
            CreateMap<Page, ViewPageDto>().ReverseMap();


            CreateMap<User, CreateOrEditUserDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, ViewUserDto>().ReverseMap();

            CreateMap<Setting, CreateOrEditSettingDto>().ReverseMap();
            CreateMap<Setting, SettingDto>().ReverseMap();
            CreateMap<Setting, ViewSettingDto>().ReverseMap();
        }
    }
}
