using AutoMapper;
using Dominio.Models;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Enum;

namespace Dominio.Mapping
{
    public class UsuariosProfile: Profile
    {
        public UsuariosProfile()
        {
            CreateMap<InputModelUsuarios, Usuarios>()
            .ForMember(d => d.TipoDocumento, o => o.MapFrom(y => ((int)y.TipoDocumento)))
            .ForMember(d => d.Sexo, o => o.MapFrom(y => ((int)y.Sexo))).ReverseMap();


            CreateMap<Usuarios, ViewModelUsuarios>();
            
        }
    }
}
