using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class Tarifa
    { 
        public int Id { get; set; }
        public TipoEntrada TipoEntrada { get; set; }
        public TipoVisita TipoVisita { get; set; }

        public Tarifa conocerTarifa()
        {
            return this;
        }

        public bool esVigente()
        {
            return true;
        }
    }
}
