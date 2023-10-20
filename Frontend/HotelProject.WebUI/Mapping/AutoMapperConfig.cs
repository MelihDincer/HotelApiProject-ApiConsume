using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Dtos.TestimonialDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        //Mapleme işlemi
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap(); //ReverseMap metodu sayesinde hem bu şekilde hem de tersine yani Service, ResultServiceDto şeklinde bir mapleme işlemi gerçekleştirilecektir. Aksi takdirde aşağıdaki örnekteki gibi 2 kez kod yazmamız gerekecekti.

            //CreateMap<ResultServiceDto, Service>();
            //CreateMap<Service, ResultServiceDto>();

            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Staff>().ReverseMap();
        }
    }
}
