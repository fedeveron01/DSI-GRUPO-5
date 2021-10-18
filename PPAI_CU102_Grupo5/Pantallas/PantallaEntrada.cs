﻿using PPAI_CU102_Grupo5.Controladores;
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
    public partial class PantallaEntrada : Form,IObservadorCantidadVisitantes
    {
        public PantallaEntrada()
        {
            InitializeComponent();
        }


        public void actualizarPantalla(ISujetoCantidadVisitantes sujetoConcreto)
        {
            GestorRegistrarVenta sujeto = (GestorRegistrarVenta) sujetoConcreto;
            LblCantidad.Text += sujeto.getCantidad();
            LblCapacidad.Text += sujeto.getCapacidad();
        }

        private void PantallaEntrada_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
