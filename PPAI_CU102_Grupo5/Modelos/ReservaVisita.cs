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

        // Inicio Seteo

        public void setCantidadAlumnos(int cantidadAlumnos)
        {
            CantidadAlumnos = cantidadAlumnos;
        }

        public void setCantidadConfirmada(int cantidadConfirmada)
        {
            CantidadConfirmada = cantidadConfirmada;
        }

        public void setFechaHoraCreacion(DateTime fechaHoraCreacion)
        {
            FechaHoraCreacion = fechaHoraCreacion;
        }

        public void setFechaHoraReserva(DateTime fechaHoraReserva)
        {
            FechaHoraReserva = fechaHoraReserva;
        }

        public void setNumeroReserva(int numeroReserva)
        {
            NumeroReserva = numeroReserva;
        }

        public void setHoraFinReal(DateTime horaFinReal)
        {
            HoraFinReal = horaFinReal;
        }

        public void setHoraInicialReal(DateTime horaInicialReal)
        {
           HoraInicialReal = horaInicialReal;
        }

        // Fin Seteo


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