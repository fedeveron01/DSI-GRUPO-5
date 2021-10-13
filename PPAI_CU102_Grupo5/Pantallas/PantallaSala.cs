using PPAI_CU102_Grupo5.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU102_Grupo5.Pantallas
{
    public partial class PantallaSala : Form,IObservadorCantidadVisitantes
    {
        public PantallaSala()
        {
            InitializeComponent();
        }

        public void actualizarPantalla(int nro,int cantidad, int capacidad)
        {
            LblCantidad.Text = "Cantidad actual de visitantes : "+cantidad;
            LblCapacidad.Text = "Capacidad de la sede :"+capacidad;
            MessageBox.Show("Sala numero " + nro);
        }

        private void PantallaSala_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
