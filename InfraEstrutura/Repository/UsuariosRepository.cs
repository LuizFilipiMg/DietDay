using Entidades;
using InfraEstrutura.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace InfraEstrutura.Repository
{
    public class UsuariosRepository: IUsuariosRepository
    {
        private readonly DbContextOptions<Contexto> _OptionsBuilder;

        public UsuariosRepository()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }
        
        public async Task<bool> AdicionaUsuario(Usuarios usuarios)
        {
            
            try
            {
                using (var data = new Contexto(_OptionsBuilder))
                {
                    await data.Usuarios.AddAsync(usuarios);
                    await data.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }
    }
}
