﻿using System;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class DetalleExposicion
    {
        public DetalleExposicion()
        {
            Obra = new Obra();
            Obra.setDuracionResumida(10);

        }

        public Obra Obra { get; set; }

        private string LugarAsignado;


        // Inicio Seteo

        public void setObra(Obra obra)
        {
            Obra = obra;
        }
        public void setLugarAsignado(string lugarAsignado)
        {
            LugarAsignado = lugarAsignado;
        }

       
        public int buscarDuracionResumidaObra()
        {
            return Obra.getDuracionResumida();
        }

        // fin Seteo 
    }
}