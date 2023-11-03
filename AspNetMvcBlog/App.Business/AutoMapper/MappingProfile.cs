using App.Business.DTOs.CategoryDTOs;
using App.Business.DTOs.PageDTOs;
using App.Business.DTOs.PostDTOs;
using App.Business.DTOs.Setting;
using App.Business.DTOs.UserDTOs;
using App.Persistence.Data.Entity;
using AutoMapper;

namespace App.Business
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Category
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<ViewCategoryDto, Category>().ReverseMap();
            CreateMap<CreateOrEditCategoryDto, Category>().ReverseMap();
            //Post
            CreateMap<PostDto, Post>().ReverseMap();
            CreateMap<ViewPostDto, Post>().ReverseMap();
            CreateMap<CreateOrEditPostDto, Post>().ReverseMap();

            //Page
            CreateMap<PageDto, Page>().ReverseMap();
            CreateMap<ViewPageDto, Page>().ReverseMap();
            CreateMap<CreateOrEditPageDto, Page>().ReverseMap();

            //User
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<ViewUserDto, User>().ReverseMap();
            CreateMap<CreateOrEditUserDto, User>().ReverseMap();

            //Setting
            CreateMap<SettingDto, Setting>().ReverseMap();
            CreateMap<ViewSettingDto, Setting>().ReverseMap();
            CreateMap<CreateOrEditSettingDto, Setting>().ReverseMap();

            //postComment
            CreateMap<DTOs.PostComment.PostCommentCreateOrEditDto, PostComment>().ReverseMap();
        }
    }
}