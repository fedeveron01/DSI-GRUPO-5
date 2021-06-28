using PPAI_CU102_Grupo5.Modelos;
using PPAI_CU102_Grupo5.Pantallas;
using PPAI_CU102_Grupo5.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU102_Grupo5.Controladores
{
    public class GestorRegistrarVenta
    {
        private Sede sedeActual;
        private Tarifa TarifaSeleccionada;
        private List<Entrada> entradas;
        private float montoEntrada;
        private Impresora impresora;
        private PantallaEntrada pantallaEntrada;
        private PantallaSala pantallaSala;
        private int cantidadMaxima;

        public GestorRegistrarVenta(Impresora impresora,PantallaEntrada pantallaEntrada,PantallaSala pantallaSala)
        {
            this.impresora = impresora;
            this.pantallaSala = pantallaSala;
            this.pantallaEntrada = pantallaEntrada;
            entradas = RepositorioEntrada.getEntradas();
        }


        public void opcionRegistrarVentaEntrada(Sesion sesionActual, PantallaRegistrarVenta pantallaRegistrarVenta)
        {
            sedeActual = buscarSedeActual(sesionActual);
            
            var tarifasVigentes = buscarTarifasVigentesYExistentes(sedeActual);
            pantallaRegistrarVenta.mostrarTarifasVigentes(tarifasVigentes);

        }


        // Busca y retorna una lista de tarifas vigentes y existentes de la sede actual
        public List<string> buscarTarifasVigentesYExistentes(Sede sedeActual)
        {
            return sedeActual.buscarTarifasVigentes();

        }

        // Calcula la duracion estimada para las exposiciones vigentes
        public int calcularDuracionEstimada()
        {
            return sedeActual.calcularDuracionExposicionesVigentes();
        }
        public Sede buscarSedeActual(Sesion sesionActual)
        {
            var usuario = sesionActual.conocerUsuario();
            var empleado = usuario.conocerEmpleado();
            var sede =empleado.conocerSede();
            return sede;
        }


        // Toma la seleccion de tarifa calcula la duracion estimada y solicita la cantidad de entradas
        public void tomarSeleccionTarifa(Tarifa seleccionada,PantallaRegistrarVenta pantalla)
        {
            TarifaSeleccionada = seleccionada;
            var duracion = calcularDuracionEstimada();
        //  MessageBox.Show(duracion.ToString());
            pantalla.solicitarCantidadEntradas();
        }


        // Obtiene la fecha y hora actual
        private DateTime obtenerFechaHoraActual()
        {
            return DateTime.Now;
        }

        // Busca la capacidad maxima de la sede y la resta con la cantidad de visitantes actuales y ese numero se compara con la cantidad de entradas que desea comprar
        // retornando en caso de ser falso un mensaje de error.
        private void buscarCapacidadSede(int cantidad, PantallaRegistrarVenta pantallaRegistrarVenta)
        {
            var fecha = obtenerFechaHoraActual();
            cantidadMaxima = sedeActual.getCantidadMaximaVisitantes()- sedeActual.getCantidadMaximaVisitantes(fecha) ;
            if (validarCantidadVisitantes(cantidad, cantidadMaxima))
            {
                var monto = calcularMontoAPagar(cantidad);
                pantallaRegistrarVenta.mostrarDatosEntrada(cantidad,montoEntrada,monto);
            }
            else
            {
                MessageBox.Show("La cantidad de entradas ingresadas supera la capacidad disponible de la sede "+sedeActual.getNombre() +" ( "+cantidadMaxima.ToString()+ " )" );
            }

        }


        // Busca el monto por tarifa sumando el monto adicional en caso de tener y lo retorna
        private float calcularMontoAPagar(int cantidad)
        {
            montoEntrada = (TarifaSeleccionada.getMonto() + TarifaSeleccionada.getMontoAdicionalGuia());
            float monto =  montoEntrada * cantidad;
            return monto;
        }


        // Valida que una cantidad sea menor o igual a otra
        private bool validarCantidadVisitantes(int cantidadIngresada, int cantidadMaxima)
        {
            return cantidadIngresada <= cantidadMaxima;
        }
         
        public void tomarSeleccionCantidadEntradas(int cantidad, PantallaRegistrarVenta pantallaRegistrarVenta)
        {
            buscarCapacidadSede(cantidad, pantallaRegistrarVenta);
        }
        public void tomarConfirmacion(int cantidadIngresada,PantallaRegistrarVenta pantallaRegistrarVenta)
        {
            var nro= buscarUltimoNumeroEntrada();
            var entradas = generarEntradas(cantidadIngresada,nro);
            imprimirEntradas(entradas);
            actualizarVistasEnPantallas(cantidadIngresada);
            finCU(pantallaRegistrarVenta);
        }

        private void finCU(PantallaRegistrarVenta pantallaRegistrarVenta)
        {
            MessageBox.Show("Venta realizada con éxito");
            pantallaRegistrarVenta.Close();
        }
        private void actualizarVistasEnPantallas(int cantidadIngresada)
        {

            pantallaEntrada.Visible = true;
            pantallaEntrada.actualizarPantalla(sedeActual.getCantidadMaximaVisitantes()+cantidadIngresada-cantidadMaxima,sedeActual.getCantidadMaximaVisitantes());
           
            
            pantallaSala.Visible = true;
            for (var i = 1; i < 5; i++)
            {
                pantallaSala.actualizarPantalla(i,sedeActual.getCantidadMaximaVisitantes() + cantidadIngresada - cantidadMaxima, sedeActual.getCantidadMaximaVisitantes());
                

            }


        }

    

        private void imprimirEntradas(List<Entrada> entradas)
        {
            impresora.Visible = true;
            for(var i = 0; i < entradas.Count; i++)
            {
                impresora.imprimir(entradas[i]);

            }
            impresora.Visible = false;


        }

        private List<Entrada> generarEntradas(int cantidadIngresada,int nro)
        {
            var idEntrada = nro;
            var entradas = new List<Entrada>();

            for(var i = 0; i < cantidadIngresada; i++)
            {
                idEntrada += 1; 
                var nuevaEntrada = new Entrada(idEntrada,montoEntrada);
                entradas.Add(nuevaEntrada);
            }

            RepositorioEntrada.generarEntradas(entradas);
            return entradas;

        }

        private int buscarUltimoNumeroEntrada()
        {
            var ultimoNro = 0;
            for (var i =0; i<entradas.Count; i++)
            {
                var nroEntrada = entradas[i].getNumero();
                if (nroEntrada > ultimoNro)
                    ultimoNro = nroEntrada;
            }

            return ultimoNro;
        }
    }
}
