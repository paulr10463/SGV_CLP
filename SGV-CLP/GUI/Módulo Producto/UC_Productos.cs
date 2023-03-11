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
            LlenarComboBoxesProductos();

            cBoxCategoria.SelectedIndex = 0;
            cBConsultarProductoPor.SelectedIndex = 0;

            cBoxProductoLote.SelectedIndex = 0;
            cBConsultarLotePor.SelectedIndex = 0;

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
            LlenarComboBoxesProductos();
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
                txtIDProd.Text.ToUpper(),
                txtNombreProducto.Text,
                Convert.ToDouble(txtPE.Text, CultureInfo.InvariantCulture),
                Convert.ToDouble(txtPVP.Text, CultureInfo.InvariantCulture),
                cBoxCategoria.Text,
                txtImagen.Text);

            ProductoMapper.IngresarProducto(producto);
            LlenarTablaProducto();
            VaciarCamposProd();
            MainMenu.uc_ventas.loadProducts();
            SystemSounds.Beep.Play();
            MessageBox.Show("Producto añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                }
            }
            LlenarTablaProducto();
            MainMenu.uc_ventas.loadProducts();
        }

        // Filtro de busqueda de productos
        private void TxtConsultarProducto_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor del ComboBox
            string selectedItem = cBConsultarProductoPor.SelectedItem.ToString();

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
                        row.Visible = row.Cells[0].Value.ToString().ToLower().Equals(filterValue.ToLower());
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
                        row.Visible = row.Cells[1].Value.ToString().ToLower().Equals(filterValue.ToLower());
                    }
                }
            }
        }

        private void cBoxConsultarProductoPorCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valida que el item seleccionado es "> 0"
            if (cBoxConsultarProductoPorCategoria.SelectedIndex > 0)
            {
                categoria_not_choose_in_ConsultarProducto_label.Hide();
                string filterValue = cBoxConsultarProductoPorCategoria.Text;
                foreach (DataGridViewRow row in SDGVProducto.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[4].Value != null)
                    {
                        row.Visible = row.Cells[4].Value.ToString().Equals(filterValue);
                    }
                }
            }
            else
            {
                categoria_not_choose_in_ConsultarProducto_label.Show();
            }
        }

        private void CBConsultarProductoPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTablaProducto();
            txtConsultarProducto.Text = string.Empty;
            if (cBConsultarProductoPor.SelectedIndex > 0)
            {
                siticoneHtmlLabel_buscarProducto_sin_campo.Hide();
                if (cBConsultarProductoPor.SelectedItem.ToString() == "Categoría")
                {
                    txtConsultarProducto.Visible = false;
                    cBoxConsultarProductoPorCategoria.Visible = true;
                    cBoxConsultarProductoPorCategoria.SelectedIndex = 0;
                }
                else
                {
                    txtConsultarProducto.Visible = true;
                    txtConsultarProducto.Enabled = true;
                    cBoxConsultarProductoPorCategoria.Visible = false;
                }
            }
            else
            {
                siticoneHtmlLabel_buscarProducto_sin_campo.Show();
                txtConsultarProducto.Enabled = false;
                cBoxConsultarProductoPorCategoria.Visible = false;
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
                    SDGVLote.Rows.Add(
                        lote.Cod_Lote,
                        lote.Cod_Producto,
                        lote.Cantidad,
                        lote.FechaElaboracion.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                }
            }
        }

        // Llenar  ComboBox Productos
        public void LlenarComboBoxesProductos()
        {
            if (NombresProductosRegistrados != null)
            {
                cBoxProductoLote.Items.Clear();
                cBoxConsultarLotePorProducto.Items.Clear();
                NombresProductosRegistrados = ProductoMapper.ConsultarNombresProductos();
                cBoxProductoLote.Items.Add("Seleccione...");
                cBoxConsultarLotePorProducto.Items.Add("Seleccione...");
                foreach (string nombreProd in NombresProductosRegistrados)
                {
                    cBoxProductoLote.Items.Add(nombreProd);
                    cBoxConsultarLotePorProducto.Items.Add(ProductoMapper.ConsultarIdProducto(nombreProd));
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
            VaciarCamposLote();
            SystemSounds.Beep.Play();
            MessageBox.Show("Lote de producto registrado con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Editar y eliminar Lote
        private void SDGVLote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SDGVLote.Columns[e.ColumnIndex].Name == "ColumnaEliminarLote")
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este lote?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string cod_Lote = SDGVLote.Rows[e.RowIndex].Cells[0].Value.ToString();
                        ProductoMapper.EliminarLote(cod_Lote);
                        MessageBox.Show("Lote de producto eliminado con éxito");
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
            LlenarTablaLote();
        }

        private void TxtConsultarLotePorCodigo_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor del 
            string filterValue = txtConsultarLotePorCodigo.Text;

            // Filtrar los datos del DataGridView en función del valor del ComboBox y del TextBox
            foreach (DataGridViewRow row in SDGVLote.Rows)
            {
                // Ocultar las filas que no cumplan con el filtro
                if (row.Cells[0].Value != null)
                {
                    row.Visible = row.Cells[0].Value.ToString().ToLower().Contains(filterValue.ToLower());
                }
            }

        }

        private void CBoxConsultarLotePorProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxConsultarLotePorProducto.SelectedIndex > 0)
            {
                Producto_not_choose_in_ConsultarLote_label.Hide();
                string filterValue = cBoxConsultarLotePorProducto.SelectedItem.ToString();

                foreach (DataGridViewRow row in SDGVLote.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[1].Value != null)
                    {
                        row.Visible = row.Cells[1].Value.ToString().Equals(filterValue);
                    }
                }
            }
            else
            {
                Producto_not_choose_in_ConsultarLote_label.Show();
            }
        }

        private void DTPFConsultarLotePorFecha_ValueChanged(object sender, EventArgs e)
        {
            string filterValue = DTPFConsultarLotePorFecha.Value.ToString("yyyy-MM-dd");
            foreach (DataGridViewRow row in SDGVLote.Rows)
            {
                // Ocultar las filas que no cumplan con el filtro
                if (row.Cells[3].Value != null)
                {
                    row.Visible = row.Cells[3].Value.ToString().Contains(filterValue);
                }
            }
        }


        private void CBConsultarLotePor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTablaLote();
            txtConsultarLotePorCodigo.Text = string.Empty;
            if (cBConsultarLotePor.SelectedIndex > 0)
            {
                siticoneHtmlLabel_buscarLote_sin_campo.Hide();

                if (cBConsultarLotePor.SelectedItem.ToString() == "Fecha")
                {
                    txtConsultarLotePorCodigo.Visible = false;
                    cBoxConsultarLotePorProducto.Visible = false;
                    DTPFConsultarLotePorFecha.Visible = true;
                }
                else if (cBConsultarLotePor.SelectedItem.ToString() == "Código producto")
                {
                    txtConsultarLotePorCodigo.Visible = false;
                    cBoxConsultarLotePorProducto.Visible = true;
                    cBoxConsultarLotePorProducto.SelectedIndex = 0;
                    DTPFConsultarLotePorFecha.Visible = false;
                }
                else
                {
                    txtConsultarLotePorCodigo.Visible = true;
                    txtConsultarLotePorCodigo.Enabled = true;
                    cBoxConsultarLotePorProducto.Visible = false;
                    DTPFConsultarLotePorFecha.Visible = false;
                }
            }
            else
            {
                siticoneHtmlLabel_buscarLote_sin_campo.Show();
                txtConsultarLotePorCodigo.Enabled = false;
                cBoxConsultarLotePorProducto.Visible = false;
                DTPFConsultarLotePorFecha.Visible = false;
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

        private void CBoxProductoLote_SelectedIndexChanged(object sender, EventArgs e)
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

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
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

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
