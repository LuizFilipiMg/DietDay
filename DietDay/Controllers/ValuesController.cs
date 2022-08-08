using Dominio.Interfaces.InterfacesServico;
using Dominio.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DietDay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
      //  private IUsuarios _IUsuarios;
       // private IMapper _IMapper;
        private IServicoUsuarios _IServicoUsuarios;
        // GET: api/<ValuesController>

        public ValuesController(IServicoUsuarios IServicoUsuarios)
        {
          //  _IUsuarios = IUsuarios;
          //  _IMapper = IMapper;
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

            _IServicoUsuarios.AdicionaUsuarios(input);            
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
