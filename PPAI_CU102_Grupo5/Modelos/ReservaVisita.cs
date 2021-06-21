using System;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class ReservaVisita
    {
        private int CantidadAlumnos { get; set; }
        private int CantidadConfirmada { get; set; }

        private DateTime FechaHoraCreacion { get; set; }
        private DateTime FechaHoraReserva { get; set; }

        private int NumeroReserva { get; set; }
        private DateTime? HoraFinReal { get; set; }
        private DateTime? HoraInicialReal { get; set; }
        public bool esFechaHora(DateTime fecha)
        {
            return fecha >= FechaHoraReserva ; 
        }

        public bool sinFechaFin()
        {
            return HoraFinReal == null ;
        }

        public int getCantidadConfirmada()
        {
            
            return CantidadConfirmada;
        }
    }

  
}