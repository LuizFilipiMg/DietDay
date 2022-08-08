using AutoMapper;
using Dominio.Models;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Mapping
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
