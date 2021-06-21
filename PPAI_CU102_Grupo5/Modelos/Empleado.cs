using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class Empleado
    {
        public Sede Sede { get; set; }
        public Sede conocerSede()
        {
            return this.Sede;
        }
    }
}
