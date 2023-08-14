using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FichaCadastroAPI.DTO.Ficha;
using FichaCadastroAPI.Models;

namespace FichaCadastroAPI.Automapper
{
    public class ConfigurationMapper : Profile
    {
        // Construtor
        public ConfigurationMapper(){
               CreateMap<FichaModel, FichaReadDTO>()
                 .ForMember(dest => dest.FichaComDetalhes, opt => opt.MapFrom(src => src.Detalhes));

            CreateMap<FichaCreateDTO, FichaModel>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.NomeCompleto))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.EmailInformado.ToLower()))
                .ForMember(dest => dest.DataNascimento, opt => opt.MapFrom(src => src.DataDeNascimento));

            CreateMap<FichaUpdateDTO, FichaModel>();

            CreateMap<DetalheModel, FichaDetalheReadDTO>();
        }
    }
}
