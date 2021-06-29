using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class Entrada
    {
        private int NumeroEntrada;
        private DateTime FechaVenta;
        private string HoraVenta;
        private float Monto;


        public Entrada(int numeroEntrada,float montoEntrada)
        {
            NumeroEntrada = numeroEntrada;
            FechaVenta = DateTime.Now.Date;
            HoraVenta = DateTime.Now.ToString("hh:mm");
            Monto = montoEntrada;
        }

        public Entrada()
        {

        }
        // Inicio seteo

        public void setNumeroEntrada(int numeroEntrada)
        {
                        NumeroEntrada = numeroEntrada;
        }

        public void setFechaVenta(DateTime fechaVenta)
        {
            FechaVenta = fechaVenta;
        }

        public void setHoraVenta(string horaVenta)
        {
            HoraVenta = horaVenta;
        }

        public void setMonto (float monto)
        {
            Monto = monto;
        }

   


        // Fin seteo


        // Retorna numero de entrada
        public int getNumero()
        {
            return NumeroEntrada;
        }

        // Retorna el monto de la entrada
        public float getMonto()
        {
            return Monto;
        }


        // Retorna la hora de la venta
        public string getHoraVenta()
        {
            return HoraVenta;
        }


        // Retorna la fecha de venta
        public DateTime getFechaVenta()
        {
            return FechaVenta;
        }

    }
}
