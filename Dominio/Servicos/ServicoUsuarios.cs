using AutoMapper;
using Dominio.Interfaces;
using Dominio.Interfaces.InterfacesServico;
using Dominio.Models;
using Entidades;
using InfraEstrutura.InterfaceRepository;
using InfraEstrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public class ServicoUsuarios : IServicoUsuarios
    {
       private readonly IUsuariosRepository _IUsuariosRepository;
       private readonly IMapper _IMapper;

        public ServicoUsuarios(IUsuariosRepository IUsuariosRepository, IMapper IMapper)
        {
            _IUsuariosRepository = IUsuariosRepository;
            _IMapper = IMapper;
        }

        public async Task AdicionaUsuarios(InputModelUsuarios inputUsuarios)
        {
            var usuarios = _IMapper.Map<Usuarios>(inputUsuarios);
            usuarios.DataHora = DateTime.Now;
            await _IUsuariosRepository.AdicionaUsuario(usuarios);

        }

    }
}
