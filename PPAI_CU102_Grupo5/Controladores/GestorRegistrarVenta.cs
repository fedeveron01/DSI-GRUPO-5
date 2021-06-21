using PPAI_CU102_Grupo5.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Controladores
{
    public class GestorRegistrarVenta
    {
        public PantallaRegistrarVenta pantallaRegistrarVenta;
        public Sede sedeActual;
        public GestorRegistrarVenta()
        {
        }


        public void opcionRegistrarVentaEntrada(Sesion sesionActual, PantallaRegistrarVenta pantallaRegistrarVenta)
        {
            var sedeActual = buscarSedeActual(sesionActual);
            var tarifasVigentes = buscarTarifasVigentesYExistentes(sedeActual);
            pantallaRegistrarVenta.mostrarTarifasVigentes(tarifasVigentes);

        }
        public List<string> buscarTarifasVigentesYExistentes(Sede sedeActual)
        {
            return sedeActual.buscarTarifasVigentes();

          

        }


   
        public Sede buscarSedeActual(Sesion sesionActual)
        {
            var usuario = sesionActual.conocerUsuario();
            var empleado = usuario.conocerEmpleado();
            var sede =empleado.conocerSede();
            return sede;
        }

    }
}
