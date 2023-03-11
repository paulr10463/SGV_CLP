using SGV_CLP.Classes;
using SGV_CLP.Classes.Modulo_Ventas;
using SGV_CLP.GUI.Módulo_Clientes;
using SGV_CLP.GUI.Módulo_Producto;
using Siticone.Desktop.UI.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SGV_CLP.GUI
{
    public partial class UC_Productos : UserControl
    {
        List<Producto> ProductosRegistrados = ProductoMapper.ConsultarProductos();
        List<string> NombresProductosRegistrados = ProductoMapper.ConsultarNombresProductos();
        List<Lote> LoteRegistrados = ProductoMapper.ConsultarLotes();
        bool isValidIdProd, isValidNombreProd, isValidCategoria, isValidPE, isValidPVP, isValidRutaImg; // Para validar los campos de Producto
        bool isValidNombProdEnLote, isValidCantidad, isValidFechaHora; // Para validar los campos de Lote

        public UC_Productos()
        {
            InitializeComponent();
            LlenarTablaProducto();
            LlenarTablaLote();
            LlenarComboBoxProductos();

            cBoxProductoLote.SelectedIndex = 0;
            cBoxCategoria.SelectedIndex = 0;

            isValidIdProd = false;
            isValidNombreProd = false;
            isValidCategoria = false;
            isValidPE = false;
            isValidPVP = false;
            isValidRutaImg = false;

            isValidNombProdEnLote = false;
            isValidCantidad = false;
            isValidFechaHora = false;

            txtIDProd.MaxLength = Constants.LIMIT_IDPROD_LENGTH;
            txtNombreProducto.MaxLength = Constants.LIMIT_NOMBREPROD_LENGTH;
            txtImagen.MaxLength = Constants.LIMIT_RUTAIMAGEN_LENGTH;


            SBAniadirProd.Enabled = false;
            SBAniadirLote.Enabled = false;

            categoria_not_choose_label.Show();

            Producto_not_choose_in_Lote_label.Show();
            FechaHora_not_choose_in_Lote_label.Show();
        }

        // Métodos de pestaña de Producto
        // Vaciar Campos Producto
        private void VaciarCamposProd()
        {
            txtIDProd.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPE.Text = string.Empty;
            txtPVP.Text = string.Empty;
            txtImagen.Text = string.Empty;
            cBoxCategoria.SelectedIndex = 0;
            isValidIdProd = false;
            isValidNombreProd = false;
            isValidCategoria = false;
            isValidPE = false;
            isValidPVP = false;
            isValidRutaImg = false;
            categoria_not_choose_label.Show();
            PVP_not_valid_label.Hide();
            PE_not_valid_label.Hide();
            rutaImagen_not_valid_label.Hide();
        }


        // Llenar tabla Producto
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

        private void SBExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                txtImagen.Text = fileName;
            }
        }

        // Añadir Producto
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

        // Editar y eliminar Producto
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

                    string cod_Producto = SDGVProducto.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Editar_Producto ventana = new Editar_Producto(cod_Producto);
                    ventana.ShowDialog();
                    LlenarTablaProducto();
                    MainMenu.uc_ventas.loadProducts();
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
            // Valida que el campo no esté vacío
            if (txtIDProd.Text.Length > 0)
            {
                // Verifica la existencia del ID
                if (ProductoMapper.IDproductoExiste(txtIDProd.Text))
                {
                    IDProd_not_unique_label.Show();
                    isValidIdProd = false;
                }
                else
                {
                    IDProd_not_unique_label.Hide();
                    isValidIdProd = true;
                }
            }
            else
            {
                isValidIdProd = false;
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
            // Valida que el campo no esté vacío
            if (txtNombreProducto.Text.Length > 0)
            {
                // Verifica la existencia del nombre de producto
                if (ProductoMapper.NombreProductoExiste(txtNombreProducto.Text))
                {
                    nombreProducto_not_unique_label.Show();
                    isValidNombreProd = false;
                }
                else
                {
                    nombreProducto_not_unique_label.Hide();
                    isValidNombreProd = true;
                }
            }
            else
            {
                isValidNombreProd = false;
            }
            ValidateProductFields();
        }

        private void CBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valida que el item seleccionado es "> 0"
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
            // Valida si hay un double en el campo
            if (ValidationUtils.IsValidDouble(txtPE.Text))
            {
                PE_not_valid_label.Hide();

                // Valida si el valor del campo de PVP es ">=" al valor del campo PE
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
            // Valida si hay un double en el campo
            if (ValidationUtils.IsValidDouble(txtPVP.Text))
            {
                PVP_not_valid_label.Hide();

                // Valida si el valor del campo de PVP es ">=" al valor del campo PE
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
            // Valida si el valor del campo es una ruta válida 
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

        // Métodos de pestaña de Lote
        // Vaciar Campos Lote
        private void VaciarCamposLote()
        {
            cBoxProductoLote.SelectedIndex = 0;
            txtCantidad.Text = string.Empty;
            SRBFechaActual.Checked = false;
            SRBElegirFecha.Checked = false;
            isValidNombProdEnLote = false;
            isValidCantidad = false;
            isValidFechaHora = false;
            Producto_not_choose_in_Lote_label.Show();
            FechaHora_not_choose_in_Lote_label.Show();
        }

        // Llenar Tabla Lote
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

        // Llenar  ComboBox Productos
        public void LlenarComboBoxProductos()
        {
            if (NombresProductosRegistrados != null)
            {
                cBoxProductoLote.Items.Clear();
                NombresProductosRegistrados = ProductoMapper.ConsultarNombresProductos();
                cBoxProductoLote.Items.Add("Seleccione...");
                foreach (string nombreProd in NombresProductosRegistrados)
                {
                    cBoxProductoLote.Items.Add(nombreProd);
                }
            }
        }

        // Añadir Lote
        private void SBAniadirLote_Click(object sender, EventArgs e)
        {
            if (SRBFechaActual.Checked)
            {
                var LoteConFechaActual = new Lote(
                ProductoMapper.ConsultarIdProducto(cBoxProductoLote.SelectedItem.ToString()) + DTPFechaLote.Value.ToString("ddMM"),
                ProductoMapper.ConsultarIdProducto(cBoxProductoLote.SelectedItem.ToString()),
                Convert.ToInt32(txtCantidad.Text),
                DateTime.Now);
                ProductoMapper.IngresarLote(LoteConFechaActual);
            }
            else
            {
                var LoteConDateTimePicker = new Lote(
                ProductoMapper.ConsultarIdProducto(cBoxProductoLote.SelectedItem.ToString()) + DTPFechaLote.Value.ToString("ddMM"),
                ProductoMapper.ConsultarIdProducto(cBoxProductoLote.SelectedItem.ToString()),
                Convert.ToInt32(txtCantidad.Text),
                DTPFechaLote.Value.Date + DTPHoraLote.Value.TimeOfDay);
                ProductoMapper.IngresarLote(LoteConDateTimePicker);
            }

            LlenarTablaLote();
            LlenarTablaProducto();

            SystemSounds.Beep.Play();
            MessageBox.Show("Lote añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Editar y eliminar Lote
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
                    string cod_Lote = SDGVLote.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Editar_Lote ventana = new Editar_Lote(cod_Lote);
                    ventana.ShowDialog();
                }
            }
        }

        // Validaciones de pestana de Lote
        private void ValidateLotFields()
        {
            if (isValidNombProdEnLote && isValidCantidad && isValidFechaHora)
            {
                SBAniadirLote.Enabled = true;
            }
            else
            {
                SBAniadirLote.Enabled = false;
            }
        }

        private void cBoxProductoLote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxProductoLote.SelectedIndex > 0)
            {
                Producto_not_choose_in_Lote_label.Hide();
                isValidNombProdEnLote = true;
            }
            else
            {
                Producto_not_choose_in_Lote_label.Show();
                isValidNombProdEnLote = false;
            }
            ValidateLotFields();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (!txtCantidad.Text.Equals(string.Empty))
            {
                isValidCantidad = true;
            }
            else
            {
                isValidCantidad = false;
            }
            ValidateLotFields();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Cantidad inválida – solo se permiten caracteres numéricos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void SRBFechaActual_CheckedChanged(object sender, EventArgs e)
        {
            DTPFechaLote.Visible = false;
            DTPHoraLote.Visible = false;
            FechaHora_not_choose_in_Lote_label.Visible = false;
            isValidFechaHora = true;
            ValidateLotFields();
        }

        private void SRBElegirFecha_CheckedChanged(object sender, EventArgs e)
        {
            DTPFechaLote.Visible = true;
            DTPHoraLote.Visible = true;
            FechaHora_not_choose_in_Lote_label.Visible = false;
            isValidFechaHora = true;
            ValidateLotFields();
        }

    }
}
