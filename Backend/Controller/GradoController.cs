using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Data;
using System.Collections.Generic;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradoController : ControllerBase
    {
        private readonly RepoGrado _repository = new RepoGrado();

        [HttpGet]
        public ActionResult<IEnumerable<Grado>> Get()
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
            return Ok("Grado eliminado correctamente.");
        }
    }
}