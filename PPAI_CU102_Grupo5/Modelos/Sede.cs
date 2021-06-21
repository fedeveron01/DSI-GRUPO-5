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
        public int Id { get; set; }
        public List<Tarifa> Tarifas { get; set; }
        public List<ReservaVisita> ReservasVisita { get; set; }
        public List<Exposicion> Exposiciones { get; set; }
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
                    detalleTarifa += Tarifas[i].Id;
                    detalleTarifa += " Tipo de visita : " + tarifa.TipoVisita.getNombre();
                    detalleTarifa += "Monto: $" + tarifa.getMonto().ToString();
                    detalleTarifa += "Monto adicional : $" + tarifa.getMontoAdicionalGuia().ToString();

                    tarifasAMostrar.Add(detalleTarifa);

                }
            }
            return tarifasAMostrar;

        }

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
