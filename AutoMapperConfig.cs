using AutoMapper;
using System.Runtime;
using WebApplication2.Entity;
using WebApplication2.Models;

namespace WebApplication2
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}
