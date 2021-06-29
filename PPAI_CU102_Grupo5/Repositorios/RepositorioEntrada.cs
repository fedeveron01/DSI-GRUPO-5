using PPAI_CU102_Grupo5.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU102_Grupo5.Repositorios
{
    static class RepositorioEntrada
    {
        // Busca del servidor las entradas existentes
        public static List<Entrada> getEntradas()
        {
            BaseDatos bd = new BaseDatos();
            var consulta = "SELECT * FROM ENTRADA ";
            DataTable res = bd.consulta(consulta);

            var entradas = new List<Entrada>();


            foreach (DataRow resultado in res.Rows)
            {
                var entrada = new Entrada();
                entrada.setFechaVenta(DateTime.Parse(resultado["fechaVenta"].ToString()));
                entrada.setHoraVenta(resultado["horaVenta"].ToString());
                entrada.setMonto(float.Parse(resultado["monto"].ToString()));
                entrada.setNumeroEntrada(Int32.Parse(resultado["nroEntrada"].ToString()));

                entradas.Add(entrada);

            }

            bd.desconectar();
            return entradas;
        }


        // Guarda en el servidor las nuevas entradas generadas
        public static void generarEntradas(List<Entrada> nuevasEntradas)
        {
            BaseDatos bd = new BaseDatos();
            string insert = "";
            for (var i = 0; i < nuevasEntradas.Count; i++)
            {
                insert += @"INSERT INTO Entrada(nroEntrada, monto, horaVenta, fechaVenta) VALUES(" +
                    nuevasEntradas[i].getNumero().ToString() + ',' +
                    nuevasEntradas[i].getMonto().ToString() + ',' +
                    "'"+nuevasEntradas[i].getHoraVenta().ToString() + "'," +
                    "'"+nuevasEntradas[i].getFechaVenta().ToString("yyyy-MM-dd") + "');";
            }
            bd.insertar(insert);
        }
    }

}
