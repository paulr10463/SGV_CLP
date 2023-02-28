using SGV_CLP.Classes;
using SGV_CLP.Classes.Modulo_Ventas;
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
        public DetalleNotaVenta detalleNotaVenta;
        Producto _producto;
        public UC_Item(Producto producto)
        {
            detalleNotaVenta = new DetalleNotaVenta();
            detalleNotaVenta.producto = producto;
            _producto = producto;
            InitializeComponent();
            siticoneButton1.Enabled = false;
            ResourceManager rm = Resources.ResourceManager;
            Image myImage = (Image)rm.GetObject(producto.Imagen);
            this.siticonePictureBox1.Image = myImage;
            this.siticoneHtmlLabel1.Text = producto.Nombre;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            detalleNotaVenta.cantidad = (int)siticoneNumericUpDown1.Value;
            detalleNotaVenta.subtotal = detalleNotaVenta.cantidad * _producto.PVP;
            UC_Ventas.notaVenta.addOrUpdateDetalleVenta(detalleNotaVenta);
            addRowInTable(detalleNotaVenta.cantidad, _producto);
            UC_Ventas.totalVenta.Text = "Total: $" + UC_Ventas.notaVenta.calcularTotalVentas().ToString();
        }

        //Activa el boton de añadir si en numericUpDown.value > 0
        private void siticoneNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if ((int)siticoneNumericUpDown1.Value > 0)
            {
                siticoneButton1.Enabled = true;
            }
            else
            {
                siticoneButton1.Enabled = false;
            }
        }

        public void addRowInTable(int cantidad, Producto producto)
        {
            bool flag = false;

            foreach (DataGridViewRow rowItem in UC_Ventas.detalleVentaTabla.Rows)
            {
                if (rowItem.Cells[0].Value != null)
                {
                    if (rowItem.Cells[0].Value.Equals(producto.Nombre))
                    {
                        rowItem.Cells[1].Value = cantidad;
                        rowItem.Cells[2].Value = detalleNotaVenta.subtotal;
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
                row.Cells[0].Value = producto.Nombre;
                row.Cells[1].Value = cantidad;
                row.Cells[2].Value = detalleNotaVenta.subtotal;
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
