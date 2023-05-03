using ApiUsuarios.Data.Dtos;
using ApiUsuarios.Models;
using AutoMapper;
    public class UsuarioProfile : Profile 
{
    public UsuarioProfile()
    {
       CreateMap<CreateUsuarioDto, Usuario>();            
    }
}