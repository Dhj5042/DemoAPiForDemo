using AutoMapper;
using DemoAPiForDemo.Model;
using DemoAPiForDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Configration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<User, SignUpModelUserVM>().ReverseMap();
        }
    }
}
