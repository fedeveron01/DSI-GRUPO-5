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
    public class RepositorioSesion
    { 
        public void getSesiones()
        {
              BaseDatos bd = new BaseDatos();
            var consulta = "SELECT * FROM SESION INNER JOIN USUARIO u ON usuario=u.id INNER JOIN Empleado e ON u.empleado = e.dni INNER JOIN SEDE s ON e.sede=s.id";
              DataTable res = bd.consulta(consulta);


            foreach (DataRow resultado in res.Rows){
                var sesion = new Sesion();
            
                var r = resultado["dni"];
                MessageBox.Show(r.ToString());
            }   
            

         }

        public Sesion getSesionActual()
        {
            BaseDatos bd = new BaseDatos();
            var consulta = "SELECT * FROM SESION INNER JOIN USUARIO u ON usuario=u.id INNER JOIN Empleado e ON u.empleado = e.dni INNER JOIN SEDE s ON e.sede=s.id WHERE fechaFin is Null";
            DataTable res = bd.consulta(consulta);
            var sesion = new Sesion();
            var usuario = new Usuario();
            var empleado = new Empleado();
            var sede = new Sede();
            // traer resultado de tabla de base de datos al codigo
            foreach (DataRow resultado in res.Rows)
            {
                sesion.setHoraInicio(resultado["horaInicio"].ToString());
                sesion.setFechaInicio(DateTime.Parse(resultado["fechaInicio"].ToString()));
            
                usuario.setNombre(resultado["nombreUsuario"].ToString());
                if(resultado["caducidad"].ToString() != "")
                    usuario.setCaducidad(Int32.Parse(resultado["caducidad"].ToString()));

                usuario.setContraseña(resultado["contraseña"].ToString());


                sesion.setUsuario(usuario);

                empleado.setApellido(resultado["apellido"].ToString());
                empleado.setNombre(resultado["nombre"].ToString());
                empleado.setCuit(Int64.Parse(resultado["cuit"].ToString()));
                empleado.setDni(Int32.Parse(resultado["dni"].ToString()));
                empleado.setFechaIngreso(DateTime.Parse(resultado["fechaIngreso"].ToString()));

                usuario.setEmpleado(empleado);

                sede.setId(Int32.Parse(resultado["id"].ToString()));

                sede.setNombre(resultado["nombreSede"].ToString());
                sede.setCantidadMaximaVisitantes(Int32.Parse(resultado["cantMaximaVisitantes"].ToString()));
                sede.setCantidadMaximaPorGuia(Int32.Parse(resultado["cantMaxPorGuia"].ToString()));

                empleado.setSede(sede);


                // hacer un for en tabla TarifaXSede
                var consulta2 = "SELECT * FROM TARIFASXSEDE INNER JOIN TARIFA t ON id_tarifa = t.id INNER JOIN TIPODEENTRADA tip ON tip.id=tipoDeEntrada INNER JOIN TIPOVISITA tipV ON tipV.id=tipoVisita WHERE id_sede =" + sede.getId().ToString();
                DataTable resTarifas = bd.consulta(consulta2);


                var tarifas = new List<Tarifa>();

                foreach (DataRow filaTarifas in resTarifas.Rows)
                {
                    var tar = new Tarifa();
                    tar.setFechaFinVigencia(DateTime.Parse(filaTarifas["fechaFinVigencia"].ToString()));
                    tar.setFechaInicioVigencia(DateTime.Parse(filaTarifas["fechaInicioVigencia"].ToString()));
                    tar.setMonto(Int32.Parse(filaTarifas["monto"].ToString()));
                    tar.setMontoAdicional(Int32.Parse(filaTarifas["montoAdicionalGuia"].ToString()));

                    var tipoEntrada = new TipoEntrada();
                    tipoEntrada.setNombre(filaTarifas["nombre"].ToString());

                    var tipoVista = new TipoVisita();
                    tipoVista.setNombre(filaTarifas["nombreTipoVisita"].ToString());

                    tar.setTipoEntrada(tipoEntrada);
                    tar.setTipoVisita(tipoVista);
                    tarifas.Add(tar);


                }

                sede.setTarifas(tarifas);



               
                
            }

            return sesion;


        }


    }
}
