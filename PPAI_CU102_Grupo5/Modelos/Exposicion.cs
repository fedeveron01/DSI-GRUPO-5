using System;
using System.Collections.Generic;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class Exposicion
    {
        public Exposicion()
        {
            DetallesExposicion = new List<DetalleExposicion>();


        }
        private DateTime FechaCierre;
        private DateTime FechaInicio;
        
        public List<DetalleExposicion> DetallesExposicion { get; set; }

        public void setFechaCierre (DateTime fechaCierre)
        {
            FechaCierre = fechaCierre;
        }

        public void setFechaInicio (DateTime fechaInicio)
        {
            FechaInicio = fechaInicio;
        }
                    

        public bool esVigente()
        {
            return DateTime.Now < FechaCierre ;
        }

        public int calcularDuracionObrasExpuestas()
        {
            int duracionObras = 0;
            //mientras existan detalles de exposición
            for(var i=0;i<DetallesExposicion.Count; i++)
            {
                 duracionObras += DetallesExposicion[i].buscarDuracionResumidaObra();

            }
            return duracionObras;
        }
    }
}