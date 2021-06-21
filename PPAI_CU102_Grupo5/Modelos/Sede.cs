using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class Sede
    { 
        public int Id { get; set; }
        public Tarifa[] Tarifas { get; set; }

        public List<string> buscarTarifasVigentes()
        {
            var tarifasAMostrar = new List<string> { };

            var detalleTarifa = "";

            //buscar vigentes
            for (int i = 0; i < Tarifas.Length; i++)
            {
                if (Tarifas[i].esVigente())
                {
                    var tarifa = Tarifas[i];
                    detalleTarifa += "Monto: $" + tarifa.TipoEntrada.getMonto().ToString();
                    detalleTarifa += "Monto adicional : $" + tarifa.TipoEntrada.getMontoAdicionalGuia().ToString();
                    detalleTarifa += "Tipo de visita : " + tarifa.TipoVisita.getNombre();

                    tarifasAMostrar.Add(detalleTarifa);
                    MessageBox.Show(tarifasAMostrar.Count.ToString());

                }
            }
            return tarifasAMostrar;

        }
    }
}
