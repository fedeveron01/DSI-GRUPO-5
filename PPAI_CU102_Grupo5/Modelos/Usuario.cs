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


        // Inicio Seteo

        public void setCaducidad(int caducidad)
        {
            Caducidad = caducidad;

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

        // Fin Seteo


        public Empleado getEmpleado()
        {
            return this.Empleado;
        }

        // Get de datos de usuario


        // Retorna la contraseña del usuario
        public string getContraseña()
        {
            return Contraseña;
        }

        public int getCaducidad()
        {
            return Caducidad;
        }

    }
}
