using System;

namespace Inmobiliariaapi.Models
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public double MontoAlquiler { get; set; }
        public bool Estado { get; set; }
        public int IdInquilino { get; set; }
        public int IdInmueble { get; set; }
        public Inquilino Inquilino { get; set; }
        public Inmueble Inmueble { get; set; }

        public Contrato() { }

        public Contrato(int idContrato, DateTime fechaInicio, DateTime fechaFinalizacion, double montoAlquiler,
                        bool estado, int idInquilino, int idInmueble, Inquilino inquilino, Inmueble inmueble)
        {
            IdContrato = idContrato;
            FechaInicio = fechaInicio;
            FechaFinalizacion = fechaFinalizacion;
            MontoAlquiler = montoAlquiler;
            Estado = estado;
            IdInquilino = idInquilino;
            IdInmueble = idInmueble;
            Inquilino = inquilino;
            Inmueble = inmueble;
        }
    }
}
