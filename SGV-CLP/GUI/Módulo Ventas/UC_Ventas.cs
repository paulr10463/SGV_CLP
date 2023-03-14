using SGV_CLP.Classes;
using SGV_CLP.Classes.Products_module;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.GUI.Módulo_Ventas;
using Siticone.Desktop.UI.WinForms;
using System.Media;
using System.Windows.Forms;


namespace SGV_CLP.GUI
{
    public partial class UC_Ventas : UserControl
    {
        List<Product> productos;
        List<Product> especialidades;
        List<Product> bebidas;
        public static Invoice invoice;
        public static SiticoneDataGridView detalleVentaTabla;
        public static SiticoneHtmlLabel totalVenta;
        public static List<UC_Item> productosUI = new List<UC_Item>();
        public string Categoria = string.Empty;
        public UC_Ventas()
        {
            invoice = new Invoice();

            InitializeComponent();
            detalleVentaTabla = siticoneDataGridView2;
            totalVenta = siticoneHtmlLabel11;
            dateTimePickerConsultarVenta.Visible = false;
            loadProducts();

        }

        public void loadProducts()
        {
            productos = ProductMapper.GetAllProduct();
            especialidades = new List<Product>();
            bebidas = new List<Product>();
            foreach (Product producto in productos)
            {
                if (producto.category.Equals("Bebidas"))
                {
                    bebidas.Add(producto);
                }
                if (producto.category.Equals("Especialidades"))
                {
                    especialidades.Add(producto);
                }
            }
            List<UC_Item> especialidadesUI = new List<UC_Item>();
            List<UC_Item> bebidasUI = new List<UC_Item>();

            especialidades.ForEach(producto => especialidadesUI.Add(new UC_Item(producto)));
            bebidas.ForEach(bebida => bebidasUI.Add(new UC_Item(bebida)));

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();

            especialidadesUI.ForEach(item => flowLayoutPanel1.Controls.Add(item));
            bebidasUI.ForEach(item => flowLayoutPanel2.Controls.Add(item));

            especialidadesUI.ForEach(item => productosUI.Add(item));
            bebidasUI.ForEach(item => productosUI.Add(item));
        }
        //Se verifica que la siticoneDataGridView2 tenga algun producto para poder abrir el checkout
        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            if (siticoneDataGridView2.RowCount == 1)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Debe elegir al menos un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Checkout ventana = new Checkout(siticoneDataGridView2);
                ventana.ShowDialog();
            }

        }

        //Vacia siticoneDataGridView2 para una nueva compra
        public void resetValues()
        {
            siticoneDataGridView2.Rows.Clear();
            siticoneHtmlLabel11.Visible = false;
        }

        //Calcula el total de la venta
        public void setTotal(SiticoneDataGridView tablaVenta)
        {
            double total = 0;
            foreach (DataGridViewRow rowItem in siticoneDataGridView2.Rows)
            {
                if (rowItem.Cells[0].Value != null)
                {
                    total += (double)rowItem.Cells[2].Value;
                }
                else
                {
                    break;
                }
            }

            siticoneHtmlLabel11.Text = "Total:      $" + total.ToString();

        }

        //Validaciones en el cuadro de Busqueda de ventas



        private void ComboBox_ConsultarVentaPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConsultarVenta.Text = System.String.Empty;
            if (ComboBox_ConsultarVentaPor.SelectedIndex != -1)
            {
                siticoneHtmlLabel_buscarCliente_sin_campo.Hide();
            }
            dateTimePickerConsultarVenta.Visible = false;
            switch (ComboBox_ConsultarVentaPor.SelectedIndex)
            {
                case 0: Categoria = "cod_NotaVenta"; txtConsultarVenta_TextChanged(null, null); break;
                case 1: Categoria = "cc_Cliente"; txtConsultarVenta_TextChanged(null, null); break;
                case 2: Categoria = "primer_Nombre"; txtConsultarVenta_TextChanged(null, null); break;
                case 3: Categoria = "primer_Apellido"; txtConsultarVenta_TextChanged(null, null); break;
                case 4: Categoria = "telefono"; txtConsultarVenta_TextChanged(null, null); break;
                case 5:
                    Categoria = "fecha_emision";
                    dateTimePickerConsultarVenta.Visible = true;
                    dateTimePickerConsultarVenta_ValueChanged(null, null);
                    break;
            }
        }


        private void siticoneDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (siticoneDataGridView2.Columns[e.ColumnIndex].Name == "EliminarDetalle")
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este detalle de nota de venta?", "Eliminar detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = siticoneDataGridView2.Rows[e.RowIndex];
                        invoice.DeleteInvoiceDetailbyProductName(row.Cells[0].Value.ToString());
                        siticoneDataGridView2.Rows.RemoveAt(e.RowIndex);
                        UC_Ventas.totalVenta.Text = "Total: $" + UC_Ventas.invoice.CalculateTotalSales().ToString();
                    }
                }
            }

        }
        public static void resetNumPickers()
        {
            productosUI.ForEach(item => item.resetComponents());
        }

        private void txtConsultarVenta_TextChanged(object sender, EventArgs e)
        {
            List<Invoice> invoices = new List<Invoice>();
            switch (ComboBox_ConsultarVentaPor.SelectedIndex)
            {
                case 0:
                    if (!txtConsultarVenta.Text.Equals(string.Empty))
                        invoices = InvoiceMapper.GetAllInvoicesByCode(Convert.ToInt32(txtConsultarVenta.Text));
                    break;

                case 1:
                    invoices = InvoiceMapper.GetAllInvoices(txtConsultarVenta.Text);
                    break;

                case >= 2 and <= 4:
                    invoices = InvoiceMapper.GetAllInvoices(Categoria, txtConsultarVenta.Text);
                    break;

            }

            llenarTablaVenta(invoices);
        }

        public void llenarTablaVenta(List<Invoice> notasVenta)
        {
            if (notasVenta != null)
            {
                siticoneDataGridView1.Rows.Clear();
                notasVenta.ForEach(item => siticoneDataGridView1.Rows.Add(
                    item.invoiceCode,
                    item.customer.customerID,
                    item.customer.firstName,
                    item.customer.firstLastName,
                    item.customer.phoneNumber,
                    item.totalSales,
                    item.issuedDate));
            }
        }

        private void dateTimePickerConsultarVenta_ValueChanged(object sender, EventArgs e)
        {
            List<Invoice> invoices = new List<Invoice>();
            invoices = InvoiceMapper.GetAllInvoicesByDate(dateTimePickerConsultarVenta.Text);
            llenarTablaVenta(invoices);
        }

        private void txtConsultarVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (ComboBox_ConsultarVentaPor.SelectedIndex)
            {
                //case 0: "cod_NotaVenta, ccCliente y Telefono"
                case 0 or 1 or 4:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                //case 2: "primer_Nombre y apellido"; 
                case 2 or 3:
                    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;

            }
        }

        private void siticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_ConsultarVentaPor_SelectedIndexChanged(null, null);
        }


    }
}
