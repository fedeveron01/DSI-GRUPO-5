using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class Usuario
    {
        private int Caducidad;

        private string Contraseña;
        private string Nombre;


        private Empleado Empleado;


        public int getCaducidad()
        {
            return Caducidad;
        }

        public void setCaducidad(int caducidad)
        {
            Caducidad = caducidad;

        }

        public string getContraseña()
        {
            return Contraseña;
        } 
        public void setContraseña(string contraseña)
        {
            Contraseña = contraseña;
        }

        public void setEmpleado(Empleado empleado)
        {
            Empleado = empleado;
        }

        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public Empleado conocerEmpleado()
        {
            return this.Empleado;
        }
     
    }
}
