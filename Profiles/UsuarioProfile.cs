using AutoMapper;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

namespace UsuarioAPI.Profiles;


public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<CreateUsuarioDto, Usuario>();
    }
}
