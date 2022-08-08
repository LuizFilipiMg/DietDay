using AutoMapper;
using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Mapping
{
    public class UsuariosProfile: Profile
    {
        public UsuariosProfile()
        {
            CreateMap<InputModelUsuarios, Usuarios>();
            CreateMap<Usuarios, ViewModelUsuarios>();
        }
    }
}
