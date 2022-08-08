using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura.InterfaceRepository
{
    public  interface IUsuariosRepository
    {        Task<bool> AdicionaUsuario(Usuarios usuarios);
    }
}
