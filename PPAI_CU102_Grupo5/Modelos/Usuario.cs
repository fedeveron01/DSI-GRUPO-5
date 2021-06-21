using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class Usuario
    {
        public Empleado Empleado { get; set; }
        public Empleado conocerEmpleado()
        {
            return this.Empleado;
        }
    }
}
