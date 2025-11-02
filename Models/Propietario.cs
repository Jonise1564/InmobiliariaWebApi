using System;

namespace Inmobiliariaapi.Models
{
    public class Propietario
    {
        public int IdPropietario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }

        public Propietario() { }

        public Propietario(int idPropietario, string nombre, string apellido, string dni,
                           string telefono, string email, string clave)
        {
            IdPropietario = idPropietario;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Telefono = telefono;
            Email = email;
            Clave = clave;
        }
    }
}
