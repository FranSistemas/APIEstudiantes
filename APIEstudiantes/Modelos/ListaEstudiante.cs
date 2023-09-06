using System;
using System.Collections.Generic; // Agrega esta directiva
using APIEstudiantes.Modelos;

namespace APIEstudiantes.Modelos
{
    public class ListaEstudiante
    {
        private List<Estudiante> listestudiante { get; set; }

        public List<Estudiante> listaEstudiante()
        {
            return listestudiante;
        }
        public ListaEstudiante()
        {
            listestudiante = new List<Estudiante>
            {
                new Estudiante(1, "Juan", "Pérez", new DateTime(2003, 5, 10), "juan@example.com"),
                new Estudiante(2, "María", "Rodríguez", new DateTime(1999, 8, 15), "maria@example.com"),
                new Estudiante(3, "Jose", "Pez", new DateTime(2010, 7, 10), "jopez@example.com"),
                new Estudiante(4, "MaríaJose", "Roz", new DateTime(1939, 8, 15), "jose@example.com")
            };
        }

        public int IdSiguiente()
        {
            return listestudiante.Count() + 1 ;   
        }
        public void AgregarEstudiante(Estudiante newestudiante)
        {
            listestudiante.Add(newestudiante);
        }

        public Estudiante BuscarEstudiantePorID(int id)
        {
            Estudiante estudianteEncontrado = listestudiante.FirstOrDefault(e => e.GetID() == id);
            
            return estudianteEncontrado;
        }
        public void ModificarEstudiantexId(Estudiante estudiante)
        {
            listestudiante[estudiante.ID].Nombre = estudiante.Nombre;
            listestudiante[estudiante.ID].Apellido = estudiante.Apellido;
            listestudiante[estudiante.ID].FechaNacimiento = estudiante.FechaNacimiento;
            listestudiante[estudiante.ID].CorreoElectronico = estudiante.CorreoElectronico;
        }
        public void EliminarEstudiante(int id)
        {
            listestudiante.RemoveAt(id);
        }
    }
}




