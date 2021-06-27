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
        private int Id;
        
        private DateTime FechaFinVigencia;
        private DateTime FechaInicioVigencia;
        private float Monto;
        private float MontoAdicional;
        private TipoEntrada TipoEntrada;
        private TipoVisita TipoVisita;

        private Tarifa conocerTarifa()
        {
            return this;
        }
        
        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }

        public TipoVisita getTipoVisita()
        {
            return TipoVisita;
        }
        public void setFechaFinVigencia (DateTime fechaFinVigencia)
        {
            FechaFinVigencia = fechaFinVigencia;
        }

        public void setFechaInicioVigencia(DateTime fechaInicioVigencia)
        {
            FechaInicioVigencia = fechaInicioVigencia;
        }

        public void setMonto(int monto)
        {
            Monto = monto;
        }

        public void setTipoVisita(TipoVisita tipoVisita)
        {
            TipoVisita = tipoVisita;
        }

        public void setTipoEntrada(TipoEntrada tipoEntrada)
        {
            TipoEntrada = tipoEntrada;

        }
        public void setMontoAdicional(int montoAdicional)
        {
            MontoAdicional = montoAdicional;
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
