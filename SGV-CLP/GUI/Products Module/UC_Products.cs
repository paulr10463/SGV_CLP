using SGV_CLP.Classes;
using SGV_CLP.Classes.Customers_Module;
using SGV_CLP.Classes.Products_module;
using SGV_CLP.GUI.Products_Module;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SGV_CLP.GUI
{
    public partial class UC_Products : UserControl
    {
        List<Product> registeredProducts;
        List<string> registeredProductsNames;
        List<Batch> registeredBatches;

        bool productCodeIsValid, productNameIsValid, categoryIsValid, productionPriceIsValid, salesPriceToThePubicIsValid, imagePathIsValid; // Para validar los campos de Producto
        bool batchProductNameIsValid, quantityIsValid, manufactureDateIsValid; // Para validar los campos de Lote

        public UC_Products()
        {
            InitializeComponent();

            registeredProducts = ProductMapper.GetAllProduct();
            registeredProductsNames = ProductMapper.GetProductsNames();
            registeredBatches = BatchMapper.GetAllBatches();

            productCodeIsValid = false;
            productNameIsValid = false;
            categoryIsValid = false;
            productionPriceIsValid = false;
            salesPriceToThePubicIsValid = false;
            imagePathIsValid = false;

            batchProductNameIsValid = false;
            quantityIsValid = false;
            manufactureDateIsValid = false;

            FillProductDataGridView();
            FillBatchDataGridView();
            FillComboBoxesBatchProducts();

            cbCategory.SelectedIndex = 0;
            cbSearchProdutBy.SelectedIndex = 0;

            cbBatchProductName.SelectedIndex = 0;
            cbSearchBatchBy.SelectedIndex = 0;

            tbProductCode.MaxLength = Constants.LIMIT_IDPROD_LENGTH;
            tbProductName.MaxLength = Constants.LIMIT_NOMBREPROD_LENGTH;
            tbImagePath.MaxLength = Constants.LIMIT_RUTAIMAGEN_LENGTH;

            labelCategoryNotChosen.Show();

            labelBatchProductNameNotChosen.Show();
            labelManufactureDateNotChosen.Show();

            buttonAddProduct.Enabled = false;
            buttonAddBatch.Enabled = false;
        }

        // Métodos de pestaña de Producto
        // Vaciar Campos Producto
        private void ClearProductFields()
        {
            tbProductCode.Text = string.Empty;
            tbProductName.Text = string.Empty;
            tbProductionPrice.Text = string.Empty;
            tbSalesPriceToThePublic.Text = string.Empty;
            tbImagePath.Text = string.Empty;
            cbCategory.SelectedIndex = 0;

            productCodeIsValid = false;
            productNameIsValid = false;
            categoryIsValid = false;
            productionPriceIsValid = false;
            salesPriceToThePubicIsValid = false;
            imagePathIsValid = false;

            labelCategoryNotChosen.Show();
            labelInvalidSalesPriceToThePublic.Hide();
            labelInvalidProductionPrice.Hide();
            labelInvalidImagePath.Hide();
        }

        // Llenar tabla Producto
        public void FillProductDataGridView()
        {
            if (registeredProducts != null)
            {
                ProductDataGridView.Rows.Clear();
                registeredProducts = ProductMapper.GetAllProduct();
                int index = 0;
                foreach (Product product in registeredProducts)
                {
                    ProductDataGridView.Rows.Add(product.productCode, product.productName, product.productionPrice, product.salesPriceToThePubic, product.category, product.totalQuantity);
                    if (product.productCode.Equals("XXX"))
                    {
                        ProductDataGridView.Rows[index].Visible = false;
                    }
                    index++;
                }
            }
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                tbImagePath.Text = fileName;
            }
        }

        // Añadir Producto
        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            var product = new Product(
                tbProductCode.Text.ToUpper(),
                tbProductName.Text,
                Convert.ToDouble(tbProductionPrice.Text, CultureInfo.InvariantCulture),
                Convert.ToDouble(tbSalesPriceToThePublic.Text, CultureInfo.InvariantCulture),
                cbCategory.Text,
                tbImagePath.Text);

            ProductMapper.AddProduct(product);

            FillProductDataGridView();
            FillComboBoxesBatchProducts();
            ClearProductFields();
            MainMenu.uc_ventas.loadProducts();

            SystemSounds.Beep.Play();
            MessageBox.Show("Producto añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Editar y eliminar Producto
        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // CLICK EN CELDA ELIMINAR PRODUCTO
                if (ProductDataGridView.Columns[e.ColumnIndex].Name == "ColumnaEliminarProducto")
                {
                    if (e.RowIndex >= 0 && ProductDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar este producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string productCode = ProductDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                            ProductMapper.DeleteProduct(productCode);
                            MessageBox.Show("Producto eliminado con éxito");
                        }
                    }
                }

                // CLICK EN CELDA EDITAR PRODUCTO
                if (ProductDataGridView.Columns[e.ColumnIndex].Name == "ColumnaEditarProducto")
                {
                    if (e.RowIndex >= 0)
                    {
                        string productCode = ProductDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        EditProduct editProductWinForm = new EditProduct(productCode);
                        editProductWinForm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esa fila está vacía, no puede hacer acciones sobre ella!!");
            }

            FillProductDataGridView();
            FillBatchDataGridView();
            FillComboBoxesBatchProducts();
            MainMenu.uc_ventas.loadProducts();
        }

        // Filtro de busqueda de productos
        private void TbSearchProductBy_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor del ComboBox
            string selectedItem = cbSearchProdutBy.SelectedItem.ToString();

            // Obtener el valor del TextBox
            string filterValue = tbSearchProductBy.Text;

            // Filtrar los datos del DataGridView en función del valor del ComboBox y del TextBox
            if (selectedItem == "Código")
            {
                foreach (DataGridViewRow row in ProductDataGridView.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro 
                    if (row.Cells[0].Value != null && !row.Cells[0].Value.ToString().Equals("XXX"))
                    {
                        row.Visible = row.Cells[0].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
            else if (selectedItem == "Nombre")
            {
                foreach (DataGridViewRow row in ProductDataGridView.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[1].Value != null && !row.Cells[1].Value.ToString().Equals("Producto X"))
                    {
                        row.Visible = row.Cells[1].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
        }

        private void CbSearchProductByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valida que el item seleccionado es "> 0"
            if (cbSearchProductByCategory.SelectedIndex > 0)
            {
                labelCategoryNotChosenInTheSearchProductTab.Hide();
                string filterValue = cbSearchProductByCategory.Text;
                foreach (DataGridViewRow row in ProductDataGridView.Rows)
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
                labelCategoryNotChosenInTheSearchProductTab.Show();
            }
        }

        private void CbSearchProductBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillProductDataGridView();
            tbSearchProductBy.Text = string.Empty;
            if (cbSearchProdutBy.SelectedIndex > 0)
            {
                labelSearchProductWithoutField.Hide();
                if (cbSearchProdutBy.SelectedItem.ToString() == "Categoría")
                {
                    tbSearchProductBy.Visible = false;
                    cbSearchProductByCategory.Visible = true;
                    cbSearchProductByCategory.SelectedIndex = 0;
                }
                else
                {
                    tbSearchProductBy.Visible = true;
                    tbSearchProductBy.Enabled = true;
                    cbSearchProductByCategory.Visible = false;
                }
            }
            else
            {
                labelSearchProductWithoutField.Show();
                tbSearchProductBy.Enabled = false;
                cbSearchProductByCategory.Visible = false;
            }
        }

        // Validaciones de Pestaña producto
        private void ValidateProductFields()
        {
            if (productCodeIsValid && productNameIsValid && productionPriceIsValid && salesPriceToThePubicIsValid && categoryIsValid && imagePathIsValid)
            {
                buttonAddProduct.Enabled = ValidationUtils.ValidarPvpMayorIgualPe(tbSalesPriceToThePublic.Text, tbProductionPrice.Text);
            }
            else
            {
                buttonAddProduct.Enabled = false;
            }
        }

        private void TbProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("ID producto inválido – solo se permiten caracteres alfabéticos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TbProductCode_TextChanged(object sender, EventArgs e)
        {
            // Valida que el campo no esté vacío
            if (tbProductCode.Text.Length > 0)
            {
                // Verifica la existencia del ID
                if (ProductMapper.ProductExistsByCode(tbProductCode.Text))
                {
                    labelProductCodeNotUnique.Show();
                    productCodeIsValid = false;
                }
                else
                {
                    labelProductCodeNotUnique.Hide();
                    productCodeIsValid = true;
                }
            }
            else
            {
                productCodeIsValid = false;
            }
            ValidateProductFields();
        }

        private void TbProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Nombre de producto inválido – solo se permiten caracteres alfabéticos y el espacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TbProductName_TextChanged(object sender, EventArgs e)
        {
            // Valida que el campo no esté vacío
            if (tbProductName.Text.Length > 0)
            {
                // Verifica la existencia del nombre de producto
                if (ProductMapper.ProductExistsByName(tbProductName.Text))
                {
                    labelProductNameNotUnique.Show();
                    productNameIsValid = false;
                }
                else
                {
                    labelProductNameNotUnique.Hide();
                    productNameIsValid = true;
                }
            }
            else
            {
                productNameIsValid = false;
            }
            ValidateProductFields();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valida que el item seleccionado es "> 0"
            if (cbCategory.SelectedIndex > 0)
            {
                labelCategoryNotChosen.Hide();
                categoryIsValid = true;
            }
            else
            {
                labelCategoryNotChosen.Show();
                categoryIsValid = false;
            }
            ValidateProductFields();
        }

        private void TbProductionPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Precio de elaboración inválido – solo se permiten caracteres numéricos y el \".\"", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TbProductionPrice_TextChanged(object sender, EventArgs e)
        {
            // Valida si hay un double en el campo
            if (ValidationUtils.IsValidDouble(tbProductionPrice.Text))
            {
                labelInvalidProductionPrice.Hide();

                // Valida si el valor del campo de PVP es ">=" al valor del campo PE
                if (ValidationUtils.ValidarPvpMayorIgualPe(tbSalesPriceToThePublic.Text, tbProductionPrice.Text))
                {
                    LabelSPPNotGreaterThanPP.Hide();
                }
                else
                {
                    LabelSPPNotGreaterThanPP.Show();
                }
                productionPriceIsValid = true;
            }
            else
            {
                labelInvalidProductionPrice.Show();
                productionPriceIsValid = false;
            }
            ValidateProductFields();
        }

        private void TbSalesPriceToThePublic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("P.V.P. inválido – solo se permiten caracteres numéricos y la \".\"", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TbSalesPriceToThePublic_TextChanged(object sender, EventArgs e)
        {
            // Valida si hay un double en el campo
            if (ValidationUtils.IsValidDouble(tbSalesPriceToThePublic.Text))
            {
                labelInvalidSalesPriceToThePublic.Hide();

                // Valida si el valor del campo de PVP es ">=" al valor del campo PE
                if (ValidationUtils.ValidarPvpMayorIgualPe(tbSalesPriceToThePublic.Text, tbProductionPrice.Text))
                {
                    LabelSPPNotGreaterThanPP.Hide();
                }
                else
                {
                    LabelSPPNotGreaterThanPP.Show();
                }
                salesPriceToThePubicIsValid = true;
            }
            else
            {
                labelInvalidSalesPriceToThePublic.Show();
                salesPriceToThePubicIsValid = false;
            }
            ValidateProductFields();
        }

        private void TbImagePath_TextChanged(object sender, EventArgs e)
        {
            // Valida si el valor del campo es una ruta válida 
            if (ValidationUtils.IsValidPath(tbImagePath.Text))
            {
                labelInvalidImagePath.Hide();
                imagePathIsValid = true;
            }
            else
            {
                labelInvalidImagePath.Show();
                imagePathIsValid = false;
            }
            ValidateProductFields();
        }

        // Métodos de pestaña de Lote
        // Vaciar Campos Lote
        private void ClearBatchFields()
        {
            cbBatchProductName.SelectedIndex = 0;
            tbQuantity.Text = string.Empty;
            rbCurrentDate.Checked = false;
            rbChooseDate.Checked = false;
            batchProductNameIsValid = false;
            quantityIsValid = false;
            manufactureDateIsValid = false;
            labelBatchProductNameNotChosen.Show();
            labelManufactureDateNotChosen.Show();
        }

        // Llenar Tabla Lote
        public void FillBatchDataGridView()
        {
            if (registeredBatches != null)
            {
                BatchDataGridView.Rows.Clear();
                registeredBatches = BatchMapper.GetAllBatches();
                foreach (Batch batch in registeredBatches)
                {
                    BatchDataGridView.Rows.Add(
                        batch.batchCode,
                        batch.productCode,
                        batch.quantity,
                        batch.manufactureDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                }
            }
        }

        // Llenar  ComboBox Productos
        public void FillComboBoxesBatchProducts()
        {
            if (registeredProductsNames != null)
            {
                cbBatchProductName.Items.Clear();
                cbSearchBatchByProductCode.Items.Clear();
                registeredProductsNames = ProductMapper.GetProductsNames();
                cbBatchProductName.Items.Add("Seleccione...");
                cbSearchBatchByProductCode.Items.Add("Seleccione...");
                foreach (string nombreProd in registeredProductsNames)
                {
                    if (!nombreProd.Equals("Producto X"))
                    {
                        cbBatchProductName.Items.Add(nombreProd);
                        cbSearchBatchByProductCode.Items.Add(ProductMapper.GetProductCode(nombreProd));
                    }
                }
            }
        }

        // Añadir Lote
        private void ButtonAddBatch_Click(object sender, EventArgs e)
        {
            string batchCode;
            string productCode = ProductMapper.GetProductCode(cbBatchProductName.SelectedItem.ToString());
            string lastBatchCode = BatchMapper.GetMostRecentBatchCodeForProduct(productCode);
            if (lastBatchCode != string.Empty)
            {
                batchCode = productCode + (Convert.ToInt32(lastBatchCode.Substring(-4)) + 1).ToString("000");
            }
            else
            {
                batchCode = productCode + "0001";
            }
            if (rbCurrentDate.Checked)
            {
                var batchWithCurrentDate = new Batch(
                batchCode,
                productCode,
                Convert.ToInt32(tbQuantity.Text),
                DateTime.Now);
                BatchMapper.AddBatch(batchWithCurrentDate);
            }
            else
            {
                var batchWithChosenDate = new Batch(
                batchCode,
                productCode,
                Convert.ToInt32(tbQuantity.Text),
                dtpManufactureDate.Value.Date + dtpManufactureHour.Value.TimeOfDay);
                BatchMapper.AddBatch(batchWithChosenDate);
            }

            FillBatchDataGridView();
            FillProductDataGridView();
            ClearBatchFields();
            SystemSounds.Beep.Play();
            MessageBox.Show("Lote de producto registrado con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Editar y eliminar Lote
        private void BatchDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (BatchDataGridView.Columns[e.ColumnIndex].Name == "ColumnaEliminarLote")
                {
                    if (e.RowIndex >= 0 && BatchDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar este lote?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string batchCode = BatchDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                            BatchMapper.DeleteBatch(batchCode);
                            MessageBox.Show("Lote de producto eliminado con éxito");
                        }
                    }
                }

                if (BatchDataGridView.Columns[e.ColumnIndex].Name == "ColumnaEditarLote")
                {
                    if (e.RowIndex >= 0)
                    {
                        string batchCode = BatchDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        EditBatch editBatchWinForm = new EditBatch(batchCode);
                        editBatchWinForm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esa fila está vacía, no puede hacer acciones sobre ella!!");
            }

            FillBatchDataGridView();
            FillProductDataGridView();
        }

        private void TbSearchBatchByBatchCode_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor del 
            string filterValue = tbSearchBatchByBatchCode.Text;

            // Filtrar los datos del DataGridView en función del valor del ComboBox y del TextBox
            foreach (DataGridViewRow row in BatchDataGridView.Rows)
            {
                // Ocultar las filas que no cumplan con el filtro
                if (row.Cells[0].Value != null)
                {
                    row.Visible = row.Cells[0].Value.ToString().ToLower().Contains(filterValue.ToLower());
                }
            }

        }

        private void CbSearchBatchByProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchBatchByProductCode.SelectedIndex > 0)
            {
                labelProductCodeNotChosenInTheSearchBatchTab.Hide();
                string filterValue = cbSearchBatchByProductCode.SelectedItem.ToString();

                foreach (DataGridViewRow row in BatchDataGridView.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[1].Value != null)
                    {
                        row.Visible = row.Cells[1].Value.ToString().Contains(filterValue);
                    }
                }
            }
            else
            {
                labelProductCodeNotChosenInTheSearchBatchTab.Show();
            }
        }

        private void DtpSearchBatchByDate_ValueChanged(object sender, EventArgs e)
        {
            string filterValue = dtpSearchBatchByDate.Value.ToString("yyyy-MM-dd");
            foreach (DataGridViewRow row in BatchDataGridView.Rows)
            {
                // Ocultar las filas que no cumplan con el filtro
                if (row.Cells[3].Value != null)
                {
                    row.Visible = row.Cells[3].Value.ToString().Contains(filterValue);
                }
            }
        }


        private void CbSearchBatchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillBatchDataGridView();
            tbSearchBatchByBatchCode.Text = string.Empty;
            if (cbSearchBatchBy.SelectedIndex > 0)
            {
                siticoneHtmlLabel_buscarLote_sin_campo.Hide();

                if (cbSearchBatchBy.SelectedItem.ToString() == "Fecha")
                {
                    tbSearchBatchByBatchCode.Visible = false;
                    cbSearchBatchByProductCode.Visible = false;
                    dtpSearchBatchByDate.Visible = true;
                }
                else if (cbSearchBatchBy.SelectedItem.ToString() == "Código producto")
                {
                    tbSearchBatchByBatchCode.Visible = false;
                    cbSearchBatchByProductCode.Visible = true;
                    cbSearchBatchByProductCode.SelectedIndex = 0;
                    dtpSearchBatchByDate.Visible = false;
                }
                else
                {
                    tbSearchBatchByBatchCode.Visible = true;
                    tbSearchBatchByBatchCode.Enabled = true;
                    cbSearchBatchByProductCode.Visible = false;
                    dtpSearchBatchByDate.Visible = false;
                }
            }
            else
            {
                siticoneHtmlLabel_buscarLote_sin_campo.Show();
                tbSearchBatchByBatchCode.Enabled = false;
                cbSearchBatchByProductCode.Visible = false;
                dtpSearchBatchByDate.Visible = false;
            }
        }

        // Validaciones de pestana de Lote
        private void ValidateBatchFields()
        {
            if (batchProductNameIsValid && quantityIsValid && manufactureDateIsValid)
            {
                buttonAddBatch.Enabled = true;
            }
            else
            {
                buttonAddBatch.Enabled = false;
            }
        }

        private void CbBatchProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBatchProductName.SelectedIndex > 0)
            {
                labelBatchProductNameNotChosen.Hide();
                batchProductNameIsValid = true;
            }
            else
            {
                labelBatchProductNameNotChosen.Show();
                batchProductNameIsValid = false;
            }
            ValidateBatchFields();
        }

        private void TbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!tbQuantity.Text.Equals(string.Empty))
            {
                quantityIsValid = true;
            }
            else
            {
                quantityIsValid = false;
            }
            ValidateBatchFields();
        }

        private void TbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Cantidad inválida – solo se permiten caracteres numéricos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void RbCurrentDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpManufactureDate.Visible = false;
            dtpManufactureHour.Visible = false;
            labelManufactureDateNotChosen.Visible = false;
            manufactureDateIsValid = true;
            ValidateBatchFields();
        }

        private void RbChooseDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpManufactureDate.Visible = true;
            dtpManufactureHour.Visible = true;
            labelManufactureDateNotChosen.Visible = false;
            manufactureDateIsValid = true;
            ValidateBatchFields();
        }
    }
}
