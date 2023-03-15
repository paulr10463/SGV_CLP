using SGV_CLP.Classes.Products_module;
using SGV_CLP.Classes.Sales_Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Módulo_Ventas
{
    public partial class ShowDetailInvoice : Form
    {
        public ShowDetailInvoice(List<InvoiceDetail> invoiceDetails, double total, int codNotaVenta)
        {
            InitializeComponent();
            CodNotaVentaLabel.Text = "Nota de venta N°: " + codNotaVenta.ToString();
            TotalLabel.Text = "Total: $" + total.ToString();
            foreach (InvoiceDetail invoiceDetail in invoiceDetails)
            {
                DataGridViewRow row = (DataGridViewRow)siticoneDataGridView1.Rows[0].Clone();
                row.Cells[0].Value = invoiceDetail.product.productName;
                row.Cells[1].Value = invoiceDetail.soldQuantity;
                row.Cells[2].Value = invoiceDetail.subTotal;
                siticoneDataGridView1.Rows.Add(row);
            }
        }

        private void siticoneDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
