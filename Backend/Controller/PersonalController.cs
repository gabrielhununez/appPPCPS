using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Data;
using System.Collections.Generic;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        private readonly RepoPersonal _repository = new RepoPersonal();

        [HttpGet]
        public ActionResult<IEnumerable<Personal>> Get()
        {
            return Ok(_repository.Mostrar());
        }

        /*
        [HttpPost]
        public ActionResult Post([FromBody] Grado grado)
        {
            _repository.Insertar(grado);
            return Ok("Grado agregado correctamente.");
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Grado grado)
        {
            _repository.Actualizar(id, grado);
            return Ok("Grado actualizado correctamente.");
        }
        */

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _repository.Eliminar(id);
            return Ok("Personal eliminado correctamente.");
        }
    }
}