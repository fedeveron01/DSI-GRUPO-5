using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Modelos

{
    public class TipoEntrada
    {
        private int Id;
        private string Nombre;

        // Inicio Seteo

        public void setId (int id)
        {
            Id = id;
        }

        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }

        // Fin Seteo

        public string getNombre()
        {
            return Nombre;
        }

    }
}
