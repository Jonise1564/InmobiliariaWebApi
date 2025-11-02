using System;


namespace Inmobiliariaapi.Models
{
    public class Pago
    {
        public int IdPago { get; set; }
        public DateTime FechaPago { get; set; }
        public double Monto { get; set; }
        public string Detalle { get; set; }
        public bool Estado { get; set; }
        public int IdContrato { get; set; }

        // Relación con contrato
        public Contrato Contrato { get; set; }

        // Constructor vacío
        public Pago() { }

        // Constructor completo
        public Pago(int idPago, DateTime fechaPago, double monto, string detalle, bool estado, int idContrato, Contrato contrato)
        {
            IdPago = idPago;
            FechaPago = fechaPago;
            Monto = monto;
            Detalle = detalle;
            Estado = estado;
            IdContrato = idContrato;
            Contrato = contrato;
        }
    }
}
