using Aplicacao.Interfaces;
using Dominio.Interfaces.InterfacesServico;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class AplicacaoUsuario: IAplicacaoUsuario
    {
        private readonly IServicoUsuarios _IServicoUsuarios;  
        public AplicacaoUsuario(IServicoUsuarios IServicoUsuarios)
        {
            _IServicoUsuarios = IServicoUsuarios; ;
        }
        public async Task AdicionaUsuarios(InputModelUsuarios inputUsuarios)
        {
            await _IServicoUsuarios.AdicionaUsuarios(inputUsuarios);
        }
       
    }
}
