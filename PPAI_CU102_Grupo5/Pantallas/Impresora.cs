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
    public partial class Impresora : Form
    {
        public Impresora()
        {
            InitializeComponent();
        }

        private void Impresora_Load(object sender, EventArgs e)
        {

        }

        internal void imprimir(Entrada entrada)
        {
            var impresion = "";
            impresion += "\n"+entrada.getNumero().ToString();
            impresion += "\n" + entrada.getMonto().ToString();
            impresion += "\n" + entrada.getFechaVenta().ToString();
            impresion += "\n" + entrada.getHoraVenta().ToString();

            MessageBox.Show(impresion);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
