using System.Windows.Forms;

namespace SGV_CLP.GUI
{
    partial class UC_Products
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Products));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            Añadir = new TabPage();
            labelInvalidImagePath = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelInvalidProductionPrice = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            LabelSPPNotGreaterThanPP = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelInvalidSalesPriceToThePublic = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCategoryNotChosen = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelProductNameNotUnique = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelProductCodeNotUnique = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbProductCode = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            SBExaminar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            tbImagePath = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel11 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            buttonAddProduct = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            cbCategory = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbSalesPriceToThePublic = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel8 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbProductionPrice = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbProductName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            Editar = new TabPage();
            labelCategoryNotChosenInTheSearchProductTab = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            cbSearchProductByCategory = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            labelSearchProductWithoutField = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            cbSearchProdutBy = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            tbSearchProductBy = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            ProductDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            CodProd = new DataGridViewTextBoxColumn();
            NombreProd = new DataGridViewTextBoxColumn();
            PrecioElab = new DataGridViewTextBoxColumn();
            PrecioVentaPub = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ColumnaEditarProducto = new DataGridViewImageColumn();
            ColumnaEliminarProducto = new DataGridViewImageColumn();
            tabPage1 = new TabPage();
            labelManufactureDateNotChosen = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelBatchProductNameNotChosen = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            GBFechaHoraElab = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            dtpManufactureHour = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            rbCurrentDate = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            rbChooseDate = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            dtpManufactureDate = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            buttonAddBatch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            cbBatchProductName = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbQuantity = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tabPage2 = new TabPage();
            labelProductCodeNotChosenInTheSearchBatchTab = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            cbSearchBatchByProductCode = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneHtmlLabel_buscarLote_sin_campo = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            dtpSearchBatchByDate = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            BatchDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            ColumnaCodLote = new DataGridViewTextBoxColumn();
            ColumnaCodProd = new DataGridViewTextBoxColumn();
            ColunmaCantidad = new DataGridViewTextBoxColumn();
            ColumnaFechayHora = new DataGridViewTextBoxColumn();
            ColumnaEditarLote = new DataGridViewImageColumn();
            ColumnaEliminarLote = new DataGridViewImageColumn();
            cbSearchBatchBy = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            tbSearchBatchByBatchCode = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneTabControl1.SuspendLayout();
            Añadir.SuspendLayout();
            Editar.SuspendLayout();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            tabPage1.SuspendLayout();
            GBFechaHoraElab.SuspendLayout();
            tabPage2.SuspendLayout();
            siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BatchDataGridView).BeginInit();
            SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            siticoneTabControl1.Alignment = TabAlignment.Left;
            siticoneTabControl1.Controls.Add(Añadir);
            siticoneTabControl1.Controls.Add(Editar);
            siticoneTabControl1.Controls.Add(tabPage1);
            siticoneTabControl1.Controls.Add(tabPage2);
            siticoneTabControl1.Dock = DockStyle.Fill;
            siticoneTabControl1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.ItemSize = new Size(160, 75);
            siticoneTabControl1.Location = new Point(0, 0);
            siticoneTabControl1.Margin = new Padding(3, 4, 3, 4);
            siticoneTabControl1.Name = "siticoneTabControl1";
            siticoneTabControl1.SelectedIndex = 0;
            siticoneTabControl1.Size = new Size(1449, 1020);
            siticoneTabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonHoverState.FillColor = Color.Black;
            siticoneTabControl1.TabButtonHoverState.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.TabButtonHoverState.ForeColor = Color.White;
            siticoneTabControl1.TabButtonHoverState.InnerColor = Color.Black;
            siticoneTabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonIdleState.FillColor = Color.Black;
            siticoneTabControl1.TabButtonIdleState.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            siticoneTabControl1.TabButtonIdleState.InnerColor = Color.Black;
            siticoneTabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonSelectedState.FillColor = Color.Black;
            siticoneTabControl1.TabButtonSelectedState.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.TabButtonSelectedState.ForeColor = Color.White;
            siticoneTabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            siticoneTabControl1.TabButtonSize = new Size(160, 75);
            siticoneTabControl1.TabIndex = 2;
            siticoneTabControl1.TabMenuBackColor = Color.Black;
            // 
            // Añadir
            // 
            Añadir.BackColor = Color.White;
            Añadir.Controls.Add(labelInvalidImagePath);
            Añadir.Controls.Add(labelInvalidProductionPrice);
            Añadir.Controls.Add(LabelSPPNotGreaterThanPP);
            Añadir.Controls.Add(labelInvalidSalesPriceToThePublic);
            Añadir.Controls.Add(labelCategoryNotChosen);
            Añadir.Controls.Add(labelProductNameNotUnique);
            Añadir.Controls.Add(labelProductCodeNotUnique);
            Añadir.Controls.Add(siticoneHtmlLabel1);
            Añadir.Controls.Add(tbProductCode);
            Añadir.Controls.Add(SBExaminar);
            Añadir.Controls.Add(tbImagePath);
            Añadir.Controls.Add(siticoneHtmlLabel11);
            Añadir.Controls.Add(buttonAddProduct);
            Añadir.Controls.Add(cbCategory);
            Añadir.Controls.Add(siticoneHtmlLabel6);
            Añadir.Controls.Add(tbSalesPriceToThePublic);
            Añadir.Controls.Add(siticoneHtmlLabel8);
            Añadir.Controls.Add(tbProductionPrice);
            Añadir.Controls.Add(siticoneHtmlLabel7);
            Añadir.Controls.Add(siticoneHtmlLabel5);
            Añadir.Controls.Add(tbProductName);
            Añadir.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Añadir.Location = new Point(164, 4);
            Añadir.Margin = new Padding(3, 5, 3, 5);
            Añadir.Name = "Añadir";
            Añadir.Padding = new Padding(3, 5, 3, 5);
            Añadir.Size = new Size(1281, 1012);
            Añadir.TabIndex = 0;
            Añadir.Text = "Registrar Producto";
            // 
            // labelInvalidImagePath
            // 
            labelInvalidImagePath.Anchor = AnchorStyles.None;
            labelInvalidImagePath.BackColor = Color.Transparent;
            labelInvalidImagePath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidImagePath.ForeColor = Color.Red;
            labelInvalidImagePath.Location = new Point(1174, 640);
            labelInvalidImagePath.Margin = new Padding(3, 4, 3, 4);
            labelInvalidImagePath.Name = "labelInvalidImagePath";
            labelInvalidImagePath.Size = new Size(89, 22);
            labelInvalidImagePath.TabIndex = 63;
            labelInvalidImagePath.Text = "Ruta inválida";
            labelInvalidImagePath.Visible = false;
            // 
            // labelInvalidProductionPrice
            // 
            labelInvalidProductionPrice.Anchor = AnchorStyles.None;
            labelInvalidProductionPrice.BackColor = Color.Transparent;
            labelInvalidProductionPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidProductionPrice.ForeColor = Color.Red;
            labelInvalidProductionPrice.Location = new Point(671, 428);
            labelInvalidProductionPrice.Margin = new Padding(3, 4, 3, 4);
            labelInvalidProductionPrice.Name = "labelInvalidProductionPrice";
            labelInvalidProductionPrice.Size = new Size(117, 22);
            labelInvalidProductionPrice.TabIndex = 62;
            labelInvalidProductionPrice.Text = "Máx. 2 decimales";
            labelInvalidProductionPrice.Visible = false;
            // 
            // LabelSPPNotGreaterThanPP
            // 
            LabelSPPNotGreaterThanPP.Anchor = AnchorStyles.None;
            LabelSPPNotGreaterThanPP.BackColor = Color.Transparent;
            LabelSPPNotGreaterThanPP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSPPNotGreaterThanPP.ForeColor = Color.Red;
            LabelSPPNotGreaterThanPP.Location = new Point(671, 541);
            LabelSPPNotGreaterThanPP.Margin = new Padding(3, 4, 3, 4);
            LabelSPPNotGreaterThanPP.Name = "LabelSPPNotGreaterThanPP";
            LabelSPPNotGreaterThanPP.Size = new Size(118, 22);
            LabelSPPNotGreaterThanPP.TabIndex = 61;
            LabelSPPNotGreaterThanPP.Text = "Debe ser >= a PE";
            LabelSPPNotGreaterThanPP.Visible = false;
            // 
            // labelInvalidSalesPriceToThePublic
            // 
            labelInvalidSalesPriceToThePublic.Anchor = AnchorStyles.None;
            labelInvalidSalesPriceToThePublic.BackColor = Color.Transparent;
            labelInvalidSalesPriceToThePublic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidSalesPriceToThePublic.ForeColor = Color.Red;
            labelInvalidSalesPriceToThePublic.Location = new Point(671, 511);
            labelInvalidSalesPriceToThePublic.Margin = new Padding(3, 4, 3, 4);
            labelInvalidSalesPriceToThePublic.Name = "labelInvalidSalesPriceToThePublic";
            labelInvalidSalesPriceToThePublic.Size = new Size(117, 22);
            labelInvalidSalesPriceToThePublic.TabIndex = 59;
            labelInvalidSalesPriceToThePublic.Text = "Máx. 2 decimales";
            labelInvalidSalesPriceToThePublic.Visible = false;
            // 
            // labelCategoryNotChosen
            // 
            labelCategoryNotChosen.Anchor = AnchorStyles.None;
            labelCategoryNotChosen.BackColor = Color.Transparent;
            labelCategoryNotChosen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategoryNotChosen.ForeColor = Color.Red;
            labelCategoryNotChosen.Location = new Point(671, 306);
            labelCategoryNotChosen.Margin = new Padding(3, 4, 3, 4);
            labelCategoryNotChosen.Name = "labelCategoryNotChosen";
            labelCategoryNotChosen.Size = new Size(265, 22);
            labelCategoryNotChosen.TabIndex = 57;
            labelCategoryNotChosen.Text = "Debe pertenecer a una categoría válida";
            labelCategoryNotChosen.Visible = false;
            // 
            // labelProductNameNotUnique
            // 
            labelProductNameNotUnique.Anchor = AnchorStyles.None;
            labelProductNameNotUnique.BackColor = Color.Transparent;
            labelProductNameNotUnique.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductNameNotUnique.ForeColor = Color.Red;
            labelProductNameNotUnique.Location = new Point(671, 207);
            labelProductNameNotUnique.Margin = new Padding(3, 4, 3, 4);
            labelProductNameNotUnique.Name = "labelProductNameNotUnique";
            labelProductNameNotUnique.Size = new Size(256, 22);
            labelProductNameNotUnique.TabIndex = 56;
            labelProductNameNotUnique.Text = "Ya existe un producto con ese nombre";
            labelProductNameNotUnique.Visible = false;
            // 
            // labelProductCodeNotUnique
            // 
            labelProductCodeNotUnique.Anchor = AnchorStyles.None;
            labelProductCodeNotUnique.BackColor = Color.Transparent;
            labelProductCodeNotUnique.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductCodeNotUnique.ForeColor = Color.Red;
            labelProductCodeNotUnique.Location = new Point(671, 107);
            labelProductCodeNotUnique.Margin = new Padding(3, 4, 3, 4);
            labelProductCodeNotUnique.Name = "labelProductCodeNotUnique";
            labelProductCodeNotUnique.Size = new Size(219, 22);
            labelProductCodeNotUnique.TabIndex = 55;
            labelProductCodeNotUnique.Text = "Ya existe un producto con ese ID";
            labelProductCodeNotUnique.Visible = false;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(133, 107);
            siticoneHtmlLabel1.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(151, 34);
            siticoneHtmlLabel1.TabIndex = 52;
            siticoneHtmlLabel1.Text = "ID Producto";
            // 
            // tbProductCode
            // 
            tbProductCode.Anchor = AnchorStyles.None;
            tbProductCode.BorderRadius = 20;
            tbProductCode.DefaultText = "";
            tbProductCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbProductCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbProductCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbProductCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbProductCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductCode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductCode.Location = new Point(421, 95);
            tbProductCode.Margin = new Padding(3, 8, 3, 8);
            tbProductCode.Name = "tbProductCode";
            tbProductCode.PasswordChar = '\0';
            tbProductCode.PlaceholderText = "";
            tbProductCode.SelectedText = "";
            tbProductCode.Size = new Size(229, 55);
            tbProductCode.TabIndex = 51;
            tbProductCode.TextOffset = new Point(5, 0);
            tbProductCode.TextChanged += TbProductCode_TextChanged;
            tbProductCode.KeyPress += TbProductCode_KeyPress;
            // 
            // SBExaminar
            // 
            SBExaminar.Anchor = AnchorStyles.None;
            SBExaminar.BorderRadius = 20;
            SBExaminar.DisabledState.BorderColor = Color.DarkGray;
            SBExaminar.DisabledState.CustomBorderColor = Color.DarkGray;
            SBExaminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBExaminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBExaminar.FillColor = Color.Black;
            SBExaminar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBExaminar.ForeColor = Color.White;
            SBExaminar.Location = new Point(953, 617);
            SBExaminar.Margin = new Padding(3, 4, 3, 4);
            SBExaminar.Name = "SBExaminar";
            SBExaminar.Size = new Size(206, 60);
            SBExaminar.TabIndex = 50;
            SBExaminar.Text = "Examinar...";
            SBExaminar.Click += ButtonBrowse_Click;
            // 
            // tbImagePath
            // 
            tbImagePath.Anchor = AnchorStyles.None;
            tbImagePath.BorderRadius = 20;
            tbImagePath.DefaultText = "";
            tbImagePath.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbImagePath.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbImagePath.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbImagePath.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbImagePath.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbImagePath.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbImagePath.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbImagePath.Location = new Point(421, 617);
            tbImagePath.Margin = new Padding(3, 7, 3, 7);
            tbImagePath.Name = "tbImagePath";
            tbImagePath.PasswordChar = '\0';
            tbImagePath.PlaceholderText = "";
            tbImagePath.SelectedText = "";
            tbImagePath.Size = new Size(515, 55);
            tbImagePath.TabIndex = 49;
            tbImagePath.TextOffset = new Point(5, 0);
            tbImagePath.TextChanged += TbImagePath_TextChanged;
            // 
            // siticoneHtmlLabel11
            // 
            siticoneHtmlLabel11.Anchor = AnchorStyles.None;
            siticoneHtmlLabel11.BackColor = Color.Transparent;
            siticoneHtmlLabel11.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel11.Location = new Point(133, 628);
            siticoneHtmlLabel11.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel11.Name = "siticoneHtmlLabel11";
            siticoneHtmlLabel11.Size = new Size(166, 34);
            siticoneHtmlLabel11.TabIndex = 48;
            siticoneHtmlLabel11.Text = "Ruta imagen";
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Anchor = AnchorStyles.None;
            buttonAddProduct.BorderRadius = 20;
            buttonAddProduct.DisabledState.BorderColor = Color.DarkGray;
            buttonAddProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonAddProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonAddProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonAddProduct.FillColor = Color.Black;
            buttonAddProduct.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddProduct.ForeColor = Color.White;
            buttonAddProduct.Location = new Point(583, 796);
            buttonAddProduct.Margin = new Padding(3, 5, 3, 5);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(206, 60);
            buttonAddProduct.TabIndex = 45;
            buttonAddProduct.Text = "Añadir";
            buttonAddProduct.Click += ButtonAddProduct_Click;
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.BackColor = Color.Transparent;
            cbCategory.BorderRadius = 20;
            cbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbCategory.ItemHeight = 35;
            cbCategory.Items.AddRange(new object[] { "Seleccione...", "Especialidades", "Bebidas Frías", "Bebidas Calientes", "Empanadas" });
            cbCategory.Location = new Point(421, 300);
            cbCategory.Margin = new Padding(3, 5, 3, 5);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(228, 41);
            cbCategory.StartIndex = 0;
            cbCategory.TabIndex = 44;
            cbCategory.TextOffset = new Point(5, 0);
            cbCategory.SelectedIndexChanged += CbCategory_SelectedIndexChanged;
            // 
            // siticoneHtmlLabel6
            // 
            siticoneHtmlLabel6.Anchor = AnchorStyles.None;
            siticoneHtmlLabel6.BackColor = Color.Transparent;
            siticoneHtmlLabel6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel6.Location = new Point(133, 306);
            siticoneHtmlLabel6.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            siticoneHtmlLabel6.Size = new Size(133, 34);
            siticoneHtmlLabel6.TabIndex = 43;
            siticoneHtmlLabel6.Text = "Categoría";
            // 
            // tbSalesPriceToThePublic
            // 
            tbSalesPriceToThePublic.Anchor = AnchorStyles.None;
            tbSalesPriceToThePublic.BorderRadius = 20;
            tbSalesPriceToThePublic.DefaultText = "";
            tbSalesPriceToThePublic.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSalesPriceToThePublic.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSalesPriceToThePublic.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSalesPriceToThePublic.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSalesPriceToThePublic.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSalesPriceToThePublic.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbSalesPriceToThePublic.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSalesPriceToThePublic.Location = new Point(421, 511);
            tbSalesPriceToThePublic.Margin = new Padding(3, 8, 3, 8);
            tbSalesPriceToThePublic.Name = "tbSalesPriceToThePublic";
            tbSalesPriceToThePublic.PasswordChar = '\0';
            tbSalesPriceToThePublic.PlaceholderText = "";
            tbSalesPriceToThePublic.SelectedText = "";
            tbSalesPriceToThePublic.Size = new Size(229, 55);
            tbSalesPriceToThePublic.TabIndex = 42;
            tbSalesPriceToThePublic.TextOffset = new Point(5, 0);
            tbSalesPriceToThePublic.TextChanged += TbSalesPriceToThePublic_TextChanged;
            tbSalesPriceToThePublic.KeyPress += TbSalesPriceToThePublic_KeyPress;
            // 
            // siticoneHtmlLabel8
            // 
            siticoneHtmlLabel8.Anchor = AnchorStyles.None;
            siticoneHtmlLabel8.BackColor = Color.Transparent;
            siticoneHtmlLabel8.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel8.Location = new Point(133, 529);
            siticoneHtmlLabel8.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel8.Name = "siticoneHtmlLabel8";
            siticoneHtmlLabel8.Size = new Size(73, 34);
            siticoneHtmlLabel8.TabIndex = 41;
            siticoneHtmlLabel8.Text = "P.V.P.";
            // 
            // tbProductionPrice
            // 
            tbProductionPrice.Anchor = AnchorStyles.None;
            tbProductionPrice.BorderRadius = 20;
            tbProductionPrice.DefaultText = "";
            tbProductionPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbProductionPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbProductionPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbProductionPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbProductionPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductionPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductionPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductionPrice.Location = new Point(421, 406);
            tbProductionPrice.Margin = new Padding(3, 8, 3, 8);
            tbProductionPrice.Name = "tbProductionPrice";
            tbProductionPrice.PasswordChar = '\0';
            tbProductionPrice.PlaceholderText = "";
            tbProductionPrice.SelectedText = "";
            tbProductionPrice.Size = new Size(229, 55);
            tbProductionPrice.TabIndex = 40;
            tbProductionPrice.TextOffset = new Point(5, 0);
            tbProductionPrice.TextChanged += TbProductionPrice_TextChanged;
            tbProductionPrice.KeyPress += TbProductionPrice_KeyPress;
            // 
            // siticoneHtmlLabel7
            // 
            siticoneHtmlLabel7.Anchor = AnchorStyles.None;
            siticoneHtmlLabel7.BackColor = Color.Transparent;
            siticoneHtmlLabel7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel7.Location = new Point(133, 416);
            siticoneHtmlLabel7.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            siticoneHtmlLabel7.Size = new Size(245, 34);
            siticoneHtmlLabel7.TabIndex = 34;
            siticoneHtmlLabel7.Text = "Precio Elaboración";
            // 
            // siticoneHtmlLabel5
            // 
            siticoneHtmlLabel5.Anchor = AnchorStyles.None;
            siticoneHtmlLabel5.BackColor = Color.Transparent;
            siticoneHtmlLabel5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel5.Location = new Point(133, 207);
            siticoneHtmlLabel5.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            siticoneHtmlLabel5.Size = new Size(229, 34);
            siticoneHtmlLabel5.TabIndex = 28;
            siticoneHtmlLabel5.Text = "Nombre Producto";
            // 
            // tbProductName
            // 
            tbProductName.Anchor = AnchorStyles.None;
            tbProductName.BorderRadius = 20;
            tbProductName.DefaultText = "";
            tbProductName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbProductName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbProductName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbProductName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbProductName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductName.Location = new Point(421, 195);
            tbProductName.Margin = new Padding(3, 8, 3, 8);
            tbProductName.Name = "tbProductName";
            tbProductName.PasswordChar = '\0';
            tbProductName.PlaceholderText = "";
            tbProductName.SelectedText = "";
            tbProductName.Size = new Size(229, 55);
            tbProductName.TabIndex = 27;
            tbProductName.TextOffset = new Point(5, 0);
            tbProductName.TextChanged += TbProductName_TextChanged;
            tbProductName.KeyPress += TbProductName_KeyPress;
            // 
            // Editar
            // 
            Editar.BackColor = Color.White;
            Editar.Controls.Add(labelCategoryNotChosenInTheSearchProductTab);
            Editar.Controls.Add(cbSearchProductByCategory);
            Editar.Controls.Add(labelSearchProductWithoutField);
            Editar.Controls.Add(cbSearchProdutBy);
            Editar.Controls.Add(tbSearchProductBy);
            Editar.Controls.Add(siticonePanel1);
            Editar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.Location = new Point(164, 4);
            Editar.Margin = new Padding(3, 4, 3, 4);
            Editar.Name = "Editar";
            Editar.Padding = new Padding(3, 5, 3, 5);
            Editar.Size = new Size(1281, 1012);
            Editar.TabIndex = 1;
            Editar.Text = "Editar/Eliminar Producto";
            // 
            // labelCategoryNotChosenInTheSearchProductTab
            // 
            labelCategoryNotChosenInTheSearchProductTab.Anchor = AnchorStyles.None;
            labelCategoryNotChosenInTheSearchProductTab.BackColor = Color.Transparent;
            labelCategoryNotChosenInTheSearchProductTab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategoryNotChosenInTheSearchProductTab.ForeColor = Color.Red;
            labelCategoryNotChosenInTheSearchProductTab.Location = new Point(324, 209);
            labelCategoryNotChosenInTheSearchProductTab.Margin = new Padding(3, 4, 3, 4);
            labelCategoryNotChosenInTheSearchProductTab.Name = "labelCategoryNotChosenInTheSearchProductTab";
            labelCategoryNotChosenInTheSearchProductTab.Size = new Size(265, 22);
            labelCategoryNotChosenInTheSearchProductTab.TabIndex = 59;
            labelCategoryNotChosenInTheSearchProductTab.Text = "Debe pertenecer a una categoría válida";
            labelCategoryNotChosenInTheSearchProductTab.Visible = false;
            // 
            // cbSearchProductByCategory
            // 
            cbSearchProductByCategory.Anchor = AnchorStyles.None;
            cbSearchProductByCategory.BackColor = Color.Transparent;
            cbSearchProductByCategory.BorderRadius = 20;
            cbSearchProductByCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearchProductByCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchProductByCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSearchProductByCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSearchProductByCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchProductByCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbSearchProductByCategory.ItemHeight = 55;
            cbSearchProductByCategory.Items.AddRange(new object[] { "Seleccione...", "Especialidades", "Bebidas" });
            cbSearchProductByCategory.Location = new Point(302, 139);
            cbSearchProductByCategory.Margin = new Padding(3, 5, 3, 5);
            cbSearchProductByCategory.Name = "cbSearchProductByCategory";
            cbSearchProductByCategory.Size = new Size(312, 61);
            cbSearchProductByCategory.TabIndex = 58;
            cbSearchProductByCategory.TextOffset = new Point(5, 0);
            cbSearchProductByCategory.Visible = false;
            cbSearchProductByCategory.SelectedIndexChanged += CbSearchProductByCategory_SelectedIndexChanged;
            // 
            // labelSearchProductWithoutField
            // 
            labelSearchProductWithoutField.Anchor = AnchorStyles.None;
            labelSearchProductWithoutField.BackColor = Color.Transparent;
            labelSearchProductWithoutField.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearchProductWithoutField.ForeColor = Color.Red;
            labelSearchProductWithoutField.Location = new Point(302, 108);
            labelSearchProductWithoutField.Margin = new Padding(3, 4, 3, 4);
            labelSearchProductWithoutField.Name = "labelSearchProductWithoutField";
            labelSearchProductWithoutField.Size = new Size(257, 22);
            labelSearchProductWithoutField.TabIndex = 25;
            labelSearchProductWithoutField.Text = "¡Seleccione un parámetro para buscar!";
            // 
            // cbSearchProdutBy
            // 
            cbSearchProdutBy.Anchor = AnchorStyles.None;
            cbSearchProdutBy.AutoCompleteCustomSource.AddRange(new string[] { "Código", "Nombre", "Categoría" });
            cbSearchProdutBy.BackColor = Color.Transparent;
            cbSearchProdutBy.BorderRadius = 20;
            cbSearchProdutBy.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearchProdutBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchProdutBy.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSearchProdutBy.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSearchProdutBy.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchProdutBy.ForeColor = Color.FromArgb(68, 88, 112);
            cbSearchProdutBy.ItemHeight = 40;
            cbSearchProdutBy.Items.AddRange(new object[] { "Seleccione...", "Código", "Nombre", "Categoría" });
            cbSearchProdutBy.Location = new Point(631, 139);
            cbSearchProdutBy.Margin = new Padding(3, 4, 3, 4);
            cbSearchProdutBy.Name = "cbSearchProdutBy";
            cbSearchProdutBy.Size = new Size(311, 46);
            cbSearchProdutBy.StartIndex = 0;
            cbSearchProdutBy.TabIndex = 20;
            cbSearchProdutBy.SelectedIndexChanged += CbSearchProductBy_SelectedIndexChanged;
            // 
            // tbSearchProductBy
            // 
            tbSearchProductBy.Anchor = AnchorStyles.None;
            tbSearchProductBy.BorderRadius = 20;
            tbSearchProductBy.DefaultText = "";
            tbSearchProductBy.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSearchProductBy.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSearchProductBy.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSearchProductBy.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSearchProductBy.Enabled = false;
            tbSearchProductBy.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchProductBy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearchProductBy.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchProductBy.Location = new Point(302, 139);
            tbSearchProductBy.Margin = new Padding(3, 5, 3, 5);
            tbSearchProductBy.Name = "tbSearchProductBy";
            tbSearchProductBy.PasswordChar = '\0';
            tbSearchProductBy.PlaceholderText = "Buscar...";
            tbSearchProductBy.SelectedText = "";
            tbSearchProductBy.Size = new Size(312, 61);
            tbSearchProductBy.TabIndex = 19;
            tbSearchProductBy.TextChanged += TbSearchProductBy_TextChanged;
            // 
            // siticonePanel1
            // 
            siticonePanel1.Controls.Add(ProductDataGridView);
            siticonePanel1.Dock = DockStyle.Bottom;
            siticonePanel1.Location = new Point(3, 340);
            siticonePanel1.Margin = new Padding(3, 5, 3, 5);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(1275, 667);
            siticonePanel1.TabIndex = 1;
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            ProductDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductDataGridView.ColumnHeadersHeight = 75;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { CodProd, NombreProd, PrecioElab, PrecioVentaPub, Categoria, Cantidad, ColumnaEditarProducto, ColumnaEliminarProducto });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ProductDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            ProductDataGridView.Dock = DockStyle.Fill;
            ProductDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            ProductDataGridView.Location = new Point(0, 0);
            ProductDataGridView.Margin = new Padding(3, 4, 3, 4);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.RowHeadersVisible = false;
            ProductDataGridView.RowHeadersWidth = 50;
            ProductDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            ProductDataGridView.RowTemplate.Height = 50;
            ProductDataGridView.Size = new Size(1275, 667);
            ProductDataGridView.TabIndex = 0;
            ProductDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ProductDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            ProductDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ProductDataGridView.ThemeStyle.BackColor = Color.White;
            ProductDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ProductDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.DimGray;
            ProductDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ProductDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProductDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ProductDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ProductDataGridView.ThemeStyle.HeaderStyle.Height = 75;
            ProductDataGridView.ThemeStyle.ReadOnly = false;
            ProductDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            ProductDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProductDataGridView.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProductDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ProductDataGridView.ThemeStyle.RowsStyle.Height = 50;
            ProductDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ProductDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ProductDataGridView.CellClick += ProductDataGridView_CellClick;
            // 
            // CodProd
            // 
            CodProd.FillWeight = 75F;
            CodProd.HeaderText = "Código";
            CodProd.MinimumWidth = 6;
            CodProd.Name = "CodProd";
            CodProd.ReadOnly = true;
            CodProd.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NombreProd
            // 
            NombreProd.FillWeight = 150F;
            NombreProd.HeaderText = "Nombre";
            NombreProd.MinimumWidth = 6;
            NombreProd.Name = "NombreProd";
            NombreProd.ReadOnly = true;
            NombreProd.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioElab
            // 
            PrecioElab.FillWeight = 50F;
            PrecioElab.HeaderText = "P.E";
            PrecioElab.MinimumWidth = 6;
            PrecioElab.Name = "PrecioElab";
            PrecioElab.ReadOnly = true;
            PrecioElab.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioVentaPub
            // 
            PrecioVentaPub.FillWeight = 50F;
            PrecioVentaPub.HeaderText = "P.V.P";
            PrecioVentaPub.MinimumWidth = 6;
            PrecioVentaPub.Name = "PrecioVentaPub";
            PrecioVentaPub.ReadOnly = true;
            PrecioVentaPub.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Categoria
            // 
            Categoria.FillWeight = 150F;
            Categoria.HeaderText = "Categoría";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            Cantidad.FillWeight = 75F;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaEditarProducto
            // 
            ColumnaEditarProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnaEditarProducto.HeaderText = "";
            ColumnaEditarProducto.Image = (Image)resources.GetObject("ColumnaEditarProducto.Image");
            ColumnaEditarProducto.MinimumWidth = 6;
            ColumnaEditarProducto.Name = "ColumnaEditarProducto";
            ColumnaEditarProducto.ReadOnly = true;
            ColumnaEditarProducto.Resizable = DataGridViewTriState.False;
            ColumnaEditarProducto.Width = 182;
            // 
            // ColumnaEliminarProducto
            // 
            ColumnaEliminarProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnaEliminarProducto.HeaderText = "";
            ColumnaEliminarProducto.Image = (Image)resources.GetObject("ColumnaEliminarProducto.Image");
            ColumnaEliminarProducto.MinimumWidth = 6;
            ColumnaEliminarProducto.Name = "ColumnaEliminarProducto";
            ColumnaEliminarProducto.ReadOnly = true;
            ColumnaEliminarProducto.Resizable = DataGridViewTriState.False;
            ColumnaEliminarProducto.Width = 182;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(labelManufactureDateNotChosen);
            tabPage1.Controls.Add(labelBatchProductNameNotChosen);
            tabPage1.Controls.Add(GBFechaHoraElab);
            tabPage1.Controls.Add(buttonAddBatch);
            tabPage1.Controls.Add(cbBatchProductName);
            tabPage1.Controls.Add(siticoneHtmlLabel3);
            tabPage1.Controls.Add(tbQuantity);
            tabPage1.Controls.Add(siticoneHtmlLabel4);
            tabPage1.Location = new Point(164, 4);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1281, 1012);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Registrar Lote";
            // 
            // labelManufactureDateNotChosen
            // 
            labelManufactureDateNotChosen.Anchor = AnchorStyles.None;
            labelManufactureDateNotChosen.BackColor = Color.Transparent;
            labelManufactureDateNotChosen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelManufactureDateNotChosen.ForeColor = Color.Red;
            labelManufactureDateNotChosen.Location = new Point(801, 505);
            labelManufactureDateNotChosen.Margin = new Padding(3, 4, 3, 4);
            labelManufactureDateNotChosen.Name = "labelManufactureDateNotChosen";
            labelManufactureDateNotChosen.Size = new Size(240, 22);
            labelManufactureDateNotChosen.TabIndex = 65;
            labelManufactureDateNotChosen.Text = "Debe tener una fecha y hora válidas";
            labelManufactureDateNotChosen.Visible = false;
            // 
            // labelBatchProductNameNotChosen
            // 
            labelBatchProductNameNotChosen.Anchor = AnchorStyles.None;
            labelBatchProductNameNotChosen.BackColor = Color.Transparent;
            labelBatchProductNameNotChosen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelBatchProductNameNotChosen.ForeColor = Color.Red;
            labelBatchProductNameNotChosen.Location = new Point(801, 239);
            labelBatchProductNameNotChosen.Margin = new Padding(3, 4, 3, 4);
            labelBatchProductNameNotChosen.Name = "labelBatchProductNameNotChosen";
            labelBatchProductNameNotChosen.Size = new Size(274, 22);
            labelBatchProductNameNotChosen.TabIndex = 64;
            labelBatchProductNameNotChosen.Text = "Debe pertenecer a un producto existente";
            labelBatchProductNameNotChosen.Visible = false;
            // 
            // GBFechaHoraElab
            // 
            GBFechaHoraElab.Anchor = AnchorStyles.None;
            GBFechaHoraElab.BackColor = Color.Transparent;
            GBFechaHoraElab.BorderColor = Color.Black;
            GBFechaHoraElab.BorderRadius = 20;
            GBFechaHoraElab.Controls.Add(dtpManufactureHour);
            GBFechaHoraElab.Controls.Add(rbCurrentDate);
            GBFechaHoraElab.Controls.Add(rbChooseDate);
            GBFechaHoraElab.Controls.Add(dtpManufactureDate);
            GBFechaHoraElab.CustomBorderColor = Color.Black;
            GBFechaHoraElab.FillColor = Color.Transparent;
            GBFechaHoraElab.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GBFechaHoraElab.ForeColor = Color.White;
            GBFechaHoraElab.Location = new Point(268, 404);
            GBFechaHoraElab.Margin = new Padding(3, 4, 3, 4);
            GBFechaHoraElab.Name = "GBFechaHoraElab";
            GBFechaHoraElab.Size = new Size(505, 209);
            GBFechaHoraElab.TabIndex = 63;
            GBFechaHoraElab.Text = "Fecha y Hora";
            GBFechaHoraElab.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // dtpManufactureHour
            // 
            dtpManufactureHour.Anchor = AnchorStyles.None;
            dtpManufactureHour.BorderRadius = 10;
            dtpManufactureHour.Checked = true;
            dtpManufactureHour.CustomFormat = "HH:mm:ss";
            dtpManufactureHour.FillColor = Color.Black;
            dtpManufactureHour.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpManufactureHour.Format = DateTimePickerFormat.Time;
            dtpManufactureHour.Location = new Point(360, 112);
            dtpManufactureHour.Margin = new Padding(3, 4, 3, 4);
            dtpManufactureHour.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpManufactureHour.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpManufactureHour.Name = "dtpManufactureHour";
            dtpManufactureHour.ShowUpDown = true;
            dtpManufactureHour.Size = new Size(123, 37);
            dtpManufactureHour.TabIndex = 59;
            dtpManufactureHour.TextOffset = new Point(5, 0);
            dtpManufactureHour.Value = new DateTime(2023, 2, 6, 1, 19, 20, 716);
            dtpManufactureHour.Visible = false;
            // 
            // rbCurrentDate
            // 
            rbCurrentDate.Anchor = AnchorStyles.None;
            rbCurrentDate.AutoSize = true;
            rbCurrentDate.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rbCurrentDate.CheckedState.BorderThickness = 0;
            rbCurrentDate.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rbCurrentDate.CheckedState.InnerColor = Color.White;
            rbCurrentDate.CheckedState.InnerOffset = -4;
            rbCurrentDate.ForeColor = Color.Black;
            rbCurrentDate.Location = new Point(21, 67);
            rbCurrentDate.Margin = new Padding(3, 4, 3, 4);
            rbCurrentDate.Name = "rbCurrentDate";
            rbCurrentDate.Size = new Size(112, 34);
            rbCurrentDate.TabIndex = 56;
            rbCurrentDate.Text = "Actual";
            rbCurrentDate.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rbCurrentDate.UncheckedState.BorderThickness = 2;
            rbCurrentDate.UncheckedState.FillColor = Color.Transparent;
            rbCurrentDate.UncheckedState.InnerColor = Color.Transparent;
            rbCurrentDate.CheckedChanged += RbCurrentDate_CheckedChanged;
            // 
            // rbChooseDate
            // 
            rbChooseDate.Anchor = AnchorStyles.None;
            rbChooseDate.AutoSize = true;
            rbChooseDate.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rbChooseDate.CheckedState.BorderThickness = 0;
            rbChooseDate.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rbChooseDate.CheckedState.InnerColor = Color.White;
            rbChooseDate.CheckedState.InnerOffset = -4;
            rbChooseDate.ForeColor = Color.Black;
            rbChooseDate.Location = new Point(164, 67);
            rbChooseDate.Margin = new Padding(3, 4, 3, 4);
            rbChooseDate.Name = "rbChooseDate";
            rbChooseDate.Size = new Size(98, 34);
            rbChooseDate.TabIndex = 57;
            rbChooseDate.Text = "Elegir";
            rbChooseDate.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rbChooseDate.UncheckedState.BorderThickness = 2;
            rbChooseDate.UncheckedState.FillColor = Color.Transparent;
            rbChooseDate.UncheckedState.InnerColor = Color.Transparent;
            rbChooseDate.CheckedChanged += RbChooseDate_CheckedChanged;
            // 
            // dtpManufactureDate
            // 
            dtpManufactureDate.Anchor = AnchorStyles.None;
            dtpManufactureDate.BorderRadius = 10;
            dtpManufactureDate.Checked = true;
            dtpManufactureDate.CustomFormat = "yyyy-MM-dd";
            dtpManufactureDate.FillColor = Color.Black;
            dtpManufactureDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpManufactureDate.Format = DateTimePickerFormat.Custom;
            dtpManufactureDate.Location = new Point(164, 112);
            dtpManufactureDate.Margin = new Padding(3, 4, 3, 4);
            dtpManufactureDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpManufactureDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpManufactureDate.Name = "dtpManufactureDate";
            dtpManufactureDate.Size = new Size(180, 37);
            dtpManufactureDate.TabIndex = 58;
            dtpManufactureDate.TextOffset = new Point(5, 0);
            dtpManufactureDate.Value = new DateTime(2023, 3, 10, 0, 0, 0, 0);
            dtpManufactureDate.Visible = false;
            // 
            // buttonAddBatch
            // 
            buttonAddBatch.Anchor = AnchorStyles.None;
            buttonAddBatch.BorderRadius = 20;
            buttonAddBatch.DisabledState.BorderColor = Color.DarkGray;
            buttonAddBatch.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonAddBatch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonAddBatch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonAddBatch.FillColor = Color.Black;
            buttonAddBatch.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddBatch.ForeColor = Color.White;
            buttonAddBatch.Location = new Point(545, 670);
            buttonAddBatch.Margin = new Padding(3, 4, 3, 4);
            buttonAddBatch.Name = "buttonAddBatch";
            buttonAddBatch.Size = new Size(206, 60);
            buttonAddBatch.TabIndex = 54;
            buttonAddBatch.Text = "Añadir";
            buttonAddBatch.Click += ButtonAddBatch_Click;
            // 
            // cbBatchProductName
            // 
            cbBatchProductName.Anchor = AnchorStyles.None;
            cbBatchProductName.BackColor = Color.Transparent;
            cbBatchProductName.BorderRadius = 20;
            cbBatchProductName.DrawMode = DrawMode.OwnerDrawFixed;
            cbBatchProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBatchProductName.FocusedColor = Color.FromArgb(94, 148, 255);
            cbBatchProductName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbBatchProductName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbBatchProductName.ForeColor = Color.FromArgb(68, 88, 112);
            cbBatchProductName.ItemHeight = 35;
            cbBatchProductName.Items.AddRange(new object[] { "Seleccione..." });
            cbBatchProductName.Location = new Point(544, 232);
            cbBatchProductName.Margin = new Padding(3, 4, 3, 4);
            cbBatchProductName.Name = "cbBatchProductName";
            cbBatchProductName.Size = new Size(228, 41);
            cbBatchProductName.StartIndex = 0;
            cbBatchProductName.TabIndex = 53;
            cbBatchProductName.TextOffset = new Point(5, 0);
            cbBatchProductName.SelectedIndexChanged += CbBatchProductName_SelectedIndexChanged;
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.Anchor = AnchorStyles.None;
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(268, 239);
            siticoneHtmlLabel3.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(119, 34);
            siticoneHtmlLabel3.TabIndex = 52;
            siticoneHtmlLabel3.Text = "Producto";
            // 
            // tbQuantity
            // 
            tbQuantity.Anchor = AnchorStyles.None;
            tbQuantity.BorderRadius = 20;
            tbQuantity.DefaultText = "";
            tbQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbQuantity.Location = new Point(544, 315);
            tbQuantity.Margin = new Padding(3, 7, 3, 7);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.PasswordChar = '\0';
            tbQuantity.PlaceholderText = "";
            tbQuantity.SelectedText = "";
            tbQuantity.Size = new Size(229, 55);
            tbQuantity.TabIndex = 51;
            tbQuantity.TextOffset = new Point(5, 0);
            tbQuantity.TextChanged += TbQuantity_TextChanged;
            tbQuantity.KeyPress += TbQuantity_KeyPress;
            // 
            // siticoneHtmlLabel4
            // 
            siticoneHtmlLabel4.Anchor = AnchorStyles.None;
            siticoneHtmlLabel4.BackColor = Color.Transparent;
            siticoneHtmlLabel4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel4.Location = new Point(269, 315);
            siticoneHtmlLabel4.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            siticoneHtmlLabel4.Size = new Size(126, 34);
            siticoneHtmlLabel4.TabIndex = 50;
            siticoneHtmlLabel4.Text = "Cantidad";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(labelProductCodeNotChosenInTheSearchBatchTab);
            tabPage2.Controls.Add(cbSearchBatchByProductCode);
            tabPage2.Controls.Add(siticoneHtmlLabel_buscarLote_sin_campo);
            tabPage2.Controls.Add(dtpSearchBatchByDate);
            tabPage2.Controls.Add(siticoneGradientPanel1);
            tabPage2.Controls.Add(cbSearchBatchBy);
            tabPage2.Controls.Add(tbSearchBatchByBatchCode);
            tabPage2.Location = new Point(164, 4);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1281, 1012);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Editar/Eliminar Lote";
            // 
            // labelProductCodeNotChosenInTheSearchBatchTab
            // 
            labelProductCodeNotChosenInTheSearchBatchTab.Anchor = AnchorStyles.None;
            labelProductCodeNotChosenInTheSearchBatchTab.BackColor = Color.Transparent;
            labelProductCodeNotChosenInTheSearchBatchTab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductCodeNotChosenInTheSearchBatchTab.ForeColor = Color.Red;
            labelProductCodeNotChosenInTheSearchBatchTab.Location = new Point(327, 213);
            labelProductCodeNotChosenInTheSearchBatchTab.Margin = new Padding(3, 4, 3, 4);
            labelProductCodeNotChosenInTheSearchBatchTab.Name = "labelProductCodeNotChosenInTheSearchBatchTab";
            labelProductCodeNotChosenInTheSearchBatchTab.Size = new Size(274, 22);
            labelProductCodeNotChosenInTheSearchBatchTab.TabIndex = 65;
            labelProductCodeNotChosenInTheSearchBatchTab.Text = "Debe pertenecer a un producto existente";
            labelProductCodeNotChosenInTheSearchBatchTab.Visible = false;
            // 
            // cbSearchBatchByProductCode
            // 
            cbSearchBatchByProductCode.Anchor = AnchorStyles.None;
            cbSearchBatchByProductCode.BackColor = Color.Transparent;
            cbSearchBatchByProductCode.BorderRadius = 10;
            cbSearchBatchByProductCode.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearchBatchByProductCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchBatchByProductCode.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSearchBatchByProductCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSearchBatchByProductCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchBatchByProductCode.ForeColor = Color.FromArgb(68, 88, 112);
            cbSearchBatchByProductCode.ItemHeight = 55;
            cbSearchBatchByProductCode.Location = new Point(313, 143);
            cbSearchBatchByProductCode.Margin = new Padding(3, 4, 3, 4);
            cbSearchBatchByProductCode.Name = "cbSearchBatchByProductCode";
            cbSearchBatchByProductCode.Size = new Size(312, 61);
            cbSearchBatchByProductCode.TabIndex = 61;
            cbSearchBatchByProductCode.TextOffset = new Point(5, 0);
            cbSearchBatchByProductCode.Visible = false;
            cbSearchBatchByProductCode.SelectedIndexChanged += CbSearchBatchByProductCode_SelectedIndexChanged;
            // 
            // siticoneHtmlLabel_buscarLote_sin_campo
            // 
            siticoneHtmlLabel_buscarLote_sin_campo.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_buscarLote_sin_campo.BackColor = Color.Transparent;
            siticoneHtmlLabel_buscarLote_sin_campo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_buscarLote_sin_campo.ForeColor = Color.Red;
            siticoneHtmlLabel_buscarLote_sin_campo.Location = new Point(313, 112);
            siticoneHtmlLabel_buscarLote_sin_campo.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_buscarLote_sin_campo.Name = "siticoneHtmlLabel_buscarLote_sin_campo";
            siticoneHtmlLabel_buscarLote_sin_campo.Size = new Size(257, 22);
            siticoneHtmlLabel_buscarLote_sin_campo.TabIndex = 60;
            siticoneHtmlLabel_buscarLote_sin_campo.Text = "¡Seleccione un parámetro para buscar!";
            // 
            // dtpSearchBatchByDate
            // 
            dtpSearchBatchByDate.Anchor = AnchorStyles.None;
            dtpSearchBatchByDate.BorderColor = Color.White;
            dtpSearchBatchByDate.BorderRadius = 10;
            dtpSearchBatchByDate.Checked = true;
            dtpSearchBatchByDate.CustomFormat = "yyyy-MM-dd";
            dtpSearchBatchByDate.FillColor = Color.Black;
            dtpSearchBatchByDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSearchBatchByDate.ForeColor = Color.White;
            dtpSearchBatchByDate.Format = DateTimePickerFormat.Custom;
            dtpSearchBatchByDate.Location = new Point(313, 143);
            dtpSearchBatchByDate.Margin = new Padding(3, 4, 3, 4);
            dtpSearchBatchByDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpSearchBatchByDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpSearchBatchByDate.Name = "dtpSearchBatchByDate";
            dtpSearchBatchByDate.Size = new Size(312, 61);
            dtpSearchBatchByDate.TabIndex = 59;
            dtpSearchBatchByDate.TextOffset = new Point(5, 0);
            dtpSearchBatchByDate.Value = new DateTime(2023, 2, 6, 1, 19, 20, 716);
            dtpSearchBatchByDate.Visible = false;
            dtpSearchBatchByDate.ValueChanged += DtpSearchBatchByDate_ValueChanged;
            // 
            // siticoneGradientPanel1
            // 
            siticoneGradientPanel1.Controls.Add(BatchDataGridView);
            siticoneGradientPanel1.Dock = DockStyle.Bottom;
            siticoneGradientPanel1.Location = new Point(0, 345);
            siticoneGradientPanel1.Margin = new Padding(3, 4, 3, 4);
            siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            siticoneGradientPanel1.Size = new Size(1281, 667);
            siticoneGradientPanel1.TabIndex = 28;
            // 
            // BatchDataGridView
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            BatchDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            BatchDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            BatchDataGridView.ColumnHeadersHeight = 75;
            BatchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BatchDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnaCodLote, ColumnaCodProd, ColunmaCantidad, ColumnaFechayHora, ColumnaEditarLote, ColumnaEliminarLote });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            BatchDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            BatchDataGridView.Dock = DockStyle.Fill;
            BatchDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            BatchDataGridView.Location = new Point(0, 0);
            BatchDataGridView.Margin = new Padding(3, 5, 3, 5);
            BatchDataGridView.Name = "BatchDataGridView";
            BatchDataGridView.RowHeadersVisible = false;
            BatchDataGridView.RowHeadersWidth = 50;
            BatchDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            BatchDataGridView.RowTemplate.Height = 50;
            BatchDataGridView.Size = new Size(1281, 667);
            BatchDataGridView.TabIndex = 27;
            BatchDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BatchDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            BatchDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BatchDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BatchDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BatchDataGridView.ThemeStyle.BackColor = Color.White;
            BatchDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            BatchDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.DimGray;
            BatchDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BatchDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BatchDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BatchDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BatchDataGridView.ThemeStyle.HeaderStyle.Height = 75;
            BatchDataGridView.ThemeStyle.ReadOnly = false;
            BatchDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            BatchDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BatchDataGridView.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BatchDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BatchDataGridView.ThemeStyle.RowsStyle.Height = 50;
            BatchDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            BatchDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            BatchDataGridView.CellClick += BatchDataGridView_CellClick;
            // 
            // ColumnaCodLote
            // 
            ColumnaCodLote.HeaderText = "Código lote";
            ColumnaCodLote.MinimumWidth = 6;
            ColumnaCodLote.Name = "ColumnaCodLote";
            ColumnaCodLote.ReadOnly = true;
            ColumnaCodLote.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaCodProd
            // 
            ColumnaCodProd.HeaderText = "Código producto";
            ColumnaCodProd.MinimumWidth = 6;
            ColumnaCodProd.Name = "ColumnaCodProd";
            ColumnaCodProd.ReadOnly = true;
            ColumnaCodProd.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColunmaCantidad
            // 
            ColunmaCantidad.HeaderText = "Cantidad";
            ColunmaCantidad.MinimumWidth = 6;
            ColunmaCantidad.Name = "ColunmaCantidad";
            ColunmaCantidad.ReadOnly = true;
            ColunmaCantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaFechayHora
            // 
            ColumnaFechayHora.HeaderText = "Fecha y Hora";
            ColumnaFechayHora.MinimumWidth = 6;
            ColumnaFechayHora.Name = "ColumnaFechayHora";
            ColumnaFechayHora.ReadOnly = true;
            ColumnaFechayHora.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaEditarLote
            // 
            ColumnaEditarLote.HeaderText = "";
            ColumnaEditarLote.Image = (Image)resources.GetObject("ColumnaEditarLote.Image");
            ColumnaEditarLote.MinimumWidth = 6;
            ColumnaEditarLote.Name = "ColumnaEditarLote";
            ColumnaEditarLote.ReadOnly = true;
            ColumnaEditarLote.Resizable = DataGridViewTriState.True;
            // 
            // ColumnaEliminarLote
            // 
            ColumnaEliminarLote.HeaderText = "";
            ColumnaEliminarLote.Image = (Image)resources.GetObject("ColumnaEliminarLote.Image");
            ColumnaEliminarLote.MinimumWidth = 6;
            ColumnaEliminarLote.Name = "ColumnaEliminarLote";
            ColumnaEliminarLote.ReadOnly = true;
            ColumnaEliminarLote.Resizable = DataGridViewTriState.True;
            // 
            // cbSearchBatchBy
            // 
            cbSearchBatchBy.Anchor = AnchorStyles.None;
            cbSearchBatchBy.BackColor = Color.Transparent;
            cbSearchBatchBy.BorderRadius = 20;
            cbSearchBatchBy.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearchBatchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchBatchBy.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSearchBatchBy.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSearchBatchBy.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchBatchBy.ForeColor = Color.FromArgb(68, 88, 112);
            cbSearchBatchBy.ItemHeight = 40;
            cbSearchBatchBy.Items.AddRange(new object[] { "Seleccione...", "Código lote", "Código producto", "Fecha" });
            cbSearchBatchBy.Location = new Point(642, 143);
            cbSearchBatchBy.Margin = new Padding(3, 4, 3, 4);
            cbSearchBatchBy.Name = "cbSearchBatchBy";
            cbSearchBatchBy.Size = new Size(311, 46);
            cbSearchBatchBy.StartIndex = 0;
            cbSearchBatchBy.TabIndex = 24;
            cbSearchBatchBy.SelectedIndexChanged += CbSearchBatchBy_SelectedIndexChanged;
            // 
            // tbSearchBatchByBatchCode
            // 
            tbSearchBatchByBatchCode.Anchor = AnchorStyles.None;
            tbSearchBatchByBatchCode.BorderRadius = 20;
            tbSearchBatchByBatchCode.DefaultText = "";
            tbSearchBatchByBatchCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSearchBatchByBatchCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSearchBatchByBatchCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSearchBatchByBatchCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSearchBatchByBatchCode.Enabled = false;
            tbSearchBatchByBatchCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchBatchByBatchCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearchBatchByBatchCode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchBatchByBatchCode.Location = new Point(313, 143);
            tbSearchBatchByBatchCode.Margin = new Padding(3, 5, 3, 5);
            tbSearchBatchByBatchCode.Name = "tbSearchBatchByBatchCode";
            tbSearchBatchByBatchCode.PasswordChar = '\0';
            tbSearchBatchByBatchCode.PlaceholderText = "Buscar...";
            tbSearchBatchByBatchCode.SelectedText = "";
            tbSearchBatchByBatchCode.Size = new Size(312, 61);
            tbSearchBatchByBatchCode.TabIndex = 23;
            tbSearchBatchByBatchCode.TextChanged += TbSearchBatchByBatchCode_TextChanged;
            // 
            // UC_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticoneTabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Products";
            Size = new Size(1449, 1020);
            siticoneTabControl1.ResumeLayout(false);
            Añadir.ResumeLayout(false);
            Añadir.PerformLayout();
            Editar.ResumeLayout(false);
            Editar.PerformLayout();
            siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            GBFechaHoraElab.ResumeLayout(false);
            GBFechaHoraElab.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            siticoneGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BatchDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage Añadir;
        private TabPage Editar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView ProductDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSearchProdutBy;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbSearchProductBy;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView BatchDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSearchBatchBy;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbSearchBatchByBatchCode;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonAddProduct;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbSalesPriceToThePublic;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel8;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbProductionPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbProductName;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonAddBatch;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbBatchProductName;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbQuantity;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpManufactureDate;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton rbChooseDate;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton rbCurrentDate;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox GBFechaHoraElab;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbImagePath;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel11;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBExaminar;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbProductCode;
        private DataGridViewTextBoxColumn ColumnaCodLote;
        private DataGridViewTextBoxColumn ColumnaCodProd;
        private DataGridViewTextBoxColumn ColunmaCantidad;
        private DataGridViewTextBoxColumn ColumnaFechayHora;
        private DataGridViewImageColumn ColumnaEditarLote;
        private DataGridViewImageColumn ColumnaEliminarLote;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelProductCodeNotUnique;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelProductNameNotUnique;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCategoryNotChosen;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidProductionPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LabelSPPNotGreaterThanPP;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidSalesPriceToThePublic;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidImagePath;
        private DataGridViewTextBoxColumn CodProd;
        private DataGridViewTextBoxColumn NombreProd;
        private DataGridViewTextBoxColumn PrecioElab;
        private DataGridViewTextBoxColumn PrecioVentaPub;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewImageColumn ColumnaEditarProducto;
        private DataGridViewImageColumn ColumnaEliminarProducto;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelSearchProductWithoutField;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpSearchBatchByDate;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelBatchProductNameNotChosen;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelManufactureDateNotChosen;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpManufactureHour;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_buscarLote_sin_campo;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSearchBatchByProductCode;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelProductCodeNotChosenInTheSearchBatchTab;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCategoryNotChosenInTheSearchProductTab;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSearchProductByCategory;
    }
}
