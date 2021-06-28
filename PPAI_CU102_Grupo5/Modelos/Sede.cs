using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class Sede
    {
        public Sede()
        {
            Tarifas = new List<Tarifa>();
            Exposiciones = new List<Exposicion>();
            Exposiciones.Add(new Exposicion());
            ReservasVisita = new List<ReservaVisita>();
            ReservasVisita.Add(new ReservaVisita());

        }
        private int CantidadMaximaVisitantes;
        private int CantidadMaximaPorGuia;
        private string Nombre;
        private int Id;
        private List<Tarifa> Tarifas;
        private List<ReservaVisita> ReservasVisita;
        private List<Exposicion> Exposiciones;


        // Inicio Seteo

        public void setNombre(string nombre)
        {
            Nombre = nombre;

        }

        public void setId (int id)
        {
            Id = id;
        }

        public string getNombre()
        {
            return Nombre;
        }
 
        public int getId()
        {
            return Id;
        }
        public int getCantidadMaximaVisitantes()
        {
            return CantidadMaximaVisitantes;
        }

        public void setCantidadMaximaVisitantes(int cantidadMaxima)
        {
            CantidadMaximaVisitantes = cantidadMaxima;
        }

        public List<Tarifa> getTarifas()
        {
            return Tarifas;
        }

        public void setTarifas(List<Tarifa> tarifas)
        {
            Tarifas = tarifas;
        }

        public void setReservasVisita(List<ReservaVisita> reservasVista)
        {
            ReservasVisita = reservasVista;
        }

        public void setExposiciones(List<Exposicion> exposiciones)
        {
            Exposiciones = exposiciones;
        }
        public void setCantidadMaximaPorGuia(int cantidadMaximaPorGuia)
        {
            CantidadMaximaPorGuia = cantidadMaximaPorGuia;
        }

        // Fin Seteo


        // Busca y retorna una lista de tarifas vigentes 
        public List<string> buscarTarifasVigentes()
        {
            var tarifasAMostrar = new List<string> { };

            var detalleTarifa = "";



            //buscar vigentes
            for (int i = 0; i < Tarifas.Count; i++)
            {
                if (Tarifas[i].esVigente())
                {
                    var tarifa = Tarifas[i];
                    detalleTarifa += Tarifas[i].getId();
                    detalleTarifa += " Tipo de visita : " + tarifa.getTipoVisita().getNombre().ToString();
                    detalleTarifa += "Monto: $" + tarifa.getMonto().ToString();
                    detalleTarifa += "Monto adicional : $" + tarifa.getMontoAdicionalGuia().ToString();

                    tarifasAMostrar.Add(detalleTarifa);

                }
            }
            return tarifasAMostrar;

        }



        // Calcula la duracion estimada de las exposiciones vigentes y lo retorna 
        public int calcularDuracionExposicionesVigentes()
        {
            List<Exposicion> vigentes = new List<Exposicion>();
            for (var i=0;i<Exposiciones.Count; i++)
            {
                if (Exposiciones[i].esVigente())
                {
                    vigentes.Add(Exposiciones[i]);
                }
            }

            int contador = 0;
            for (var i = 0; i < vigentes.Count; i++)
            {
               contador +=  vigentes[i].calcularDuracionObrasExpuestas();
            }

            return contador;
        }



        // Calcula la cantidad de visitantes dentro del museo
        public int getCantidadMaximaVisitantes(DateTime fechaActual)
        {
            var cantidadConfirmada = 0;
            for (var i = 0; i < ReservasVisita.Count; i++)
            {
                if (ReservasVisita[i].esFechaHora(fechaActual))
                {
                    if (ReservasVisita[i].sinFechaFin())
                    {
                        cantidadConfirmada += ReservasVisita[i].getCantidadConfirmada();
                    }
                }
            }

            return cantidadConfirmada;
        }
    }
}
