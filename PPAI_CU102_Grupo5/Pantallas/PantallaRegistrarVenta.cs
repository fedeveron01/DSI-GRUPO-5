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
            var tarifas = new Tarifa[] { new Tarifa()};
            tarifas[0].TipoEntrada = new TipoEntrada();
            tarifas[0].TipoVisita = new TipoVisita();

            sesionActual.Usuario.Empleado.Sede.Tarifas = tarifas;


            
    

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
        }


        public void mostrarTarifasVigentes(List<string> tarifasVigentes)
        {

            CBTarifas.Items.Add(tarifasVigentes[0].ToString()) ;

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
    }
}
