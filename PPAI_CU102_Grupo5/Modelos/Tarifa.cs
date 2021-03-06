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


        // Inicio Seteo

        public void setId(int id)
        {
            Id = id;
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

        // Fin Seteo



        // Retorna el un tipo de visita
        public TipoVisita getTipoVisita()
        {
            return TipoVisita;
        }


        // Retorna un tipo de entrada
        public TipoEntrada getTipoEntrada()
        {
            return TipoEntrada;
        }

        private Tarifa conocerTarifa()
        {
            return this;
        }


        // Retorna el id de la tarifa
        public int getId()
        {
            return Id;
        }


        // Retorna el monto de la tarifa
        public float getMonto()
        {

            return Monto;
        }


        //Retorna el monto adicional por guia de la tarifa
        public float getMontoAdicionalGuia()
        {
            return MontoAdicional;
        }
        

        // Verifica que la tarifa sea vigente (fecha de fin vigencia > fecha actual)
        public bool esVigente()
        {
            return DateTime.Now < FechaFinVigencia;
        }
    }
}
