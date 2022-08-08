using Entidades;
using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfacesServico
{
    public interface IServicoUsuarios
    {
        Task AdicionaUsuarios(Usuarios usuarios);
    }
}
