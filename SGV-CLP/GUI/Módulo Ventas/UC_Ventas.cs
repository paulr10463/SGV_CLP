using SGV_CLP.Classes;
using SGV_CLP.Classes.Modulo_Ventas;
using SGV_CLP.GUI.Módulo_Ventas;
using Siticone.Desktop.UI.WinForms;
using System.Media;


namespace SGV_CLP.GUI
{
    public partial class UC_Ventas : UserControl
    {

        public static NotaVenta notaVenta;
        public static SiticoneDataGridView detalleVentaTabla;
        public static SiticoneHtmlLabel totalVenta;
        public static List<UC_Item> productosUI = new List<UC_Item>();
        public UC_Ventas()
        {
            notaVenta = new NotaVenta();
            List<Producto> productos = ProductoMapper.ConsultarProductos();
            List<Producto> especialidades = new List<Producto>();
            List<Producto> bebidas = new List<Producto>();
            
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
            InitializeComponent();
            detalleVentaTabla = siticoneDataGridView2;
            totalVenta = siticoneHtmlLabel11;

            List<UC_Item> especialidadesUI = new List<UC_Item>();
            List<UC_Item> bebidasUI = new List<UC_Item>();

            foreach (Producto producto in especialidades)
            {
                especialidadesUI.Add(new UC_Item(producto));
            }
            foreach (Producto producto in bebidas)
            {
                bebidasUI.Add(new UC_Item(producto));
            }
            foreach (UC_Item item in especialidadesUI)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
            foreach (UC_Item item in bebidasUI)
            {
                flowLayoutPanel2.Controls.Add(item);
            }
            especialidadesUI.ForEach( item => productosUI.Add(item));
            bebidasUI.ForEach( item => productosUI.Add(item));
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
        private void txtConsultarVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (ComboBox_ConsultarVentaPor.SelectedIndex)
            {
                case 0:
                    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras y números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 1:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números o \"-\" (siga el formato aaaa-mm-dd)!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 2:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 3:
                    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 4:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                default:
                    if (ComboBox_ConsultarVentaPor.SelectedIndex == -1) e.Handled = true;
                    break;
            }
        }

        private void ComboBox_ConsultarVentaPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConsultarVenta.Text = System.String.Empty;
            if (ComboBox_ConsultarVentaPor.SelectedIndex != -1)
            {
                siticoneHtmlLabel_buscarCliente_sin_campo.Hide();
            }
        }


        private void siticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            bool flag = false;
            List<string> codFacturaList = new List<string>();
            foreach (DataGridViewRow rowItem in siticoneDataGridView1.Rows)
            {
                if (rowItem.Cells[0].Value != null)
                {
                    codFacturaList.Add((string)rowItem.Cells[0].Value);
                }

        }


        
    }

    private void txtConsultarVenta_KeyUp(object sender, KeyEventArgs e)
    {
        string filtro = txtConsultarVenta.Text;

        switch (ComboBox_ConsultarVentaPor.SelectedIndex)
        {
            case 0:
                // Filtrar los datos del DataGridView
                foreach (DataGridViewRow row in siticoneDataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        // Ocultar las filas que no cumplan con el filtro
                        row.Visible = row.Cells[0].Value.ToString().Contains(filtro);
                    }
                }
                break;
            case 1:
                // Filtrar los datos del DataGridView
                foreach (DataGridViewRow row in siticoneDataGridView1.Rows)
                {
                    if (row.Cells[7].Value != null)
                    {
                        // Ocultar las filas que no cumplan con el filtro
                        row.Visible = row.Cells[7].Value.ToString().Contains(filtro);
                    }
                }
                break;
            case 2:
                // Filtrar los datos del DataGridView
                foreach (DataGridViewRow row in siticoneDataGridView1.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        // Ocultar las filas que no cumplan con el filtro
                        row.Visible = row.Cells[1].Value.ToString().Contains(filtro);
                    }
                }
                break;
            case 3:
                // Filtrar los datos del DataGridView
                foreach (DataGridViewRow row in siticoneDataGridView1.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        // Ocultar las filas que no cumplan con el filtro
                        row.Visible = row.Cells[2].Value.ToString().Contains(filtro);
                    }
                }
                break;
            case 4:
                // Filtrar los datos del DataGridView
                foreach (DataGridViewRow row in siticoneDataGridView1.Rows)
                {
                    if (row.Cells[4].Value != null)
                    {
                        // Ocultar las filas que no cumplan con el filtro
                        row.Visible = row.Cells[4].Value.ToString().Contains(filtro);
                    }
                }
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
                            UC_Ventas.notaVenta.setTotalVentas();
                        }
                    }
                }

        }
        public static void resetNumPickers(){
            productosUI.ForEach(item => item.resetComponents());
        }
    } 
}
