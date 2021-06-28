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
        private DateTime? FechaCierre;
        private DateTime FechaInicio;
        private int IdExposicion;
        private string Nombre;

        private List<DetalleExposicion> DetallesExposicion;


        // Inicio Seteo

        public void setFechaCierre (DateTime fechaCierre)
        {
            FechaCierre = fechaCierre;
        }

        public void setIdExposicion(int idExposicion)
        {
            IdExposicion = idExposicion;
        }
        public void setDetalleExposicion(List<DetalleExposicion> detalleExposicion)
        {
            DetallesExposicion = detalleExposicion; 
        }
        
        public void setFechaInicio (DateTime fechaInicio)
        {
            FechaInicio = fechaInicio;
        }

        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }

    

        // Fin Seteo

        
        // Get id de la exposicion
        public int getIdExposicion()
        {
            return IdExposicion;
        }


        //  Valida que sean exposiciones vigentes 
        public bool esVigente()
        {
            return DateTime.Now <= FechaCierre  || FechaCierre==null;
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