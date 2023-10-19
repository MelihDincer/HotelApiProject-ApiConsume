using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;

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
        }
    }
}
