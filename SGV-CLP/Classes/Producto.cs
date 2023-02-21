namespace SGV_CLP.Classes
{
    internal class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }

        public string Categoria { get; set; }

        public double PVP{ get; set; }
            
        public double PrecioElaboracion { get; set; }

        public Producto(string nombre, string imagen)
        {
            Nombre = nombre;
            Imagen = imagen;
        }

    }
}
