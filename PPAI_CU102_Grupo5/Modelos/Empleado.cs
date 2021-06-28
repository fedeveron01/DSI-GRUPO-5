using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class Empleado
    {
        private Sede Sede { get; set; }
        private int Dni;
        private long Cuit;
        private string Apellido;
        private string Nombre;
        private DateTime FechaNacimiento;
        private string Sexo;
        private long Telefono;
        private string Mail;
        private DateTime FechaIngreso;

        
        public Empleado()
        {

        }

        // Inicio Seteo

        public void setDni(int dni)
        {
            Dni = dni;
        }

        public void setCuit(long cuit)
        {
            Cuit = cuit;
        }

        public void setApellido(string apellido)
        {
            Apellido = apellido;
        }

        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        
        public void setFechaIngreso(DateTime fechaIngreso)
        {
            FechaIngreso = fechaIngreso;
        }
        public void setMail(string mail)
        {
            Mail = mail;
        }
        public void setFechaNacimiento(DateTime fechaNacimiento)
        {
            FechaNacimiento = fechaNacimiento;
        }

        public void setSexo(string sexo)
        {
            Sexo = sexo;
        }

        public void setTelefono(long telefono)
        {
            Telefono = telefono;
        }

  
        public void setSede(Sede sede)
        {
            Sede = sede; 
        }

        // Fin Seteo


        public Sede conocerSede()
        {
            return this.Sede;
        }
    }
}
