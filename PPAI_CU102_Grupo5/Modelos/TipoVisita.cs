using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class TipoVisita
    {
       public TipoVisita()
        {

        }
        private string Nombre;
        private int Id;


        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }

        public void setId (int id)
        {
            Id = id;
        }

        public string getNombre()
        {
            return this.Nombre;
        }

    }
}
