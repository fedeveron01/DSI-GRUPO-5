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
        //Busca las sesiones en el servidor 
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
            //Busca en el servidor la sesion actual para encontrar la sede
            BaseDatos bd = new BaseDatos();
            var consulta = "SELECT * FROM SESION INNER JOIN USUARIO u ON usuario=u.id INNER JOIN Empleado e ON u.empleado = e.dni INNER JOIN SEDE s ON e.sede=s.idSede WHERE fechaFin is Null";
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

                sede.setId(Int32.Parse(resultado["idSede"].ToString()));

                sede.setNombre(resultado["nombreSede"].ToString());
                sede.setCantidadMaximaVisitantes(Int32.Parse(resultado["cantMaximaVisitantes"].ToString()));
                sede.setCantidadMaximaPorGuia(Int32.Parse(resultado["cantMaxPorGuia"].ToString()));

                empleado.setSede(sede);


                // buscar tarifas de la sede
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
                    tar.setId(Int32.Parse(filaTarifas["id"].ToString()));

                    var tipoEntrada = new TipoEntrada();
                    tipoEntrada.setNombre(filaTarifas["nombre"].ToString());

                    var tipoVista = new TipoVisita();
                    tipoVista.setNombre(filaTarifas["nombreTipoVisita"].ToString());

                    tar.setTipoEntrada(tipoEntrada);
                    tar.setTipoVisita(tipoVista);
                    tarifas.Add(tar);


                }

                sede.setTarifas(tarifas);

                // buscar reservas de la sede
                var consultaReservas = "SELECT * FROM RESERVASXSEDE INNER JOIN ReservaVisita r ON id_reserva = r.numeroReserva  WHERE id_sede =" + sede.getId().ToString();
                DataTable resReservas = bd.consulta(consultaReservas);


                var reservas = new List<ReservaVisita>();

                foreach (DataRow filaReservas in resReservas.Rows)
                {
                    var reservaVisita = new ReservaVisita();

                    
                    reservaVisita.setCantidadAlumnos(Int32.Parse(filaReservas["cantidadAlumnos"].ToString()));
                    reservaVisita.setFechaHoraCreacion(DateTime.Parse(filaReservas["fechaHoraCreacion"].ToString()));
                    reservaVisita.setCantidadConfirmada(Int32.Parse(filaReservas["cantidadConfirmada"].ToString()));
                    reservaVisita.setFechaHoraReserva(DateTime.Parse(filaReservas["fechaHoraReserva"].ToString()));
                    reservaVisita.setNumeroReserva(Int32.Parse(filaReservas["numeroReserva"].ToString()));
                    if(filaReservas["horaFinReal"].ToString() != "")
                    {
                        reservaVisita.setHoraFinReal(DateTime.Parse(filaReservas["horaFinReal"].ToString()));

                    }
                    if (filaReservas["horaInicialReal"].ToString() != "")
                    {
                        reservaVisita.setHoraInicialReal(DateTime.Parse(filaReservas["horaInicialReal"].ToString()));

                    }

                    reservas.Add(reservaVisita);
                }

                sede.setReservasVisita(reservas);

                // buscar exposiciones de la sede 
                var consultaExposiciones = "SELECT * FROM ExposicionesXSede INNER JOIN Exposicion e ON id_exposicion = e.idExposicion  WHERE id_sede =" + sede.getId().ToString();
                DataTable resExposiciones = bd.consulta(consultaExposiciones);


                var exposiciones = new List<Exposicion>();

                foreach (DataRow filaExposiciones in resExposiciones.Rows)
                {
                    var exposicion = new Exposicion();
                    exposicion.setFechaInicio(DateTime.Parse(filaExposiciones["fechaInicio"].ToString()));
                    if(filaExposiciones["fechaFin"].ToString() != "")
                    {
                        exposicion.setFechaCierre(DateTime.Parse(filaExposiciones["fechaFin"].ToString()));

                    }
                    exposicion.setNombre(filaExposiciones["nombre"].ToString());
                    exposicion.setIdExposicion(Int32.Parse(filaExposiciones["idExposicion"].ToString()));
                    exposiciones.Add(exposicion);
                }

                sede.setExposiciones(exposiciones);


                // buscar detalles exposiciones y obra
                for (var i = 0; i < exposiciones.Count; i++)
                {
                    var consultaDetalles = "SELECT * FROM DetalleExposicion INNER JOIN Obra o ON idObra=o.id WHERE idExposicion =" + exposiciones[i].getIdExposicion().ToString();
                    DataTable resDetalles = bd.consulta(consultaDetalles);

                    var detalles = new List<DetalleExposicion>();

                    foreach (DataRow filaDetalle in resDetalles.Rows)
                    {
                        var detalle = new DetalleExposicion();
                        var obra = new Obra();
                        detalle.setLugarAsignado(filaDetalle["lugarAsignado"].ToString());
                        obra.setDuracionResumida(Int32.Parse(filaDetalle["duracionResumida"].ToString()));
                        obra.setNombreObra(filaDetalle["nombreObra"].ToString());

                        detalle.setObra(obra);


                        detalles.Add(detalle);
                    }

                    exposiciones[i].setDetalleExposicion(detalles);
                }
            


            }

            return sesion;


        }


    }
}
