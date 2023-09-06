using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using APIEstudiantes.Modelos;

namespace APIEstudiantes.Controllers
{
    [Route("api/estudiantes")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {

        private ListaEstudiante listaEstudiante = new ListaEstudiante(); // Declaración de la lista de estudiantes
        // GET: api/estudiantes
        [HttpGet]
        public ActionResult<IEnumerable<Estudiante>> Get()
        {
            return Ok(listaEstudiante.listaEstudiante()); // Llama al método listaEstudiante() sin paréntesis
        }

        // GET: api/estudiantes/5
        [HttpGet("{ID}")]
        public ActionResult<Estudiante> Get(int id)
        {
            // Utiliza LINQ para buscar el estudiante por su ID
                Estudiante estudianteEncontrado = listaEstudiante.BuscarEstudiantePorID(id);
            if (estudianteEncontrado == null)
            {
                return NotFound(); // Devuelve un código de respuesta 404 si el estudiante no se encuentra
            }

            return Ok(estudianteEncontrado); // Devuelve el estudiante como respuesta si se encuentra
        }
        [HttpPost]
        public ActionResult<Estudiante> Post([FromBody] Estudiante estudiante)
        {
            if (estudiante == null)
            {
                return BadRequest("Datos del estudiante no proporcionados");
            }

            // Generar un nuevo ID para el estudiante
            int nuevoId = listaEstudiante.IdSiguiente();
            estudiante.SetID(nuevoId);

            // Agregar el nuevo estudiante a la lista
            listaEstudiante.AgregarEstudiante(estudiante);

            return CreatedAtAction(nameof(Get), new { id = estudiante.ID }, estudiante);
        }
        [HttpPut("{ID}")]
        public ActionResult<Estudiante> Put(int ID, [FromBody] Estudiante estudiante)
    
        {
            // Buscar el estudiante por su ID
            Estudiante estudianteExistente = listaEstudiante.BuscarEstudiantePorID(ID);

            if (estudianteExistente == null)
            {
                return NotFound(); // El estudiante no se encontró, devuelve un código 404
            }

            // Actualizar las propiedades del estudianteExistente con los datos de estudiante
            estudianteExistente.Nombre = estudiante.Nombre;
            estudianteExistente.Apellido = estudiante.Apellido;
            estudianteExistente.CorreoElectronico = estudiante.CorreoElectronico;
            estudianteExistente.FechaNacimiento = estudiante.FechaNacimiento;

            // Guardar los cambios (esto dependerá de cómo gestionas los datos)
            listaEstudiante.ModificarEstudiantexId(estudiante);

            return Ok(estudianteExistente); // Devuelve el estudiante actualizado como respuesta
        }
        [HttpDelete("{ID}")]
        public ActionResult Delete(int ID)
        {
        // Buscar el estudiante por su ID
        Estudiante estudianteExistente = listaEstudiante.BuscarEstudiantePorID(ID);

        if (estudianteExistente == null)
        {
            return NotFound(); // El estudiante no se encontró, devuelve un código 404
        }
        listaEstudiante.EliminarEstudiante(estudianteExistente.ID);

        return Ok("Eliminado con exito"); 
        }

    }
}  
