using System.Windows.Forms;

namespace SGV_CLP.GUI
{
    partial class UC_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Productos));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            Añadir = new TabPage();
            rutaImagen_not_valid_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            PE_not_valid_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            PVP_not_greater_than_PE_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            PVP_not_valid_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            categoria_not_choose_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            nombreProducto_not_unique_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            IDProd_not_unique_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtIDProd = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            txtImagen = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel11 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            SBAniadirProd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            cBoxCategoria = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtPVP = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel8 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtPE = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtNombreProducto = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            Editar = new TabPage();
            siticoneHtmlLabel_buscarProducto_sin_campo = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ComboBox_ConsultarProductoPor = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            txtConsultarProducto = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            SDGVProducto = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            CodProd = new DataGridViewTextBoxColumn();
            NombreProd = new DataGridViewTextBoxColumn();
            PrecioElab = new DataGridViewTextBoxColumn();
            PrecioVentaPub = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ColumnaEditarProducto = new DataGridViewImageColumn();
            ColumnaEliminarProducto = new DataGridViewImageColumn();
            tabPage1 = new TabPage();
            siticoneGroupBox1 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            SRBFechaActual = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            SRBElegirFecha = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            siticoneDateTimePicker1 = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            SBAniadirLote = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SCBProductoLote = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtCantidad = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tabPage2 = new TabPage();
            siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            SDGVLote = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            ColumnaCodLote = new DataGridViewTextBoxColumn();
            ColumnaCodProd = new DataGridViewTextBoxColumn();
            ColunmaCantidad = new DataGridViewTextBoxColumn();
            ColumnaFechayHora = new DataGridViewTextBoxColumn();
            ColumnaEditarLote = new DataGridViewImageColumn();
            ColumnaEliminarLote = new DataGridViewImageColumn();
            siticoneComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneTabControl1.SuspendLayout();
            Añadir.SuspendLayout();
            Editar.SuspendLayout();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SDGVProducto).BeginInit();
            tabPage1.SuspendLayout();
            siticoneGroupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SDGVLote).BeginInit();
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
            Añadir.Controls.Add(rutaImagen_not_valid_label);
            Añadir.Controls.Add(PE_not_valid_label);
            Añadir.Controls.Add(PVP_not_greater_than_PE_label);
            Añadir.Controls.Add(PVP_not_valid_label);
            Añadir.Controls.Add(categoria_not_choose_label);
            Añadir.Controls.Add(nombreProducto_not_unique_label);
            Añadir.Controls.Add(IDProd_not_unique_label);
            Añadir.Controls.Add(siticoneHtmlLabel1);
            Añadir.Controls.Add(txtIDProd);
            Añadir.Controls.Add(siticoneButton3);
            Añadir.Controls.Add(txtImagen);
            Añadir.Controls.Add(siticoneHtmlLabel11);
            Añadir.Controls.Add(SBAniadirProd);
            Añadir.Controls.Add(cBoxCategoria);
            Añadir.Controls.Add(siticoneHtmlLabel6);
            Añadir.Controls.Add(txtPVP);
            Añadir.Controls.Add(siticoneHtmlLabel8);
            Añadir.Controls.Add(txtPE);
            Añadir.Controls.Add(siticoneHtmlLabel7);
            Añadir.Controls.Add(siticoneHtmlLabel5);
            Añadir.Controls.Add(txtNombreProducto);
            Añadir.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Añadir.Location = new Point(164, 4);
            Añadir.Margin = new Padding(3, 5, 3, 5);
            Añadir.Name = "Añadir";
            Añadir.Padding = new Padding(3, 5, 3, 5);
            Añadir.Size = new Size(1281, 1012);
            Añadir.TabIndex = 0;
            Añadir.Text = "Registrar Producto";
            // 
            // rutaImagen_not_valid_label
            // 
            rutaImagen_not_valid_label.Anchor = AnchorStyles.None;
            rutaImagen_not_valid_label.BackColor = Color.Transparent;
            rutaImagen_not_valid_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rutaImagen_not_valid_label.ForeColor = Color.Red;
            rutaImagen_not_valid_label.Location = new Point(1174, 640);
            rutaImagen_not_valid_label.Margin = new Padding(3, 4, 3, 4);
            rutaImagen_not_valid_label.Name = "rutaImagen_not_valid_label";
            rutaImagen_not_valid_label.Size = new Size(89, 22);
            rutaImagen_not_valid_label.TabIndex = 63;
            rutaImagen_not_valid_label.Text = "Ruta inválida";
            rutaImagen_not_valid_label.Visible = false;
            // 
            // PE_not_valid_label
            // 
            PE_not_valid_label.Anchor = AnchorStyles.None;
            PE_not_valid_label.BackColor = Color.Transparent;
            PE_not_valid_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PE_not_valid_label.ForeColor = Color.Red;
            PE_not_valid_label.Location = new Point(671, 428);
            PE_not_valid_label.Margin = new Padding(3, 4, 3, 4);
            PE_not_valid_label.Name = "PE_not_valid_label";
            PE_not_valid_label.Size = new Size(117, 22);
            PE_not_valid_label.TabIndex = 62;
            PE_not_valid_label.Text = "Máx. 2 decimales";
            PE_not_valid_label.Visible = false;
            // 
            // PVP_not_greater_than_PE_label
            // 
            PVP_not_greater_than_PE_label.Anchor = AnchorStyles.None;
            PVP_not_greater_than_PE_label.BackColor = Color.Transparent;
            PVP_not_greater_than_PE_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PVP_not_greater_than_PE_label.ForeColor = Color.Red;
            PVP_not_greater_than_PE_label.Location = new Point(671, 541);
            PVP_not_greater_than_PE_label.Margin = new Padding(3, 4, 3, 4);
            PVP_not_greater_than_PE_label.Name = "PVP_not_greater_than_PE_label";
            PVP_not_greater_than_PE_label.Size = new Size(118, 22);
            PVP_not_greater_than_PE_label.TabIndex = 61;
            PVP_not_greater_than_PE_label.Text = "Debe ser >= a PE";
            PVP_not_greater_than_PE_label.Visible = false;
            // 
            // PVP_not_valid_label
            // 
            PVP_not_valid_label.Anchor = AnchorStyles.None;
            PVP_not_valid_label.BackColor = Color.Transparent;
            PVP_not_valid_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PVP_not_valid_label.ForeColor = Color.Red;
            PVP_not_valid_label.Location = new Point(671, 511);
            PVP_not_valid_label.Margin = new Padding(3, 4, 3, 4);
            PVP_not_valid_label.Name = "PVP_not_valid_label";
            PVP_not_valid_label.Size = new Size(117, 22);
            PVP_not_valid_label.TabIndex = 59;
            PVP_not_valid_label.Text = "Máx. 2 decimales";
            PVP_not_valid_label.Visible = false;
            // 
            // categoria_not_choose_label
            // 
            categoria_not_choose_label.Anchor = AnchorStyles.None;
            categoria_not_choose_label.BackColor = Color.Transparent;
            categoria_not_choose_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoria_not_choose_label.ForeColor = Color.Red;
            categoria_not_choose_label.Location = new Point(671, 306);
            categoria_not_choose_label.Margin = new Padding(3, 4, 3, 4);
            categoria_not_choose_label.Name = "categoria_not_choose_label";
            categoria_not_choose_label.Size = new Size(265, 22);
            categoria_not_choose_label.TabIndex = 57;
            categoria_not_choose_label.Text = "Debe pertenecer a una categoría válida";
            categoria_not_choose_label.Visible = false;
            // 
            // nombreProducto_not_unique_label
            // 
            nombreProducto_not_unique_label.Anchor = AnchorStyles.None;
            nombreProducto_not_unique_label.BackColor = Color.Transparent;
            nombreProducto_not_unique_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nombreProducto_not_unique_label.ForeColor = Color.Red;
            nombreProducto_not_unique_label.Location = new Point(671, 207);
            nombreProducto_not_unique_label.Margin = new Padding(3, 4, 3, 4);
            nombreProducto_not_unique_label.Name = "nombreProducto_not_unique_label";
            nombreProducto_not_unique_label.Size = new Size(256, 22);
            nombreProducto_not_unique_label.TabIndex = 56;
            nombreProducto_not_unique_label.Text = "Ya existe un producto con ese nombre";
            nombreProducto_not_unique_label.Visible = false;
            // 
            // IDProd_not_unique_label
            // 
            IDProd_not_unique_label.Anchor = AnchorStyles.None;
            IDProd_not_unique_label.BackColor = Color.Transparent;
            IDProd_not_unique_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IDProd_not_unique_label.ForeColor = Color.Red;
            IDProd_not_unique_label.Location = new Point(671, 107);
            IDProd_not_unique_label.Margin = new Padding(3, 4, 3, 4);
            IDProd_not_unique_label.Name = "IDProd_not_unique_label";
            IDProd_not_unique_label.Size = new Size(219, 22);
            IDProd_not_unique_label.TabIndex = 55;
            IDProd_not_unique_label.Text = "Ya existe un producto con ese ID";
            IDProd_not_unique_label.Visible = false;
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
            // txtIDProd
            // 
            txtIDProd.Anchor = AnchorStyles.None;
            txtIDProd.BorderRadius = 20;
            txtIDProd.DefaultText = "";
            txtIDProd.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtIDProd.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtIDProd.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtIDProd.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtIDProd.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtIDProd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDProd.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtIDProd.Location = new Point(421, 95);
            txtIDProd.Margin = new Padding(3, 8, 3, 8);
            txtIDProd.Name = "txtIDProd";
            txtIDProd.PasswordChar = '\0';
            txtIDProd.PlaceholderText = "";
            txtIDProd.SelectedText = "";
            txtIDProd.Size = new Size(229, 55);
            txtIDProd.TabIndex = 51;
            txtIDProd.TextOffset = new Point(5, 0);
            txtIDProd.TextChanged += txtIDProd_TextChanged;
            txtIDProd.KeyPress += txtIDProd_KeyPress;
            // 
            // siticoneButton3
            // 
            siticoneButton3.Anchor = AnchorStyles.None;
            siticoneButton3.BorderRadius = 20;
            siticoneButton3.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton3.FillColor = Color.Black;
            siticoneButton3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton3.ForeColor = Color.White;
            siticoneButton3.Location = new Point(953, 617);
            siticoneButton3.Margin = new Padding(3, 4, 3, 4);
            siticoneButton3.Name = "siticoneButton3";
            siticoneButton3.Size = new Size(206, 60);
            siticoneButton3.TabIndex = 50;
            siticoneButton3.Text = "Examinar...";
            siticoneButton3.Click += siticoneButton3_Click;
            // 
            // txtImagen
            // 
            txtImagen.Anchor = AnchorStyles.None;
            txtImagen.BorderRadius = 20;
            txtImagen.DefaultText = "";
            txtImagen.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtImagen.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtImagen.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtImagen.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtImagen.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtImagen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtImagen.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtImagen.Location = new Point(421, 617);
            txtImagen.Margin = new Padding(3, 7, 3, 7);
            txtImagen.Name = "txtImagen";
            txtImagen.PasswordChar = '\0';
            txtImagen.PlaceholderText = "";
            txtImagen.SelectedText = "";
            txtImagen.Size = new Size(515, 55);
            txtImagen.TabIndex = 49;
            txtImagen.TextOffset = new Point(5, 0);
            txtImagen.TextChanged += txtImagen_TextChanged;
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
            // SBAniadirProd
            // 
            SBAniadirProd.Anchor = AnchorStyles.None;
            SBAniadirProd.BorderRadius = 20;
            SBAniadirProd.DisabledState.BorderColor = Color.DarkGray;
            SBAniadirProd.DisabledState.CustomBorderColor = Color.DarkGray;
            SBAniadirProd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBAniadirProd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBAniadirProd.FillColor = Color.Black;
            SBAniadirProd.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBAniadirProd.ForeColor = Color.White;
            SBAniadirProd.Location = new Point(493, 796);
            SBAniadirProd.Margin = new Padding(3, 5, 3, 5);
            SBAniadirProd.Name = "SBAniadirProd";
            SBAniadirProd.Size = new Size(206, 60);
            SBAniadirProd.TabIndex = 45;
            SBAniadirProd.Text = "Añadir";
            SBAniadirProd.Click += SBAniadirProducto_Click;
            // 
            // cBoxCategoria
            // 
            cBoxCategoria.Anchor = AnchorStyles.None;
            cBoxCategoria.BackColor = Color.Transparent;
            cBoxCategoria.BorderRadius = 20;
            cBoxCategoria.DrawMode = DrawMode.OwnerDrawFixed;
            cBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxCategoria.FocusedColor = Color.FromArgb(94, 148, 255);
            cBoxCategoria.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cBoxCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxCategoria.ForeColor = Color.FromArgb(68, 88, 112);
            cBoxCategoria.ItemHeight = 35;
            cBoxCategoria.Items.AddRange(new object[] { "Especialidades", "Bebidas" });
            cBoxCategoria.Location = new Point(421, 300);
            cBoxCategoria.Margin = new Padding(3, 5, 3, 5);
            cBoxCategoria.Name = "cBoxCategoria";
            cBoxCategoria.Size = new Size(228, 41);
            cBoxCategoria.TabIndex = 44;
            cBoxCategoria.TextOffset = new Point(5, 0);
            cBoxCategoria.SelectedIndexChanged += cBoxCategoria_SelectedIndexChanged;
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
            // txtPVP
            // 
            txtPVP.Anchor = AnchorStyles.None;
            txtPVP.BorderRadius = 20;
            txtPVP.DefaultText = "";
            txtPVP.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPVP.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPVP.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPVP.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPVP.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPVP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPVP.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPVP.Location = new Point(421, 511);
            txtPVP.Margin = new Padding(3, 8, 3, 8);
            txtPVP.Name = "txtPVP";
            txtPVP.PasswordChar = '\0';
            txtPVP.PlaceholderText = "";
            txtPVP.SelectedText = "";
            txtPVP.Size = new Size(229, 55);
            txtPVP.TabIndex = 42;
            txtPVP.TextOffset = new Point(5, 0);
            txtPVP.TextChanged += txtPVP_TextChanged;
            txtPVP.KeyPress += txtPVP_KeyPress;
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
            // txtPE
            // 
            txtPE.Anchor = AnchorStyles.None;
            txtPE.BorderRadius = 20;
            txtPE.DefaultText = "";
            txtPE.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPE.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPE.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPE.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPE.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPE.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPE.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPE.Location = new Point(421, 406);
            txtPE.Margin = new Padding(3, 8, 3, 8);
            txtPE.Name = "txtPE";
            txtPE.PasswordChar = '\0';
            txtPE.PlaceholderText = "";
            txtPE.SelectedText = "";
            txtPE.Size = new Size(229, 55);
            txtPE.TabIndex = 40;
            txtPE.TextOffset = new Point(5, 0);
            txtPE.TextChanged += txtPE_TextChanged;
            txtPE.KeyPress += txtPE_KeyPress;
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
            // txtNombreProducto
            // 
            txtNombreProducto.Anchor = AnchorStyles.None;
            txtNombreProducto.BorderRadius = 20;
            txtNombreProducto.DefaultText = "";
            txtNombreProducto.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombreProducto.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombreProducto.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombreProducto.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombreProducto.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombreProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreProducto.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombreProducto.Location = new Point(421, 195);
            txtNombreProducto.Margin = new Padding(3, 8, 3, 8);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.PasswordChar = '\0';
            txtNombreProducto.PlaceholderText = "";
            txtNombreProducto.SelectedText = "";
            txtNombreProducto.Size = new Size(229, 55);
            txtNombreProducto.TabIndex = 27;
            txtNombreProducto.TextOffset = new Point(5, 0);
            txtNombreProducto.TextChanged += txtNombreProducto_TextChanged;
            txtNombreProducto.KeyPress += txtNombreProducto_KeyPress;
            // 
            // Editar
            // 
            Editar.BackColor = Color.White;
            Editar.Controls.Add(siticoneHtmlLabel_buscarProducto_sin_campo);
            Editar.Controls.Add(ComboBox_ConsultarProductoPor);
            Editar.Controls.Add(txtConsultarProducto);
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
            // siticoneHtmlLabel_buscarProducto_sin_campo
            // 
            siticoneHtmlLabel_buscarProducto_sin_campo.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_buscarProducto_sin_campo.BackColor = Color.Transparent;
            siticoneHtmlLabel_buscarProducto_sin_campo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_buscarProducto_sin_campo.ForeColor = Color.Red;
            siticoneHtmlLabel_buscarProducto_sin_campo.Location = new Point(302, 108);
            siticoneHtmlLabel_buscarProducto_sin_campo.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_buscarProducto_sin_campo.Name = "siticoneHtmlLabel_buscarProducto_sin_campo";
            siticoneHtmlLabel_buscarProducto_sin_campo.Size = new Size(152, 22);
            siticoneHtmlLabel_buscarProducto_sin_campo.TabIndex = 25;
            siticoneHtmlLabel_buscarProducto_sin_campo.Text = "¡Seleccione un campo!";
            // 
            // ComboBox_ConsultarProductoPor
            // 
            ComboBox_ConsultarProductoPor.Anchor = AnchorStyles.None;
            ComboBox_ConsultarProductoPor.AutoCompleteCustomSource.AddRange(new string[] { "Código", "Nombre", "Categoría" });
            ComboBox_ConsultarProductoPor.BackColor = Color.Transparent;
            ComboBox_ConsultarProductoPor.BorderRadius = 20;
            ComboBox_ConsultarProductoPor.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBox_ConsultarProductoPor.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_ConsultarProductoPor.FocusedColor = Color.FromArgb(94, 148, 255);
            ComboBox_ConsultarProductoPor.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ComboBox_ConsultarProductoPor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_ConsultarProductoPor.ForeColor = Color.FromArgb(68, 88, 112);
            ComboBox_ConsultarProductoPor.ItemHeight = 40;
            ComboBox_ConsultarProductoPor.Items.AddRange(new object[] { "Código", "Nombre", "Categoría" });
            ComboBox_ConsultarProductoPor.Location = new Point(631, 139);
            ComboBox_ConsultarProductoPor.Margin = new Padding(3, 4, 3, 4);
            ComboBox_ConsultarProductoPor.Name = "ComboBox_ConsultarProductoPor";
            ComboBox_ConsultarProductoPor.Size = new Size(311, 46);
            ComboBox_ConsultarProductoPor.TabIndex = 20;
            ComboBox_ConsultarProductoPor.SelectedIndexChanged += ComboBox_ConsultarProductoPor_SelectedIndexChanged;
            // 
            // txtConsultarProducto
            // 
            txtConsultarProducto.Anchor = AnchorStyles.None;
            txtConsultarProducto.BorderRadius = 20;
            txtConsultarProducto.DefaultText = "";
            txtConsultarProducto.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConsultarProducto.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConsultarProducto.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConsultarProducto.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConsultarProducto.Enabled = false;
            txtConsultarProducto.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConsultarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtConsultarProducto.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConsultarProducto.Location = new Point(302, 139);
            txtConsultarProducto.Margin = new Padding(3, 5, 3, 5);
            txtConsultarProducto.Name = "txtConsultarProducto";
            txtConsultarProducto.PasswordChar = '\0';
            txtConsultarProducto.PlaceholderText = "Buscar...";
            txtConsultarProducto.SelectedText = "";
            txtConsultarProducto.Size = new Size(312, 61);
            txtConsultarProducto.TabIndex = 19;
            txtConsultarProducto.TextChanged += txtConsultarProducto_TextChanged;
            // 
            // siticonePanel1
            // 
            siticonePanel1.Controls.Add(SDGVProducto);
            siticonePanel1.Dock = DockStyle.Bottom;
            siticonePanel1.Location = new Point(3, 340);
            siticonePanel1.Margin = new Padding(3, 5, 3, 5);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(1275, 667);
            siticonePanel1.TabIndex = 1;
            // 
            // SDGVProducto
            // 
            SDGVProducto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            SDGVProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SDGVProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SDGVProducto.ColumnHeadersHeight = 75;
            SDGVProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SDGVProducto.Columns.AddRange(new DataGridViewColumn[] { CodProd, NombreProd, PrecioElab, PrecioVentaPub, Categoria, Cantidad, ColumnaEditarProducto, ColumnaEliminarProducto });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SDGVProducto.DefaultCellStyle = dataGridViewCellStyle3;
            SDGVProducto.Dock = DockStyle.Fill;
            SDGVProducto.GridColor = Color.FromArgb(231, 229, 255);
            SDGVProducto.Location = new Point(0, 0);
            SDGVProducto.Margin = new Padding(3, 4, 3, 4);
            SDGVProducto.Name = "SDGVProducto";
            SDGVProducto.RowHeadersVisible = false;
            SDGVProducto.RowHeadersWidth = 50;
            SDGVProducto.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            SDGVProducto.RowTemplate.Height = 50;
            SDGVProducto.Size = new Size(1275, 667);
            SDGVProducto.TabIndex = 0;
            SDGVProducto.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SDGVProducto.ThemeStyle.AlternatingRowsStyle.Font = null;
            SDGVProducto.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SDGVProducto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SDGVProducto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SDGVProducto.ThemeStyle.BackColor = Color.White;
            SDGVProducto.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            SDGVProducto.ThemeStyle.HeaderStyle.BackColor = Color.DimGray;
            SDGVProducto.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SDGVProducto.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SDGVProducto.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SDGVProducto.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SDGVProducto.ThemeStyle.HeaderStyle.Height = 75;
            SDGVProducto.ThemeStyle.ReadOnly = false;
            SDGVProducto.ThemeStyle.RowsStyle.BackColor = Color.White;
            SDGVProducto.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SDGVProducto.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SDGVProducto.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            SDGVProducto.ThemeStyle.RowsStyle.Height = 50;
            SDGVProducto.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            SDGVProducto.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            SDGVProducto.CellClick += SDGVProducto_CellClick;
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
            tabPage1.Controls.Add(siticoneGroupBox1);
            tabPage1.Controls.Add(SBAniadirLote);
            tabPage1.Controls.Add(SCBProductoLote);
            tabPage1.Controls.Add(siticoneHtmlLabel3);
            tabPage1.Controls.Add(txtCantidad);
            tabPage1.Controls.Add(siticoneHtmlLabel4);
            tabPage1.Location = new Point(164, 4);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1281, 1012);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Añadir Lote";
            // 
            // siticoneGroupBox1
            // 
            siticoneGroupBox1.Anchor = AnchorStyles.None;
            siticoneGroupBox1.BorderRadius = 20;
            siticoneGroupBox1.Controls.Add(SRBFechaActual);
            siticoneGroupBox1.Controls.Add(SRBElegirFecha);
            siticoneGroupBox1.Controls.Add(siticoneDateTimePicker1);
            siticoneGroupBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneGroupBox1.ForeColor = Color.Black;
            siticoneGroupBox1.Location = new Point(433, 349);
            siticoneGroupBox1.Margin = new Padding(3, 4, 3, 4);
            siticoneGroupBox1.Name = "siticoneGroupBox1";
            siticoneGroupBox1.Size = new Size(473, 204);
            siticoneGroupBox1.TabIndex = 63;
            siticoneGroupBox1.Text = "Fecha y Hora";
            // 
            // SRBFechaActual
            // 
            SRBFechaActual.AutoSize = true;
            SRBFechaActual.Checked = true;
            SRBFechaActual.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            SRBFechaActual.CheckedState.BorderThickness = 0;
            SRBFechaActual.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            SRBFechaActual.CheckedState.InnerColor = Color.White;
            SRBFechaActual.CheckedState.InnerOffset = -4;
            SRBFechaActual.Location = new Point(15, 68);
            SRBFechaActual.Margin = new Padding(3, 4, 3, 4);
            SRBFechaActual.Name = "SRBFechaActual";
            SRBFechaActual.Size = new Size(112, 34);
            SRBFechaActual.TabIndex = 56;
            SRBFechaActual.TabStop = true;
            SRBFechaActual.Text = "Actual";
            SRBFechaActual.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            SRBFechaActual.UncheckedState.BorderThickness = 2;
            SRBFechaActual.UncheckedState.FillColor = Color.Transparent;
            SRBFechaActual.UncheckedState.InnerColor = Color.Transparent;
            SRBFechaActual.CheckedChanged += siticoneRadioButton1_CheckedChanged;
            // 
            // SRBElegirFecha
            // 
            SRBElegirFecha.AutoSize = true;
            SRBElegirFecha.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            SRBElegirFecha.CheckedState.BorderThickness = 0;
            SRBElegirFecha.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            SRBElegirFecha.CheckedState.InnerColor = Color.White;
            SRBElegirFecha.CheckedState.InnerOffset = -4;
            SRBElegirFecha.Location = new Point(245, 68);
            SRBElegirFecha.Margin = new Padding(3, 4, 3, 4);
            SRBElegirFecha.Name = "SRBElegirFecha";
            SRBElegirFecha.Size = new Size(98, 34);
            SRBElegirFecha.TabIndex = 57;
            SRBElegirFecha.Text = "Elegir";
            SRBElegirFecha.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            SRBElegirFecha.UncheckedState.BorderThickness = 2;
            SRBElegirFecha.UncheckedState.FillColor = Color.Transparent;
            SRBElegirFecha.UncheckedState.InnerColor = Color.Transparent;
            SRBElegirFecha.CheckedChanged += siticoneRadioButton2_CheckedChanged;
            // 
            // siticoneDateTimePicker1
            // 
            siticoneDateTimePicker1.BorderRadius = 10;
            siticoneDateTimePicker1.Checked = true;
            siticoneDateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            siticoneDateTimePicker1.FillColor = Color.White;
            siticoneDateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDateTimePicker1.Format = DateTimePickerFormat.Custom;
            siticoneDateTimePicker1.Location = new Point(237, 127);
            siticoneDateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            siticoneDateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            siticoneDateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            siticoneDateTimePicker1.Name = "siticoneDateTimePicker1";
            siticoneDateTimePicker1.ShowUpDown = true;
            siticoneDateTimePicker1.Size = new Size(199, 37);
            siticoneDateTimePicker1.TabIndex = 58;
            siticoneDateTimePicker1.TextOffset = new Point(5, 0);
            siticoneDateTimePicker1.Value = new DateTime(2023, 2, 6, 1, 19, 20, 716);
            siticoneDateTimePicker1.Visible = false;
            // 
            // SBAniadirLote
            // 
            SBAniadirLote.Anchor = AnchorStyles.None;
            SBAniadirLote.BorderRadius = 20;
            SBAniadirLote.DisabledState.BorderColor = Color.DarkGray;
            SBAniadirLote.DisabledState.CustomBorderColor = Color.DarkGray;
            SBAniadirLote.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBAniadirLote.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBAniadirLote.FillColor = Color.Black;
            SBAniadirLote.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBAniadirLote.ForeColor = Color.White;
            SBAniadirLote.Location = new Point(535, 635);
            SBAniadirLote.Margin = new Padding(3, 4, 3, 4);
            SBAniadirLote.Name = "SBAniadirLote";
            SBAniadirLote.Size = new Size(206, 60);
            SBAniadirLote.TabIndex = 54;
            SBAniadirLote.Text = "Añadir";
            SBAniadirLote.Click += SBAniadirLote_Click;
            // 
            // SCBProductoLote
            // 
            SCBProductoLote.Anchor = AnchorStyles.None;
            SCBProductoLote.AutoCompleteCustomSource.AddRange(new string[] { "Humita de sal", "Humita de Dulce", "Tamal" });
            SCBProductoLote.BackColor = Color.Transparent;
            SCBProductoLote.BorderRadius = 20;
            SCBProductoLote.DrawMode = DrawMode.OwnerDrawFixed;
            SCBProductoLote.DropDownStyle = ComboBoxStyle.DropDownList;
            SCBProductoLote.FocusedColor = Color.FromArgb(94, 148, 255);
            SCBProductoLote.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SCBProductoLote.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SCBProductoLote.ForeColor = Color.FromArgb(68, 88, 112);
            SCBProductoLote.ItemHeight = 35;
            SCBProductoLote.Location = new Point(678, 168);
            SCBProductoLote.Margin = new Padding(3, 4, 3, 4);
            SCBProductoLote.Name = "SCBProductoLote";
            SCBProductoLote.Size = new Size(228, 41);
            SCBProductoLote.TabIndex = 53;
            SCBProductoLote.TextOffset = new Point(5, 0);
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.Anchor = AnchorStyles.None;
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(402, 175);
            siticoneHtmlLabel3.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(119, 34);
            siticoneHtmlLabel3.TabIndex = 52;
            siticoneHtmlLabel3.Text = "Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.None;
            txtCantidad.BorderRadius = 20;
            txtCantidad.DefaultText = "";
            txtCantidad.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCantidad.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCantidad.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCantidad.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCantidad.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCantidad.Location = new Point(678, 251);
            txtCantidad.Margin = new Padding(3, 7, 3, 7);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PasswordChar = '\0';
            txtCantidad.PlaceholderText = "";
            txtCantidad.SelectedText = "";
            txtCantidad.Size = new Size(229, 55);
            txtCantidad.TabIndex = 51;
            txtCantidad.TextOffset = new Point(5, 0);
            // 
            // siticoneHtmlLabel4
            // 
            siticoneHtmlLabel4.Anchor = AnchorStyles.None;
            siticoneHtmlLabel4.BackColor = Color.Transparent;
            siticoneHtmlLabel4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel4.Location = new Point(403, 251);
            siticoneHtmlLabel4.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            siticoneHtmlLabel4.Size = new Size(126, 34);
            siticoneHtmlLabel4.TabIndex = 50;
            siticoneHtmlLabel4.Text = "Cantidad";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(siticoneGradientPanel1);
            tabPage2.Controls.Add(siticoneComboBox1);
            tabPage2.Controls.Add(siticoneTextBox1);
            tabPage2.Location = new Point(164, 4);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1281, 1012);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Editar/Eliminar Lote";
            // 
            // siticoneGradientPanel1
            // 
            siticoneGradientPanel1.Controls.Add(SDGVLote);
            siticoneGradientPanel1.Dock = DockStyle.Bottom;
            siticoneGradientPanel1.Location = new Point(0, 345);
            siticoneGradientPanel1.Margin = new Padding(3, 4, 3, 4);
            siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            siticoneGradientPanel1.Size = new Size(1281, 667);
            siticoneGradientPanel1.TabIndex = 28;
            // 
            // SDGVLote
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            SDGVLote.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            SDGVLote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            SDGVLote.ColumnHeadersHeight = 75;
            SDGVLote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SDGVLote.Columns.AddRange(new DataGridViewColumn[] { ColumnaCodLote, ColumnaCodProd, ColunmaCantidad, ColumnaFechayHora, ColumnaEditarLote, ColumnaEliminarLote });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            SDGVLote.DefaultCellStyle = dataGridViewCellStyle6;
            SDGVLote.Dock = DockStyle.Fill;
            SDGVLote.GridColor = Color.FromArgb(231, 229, 255);
            SDGVLote.Location = new Point(0, 0);
            SDGVLote.Margin = new Padding(3, 5, 3, 5);
            SDGVLote.Name = "SDGVLote";
            SDGVLote.RowHeadersVisible = false;
            SDGVLote.RowHeadersWidth = 50;
            SDGVLote.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(231, 229, 255);
            SDGVLote.RowTemplate.DividerHeight = 15;
            SDGVLote.RowTemplate.Height = 50;
            SDGVLote.Size = new Size(1281, 667);
            SDGVLote.TabIndex = 27;
            SDGVLote.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SDGVLote.ThemeStyle.AlternatingRowsStyle.Font = null;
            SDGVLote.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SDGVLote.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SDGVLote.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SDGVLote.ThemeStyle.BackColor = Color.White;
            SDGVLote.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            SDGVLote.ThemeStyle.HeaderStyle.BackColor = Color.DimGray;
            SDGVLote.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SDGVLote.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SDGVLote.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SDGVLote.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SDGVLote.ThemeStyle.HeaderStyle.Height = 75;
            SDGVLote.ThemeStyle.ReadOnly = false;
            SDGVLote.ThemeStyle.RowsStyle.BackColor = Color.White;
            SDGVLote.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SDGVLote.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SDGVLote.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            SDGVLote.ThemeStyle.RowsStyle.Height = 50;
            SDGVLote.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            SDGVLote.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            SDGVLote.CellClick += SDGVLote_CellClick;
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
            // siticoneComboBox1
            // 
            siticoneComboBox1.Anchor = AnchorStyles.None;
            siticoneComboBox1.BackColor = Color.Transparent;
            siticoneComboBox1.BorderRadius = 20;
            siticoneComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            siticoneComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            siticoneComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            siticoneComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            siticoneComboBox1.ItemHeight = 40;
            siticoneComboBox1.Items.AddRange(new object[] { "Código lote", "Código producto" });
            siticoneComboBox1.Location = new Point(642, 143);
            siticoneComboBox1.Margin = new Padding(3, 4, 3, 4);
            siticoneComboBox1.Name = "siticoneComboBox1";
            siticoneComboBox1.Size = new Size(311, 46);
            siticoneComboBox1.TabIndex = 24;
            // 
            // siticoneTextBox1
            // 
            siticoneTextBox1.Anchor = AnchorStyles.None;
            siticoneTextBox1.BorderRadius = 20;
            siticoneTextBox1.DefaultText = "";
            siticoneTextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            siticoneTextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            siticoneTextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            siticoneTextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            siticoneTextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneTextBox1.Location = new Point(313, 143);
            siticoneTextBox1.Margin = new Padding(3, 5, 3, 5);
            siticoneTextBox1.Name = "siticoneTextBox1";
            siticoneTextBox1.PasswordChar = '\0';
            siticoneTextBox1.PlaceholderText = "Buscar...";
            siticoneTextBox1.SelectedText = "";
            siticoneTextBox1.Size = new Size(312, 61);
            siticoneTextBox1.TabIndex = 23;
            // 
            // UC_Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticoneTabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Productos";
            Size = new Size(1449, 1020);
            siticoneTabControl1.ResumeLayout(false);
            Añadir.ResumeLayout(false);
            Añadir.PerformLayout();
            Editar.ResumeLayout(false);
            Editar.PerformLayout();
            siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SDGVProducto).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            siticoneGroupBox1.ResumeLayout(false);
            siticoneGroupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            siticoneGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SDGVLote).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage Añadir;
        private TabPage Editar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView SDGVProducto;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox ComboBox_ConsultarProductoPor;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtConsultarProducto;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView SDGVLote;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBAniadirProd;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cBoxCategoria;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPVP;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel8;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPE;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNombreProducto;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBAniadirLote;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox SCBProductoLote;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCantidad;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker siticoneDateTimePicker1;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton SRBElegirFecha;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton SRBFechaActual;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtImagen;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel11;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtIDProd;
        private DataGridViewTextBoxColumn ColumnaCodLote;
        private DataGridViewTextBoxColumn ColumnaCodProd;
        private DataGridViewTextBoxColumn ColunmaCantidad;
        private DataGridViewTextBoxColumn ColumnaFechayHora;
        private DataGridViewImageColumn ColumnaEditarLote;
        private DataGridViewImageColumn ColumnaEliminarLote;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel IDProd_not_unique_label;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel nombreProducto_not_unique_label;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel categoria_not_choose_label;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel PE_not_valid_label;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel PVP_not_greater_than_PE_label;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel PVP_not_valid_label;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel rutaImagen_not_valid_label;
        private DataGridViewTextBoxColumn CodProd;
        private DataGridViewTextBoxColumn NombreProd;
        private DataGridViewTextBoxColumn PrecioElab;
        private DataGridViewTextBoxColumn PrecioVentaPub;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewImageColumn ColumnaEditarProducto;
        private DataGridViewImageColumn ColumnaEliminarProducto;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_buscarProducto_sin_campo;
    }
}
