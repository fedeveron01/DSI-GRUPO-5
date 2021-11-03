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
using PPAI_CU102_Grupo5.Repositorios;

namespace PPAI_CU102_Grupo5
{
    public partial class PantallaRegistrarVenta : Form
    {
        public GestorRegistrarVenta gestorRegistrarVenta;
        private Sesion sesionActual;
        private int cantidadEntradasIngresadas;
        public PantallaRegistrarVenta(GestorRegistrarVenta gestorRegistrarVenta, RepositorioSesion repositorioSesion)
        {

            InitializeComponent();
            this.gestorRegistrarVenta = gestorRegistrarVenta;
            sesionActual = repositorioSesion.getSesionActual();
     

        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
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
            this.BtnCancelar.Visible = true;
            this.CheckGuia.Visible = true;
          
            
        }

        public void solicitarCantidadEntradas()
        {
            this.CBTarifas.Visible = false;
            this.TxtTarifas.Visible = false;
            this.BtnConfirmar.Visible = false;
            this.CheckGuia.Visible = false;

            NmbCantidad.Visible = true;
            BtnConfirmarCantidad.Visible = true;
            LblCantidad.Visible = true;
           
            this.BtnVolverTarifas.Visible = true;

        }

        public void mostrarTarifasVigentes(List<string> tarifasVigentes)
        {
            CBTarifas.Items.Clear();
          for(var i = 0; i < tarifasVigentes.Count; i++)
            {
                CBTarifas.Items.Add(tarifasVigentes[i].ToString());
                
                

            }

        }

        public void mostrarDatosEntrada(int cantidad, float precio ,float montoTotal )
        {

            NmbCantidad.Visible = false;
            BtnConfirmarCantidad.Visible = false;
            LblCantidad.Visible = false;
            BtnVolverTarifas.Visible = false;

            LblMostrarCantidad.Visible = true;
            LblPrecio.Visible = true;
            LblTotal.Visible = true;
            BtnVolverCantidad.Visible = true;

            LblMostrarCantidad.Text = "Cantidad entradas : " + cantidad.ToString();
            LblPrecio.Text = "Precio por entrada : $" + precio.ToString();
            LblTotal.Text = "Total : $ " + montoTotal.ToString();
            solicitarConfirmacion();

        }

        private void solicitarConfirmacion()
        {
            BtnConfirmarVenta.Visible = true;
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
            cantidadEntradasIngresadas = int.Parse(NmbCantidad.Value.ToString());
            tomarSeleccionCantidadEntradas(cantidadEntradasIngresadas);
        }

        private void tomarSeleccionTarifa()
        {
            string[] tarifas = CBTarifas.SelectedItem.ToString().Split(' ');
            string tarifa = tarifas[0];
            Tarifa seleccionada = sesionActual.getUsuario().getEmpleado().getSede().getTarifas().Where(tar => tar.getId() == int.Parse(tarifa)).FirstOrDefault();
            var conGuia = CheckGuia.Checked;
            gestorRegistrarVenta.tomarSeleccionTarifa(seleccionada,conGuia,this);
        }
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            
            tomarSeleccionTarifa();
        }

        public void tomarConfirmacion()
        {
            gestorRegistrarVenta.tomarConfirmacion(cantidadEntradasIngresadas, this);
        }
        private void BtnConfirmarVenta_Click(object sender, EventArgs e)
        {
            tomarConfirmacion();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void desactivarTodo()
        {
            this.BtnCancelar.Visible = false;
            this.BtnConfirmar.Visible = false;
            this.BtnConfirmarCantidad.Visible = false;
            this.BtnConfirmarVenta.Visible = false;
            this.BtnVolverTarifas.Visible = false;
            this.BtnVolverCantidad.Visible = false;
            this.LblCantidad.Visible = false;
            this.LblMensajeEntradas.Visible = false;
            this.LblMensajeTarifas.Visible = false;
            this.LblMostrarCantidad.Visible = false;
            this.LblPrecio.Visible = false;
            this.LblTotal.Visible = false;
            this.CBTarifas.Visible = false;
            this.TxtTarifas.Visible = false;
            this.NmbCantidad.Visible = false;
            this.CheckGuia.Visible = false;
           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La venta ha sido cancelada");
            this.desactivarTodo();
            this.BtnOpcionRegistrarVentaEntrada.Visible = true;


        }

        private void NmbCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (int.Parse(NmbCantidad.Value.ToString()) <= 0)
            {
                LblMensajeEntradas.Visible = true;
                BtnConfirmarCantidad.Enabled = false;
            }
            else
            {
                LblMensajeEntradas.Visible = false;
                BtnConfirmarCantidad.Enabled = true;
            }
               
        }

   

 
        private void CBTarifas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblMensajeTarifas.Visible = false;
            BtnConfirmar.Enabled = true;
        }

        private void NmbCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.Parse(NmbCantidad.Value.ToString()) <= 0)
            {
                LblMensajeEntradas.Visible = true;
                BtnConfirmarCantidad.Enabled = false;

            }
            else
            {
                LblMensajeEntradas.Visible = false;
                BtnConfirmarCantidad.Enabled = true;

            }
        }

        private void CBTarifas_KeyUp(object sender, KeyEventArgs e)
        {
            if (CBTarifas.SelectedIndex == -1)
            {
                LblMensajeTarifas.Visible = true;
                BtnConfirmar.Enabled = false;
            }
            else
            {
                LblMensajeTarifas.Visible = false;
                BtnConfirmar.Enabled = true;

            }
        }

        private void BtnVolverCantidad_Click(object sender, EventArgs e)
        {
            this.desactivarTodo();
            this.solicitarCantidadEntradas();
        }

        private void BtnVolverTarifas_Click(object sender, EventArgs e)
        {
            this.desactivarTodo();
            this.habilitarPantalla();
        }
    }
}
