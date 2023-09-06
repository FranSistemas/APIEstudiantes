using System;
namespace APIEstudiantes.Modelos
{
    public class Estudiante
    {
        // Propiedades de la clase Estudiante
        public int ID { get;  set; }
        public string Nombre { get; set; }
        public string Apellido { get;  set; }
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }

        // Constructor para inicializar un estudiante con valores iniciales
        public Estudiante(int id, string nombre, string apellido, DateTime fechaNacimiento, string correoElectronico)
        {
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            CorreoElectronico = correoElectronico;
        }
        
    // Métodos Get para obtener los valores de los atributos
    public int GetID()
    {
        return ID;
    }

    public string GetNombre()
    {
        return Nombre;
    }

    public string GetApellido()
    {
        return Apellido;
    }

    public DateTime GetFechaNacimiento()
    {
        return FechaNacimiento;
    }

    public string GetCorreoElectronico()
    {
        return CorreoElectronico;
    }

    // Métodos Set para actualizar los valores de los atributos
    public void SetID(int id)
    {
        ID = id;
    }

    public void SetNombre(string nombre)
    {
        Nombre = nombre;
    }

    public void SetApellido(string apellido)
    {
        Apellido = apellido;
    }

    public void SetFechaNacimiento(DateTime fechaNacimiento)
    {
        FechaNacimiento = fechaNacimiento;
    }

    public void SetCorreoElectronico(string correoElectronico)
    {
        CorreoElectronico = correoElectronico;
    }

        // Método para mostrar información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Correo Electrónico: {CorreoElectronico}");
        }

    }
}