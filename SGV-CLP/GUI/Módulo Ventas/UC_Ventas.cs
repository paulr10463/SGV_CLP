using SGV_CLP.Classes;
using SGV_CLP.Classes.Modulo_Ventas;
using SGV_CLP.GUI.Módulo_Ventas;
using Siticone.Desktop.UI.WinForms;
using System.Media;
using System.Windows.Forms;


namespace SGV_CLP.GUI
{
    public partial class UC_Ventas : UserControl
    {
        List<Producto> productos;
        List<Producto> especialidades;
        List<Producto> bebidas;
        public static NotaVenta notaVenta;
        public static SiticoneDataGridView detalleVentaTabla;
        public static SiticoneHtmlLabel totalVenta;
        public static List<UC_Item> productosUI = new List<UC_Item>();
        public string Categoria = string.Empty;
        public UC_Ventas()
        {
            notaVenta = new NotaVenta();

            InitializeComponent();
            detalleVentaTabla = siticoneDataGridView2;
            totalVenta = siticoneHtmlLabel11;
            dateTimePickerConsultarVenta.Visible = false;
            loadProducts();

        }

        public void loadProducts()
        {
            productos = ProductoMapper.ConsultarProductos();
            especialidades = new List<Producto>();
            bebidas = new List<Producto>();
            foreach (Producto producto in productos)
            {
                if (producto.Categoria.Equals("Bebidas"))
                {
                    bebidas.Add(producto);
                }
                if (producto.Categoria.Equals("Especialidades"))
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
                case 0: Categoria = "cod_NotaVenta"; txtConsultarVenta_TextChanged(null,null); break;
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
                            notaVenta.deleteDetailbyProductName(row.Cells[0].Value.ToString());
                            siticoneDataGridView2.Rows.RemoveAt(e.RowIndex);
                            UC_Ventas.totalVenta.Text = "Total: $" + UC_Ventas.notaVenta.calcularTotalVentas().ToString();
                        }
                    }
                }

        }
        public static void resetNumPickers(){
            productosUI.ForEach(item => item.resetComponents());
        }

        private void txtConsultarVenta_TextChanged(object sender, EventArgs e)
        {
            List<NotaVenta> notasVenta = new List<NotaVenta>();
            switch (ComboBox_ConsultarVentaPor.SelectedIndex)
            {
                case 0:
                    if (!txtConsultarVenta.Text.Equals(string.Empty))
                    notasVenta = NotaVentaMapper.ConsultarNotaVenta(Convert.ToInt32(txtConsultarVenta.Text));
                    break;

                case 1:
                    notasVenta = NotaVentaMapper.ConsultarNotaVenta(txtConsultarVenta.Text);
                    break;

                case >=2 and <=4:
                    notasVenta = NotaVentaMapper.ConsultarNotaVenta(Categoria, txtConsultarVenta.Text);
                    break;

            }
                 
                llenarTablaVenta(notasVenta);           
        }

        public void llenarTablaVenta(List<NotaVenta> notasVenta)
        {
            if (notasVenta != null)
            {
                siticoneDataGridView1.Rows.Clear();
                notasVenta.ForEach(item => siticoneDataGridView1.Rows.Add(
                    item.codNotaVenta, 
                    item.cliente.Cc_Cliente, 
                    item.cliente.Primer_Nombre,
                    item.cliente.Primer_Apellido,
                    item.cliente.Telefono,
                    item.precioFinal,
                    item.fechaVenta));
            }
        }

        private void dateTimePickerConsultarVenta_ValueChanged(object sender, EventArgs e)
        {
            List<NotaVenta> notasVenta = new List<NotaVenta>();
            notasVenta = NotaVentaMapper.ConsultarNotaVentabyDate(dateTimePickerConsultarVenta.Text);
            llenarTablaVenta(notasVenta);
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
