using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_CU102_Grupo5.Controladores;
using PPAI_CU102_Grupo5.Modelos;

namespace PPAI_CU102_Grupo5
{
    public partial class PantallaRegistrarVenta : Form
    {
        public GestorRegistrarVenta gestorRegistrarVenta;
        private Sesion sesionActual;
        public PantallaRegistrarVenta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gestorRegistrarVenta = new GestorRegistrarVenta();
            sesionActual = new Sesion();
            sesionActual.Usuario = new Usuario();
            sesionActual.Usuario.Empleado = new Empleado();
            sesionActual.Usuario.Empleado.Sede = new Sede();
            //repositorio.getUsuarios() ; 
            //repositorio.getSesiones();

            var tarifa = new Tarifa();

            sesionActual.Usuario.Empleado.Sede.Tarifas.Add(tarifa);


            
    

        }

        private void opcionRegistrarVentaEntrada()
        {
            this.habilitarPantalla();

            this.gestorRegistrarVenta.opcionRegistrarVentaEntrada(sesionActual, this);


        }

        private void habilitarPantalla()
        {
            this.CBTarifas.Visible = true;
            this.TxtTarifas.Visible = true;
            this.BtnOpcionRegistrarVentaEntrada.Visible = false;
            this.BtnConfirmar.Visible = true; 

            
        }

        public void solicitarCantidadEntradas()
        {
            this.CBTarifas.Visible = false;
            this.TxtTarifas.Visible = false;
            this.BtnConfirmar.Visible = false;

            NmbCantidad.Visible = true;
            BtnConfirmarCantidad.Visible = true;
            LblCantidad.Visible = true; 

        }

        public void mostrarTarifasVigentes(List<string> tarifasVigentes)
        {

            CBTarifas.Items.Add(tarifasVigentes[0].ToString()) ;

        }

        internal void mostrarDatosEntrada(int cantidad, float precio ,float montoTotal )
        {

            NmbCantidad.Visible = false;
            BtnConfirmarCantidad.Visible = false;
            LblCantidad.Visible = false;

            LblMostrarCantidad.Visible = true;
            LblPrecio.Visible = true;
            LblTotal.Visible = true;
            BtnConfirmarVenta.Visible = true;

            LblMostrarCantidad.Text = "Cantidad entradas : " + cantidad.ToString();
            LblPrecio.Text = "Precio por entrada : $" + precio.ToString();
            LblTotal.Text = "Total : $ " + montoTotal.ToString();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnOpcionRegistrarVentaEntrada_Click(object sender, EventArgs e)
        {
            this.opcionRegistrarVentaEntrada();
        }

        private void tomarSeleccionCantidadEntradas(int cantidad)
        {
            gestorRegistrarVenta.tomarSeleccionCantidadEntradas(cantidad, this);
        }
        private void BtnConfirmarCantidad_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(NmbCantidad.Value.ToString());
            tomarSeleccionCantidadEntradas(cantidad);
        }

        private void tomarSeleccionTarifa(string tarifa)
        {
            Tarifa seleccionada = sesionActual.Usuario.Empleado.Sede.Tarifas.Where(tar => tar.Id == int.Parse(tarifa)).FirstOrDefault();
            gestorRegistrarVenta.tomarSeleccionTarifa(seleccionada,this);
        }
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            var tarifa = CBTarifas.SelectedItem.ToString().Split(' ');
            
            tomarSeleccionTarifa(tarifa[0]);
        }
    }
}
