using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU102_Grupo5.Modelos
{
    public interface ISujetoCantidadVisitantes
    {
        public void actualizarVistasEnPantallas(int cantidadIngresada);
        public void suscribir(IObservadorCantidadVisitantes observador);

        public void quitar(IObservadorCantidadVisitantes observador);


    }
}
