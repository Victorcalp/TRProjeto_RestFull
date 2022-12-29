using Microsoft.AspNetCore.Mvc;
using TRProjeto_RestFull.Business;
using TRProjeto_RestFull.Data.VO;

namespace TRProjeto_RestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteBusiness _cliente;

        public ClienteController(IClienteBusiness cliente)
        {
            _cliente = cliente;
        }

        [HttpGet]
        public IActionResult FiendAll()
        {
            return Ok(_cliente.FiendAll());
        }

        [HttpGet("{id}")]
        public IActionResult Fiend(long id)
        {
            return Ok(_cliente.FiendById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] ClienteVO cliente)
        {
            var obj = _cliente.Create(cliente);
            return Ok(obj);
        }

        [HttpPut]
        public IActionResult Update(ClienteVO cliente)
        {
            var obj = _cliente.Update(cliente);
            return Ok(obj);
        }

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            _cliente.Delete(id);
            return NoContent();
        }
    }
}
