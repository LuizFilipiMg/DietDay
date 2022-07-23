using Dominio.Interfaces;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace InfraEstrutura.Repositorio
{
    public class UsuariosRepository: IUsuarios
    {
        private readonly DbContextOptions<Contexto> _OptionsBuilder;

        public UsuariosRepository()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }
        //public async Task Adicionar(T Objeto)
        //{
        //    using (var data = new Contexto(_OptionsBuilder))
        //    {
        //        await data.Set<T>().AddAsync(Objeto);
        //        await data.SaveChangesAsync();
        //    }
        //}
        public async Task<bool> AdicionaUsuario(string email, string senha, int idade, string celular)
        {

            try
            {
                using (var data = new Contexto(_OptionsBuilder))
                {
                    await data.Usuarios.AddAsync(
                          new Usuarios
                          {
                              Id = 1,
                              Nome = "luiz",
                              Email ="filipimg@outlook.com",
                              Telefone="31993441126"
                          });

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
