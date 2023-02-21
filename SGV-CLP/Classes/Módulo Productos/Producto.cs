namespace SGV_CLP.Classes
{
    public class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string Categoria { get; set; }
        public double PVP{ get; set; }
        public double PrecioElaboracion { get; set; }
        public double CantidadTotal { get; set; }

        // Para crear un producto nuevo
       public Producto(string nombre, string imagen)
        {
            this.Nombre = nombre;
            this.Imagen = imagen;
        }
        
        public Producto(string ID, string nombre, double precioElaboracion, double pvp, string categoria, string imagen)
        {
            Id = ID;
            Nombre = nombre;
            PrecioElaboracion = precioElaboracion;
            PVP = pvp;
            Categoria = categoria;
            CantidadTotal = 0;
            Imagen = imagen;
        }

        // Para obtener de base de datos
        public Producto(string ID, string nombre, double precioElaboracion, double pvp, string categoria, double cantidadTotal, string imagen)
        {
            Id = ID;
            Nombre = nombre;
            PrecioElaboracion = precioElaboracion;
            PVP = pvp;
            Categoria = categoria;
            CantidadTotal = cantidadTotal;
            Imagen = imagen;
        }
    }
}
