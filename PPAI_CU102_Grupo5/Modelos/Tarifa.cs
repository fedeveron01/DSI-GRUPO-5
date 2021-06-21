using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class Tarifa
    { 
        public Tarifa()
        {
            TipoEntrada = new TipoEntrada();
            TipoVisita = new TipoVisita();
            FechaFinVigencia = DateTime.Now.AddDays(10);
            FechaInicioVigencia = DateTime.Now;
            Monto = 0;
            MontoAdicional = 0;

        }
        public int Id { get; set; }
        public TipoEntrada TipoEntrada { get; set; }
        public TipoVisita TipoVisita { get; set; }

        public DateTime FechaFinVigencia { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public float Monto { get; set; }
        public float MontoAdicional { get; set; }
        public Tarifa conocerTarifa()
        {
            return this;
        }


        public float getMonto()
        {

            return Monto;
        }

        public float getMontoAdicionalGuia()
        {
            return MontoAdicional;
        }
        public bool esVigente()
        {
            return DateTime.Now < FechaFinVigencia;
        }
    }
}
