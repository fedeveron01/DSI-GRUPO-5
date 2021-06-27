using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class Sesion
    {
        private Usuario Usuario;

        private DateTime? FechaFin;
        private DateTime FechaInicio;
        private string HoraFin;
        private string HoraInicio;


        public void setFechaFin(DateTime fechaFin)
        {
            FechaFin = fechaFin;
        }

        public void setFechaInicio(DateTime fechaInicio)
        {
            FechaInicio = fechaInicio;
        }
        public void setHoraFin(string horaFin)
        {
            HoraFin = horaFin;
        }

        public void setHoraInicio(string horaInicio)
        {
            HoraInicio = horaInicio;
        }

        public Usuario conocerUsuario()
        {
            return Usuario;
        }
    

        public void setUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }
    }

}
