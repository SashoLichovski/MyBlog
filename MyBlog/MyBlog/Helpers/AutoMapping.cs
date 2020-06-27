using AutoMapper;
using MyBlog.Data;
using MyBlog.ViewModels.AuthModels;
using MyBlog.ViewModels.GalleryModels;
using MyBlog.ViewModels.PostModels;
using MyBlog.ViewModels.UserModels;

namespace MyBlog.Helpers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            //Post controller models
            CreateMap<Post, HomePageModel>();
            CreateMap<Post, PostDetailsModel>();
            CreateMap<Post, ManagePostModel>();
            CreateMap<Post, ModifyPostModel>();

            //Gallery controller models
            CreateMap<GalleryImage, OverviewModel>();

            //Auth controller models
            CreateMap<SignInModel, User>();

            //User controller models
            CreateMap<RegisterModel, User>();
        }

    }
}
