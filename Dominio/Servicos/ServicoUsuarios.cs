using AutoMapper;
using Dominio.Interfaces;
using Dominio.Interfaces.InterfacesServico;
using Entidades;
using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public class ServicoUsuarios : IServicoUsuarios
    {
        private readonly IUsuarios _IUsuarios;
      //  private readonly IMapper _IMapper;

        public ServicoUsuarios(IUsuarios IUsuarios)//, IMapper IMapper)
        {
            _IUsuarios = IUsuarios;
            //_IMapper = IMapper;
        }

        public async Task AdicionaUsuarios(Usuarios usuarios)
        {                   
            usuarios.DataHora = DateTime.Now;

            await _IUsuarios.AdicionaUsuario(usuarios);

        }

    }
}
