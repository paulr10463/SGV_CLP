using SGV_CLP.Classes;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.Classes.Products_module;
using SGV_CLP.Properties;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Módulo_Ventas
{
    public partial class UC_Item : UserControl
    {
        public InvoiceDetail invoiceDetail;
        Product _producto;
        public UC_Item(Product producto)
        {
            invoiceDetail = new InvoiceDetail();
            invoiceDetail.product = producto;
            _producto = producto;
            InitializeComponent();
            siticoneButton1.Enabled = false;
            ResourceManager rm = Resources.ResourceManager;
            //Para coger la imagen mediante la carpeta de resources del programa
            //Image myImage = (Image)rm.GetObject(producto.Imagen);
            //this.siticonePictureBox1.Image = myImage;

            //En caso de coger la imagen a través de una ruta en la compu
            try
            {
                Image myImage = Image.FromFile(Path.Combine(Application.StartupPath, producto.imagePath));
                this.siticonePictureBox1.Image = myImage;
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            this.siticoneHtmlLabel1.Text = producto.productName;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            invoiceDetail.soldQuantity = (int)siticoneNumericUpDown1.Value;
            invoiceDetail.subTotal = invoiceDetail.soldQuantity * _producto.salesPriceToThePubic;
            UC_Ventas.invoice.AddOrUpdateInvoiceDetail(invoiceDetail);
            addRowInTable(invoiceDetail.soldQuantity, _producto);
            UC_Ventas.totalVenta.Visible = true;
            UC_Ventas.totalVenta.Text = "Total: $" + UC_Ventas.invoice.CalculateTotalSales().ToString();
        }

        //Activa el boton de añadir si en numericUpDown.value > 0
        private void siticoneNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int cantidadProducto = int.Parse(ProductMapper.GetProductField(this._producto.productCode, "cantidad_Total")); 
            if ((int)siticoneNumericUpDown1.Value > cantidadProducto)
            {
                MessageBox.Show("Cantidad en inventario de " + _producto.productName + " es escasa");
                siticoneButton1.Enabled = false;
                siticoneNumericUpDown1.Value -= 1;
            }
            else if ((int)siticoneNumericUpDown1.Value == 0 || cantidadProducto == 0)
            {
                siticoneButton1.Enabled = false;
            }
            else if((int)siticoneNumericUpDown1.Value <= cantidadProducto && cantidadProducto > 0)
            {
                siticoneButton1.Enabled = true;
            }
        }

        public void addRowInTable(int cantidad, Product producto)
        {
            bool flag = false;

            foreach (DataGridViewRow rowItem in UC_Ventas.detalleVentaTabla.Rows)
            {
                if (rowItem.Cells[0].Value != null)
                {
                    if (rowItem.Cells[0].Value.Equals(producto.productName))
                    {
                        rowItem.Cells[1].Value = cantidad;
                        rowItem.Cells[2].Value = invoiceDetail.subTotal;
                        flag = true;
                    }
                }
                else
                {
                    break;
                }
            }
            if (!flag)
            {
                DataGridViewRow row = (DataGridViewRow)UC_Ventas.detalleVentaTabla.Rows[0].Clone();
                row.Cells[0].Value = producto.productName;
                row.Cells[1].Value = cantidad;
                row.Cells[2].Value = invoiceDetail.subTotal;
                UC_Ventas.detalleVentaTabla.Rows.Add(row);
            }
           
        }

        public void resetComponents()
        {
            this.siticoneNumericUpDown1.Value = 0;
            this.siticoneButton1.Enabled = false;
        }
    }
}
