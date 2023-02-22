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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.Añadir = new System.Windows.Forms.TabPage();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtIDProd = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtImagen = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel11 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.SBAniadirProd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtCategoria = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtPVP = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel8 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtPE = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtNombreProducto = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.Editar = new System.Windows.Forms.TabPage();
            this.siticoneComboBox6 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneTextBox6 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SDGVProducto = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.ColumnaCódigoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidadProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEditarProducto = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnaEliminarProducto = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.siticoneGroupBox1 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.SRBFechaActual = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.SRBElegirFecha = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.siticoneDateTimePicker1 = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.SBAniadirLote = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SCBProductoLote = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtCantidad = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.SDGVLote = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.ColumnaCodLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunmaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechayHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEditarLote = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnaEliminarLote = new System.Windows.Forms.DataGridViewImageColumn();
            this.siticoneComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneTabControl1.SuspendLayout();
            this.Añadir.SuspendLayout();
            this.Editar.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SDGVProducto)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.siticoneGroupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SDGVLote)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            this.siticoneTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.siticoneTabControl1.Controls.Add(this.Añadir);
            this.siticoneTabControl1.Controls.Add(this.Editar);
            this.siticoneTabControl1.Controls.Add(this.tabPage1);
            this.siticoneTabControl1.Controls.Add(this.tabPage2);
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(160, 75);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(1449, 1020);
            this.siticoneTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.siticoneTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(160, 75);
            this.siticoneTabControl1.TabIndex = 2;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.Black;
            // 
            // Añadir
            // 
            this.Añadir.BackColor = System.Drawing.Color.White;
            this.Añadir.Controls.Add(this.siticoneHtmlLabel1);
            this.Añadir.Controls.Add(this.txtIDProd);
            this.Añadir.Controls.Add(this.siticoneButton3);
            this.Añadir.Controls.Add(this.txtImagen);
            this.Añadir.Controls.Add(this.siticoneHtmlLabel11);
            this.Añadir.Controls.Add(this.SBAniadirProd);
            this.Añadir.Controls.Add(this.txtCategoria);
            this.Añadir.Controls.Add(this.siticoneHtmlLabel6);
            this.Añadir.Controls.Add(this.txtPVP);
            this.Añadir.Controls.Add(this.siticoneHtmlLabel8);
            this.Añadir.Controls.Add(this.txtPE);
            this.Añadir.Controls.Add(this.siticoneHtmlLabel7);
            this.Añadir.Controls.Add(this.siticoneHtmlLabel5);
            this.Añadir.Controls.Add(this.txtNombreProducto);
            this.Añadir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Añadir.Location = new System.Drawing.Point(164, 4);
            this.Añadir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Añadir.Name = "Añadir";
            this.Añadir.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Añadir.Size = new System.Drawing.Size(1281, 1012);
            this.Añadir.TabIndex = 0;
            this.Añadir.Text = "Registrar Producto";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(267, 96);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(151, 34);
            this.siticoneHtmlLabel1.TabIndex = 52;
            this.siticoneHtmlLabel1.Text = "ID Producto";
            // 
            // txtIDProd
            // 
            this.txtIDProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDProd.BorderRadius = 20;
            this.txtIDProd.DefaultText = "";
            this.txtIDProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProd.Location = new System.Drawing.Point(556, 96);
            this.txtIDProd.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.PasswordChar = '\0';
            this.txtIDProd.PlaceholderText = "";
            this.txtIDProd.SelectedText = "";
            this.txtIDProd.Size = new System.Drawing.Size(229, 55);
            this.txtIDProd.TabIndex = 51;
            this.txtIDProd.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneButton3.BorderRadius = 20;
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.FillColor = System.Drawing.Color.Black;
            this.siticoneButton3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.Location = new System.Drawing.Point(818, 613);
            this.siticoneButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.Size = new System.Drawing.Size(206, 60);
            this.siticoneButton3.TabIndex = 50;
            this.siticoneButton3.Text = "Examinar...";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImagen.BorderRadius = 20;
            this.txtImagen.DefaultText = "";
            this.txtImagen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImagen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImagen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImagen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtImagen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImagen.Location = new System.Drawing.Point(556, 617);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.PasswordChar = '\0';
            this.txtImagen.PlaceholderText = "";
            this.txtImagen.SelectedText = "";
            this.txtImagen.Size = new System.Drawing.Size(229, 55);
            this.txtImagen.TabIndex = 49;
            this.txtImagen.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // siticoneHtmlLabel11
            // 
            this.siticoneHtmlLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel11.Location = new System.Drawing.Point(267, 639);
            this.siticoneHtmlLabel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneHtmlLabel11.Name = "siticoneHtmlLabel11";
            this.siticoneHtmlLabel11.Size = new System.Drawing.Size(101, 34);
            this.siticoneHtmlLabel11.TabIndex = 48;
            this.siticoneHtmlLabel11.Text = "Imagen";
            // 
            // SBAniadirProd
            // 
            this.SBAniadirProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SBAniadirProd.BorderRadius = 20;
            this.SBAniadirProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SBAniadirProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SBAniadirProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SBAniadirProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SBAniadirProd.FillColor = System.Drawing.Color.Black;
            this.SBAniadirProd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SBAniadirProd.ForeColor = System.Drawing.Color.White;
            this.SBAniadirProd.Location = new System.Drawing.Point(493, 796);
            this.SBAniadirProd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SBAniadirProd.Name = "SBAniadirProd";
            this.SBAniadirProd.Size = new System.Drawing.Size(206, 60);
            this.SBAniadirProd.TabIndex = 45;
            this.SBAniadirProd.Text = "Añadir";
            this.SBAniadirProd.Click += new System.EventHandler(this.SBAniadirProducto_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoria.BackColor = System.Drawing.Color.Transparent;
            this.txtCategoria.BorderRadius = 20;
            this.txtCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtCategoria.ItemHeight = 35;
            this.txtCategoria.Items.AddRange(new object[] {
            "Bebidas calientes",
            "Bebidas Frías",
            "Fritos",
            "Extras"});
            this.txtCategoria.Location = new System.Drawing.Point(556, 301);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(228, 41);
            this.txtCategoria.TabIndex = 44;
            this.txtCategoria.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(267, 307);
            this.siticoneHtmlLabel6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(133, 34);
            this.siticoneHtmlLabel6.TabIndex = 43;
            this.siticoneHtmlLabel6.Text = "Categoría";
            // 
            // txtPVP
            // 
            this.txtPVP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPVP.BorderRadius = 20;
            this.txtPVP.DefaultText = "";
            this.txtPVP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPVP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPVP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPVP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPVP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPVP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPVP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPVP.Location = new System.Drawing.Point(556, 512);
            this.txtPVP.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.txtPVP.Name = "txtPVP";
            this.txtPVP.PasswordChar = '\0';
            this.txtPVP.PlaceholderText = "";
            this.txtPVP.SelectedText = "";
            this.txtPVP.Size = new System.Drawing.Size(229, 55);
            this.txtPVP.TabIndex = 42;
            this.txtPVP.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // siticoneHtmlLabel8
            // 
            this.siticoneHtmlLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel8.Location = new System.Drawing.Point(267, 528);
            this.siticoneHtmlLabel8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.siticoneHtmlLabel8.Name = "siticoneHtmlLabel8";
            this.siticoneHtmlLabel8.Size = new System.Drawing.Size(73, 34);
            this.siticoneHtmlLabel8.TabIndex = 41;
            this.siticoneHtmlLabel8.Text = "P.V.P.";
            // 
            // txtPE
            // 
            this.txtPE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPE.BorderRadius = 20;
            this.txtPE.DefaultText = "";
            this.txtPE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPE.Location = new System.Drawing.Point(556, 407);
            this.txtPE.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.txtPE.Name = "txtPE";
            this.txtPE.PasswordChar = '\0';
            this.txtPE.PlaceholderText = "";
            this.txtPE.SelectedText = "";
            this.txtPE.Size = new System.Drawing.Size(229, 55);
            this.txtPE.TabIndex = 40;
            this.txtPE.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // siticoneHtmlLabel7
            // 
            this.siticoneHtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel7.Location = new System.Drawing.Point(267, 417);
            this.siticoneHtmlLabel7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            this.siticoneHtmlLabel7.Size = new System.Drawing.Size(245, 34);
            this.siticoneHtmlLabel7.TabIndex = 34;
            this.siticoneHtmlLabel7.Text = "Precio Elaboración";
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(267, 196);
            this.siticoneHtmlLabel5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(229, 34);
            this.siticoneHtmlLabel5.TabIndex = 28;
            this.siticoneHtmlLabel5.Text = "Nombre Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreProducto.BorderRadius = 20;
            this.txtNombreProducto.DefaultText = "";
            this.txtNombreProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.Location = new System.Drawing.Point(556, 196);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.PlaceholderText = "";
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.Size = new System.Drawing.Size(229, 55);
            this.txtNombreProducto.TabIndex = 27;
            this.txtNombreProducto.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.White;
            this.Editar.Controls.Add(this.siticoneComboBox6);
            this.Editar.Controls.Add(this.siticoneTextBox6);
            this.Editar.Controls.Add(this.siticonePanel1);
            this.Editar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Editar.Location = new System.Drawing.Point(164, 4);
            this.Editar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Editar.Name = "Editar";
            this.Editar.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Editar.Size = new System.Drawing.Size(1281, 1012);
            this.Editar.TabIndex = 1;
            this.Editar.Text = "Editar/Eliminar Producto";
            // 
            // siticoneComboBox6
            // 
            this.siticoneComboBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneComboBox6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox6.BorderRadius = 20;
            this.siticoneComboBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox6.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneComboBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox6.ItemHeight = 40;
            this.siticoneComboBox6.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Categoría"});
            this.siticoneComboBox6.Location = new System.Drawing.Point(631, 139);
            this.siticoneComboBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneComboBox6.Name = "siticoneComboBox6";
            this.siticoneComboBox6.Size = new System.Drawing.Size(311, 46);
            this.siticoneComboBox6.TabIndex = 20;
            // 
            // siticoneTextBox6
            // 
            this.siticoneTextBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneTextBox6.BorderRadius = 20;
            this.siticoneTextBox6.DefaultText = "";
            this.siticoneTextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox6.Location = new System.Drawing.Point(302, 139);
            this.siticoneTextBox6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.siticoneTextBox6.Name = "siticoneTextBox6";
            this.siticoneTextBox6.PasswordChar = '\0';
            this.siticoneTextBox6.PlaceholderText = "Buscar...";
            this.siticoneTextBox6.SelectedText = "";
            this.siticoneTextBox6.Size = new System.Drawing.Size(312, 61);
            this.siticoneTextBox6.TabIndex = 19;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.SDGVProducto);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.Location = new System.Drawing.Point(3, 340);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(1275, 667);
            this.siticonePanel1.TabIndex = 1;
            // 
            // SDGVProducto
            // 
            this.SDGVProducto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SDGVProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SDGVProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SDGVProducto.ColumnHeadersHeight = 75;
            this.SDGVProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SDGVProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCódigoProd,
            this.ColumnaNombreProd,
            this.ColumnaPE,
            this.ColumnaPVP,
            this.ColumnaCategoria,
            this.ColumnaCantidadProd,
            this.ColumnaEditarProducto,
            this.ColumnaEliminarProducto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SDGVProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.SDGVProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SDGVProducto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SDGVProducto.Location = new System.Drawing.Point(0, 0);
            this.SDGVProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SDGVProducto.Name = "SDGVProducto";
            this.SDGVProducto.RowHeadersVisible = false;
            this.SDGVProducto.RowHeadersWidth = 50;
            this.SDGVProducto.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SDGVProducto.RowTemplate.DividerHeight = 15;
            this.SDGVProducto.RowTemplate.Height = 50;
            this.SDGVProducto.Size = new System.Drawing.Size(1275, 667);
            this.SDGVProducto.TabIndex = 0;
            this.SDGVProducto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SDGVProducto.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SDGVProducto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SDGVProducto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SDGVProducto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SDGVProducto.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SDGVProducto.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SDGVProducto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.SDGVProducto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SDGVProducto.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SDGVProducto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SDGVProducto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SDGVProducto.ThemeStyle.HeaderStyle.Height = 75;
            this.SDGVProducto.ThemeStyle.ReadOnly = false;
            this.SDGVProducto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SDGVProducto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SDGVProducto.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SDGVProducto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SDGVProducto.ThemeStyle.RowsStyle.Height = 50;
            this.SDGVProducto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SDGVProducto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SDGVProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SDGVProducto_CellClick);
            // 
            // ColumnaCódigoProd
            // 
            this.ColumnaCódigoProd.FillWeight = 75F;
            this.ColumnaCódigoProd.HeaderText = "Código";
            this.ColumnaCódigoProd.MinimumWidth = 6;
            this.ColumnaCódigoProd.Name = "ColumnaCódigoProd";
            this.ColumnaCódigoProd.ReadOnly = true;
            this.ColumnaCódigoProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaNombreProd
            // 
            this.ColumnaNombreProd.FillWeight = 150F;
            this.ColumnaNombreProd.HeaderText = "Nombre";
            this.ColumnaNombreProd.MinimumWidth = 6;
            this.ColumnaNombreProd.Name = "ColumnaNombreProd";
            this.ColumnaNombreProd.ReadOnly = true;
            this.ColumnaNombreProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaPE
            // 
            this.ColumnaPE.FillWeight = 50F;
            this.ColumnaPE.HeaderText = "P.E";
            this.ColumnaPE.MinimumWidth = 6;
            this.ColumnaPE.Name = "ColumnaPE";
            this.ColumnaPE.ReadOnly = true;
            this.ColumnaPE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaPVP
            // 
            this.ColumnaPVP.FillWeight = 50F;
            this.ColumnaPVP.HeaderText = "P.V.P";
            this.ColumnaPVP.MinimumWidth = 6;
            this.ColumnaPVP.Name = "ColumnaPVP";
            this.ColumnaPVP.ReadOnly = true;
            this.ColumnaPVP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaCategoria
            // 
            this.ColumnaCategoria.FillWeight = 150F;
            this.ColumnaCategoria.HeaderText = "Categoría";
            this.ColumnaCategoria.MinimumWidth = 6;
            this.ColumnaCategoria.Name = "ColumnaCategoria";
            this.ColumnaCategoria.ReadOnly = true;
            this.ColumnaCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaCantidadProd
            // 
            this.ColumnaCantidadProd.FillWeight = 75F;
            this.ColumnaCantidadProd.HeaderText = "Cantidad";
            this.ColumnaCantidadProd.MinimumWidth = 6;
            this.ColumnaCantidadProd.Name = "ColumnaCantidadProd";
            this.ColumnaCantidadProd.ReadOnly = true;
            this.ColumnaCantidadProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaEditarProducto
            // 
            this.ColumnaEditarProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnaEditarProducto.HeaderText = "";
            this.ColumnaEditarProducto.Image = ((System.Drawing.Image)(resources.GetObject("ColumnaEditarProducto.Image")));
            this.ColumnaEditarProducto.MinimumWidth = 6;
            this.ColumnaEditarProducto.Name = "ColumnaEditarProducto";
            this.ColumnaEditarProducto.ReadOnly = true;
            this.ColumnaEditarProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnaEditarProducto.Width = 182;
            // 
            // ColumnaEliminarProducto
            // 
            this.ColumnaEliminarProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnaEliminarProducto.HeaderText = "";
            this.ColumnaEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("ColumnaEliminarProducto.Image")));
            this.ColumnaEliminarProducto.MinimumWidth = 6;
            this.ColumnaEliminarProducto.Name = "ColumnaEliminarProducto";
            this.ColumnaEliminarProducto.ReadOnly = true;
            this.ColumnaEliminarProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnaEliminarProducto.Width = 182;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.siticoneGroupBox1);
            this.tabPage1.Controls.Add(this.SBAniadirLote);
            this.tabPage1.Controls.Add(this.SCBProductoLote);
            this.tabPage1.Controls.Add(this.siticoneHtmlLabel3);
            this.tabPage1.Controls.Add(this.txtCantidad);
            this.tabPage1.Controls.Add(this.siticoneHtmlLabel4);
            this.tabPage1.Location = new System.Drawing.Point(164, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1281, 1012);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Añadir Lote";
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneGroupBox1.BorderRadius = 20;
            this.siticoneGroupBox1.Controls.Add(this.SRBFechaActual);
            this.siticoneGroupBox1.Controls.Add(this.SRBElegirFecha);
            this.siticoneGroupBox1.Controls.Add(this.siticoneDateTimePicker1);
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(433, 350);
            this.siticoneGroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.Size = new System.Drawing.Size(473, 204);
            this.siticoneGroupBox1.TabIndex = 63;
            this.siticoneGroupBox1.Text = "Fecha y Hora";
            // 
            // SRBFechaActual
            // 
            this.SRBFechaActual.AutoSize = true;
            this.SRBFechaActual.Checked = true;
            this.SRBFechaActual.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SRBFechaActual.CheckedState.BorderThickness = 0;
            this.SRBFechaActual.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SRBFechaActual.CheckedState.InnerColor = System.Drawing.Color.White;
            this.SRBFechaActual.CheckedState.InnerOffset = -4;
            this.SRBFechaActual.Location = new System.Drawing.Point(15, 68);
            this.SRBFechaActual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SRBFechaActual.Name = "SRBFechaActual";
            this.SRBFechaActual.Size = new System.Drawing.Size(112, 34);
            this.SRBFechaActual.TabIndex = 56;
            this.SRBFechaActual.TabStop = true;
            this.SRBFechaActual.Text = "Actual";
            this.SRBFechaActual.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SRBFechaActual.UncheckedState.BorderThickness = 2;
            this.SRBFechaActual.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.SRBFechaActual.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.SRBFechaActual.CheckedChanged += new System.EventHandler(this.siticoneRadioButton1_CheckedChanged);
            // 
            // SRBElegirFecha
            // 
            this.SRBElegirFecha.AutoSize = true;
            this.SRBElegirFecha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SRBElegirFecha.CheckedState.BorderThickness = 0;
            this.SRBElegirFecha.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SRBElegirFecha.CheckedState.InnerColor = System.Drawing.Color.White;
            this.SRBElegirFecha.CheckedState.InnerOffset = -4;
            this.SRBElegirFecha.Location = new System.Drawing.Point(245, 68);
            this.SRBElegirFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SRBElegirFecha.Name = "SRBElegirFecha";
            this.SRBElegirFecha.Size = new System.Drawing.Size(98, 34);
            this.SRBElegirFecha.TabIndex = 57;
            this.SRBElegirFecha.Text = "Elegir";
            this.SRBElegirFecha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SRBElegirFecha.UncheckedState.BorderThickness = 2;
            this.SRBElegirFecha.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.SRBElegirFecha.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.SRBElegirFecha.CheckedChanged += new System.EventHandler(this.siticoneRadioButton2_CheckedChanged);
            // 
            // siticoneDateTimePicker1
            // 
            this.siticoneDateTimePicker1.BorderRadius = 10;
            this.siticoneDateTimePicker1.Checked = true;
            this.siticoneDateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.siticoneDateTimePicker1.FillColor = System.Drawing.Color.White;
            this.siticoneDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.siticoneDateTimePicker1.Location = new System.Drawing.Point(237, 127);
            this.siticoneDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.siticoneDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.siticoneDateTimePicker1.Name = "siticoneDateTimePicker1";
            this.siticoneDateTimePicker1.ShowUpDown = true;
            this.siticoneDateTimePicker1.Size = new System.Drawing.Size(199, 37);
            this.siticoneDateTimePicker1.TabIndex = 58;
            this.siticoneDateTimePicker1.TextOffset = new System.Drawing.Point(5, 0);
            this.siticoneDateTimePicker1.Value = new System.DateTime(2023, 2, 6, 1, 19, 20, 716);
            this.siticoneDateTimePicker1.Visible = false;
            // 
            // SBAniadirLote
            // 
            this.SBAniadirLote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SBAniadirLote.BorderRadius = 20;
            this.SBAniadirLote.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SBAniadirLote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SBAniadirLote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SBAniadirLote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SBAniadirLote.FillColor = System.Drawing.Color.Black;
            this.SBAniadirLote.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SBAniadirLote.ForeColor = System.Drawing.Color.White;
            this.SBAniadirLote.Location = new System.Drawing.Point(535, 634);
            this.SBAniadirLote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SBAniadirLote.Name = "SBAniadirLote";
            this.SBAniadirLote.Size = new System.Drawing.Size(206, 60);
            this.SBAniadirLote.TabIndex = 54;
            this.SBAniadirLote.Text = "Añadir";
            this.SBAniadirLote.Click += new System.EventHandler(this.SBAniadirLote_Click);
            // 
            // SCBProductoLote
            // 
            this.SCBProductoLote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SCBProductoLote.AutoCompleteCustomSource.AddRange(new string[] {
            "Humita de sal",
            "Humita de Dulce",
            "Tamal"});
            this.SCBProductoLote.BackColor = System.Drawing.Color.Transparent;
            this.SCBProductoLote.BorderRadius = 20;
            this.SCBProductoLote.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SCBProductoLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SCBProductoLote.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SCBProductoLote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SCBProductoLote.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SCBProductoLote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SCBProductoLote.ItemHeight = 35;
            this.SCBProductoLote.Location = new System.Drawing.Point(678, 168);
            this.SCBProductoLote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SCBProductoLote.Name = "SCBProductoLote";
            this.SCBProductoLote.Size = new System.Drawing.Size(228, 41);
            this.SCBProductoLote.TabIndex = 53;
            this.SCBProductoLote.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(402, 175);
            this.siticoneHtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(119, 34);
            this.siticoneHtmlLabel3.TabIndex = 52;
            this.siticoneHtmlLabel3.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.BorderRadius = 20;
            this.txtCantidad.DefaultText = "";
            this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.Location = new System.Drawing.Point(678, 250);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.Size = new System.Drawing.Size(229, 55);
            this.txtCantidad.TabIndex = 51;
            this.txtCantidad.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(403, 250);
            this.siticoneHtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(126, 34);
            this.siticoneHtmlLabel4.TabIndex = 50;
            this.siticoneHtmlLabel4.Text = "Cantidad";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.siticoneGradientPanel1);
            this.tabPage2.Controls.Add(this.siticoneComboBox1);
            this.tabPage2.Controls.Add(this.siticoneTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(164, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1281, 1012);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Editar/Eliminar Lote";
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.Controls.Add(this.SDGVLote);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 345);
            this.siticoneGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(1281, 667);
            this.siticoneGradientPanel1.TabIndex = 28;
            // 
            // SDGVLote
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.SDGVLote.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SDGVLote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.SDGVLote.ColumnHeadersHeight = 75;
            this.SDGVLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SDGVLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCodLote,
            this.ColumnaCodProd,
            this.ColunmaCantidad,
            this.ColumnaFechayHora,
            this.ColumnaEditarLote,
            this.ColumnaEliminarLote});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SDGVLote.DefaultCellStyle = dataGridViewCellStyle6;
            this.SDGVLote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SDGVLote.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SDGVLote.Location = new System.Drawing.Point(0, 0);
            this.SDGVLote.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SDGVLote.Name = "SDGVLote";
            this.SDGVLote.RowHeadersVisible = false;
            this.SDGVLote.RowHeadersWidth = 50;
            this.SDGVLote.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SDGVLote.RowTemplate.DividerHeight = 15;
            this.SDGVLote.RowTemplate.Height = 50;
            this.SDGVLote.Size = new System.Drawing.Size(1281, 667);
            this.SDGVLote.TabIndex = 27;
            this.SDGVLote.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SDGVLote.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SDGVLote.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SDGVLote.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SDGVLote.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SDGVLote.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SDGVLote.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SDGVLote.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.SDGVLote.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SDGVLote.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SDGVLote.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SDGVLote.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SDGVLote.ThemeStyle.HeaderStyle.Height = 75;
            this.SDGVLote.ThemeStyle.ReadOnly = false;
            this.SDGVLote.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SDGVLote.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SDGVLote.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SDGVLote.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SDGVLote.ThemeStyle.RowsStyle.Height = 50;
            this.SDGVLote.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SDGVLote.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SDGVLote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SDGVLote_CellClick);
            // 
            // ColumnaCodLote
            // 
            this.ColumnaCodLote.HeaderText = "Código lote";
            this.ColumnaCodLote.MinimumWidth = 6;
            this.ColumnaCodLote.Name = "ColumnaCodLote";
            this.ColumnaCodLote.ReadOnly = true;
            this.ColumnaCodLote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaCodProd
            // 
            this.ColumnaCodProd.HeaderText = "Código producto";
            this.ColumnaCodProd.MinimumWidth = 6;
            this.ColumnaCodProd.Name = "ColumnaCodProd";
            this.ColumnaCodProd.ReadOnly = true;
            this.ColumnaCodProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColunmaCantidad
            // 
            this.ColunmaCantidad.HeaderText = "Cantidad";
            this.ColunmaCantidad.MinimumWidth = 6;
            this.ColunmaCantidad.Name = "ColunmaCantidad";
            this.ColunmaCantidad.ReadOnly = true;
            this.ColunmaCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaFechayHora
            // 
            this.ColumnaFechayHora.HeaderText = "Fecha y Hora";
            this.ColumnaFechayHora.MinimumWidth = 6;
            this.ColumnaFechayHora.Name = "ColumnaFechayHora";
            this.ColumnaFechayHora.ReadOnly = true;
            this.ColumnaFechayHora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaEditarLote
            // 
            this.ColumnaEditarLote.HeaderText = "";
            this.ColumnaEditarLote.Image = ((System.Drawing.Image)(resources.GetObject("ColumnaEditarLote.Image")));
            this.ColumnaEditarLote.MinimumWidth = 6;
            this.ColumnaEditarLote.Name = "ColumnaEditarLote";
            this.ColumnaEditarLote.ReadOnly = true;
            this.ColumnaEditarLote.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnaEliminarLote
            // 
            this.ColumnaEliminarLote.HeaderText = "";
            this.ColumnaEliminarLote.Image = ((System.Drawing.Image)(resources.GetObject("ColumnaEliminarLote.Image")));
            this.ColumnaEliminarLote.MinimumWidth = 6;
            this.ColumnaEliminarLote.Name = "ColumnaEliminarLote";
            this.ColumnaEliminarLote.ReadOnly = true;
            this.ColumnaEliminarLote.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // siticoneComboBox1
            // 
            this.siticoneComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox1.BorderRadius = 20;
            this.siticoneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox1.ItemHeight = 40;
            this.siticoneComboBox1.Items.AddRange(new object[] {
            "Código lote",
            "Código producto"});
            this.siticoneComboBox1.Location = new System.Drawing.Point(642, 143);
            this.siticoneComboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneComboBox1.Name = "siticoneComboBox1";
            this.siticoneComboBox1.Size = new System.Drawing.Size(311, 46);
            this.siticoneComboBox1.TabIndex = 24;
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneTextBox1.BorderRadius = 20;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Location = new System.Drawing.Point(313, 143);
            this.siticoneTextBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "Buscar...";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(312, 61);
            this.siticoneTextBox1.TabIndex = 23;
            // 
            // UC_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneTabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Productos";
            this.Size = new System.Drawing.Size(1449, 1020);
            this.siticoneTabControl1.ResumeLayout(false);
            this.Añadir.ResumeLayout(false);
            this.Añadir.PerformLayout();
            this.Editar.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SDGVProducto)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.siticoneGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SDGVLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage Añadir;
        private TabPage Editar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView SDGVProducto;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox6;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView SDGVLote;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBAniadirProd;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox txtCategoria;
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
        private DataGridViewTextBoxColumn ColumnaCódigoProd;
        private DataGridViewTextBoxColumn ColumnaNombreProd;
        private DataGridViewTextBoxColumn ColumnaPE;
        private DataGridViewTextBoxColumn ColumnaPVP;
        private DataGridViewTextBoxColumn ColumnaCategoria;
        private DataGridViewTextBoxColumn ColumnaCantidadProd;
        private DataGridViewImageColumn ColumnaEditarProducto;
        private DataGridViewImageColumn ColumnaEliminarProducto;
        private DataGridViewTextBoxColumn ColumnaCodLote;
        private DataGridViewTextBoxColumn ColumnaCodProd;
        private DataGridViewTextBoxColumn ColunmaCantidad;
        private DataGridViewTextBoxColumn ColumnaFechayHora;
        private DataGridViewImageColumn ColumnaEditarLote;
        private DataGridViewImageColumn ColumnaEliminarLote;
    }
}
