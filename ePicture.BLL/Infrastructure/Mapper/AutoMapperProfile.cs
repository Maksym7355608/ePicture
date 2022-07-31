using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ePicture.BLL.DTO;
using ePicture.DAL.Entities;

namespace ePicture.BLL.Infrastructure.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>()
                .ForMember(x => x.Name, z => z.MapFrom(z => z.Name))
                .ForMember(x => x.Surname, z => z.MapFrom(z => z.Surname))
                .ForMember(x => x.Email, z => z.MapFrom(z => z.Email))
                .ForMember(x => x.Password, z => z.MapFrom(z => z.Password))
                .ReverseMap();

            CreateMap<Artist, ArtistModel>()
                .ForMember(x => x.Name, z => z.MapFrom(z => z.User.Name))
                .ForMember(x => x.Surname, z => z.MapFrom(z => z.User.Surname))
                .ForMember(x => x.Email, z => z.MapFrom(z => z.User.Email))
                .ForMember(x => x.Pictures, z => z.MapFrom(z => z.Pictures))
                .ReverseMap();

            CreateMap<Picture, PictureModel>()
                 .ForMember(x => x.Name, z => z.MapFrom(z => z.Name))
                 .ForMember(x => x.Path, z => z.MapFrom(z => z.Path))
                 .ForMember(x => x.Path, z => z.MapFrom(z => z.Path))
                 .ForMember(x => x.Description, z => z.MapFrom(z => z.Description))
                 .ForMember(x => x.Tags, z => z.MapFrom(z => z.Tags))
                 .ReverseMap();

            CreateMap<Tag, TagModel>()
                .ForMember(x => x.NameTag, z => z.MapFrom(z => z.NameTag))
                .ReverseMap();

            CreateMap<UserModel, RegisterModel>()
                .ForMember(x => x.Name, z => z.MapFrom(z => z.Name))
                .ForMember(x => x.Surname, z => z.MapFrom(z => z.Surname))
                .ForMember(x => x.Email, z => z.MapFrom(z => z.Email))
                .ForMember(x => x.Password, z => z.MapFrom(z => z.Password))
                .ReverseMap();
        }
    }
}
