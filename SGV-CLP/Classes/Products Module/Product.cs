namespace SGV_CLP.Classes.Products_module
{
    public class Product
    {
        public string productCode { get; set; }
        public string productName { get; set; }
        public string imagePath { get; set; }
        public string category { get; set; }
        public double salesPriceToThePubic{ get; set; } // sales price to the public = S.P.P
        public double productionPrice { get; set; }
        public double totalQuantity { get; set; }

        // Para crear un producto nuevo
       public Product(string productName, string imagePath)
        {
            this.productName = productName;
            this.imagePath = imagePath;
        }
        
        public Product(string productCode, string productName, double productionPrice, double salesPriceToThePublic, string category, string imagenPath)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.productionPrice = productionPrice;
            this.salesPriceToThePubic = salesPriceToThePublic;
            this.category = category;
            this.imagePath = imagenPath;
            totalQuantity = 0;
        }

        // Para obtener de base de datos
        public Product(string productCode, string productName, double productionPrice, double salesPriceToThePublic, string category, double totalQuantity, string imagenPath)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.productionPrice = productionPrice;
            this.salesPriceToThePubic = salesPriceToThePublic;
            this.category = category;
            this.totalQuantity = totalQuantity;
            this.imagePath = imagenPath;
        }
    }
}
