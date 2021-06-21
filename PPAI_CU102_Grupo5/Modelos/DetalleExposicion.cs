using System;

namespace PPAI_CU102_Grupo5.Modelos
{
    public class DetalleExposicion
    {
        public DetalleExposicion()
        {
            Obra = new Obra();
            Obra.DuracionResumida = 10;

        }

        public Obra Obra { get; set; }
        public int buscarDuracionResumidaObra()
        {
            return Obra.getDuracionResumida();
        }
    }
}