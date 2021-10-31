using PPAI_CU102_Grupo5.Controladores;
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
        private int nroPantalla ;
        public PantallaSala(int nro)
        {
            this.nroPantalla = nro;
            InitializeComponent();
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

        public void actualizarPantalla(int cantidad , int capacidad )
        {
           
                LblCantidad.Text += cantidad;
                LblCapacidad.Text += capacidad;
                MessageBox.Show("Sala numero " + this.nroPantalla);


        }
    }
}
