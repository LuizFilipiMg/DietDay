using AutoMapper;
using Dominio.Interfaces;
using Dominio.Interfaces.InterfacesServico;
using Dominio.Servicos;
using Entidades;
using Entidades.Models;
using InfraEstrutura.Repositorio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DietDay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
      //  private IUsuarios _IUsuarios;
        private IMapper _IMapper;
        private IServicoUsuarios _IServicoUsuarios;
        // GET: api/<ValuesController>

        public ValuesController(IServicoUsuarios IServicoUsuarios, IMapper IMapper)
        {
          //  _IUsuarios = IUsuarios;
            _IMapper = IMapper;
            _IServicoUsuarios = IServicoUsuarios;
        }
        
        [HttpGet("{id}")]
        public void Get(int id)
        {
            var input = new InputModelUsuarios
            {
                Nome = "Luiz",
                Ddd = "031",
                Email = "filipimg@outlook.com",
                Telefone = "31993441126"
            };

            var usuarios = _IMapper.Map<Usuarios>(input);

            //public int teste = 0;


            var x =  _IServicoUsuarios.AdicionaUsuarios(usuarios);
            
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
