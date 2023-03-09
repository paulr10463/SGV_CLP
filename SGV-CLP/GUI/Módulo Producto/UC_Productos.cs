using SGV_CLP.Classes;
using SGV_CLP.Classes.Modulo_Ventas;
using SGV_CLP.GUI.Módulo_Clientes;
using SGV_CLP.GUI.Módulo_Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGV_CLP.GUI
{
    public partial class UC_Productos : UserControl
    {
        List<Producto> ProductosRegistrados = ProductoMapper.ConsultarProductos();
        List<string> NombresProductosRegistrados = ProductoMapper.ConsultarNombresProductos();
        List<Lote> LoteRegistrados = ProductoMapper.ConsultarLotes();
        bool isValidIdProd, isValidNombreProd, isValidCategoria, isValidPE, isValidPVP, isValidRutaImg; // Para validar los campos de los productos
        bool isValidNombProdEnLote, isValidCantidadLote, isValidFechaElabLote; // Para validar los campos de los lotes

        public UC_Productos()
        {
            InitializeComponent();
            LlenarTablaProducto();
            LlenarTablaLote();
            LlenarComboBoxProductos();
            isValidIdProd = false;
            isValidNombreProd = false;
            isValidCategoria = false;
            isValidPE = false;
            isValidPVP = false;
            isValidRutaImg = false;

            isValidNombProdEnLote = false;
            isValidCantidadLote = false;
            isValidFechaElabLote = false;

            SBAniadirProd.Enabled = false;
            SBAniadirLote.Enabled = false;

            categoria_not_choose_label.Show();
            Producto_not_choose_in_Lote_label.Show();
        }

        private void VaciarCamposProd()
        {
            txtIDProd.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPE.Text = string.Empty;
            txtPVP.Text = string.Empty;
            txtImagen.Text = string.Empty;
            cBoxCategoria.SelectedIndex = 0;
            categoria_not_choose_label.Show();
            PVP_not_valid_label.Hide();
            PE_not_valid_label.Hide();
            rutaImagen_not_valid_label.Hide();
        }

        public void LlenarTablaProducto()
        {
            if (ProductosRegistrados != null)
            {
                SDGVProducto.Rows.Clear();
                ProductosRegistrados = ProductoMapper.ConsultarProductos();
                foreach (Producto producto in ProductosRegistrados)
                {
                    SDGVProducto.Rows.Add(producto.Id, producto.Nombre, producto.PrecioElaboracion, producto.PVP, producto.Categoria, producto.CantidadTotal);
                }
            }
        }

        public void LlenarTablaLote()
        {
            if (LoteRegistrados != null)
            {
                SDGVLote.Rows.Clear();
                LoteRegistrados = ProductoMapper.ConsultarLotes();
                foreach (Lote lote in LoteRegistrados)
                {
                    SDGVLote.Rows.Add(lote.Cod_Lote, lote.Cod_Producto, lote.Cantidad, lote.FechaElaboracion);
                }
            }
        }

        public void LlenarComboBoxProductos()
        {
            if (NombresProductosRegistrados != null)
            {
                ComboBox_ProductoLote.Items.Clear();
                NombresProductosRegistrados = ProductoMapper.ConsultarNombresProductos();
                foreach (string nombreProd in NombresProductosRegistrados)
                {
                    ComboBox_ProductoLote.Items.Add(nombreProd);
                }
            }
        }

        private void siticoneRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker1.Visible = false;
        }

        private void siticoneRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker1.Visible = true;
        }

        private void SBAniadirProducto_Click(object sender, EventArgs e)
        {
            var producto = new Producto(
                txtIDProd.Text,
                txtNombreProducto.Text,
                Convert.ToDouble(txtPE.Text, CultureInfo.InvariantCulture),
                Convert.ToDouble(txtPVP.Text, CultureInfo.InvariantCulture),
                cBoxCategoria.Text,
                txtImagen.Text);

            ProductoMapper.IngresarProducto(producto);
            LlenarTablaProducto();
            LlenarComboBoxProductos();

            SystemSounds.Beep.Play();
            MessageBox.Show("Producto añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainMenu.uc_ventas.loadProducts();
            VaciarCamposProd();
        }

        private void SBAniadirLote_Click(object sender, EventArgs e)
        {
            if (SRBFechaActual.Checked)
            {

                var LoteConFechaActual = new Lote(
                ProductoMapper.ConsultarIdProducto(ComboBox_ProductoLote.SelectedItem.ToString()) + siticoneDateTimePicker1.Value.ToString("ddMM"),
                ProductoMapper.ConsultarIdProducto(ComboBox_ProductoLote.SelectedItem.ToString()),
                Convert.ToInt32(txtCantidad.Text),
                DateTime.Now);
                ProductoMapper.IngresarLote(LoteConFechaActual);
            }
            else
            {
                var LoteConDateTimePicker = new Lote(
                ProductoMapper.ConsultarIdProducto(ComboBox_ProductoLote.SelectedItem.ToString()) + siticoneDateTimePicker1.Value.ToString("ddMM"),
                ProductoMapper.ConsultarIdProducto(ComboBox_ProductoLote.SelectedItem.ToString()),
                Convert.ToInt32(txtCantidad.Text),
                siticoneDateTimePicker1.Value);
                ProductoMapper.IngresarLote(LoteConDateTimePicker);
            }
            LlenarTablaLote();

            //siticoneDateTimePicker1.Value.Year.ToString();
            SystemSounds.Beep.Play();
            MessageBox.Show("Lote añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                txtImagen.Text = fileName;
            }
        }

        private void SDGVProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // CLICK EN CELDA ELIMINAR PRODUCTO
            if (SDGVProducto.Columns[e.ColumnIndex].Name == "ColumnaEliminarProducto")
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string cod_Producto = SDGVProducto.Rows[e.RowIndex].Cells[0].Value.ToString();

                        ProductoMapper.EliminarProducto(cod_Producto);
                        MessageBox.Show("Producto eliminado con éxito");
                        LlenarTablaProducto();
                    }
                }
            }

            // CLICK EN CELDA EDITAR PRODUCTO
            if (SDGVProducto.Columns[e.ColumnIndex].Name == "ColumnaEditarProducto")
            {
                if (e.RowIndex >= 0)
                {

                    String cod_Producto = SDGVProducto.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Editar_Producto ventana = new Editar_Producto(cod_Producto);
                    ventana.ShowDialog();
                    LlenarTablaProducto();
                    MainMenu.uc_ventas.loadProducts();
                }
            }
        }

        private void SDGVLote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SDGVLote.Columns[e.ColumnIndex].Name == "ColumnaEliminarLote")
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este Lote?", "Eliminar Lote", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        /*clientes.RemoveAt(e.RowIndex);
                        siticoneDataGridView1.Rows.Clear();
                        foreach (Cliente c in clientes)
                        {
                            //siticoneDataGridView1.Rows.Add(c.cedula, c.nombres, c.apellidos, c.direccion, c.telefono);
                        }
                        */
                    }
                }
            }

            if (SDGVLote.Columns[e.ColumnIndex].Name == "ColumnaEditarLote")
            {
                if (e.RowIndex >= 0)
                {
                    // String cedula = siticoneDataGridView1.Rows[e.RowIndex].Cells["ColumnaCedula"].Value.ToString();
                    Editar_Lote ventana = new Editar_Lote();
                    ventana.ShowDialog();
                }
            }
        }

        // Filtro de busqueda de productos
        private void TxtConsultarProducto_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor del ComboBox
            string selectedItem = ComboBox_ConsultarProductoPor.SelectedItem.ToString();

            // Obtener el valor del TextBox
            string filterValue = txtConsultarProducto.Text;

            // Filtrar los datos del DataGridView en función del valor del ComboBox y del TextBox
            if (selectedItem == "Código")
            {
                foreach (DataGridViewRow row in SDGVProducto.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[0].Value != null)
                    {
                        row.Visible = row.Cells[0].Value.ToString().Contains(filterValue);
                    }
                }
            }
            else if (selectedItem == "Nombre")
            {
                foreach (DataGridViewRow row in SDGVProducto.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[1].Value != null)
                    {
                        row.Visible = row.Cells[1].Value.ToString().Contains(filterValue);
                    }
                }
            }
            else if (selectedItem == "Categoría")
            {
                foreach (DataGridViewRow row in SDGVProducto.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[4].Value != null)
                    {
                        row.Visible = row.Cells[4].Value.ToString().Contains(filterValue);
                    }
                }
            }
        }

        private void ComboBox_ConsultarProductoPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConsultarProducto.Text = System.String.Empty;
            if (ComboBox_ConsultarProductoPor.SelectedIndex != -1)
            {
                siticoneHtmlLabel_buscarProducto_sin_campo.Hide();
                txtConsultarProducto.Enabled = true;
            }
            else
            {
                siticoneHtmlLabel_buscarProducto_sin_campo.Show();
                txtConsultarProducto.Enabled = false;
            }
        }

        // Validaciones de Pestaña producto
        private void ValidateProductFields()
        {
            if (isValidIdProd && isValidNombreProd && isValidPE && isValidPVP && isValidCategoria && isValidRutaImg)
            {
                SBAniadirProd.Enabled = ValidationUtils.ValidarPvpMayorIgualPe(txtPVP.Text, txtPE.Text);
            }
            else
            {
                SBAniadirProd.Enabled = false;
            }
        }

        private void TxtIDProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("ID producto inválido – solo se permiten caracteres alfabéticos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TxtIDProd_TextChanged(object sender, EventArgs e)
        {
            // No permite ingresar más de 7 caracteres
            if (txtIDProd.Text.Length > Constants.LIMIT_IDPROD_LENGTH)
            {
                txtIDProd.Text = txtIDProd.Text.Substring(0, Constants.LIMIT_IDPROD_LENGTH);
                txtIDProd.SelectionStart = Constants.LIMIT_IDPROD_LENGTH;
            }
            // Verifica la existencia del ID
            else if (ProductoMapper.IDproductoExiste(txtIDProd.Text))
            {
                IDProd_not_unique_label.Show();
                isValidIdProd = false;
            }
            else
            {
                IDProd_not_unique_label.Hide();
                isValidIdProd = true;
            }
            ValidateProductFields();
        }

        private void TxtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Nombre de producto inválido – solo se permiten caracteres alfabéticos y el espacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TxtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            // No permite ingresar más de 7 caracteres
            if (txtNombreProducto.Text.Length > Constants.LIMIT_NOMBREPROD_LENGTH)
            {
                txtNombreProducto.Text = txtNombreProducto.Text.Substring(0, Constants.LIMIT_IDPROD_LENGTH);
                txtNombreProducto.SelectionStart = Constants.LIMIT_IDPROD_LENGTH;
            }
            // Verifica la existencia del ID
            else if (ProductoMapper.NombreProductoExiste(txtNombreProducto.Text))
            {
                nombreProducto_not_unique_label.Show();
                isValidNombreProd = false;
            }
            else
            {
                nombreProducto_not_unique_label.Hide();
                isValidNombreProd = true;
            }
            ValidateProductFields();
        }

        private void CBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxCategoria.SelectedIndex > 0)
            {
                categoria_not_choose_label.Hide();
                isValidCategoria = true;
            }
            else
            {
                categoria_not_choose_label.Show();
                isValidCategoria = false;
            }
            ValidateProductFields();
        }

        private void TxtPE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Precio de elaboración inválido – solo se permiten caracteres numéricos y la \".\"", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TxtPE_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUtils.IsValidDouble(txtPE.Text))
            {
                PE_not_valid_label.Hide();

                if (ValidationUtils.ValidarPvpMayorIgualPe(txtPVP.Text, txtPE.Text))
                {
                    PVP_not_greater_than_PE_label.Hide();
                }
                else
                {
                    PVP_not_greater_than_PE_label.Show();
                }
                isValidPE = true;
            }
            else
            {
                PE_not_valid_label.Show();
                isValidPE = false;
            }
            ValidateProductFields();
        }

        private void TxtPVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("P.V.P. inválido – solo se permiten caracteres numéricos y la \".\"", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TxtPVP_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUtils.IsValidDouble(txtPVP.Text))
            {
                PVP_not_valid_label.Hide();

                if (ValidationUtils.ValidarPvpMayorIgualPe(txtPVP.Text, txtPE.Text))
                {
                    PVP_not_greater_than_PE_label.Hide();
                }
                else
                {
                    PVP_not_greater_than_PE_label.Show();
                }
                isValidPVP = true;
            }
            else
            {
                PVP_not_valid_label.Show();
                isValidPVP = false;
            }
            ValidateProductFields();
        }

        private void TxtImagen_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUtils.IsValidPath(txtImagen.Text))
            {
                rutaImagen_not_valid_label.Hide();
                isValidRutaImg = true;
            }
            else
            {
                rutaImagen_not_valid_label.Show();
                isValidRutaImg = false;
            }
            ValidateProductFields();
        }

        // Validaciones de pestana de Lote
        private void ValidateLotFields()
        {
            if (isValidNombProdEnLote && isValidCantidadLote && isValidFechaElabLote)
            {
                SBAniadirLote.Enabled = true;
            }
            else
            {
                SBAniadirLote.Enabled = false;
            }
        }
    }
}
