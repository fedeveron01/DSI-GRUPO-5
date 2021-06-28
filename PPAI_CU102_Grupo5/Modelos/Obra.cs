namespace PPAI_CU102_Grupo5.Modelos
{
    public class Obra
    {
        private int DuracionResumida;
        private int Id;
        private string NombreObra;

        // Inicio Seteo

        public void setDuracionResumida(int duracionResumida)
        {
            DuracionResumida = duracionResumida;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public void setNombreObra (string nombreObra)
        {
            NombreObra = nombreObra;
        }

        public int getDuracionResumida()
        {
            return DuracionResumida; 
        }

        // Fin Seteo
    }
}