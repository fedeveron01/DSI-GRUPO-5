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
        private Sede sedeActual;
        private Tarifa TarifaSeleccionada;
        private float montoEntrada; 
        public GestorRegistrarVenta()
        {
        }


        public void opcionRegistrarVentaEntrada(Sesion sesionActual, PantallaRegistrarVenta pantallaRegistrarVenta)
        {
            sedeActual = buscarSedeActual(sesionActual);
            var tarifasVigentes = buscarTarifasVigentesYExistentes(sedeActual);
            pantallaRegistrarVenta.mostrarTarifasVigentes(tarifasVigentes);



        }
        public List<string> buscarTarifasVigentesYExistentes(Sede sedeActual)
        {
            return sedeActual.buscarTarifasVigentes();

          

        }


        public void calcularDuracionEstimada()
        {
            sedeActual.calcularDuracionExposicionesVigentes();
        }
        public Sede buscarSedeActual(Sesion sesionActual)
        {
            var usuario = sesionActual.conocerUsuario();
            var empleado = usuario.conocerEmpleado();
            var sede =empleado.conocerSede();
            return sede;
        }

        public void tomarSeleccionTarifa(Tarifa seleccionada,PantallaRegistrarVenta pantalla)
        {
            TarifaSeleccionada = seleccionada;
            calcularDuracionEstimada();
            pantalla.solicitarCantidadEntradas();
        }



        private DateTime obtenerFechaHoraActual()
        {
            return DateTime.Now;
        }
        private void buscarCapacidadSede(int cantidad, PantallaRegistrarVenta pantallaRegistrarVenta)
        {
            var fecha = obtenerFechaHoraActual();
            int cantidadMaxima = sedeActual.getCantidadMaximaVisitantes(fecha);
            if (validarCantidadVisitantes(cantidad, cantidadMaxima))
            {
                var monto = calcularMontoAPagar(cantidad);
                pantallaRegistrarVenta.mostrarDatosEntrada(cantidad,montoEntrada,monto);
            }

        }

        private float calcularMontoAPagar(int cantidad)
        {
            montoEntrada = (TarifaSeleccionada.getMonto() + TarifaSeleccionada.getMontoAdicionalGuia());
            float monto =  montoEntrada * cantidad;
            return monto;
        }

        private bool validarCantidadVisitantes(int cantidadIngresada, int cantidadMaxima)
        {
            return cantidadIngresada <= cantidadMaxima;
        }

        public void tomarSeleccionCantidadEntradas(int cantidad, PantallaRegistrarVenta pantallaRegistrarVenta)
        {
            buscarCapacidadSede(cantidad, pantallaRegistrarVenta);
        }
    }
}
