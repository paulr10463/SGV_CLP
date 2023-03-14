namespace SGV_CLP.GUI
{
    partial class UC_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Proveedores));
            siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            Añadir = new TabPage();
            siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            SBAniadirProveedor = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            txtTelefono = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtDirec = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtRUC = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtNombreProv = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            Editar = new TabPage();
            siticoneComboBox6 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneTextBox6 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            SDGVProveedor = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            ColumnaRUC = new DataGridViewTextBoxColumn();
            ColumnaNombreProv = new DataGridViewTextBoxColumn();
            ColumnaDireccion = new DataGridViewTextBoxColumn();
            ColumnaTelefono = new DataGridViewTextBoxColumn();
            ColumnaEditarProveedor = new DataGridViewImageColumn();
            ColumnaEliminarProveedor = new DataGridViewImageColumn();
            siticoneTabControl1.SuspendLayout();
            Añadir.SuspendLayout();
            Editar.SuspendLayout();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SDGVProveedor).BeginInit();
            SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            siticoneTabControl1.Alignment = TabAlignment.Left;
            siticoneTabControl1.Controls.Add(Añadir);
            siticoneTabControl1.Controls.Add(Editar);
            siticoneTabControl1.Dock = DockStyle.Fill;
            siticoneTabControl1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.ItemSize = new Size(160, 75);
            siticoneTabControl1.Location = new Point(0, 0);
            siticoneTabControl1.Margin = new Padding(3, 4, 3, 4);
            siticoneTabControl1.Name = "siticoneTabControl1";
            siticoneTabControl1.SelectedIndex = 0;
            siticoneTabControl1.Size = new Size(1549, 945);
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
            Añadir.Controls.Add(siticoneHtmlLabel4);
            Añadir.Controls.Add(SBAniadirProveedor);
            Añadir.Controls.Add(txtTelefono);
            Añadir.Controls.Add(txtDirec);
            Añadir.Controls.Add(siticoneHtmlLabel1);
            Añadir.Controls.Add(txtRUC);
            Añadir.Controls.Add(siticoneHtmlLabel7);
            Añadir.Controls.Add(siticoneHtmlLabel5);
            Añadir.Controls.Add(txtNombreProv);
            Añadir.Controls.Add(siticoneHtmlLabel3);
            Añadir.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Añadir.Location = new Point(164, 4);
            Añadir.Margin = new Padding(3, 5, 3, 5);
            Añadir.Name = "Añadir";
            Añadir.Padding = new Padding(3, 5, 3, 5);
            Añadir.Size = new Size(1381, 937);
            Añadir.TabIndex = 0;
            Añadir.Text = "Registrar Proveedor";
            Añadir.UseVisualStyleBackColor = true;
            // 
            // siticoneHtmlLabel4
            // 
            siticoneHtmlLabel4.Anchor = AnchorStyles.None;
            siticoneHtmlLabel4.BackColor = Color.Transparent;
            siticoneHtmlLabel4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel4.Location = new Point(387, 193);
            siticoneHtmlLabel4.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            siticoneHtmlLabel4.Size = new Size(57, 34);
            siticoneHtmlLabel4.TabIndex = 55;
            siticoneHtmlLabel4.Text = "RUC";
            // 
            // SBAniadirProveedor
            // 
            SBAniadirProveedor.Anchor = AnchorStyles.None;
            SBAniadirProveedor.BorderRadius = 20;
            SBAniadirProveedor.DisabledState.BorderColor = Color.DarkGray;
            SBAniadirProveedor.DisabledState.CustomBorderColor = Color.DarkGray;
            SBAniadirProveedor.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBAniadirProveedor.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBAniadirProveedor.FillColor = Color.Black;
            SBAniadirProveedor.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBAniadirProveedor.ForeColor = Color.White;
            SBAniadirProveedor.Location = new Point(559, 684);
            SBAniadirProveedor.Margin = new Padding(3, 4, 3, 4);
            SBAniadirProveedor.Name = "SBAniadirProveedor";
            SBAniadirProveedor.Size = new Size(206, 60);
            SBAniadirProveedor.TabIndex = 54;
            SBAniadirProveedor.Text = "Añadir";
            SBAniadirProveedor.Click += SBAniadirProveedor_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.BorderRadius = 20;
            txtTelefono.DefaultText = "";
            txtTelefono.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTelefono.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTelefono.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTelefono.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTelefono.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefono.Location = new Point(703, 480);
            txtTelefono.Margin = new Padding(3, 7, 3, 7);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PlaceholderText = "";
            txtTelefono.SelectedText = "";
            txtTelefono.Size = new Size(229, 55);
            txtTelefono.TabIndex = 53;
            // 
            // txtDirec
            // 
            txtDirec.Anchor = AnchorStyles.None;
            txtDirec.BorderRadius = 20;
            txtDirec.DefaultText = "";
            txtDirec.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDirec.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDirec.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDirec.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDirec.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDirec.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDirec.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDirec.Location = new Point(703, 381);
            txtDirec.Margin = new Padding(3, 7, 3, 7);
            txtDirec.Name = "txtDirec";
            txtDirec.PasswordChar = '\0';
            txtDirec.PlaceholderText = "";
            txtDirec.SelectedText = "";
            txtDirec.Size = new Size(229, 55);
            txtDirec.TabIndex = 52;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(387, 391);
            siticoneHtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(126, 34);
            siticoneHtmlLabel1.TabIndex = 51;
            siticoneHtmlLabel1.Text = "Dirección";
            // 
            // txtRUC
            // 
            txtRUC.Anchor = AnchorStyles.None;
            txtRUC.BorderRadius = 20;
            txtRUC.DefaultText = "";
            txtRUC.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRUC.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRUC.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRUC.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRUC.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRUC.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtRUC.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRUC.Location = new Point(703, 184);
            txtRUC.Margin = new Padding(3, 7, 3, 7);
            txtRUC.Name = "txtRUC";
            txtRUC.PasswordChar = '\0';
            txtRUC.PlaceholderText = "";
            txtRUC.SelectedText = "";
            txtRUC.Size = new Size(229, 55);
            txtRUC.TabIndex = 50;
            // 
            // siticoneHtmlLabel7
            // 
            siticoneHtmlLabel7.Anchor = AnchorStyles.None;
            siticoneHtmlLabel7.BackColor = Color.Transparent;
            siticoneHtmlLabel7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel7.Location = new Point(387, 489);
            siticoneHtmlLabel7.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            siticoneHtmlLabel7.Size = new Size(112, 34);
            siticoneHtmlLabel7.TabIndex = 49;
            siticoneHtmlLabel7.Text = "Teléfono";
            // 
            // siticoneHtmlLabel5
            // 
            siticoneHtmlLabel5.Anchor = AnchorStyles.None;
            siticoneHtmlLabel5.BackColor = Color.Transparent;
            siticoneHtmlLabel5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel5.Location = new Point(387, 292);
            siticoneHtmlLabel5.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            siticoneHtmlLabel5.Size = new Size(293, 34);
            siticoneHtmlLabel5.TabIndex = 46;
            siticoneHtmlLabel5.Text = "Nombre del Proveedor";
            // 
            // txtNombreProv
            // 
            txtNombreProv.Anchor = AnchorStyles.None;
            txtNombreProv.BorderRadius = 20;
            txtNombreProv.DefaultText = "";
            txtNombreProv.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombreProv.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombreProv.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombreProv.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombreProv.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombreProv.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreProv.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombreProv.Location = new Point(703, 283);
            txtNombreProv.Margin = new Padding(3, 7, 3, 7);
            txtNombreProv.Name = "txtNombreProv";
            txtNombreProv.PasswordChar = '\0';
            txtNombreProv.PlaceholderText = "";
            txtNombreProv.SelectedText = "";
            txtNombreProv.Size = new Size(229, 55);
            txtNombreProv.TabIndex = 45;
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.Anchor = AnchorStyles.None;
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(469, 284);
            siticoneHtmlLabel3.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(57, 34);
            siticoneHtmlLabel3.TabIndex = 44;
            siticoneHtmlLabel3.Text = "RUC";
            // 
            // Editar
            // 
            Editar.Controls.Add(siticoneComboBox6);
            Editar.Controls.Add(siticoneTextBox6);
            Editar.Controls.Add(siticonePanel1);
            Editar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.Location = new Point(164, 4);
            Editar.Margin = new Padding(3, 5, 3, 5);
            Editar.Name = "Editar";
            Editar.Padding = new Padding(3, 5, 3, 5);
            Editar.Size = new Size(1381, 937);
            Editar.TabIndex = 1;
            Editar.Text = "Editar/Eliminar Proveedor";
            Editar.UseVisualStyleBackColor = true;
            // 
            // siticoneComboBox6
            // 
            siticoneComboBox6.Anchor = AnchorStyles.None;
            siticoneComboBox6.AutoCompleteCustomSource.AddRange(new string[] { "RUC", "Nombre" });
            siticoneComboBox6.BackColor = Color.Transparent;
            siticoneComboBox6.BorderRadius = 20;
            siticoneComboBox6.DrawMode = DrawMode.OwnerDrawFixed;
            siticoneComboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            siticoneComboBox6.FocusedColor = Color.FromArgb(94, 148, 255);
            siticoneComboBox6.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneComboBox6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneComboBox6.ForeColor = Color.FromArgb(68, 88, 112);
            siticoneComboBox6.ItemHeight = 40;
            siticoneComboBox6.Items.AddRange(new object[] { "RUC", "Nombre", "Teléfono" });
            siticoneComboBox6.Location = new Point(686, 104);
            siticoneComboBox6.Margin = new Padding(3, 4, 3, 4);
            siticoneComboBox6.Name = "siticoneComboBox6";
            siticoneComboBox6.Size = new Size(311, 46);
            siticoneComboBox6.TabIndex = 20;
            // 
            // siticoneTextBox6
            // 
            siticoneTextBox6.Anchor = AnchorStyles.None;
            siticoneTextBox6.BorderRadius = 20;
            siticoneTextBox6.DefaultText = "";
            siticoneTextBox6.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            siticoneTextBox6.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            siticoneTextBox6.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            siticoneTextBox6.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            siticoneTextBox6.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneTextBox6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTextBox6.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneTextBox6.Location = new Point(337, 104);
            siticoneTextBox6.Margin = new Padding(3, 5, 3, 5);
            siticoneTextBox6.Name = "siticoneTextBox6";
            siticoneTextBox6.PasswordChar = '\0';
            siticoneTextBox6.PlaceholderText = "Buscar...";
            siticoneTextBox6.SelectedText = "";
            siticoneTextBox6.Size = new Size(312, 61);
            siticoneTextBox6.TabIndex = 19;
            // 
            // siticonePanel1
            // 
            siticonePanel1.Controls.Add(SDGVProveedor);
            siticonePanel1.Dock = DockStyle.Bottom;
            siticonePanel1.Location = new Point(3, 265);
            siticonePanel1.Margin = new Padding(3, 5, 3, 5);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(1375, 667);
            siticonePanel1.TabIndex = 1;
            // 
            // SDGVProveedor
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            SDGVProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SDGVProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SDGVProveedor.ColumnHeadersHeight = 50;
            SDGVProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SDGVProveedor.Columns.AddRange(new DataGridViewColumn[] { ColumnaRUC, ColumnaNombreProv, ColumnaDireccion, ColumnaTelefono, ColumnaEditarProveedor, ColumnaEliminarProveedor });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SDGVProveedor.DefaultCellStyle = dataGridViewCellStyle3;
            SDGVProveedor.Dock = DockStyle.Fill;
            SDGVProveedor.GridColor = Color.FromArgb(231, 229, 255);
            SDGVProveedor.Location = new Point(0, 0);
            SDGVProveedor.Margin = new Padding(3, 4, 3, 4);
            SDGVProveedor.Name = "SDGVProveedor";
            SDGVProveedor.RowHeadersVisible = false;
            SDGVProveedor.RowHeadersWidth = 51;
            SDGVProveedor.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            SDGVProveedor.RowTemplate.Height = 50;
            SDGVProveedor.Size = new Size(1375, 667);
            SDGVProveedor.TabIndex = 0;
            SDGVProveedor.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SDGVProveedor.ThemeStyle.AlternatingRowsStyle.Font = null;
            SDGVProveedor.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SDGVProveedor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SDGVProveedor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SDGVProveedor.ThemeStyle.BackColor = Color.White;
            SDGVProveedor.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            SDGVProveedor.ThemeStyle.HeaderStyle.BackColor = Color.DimGray;
            SDGVProveedor.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SDGVProveedor.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SDGVProveedor.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SDGVProveedor.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SDGVProveedor.ThemeStyle.HeaderStyle.Height = 50;
            SDGVProveedor.ThemeStyle.ReadOnly = false;
            SDGVProveedor.ThemeStyle.RowsStyle.BackColor = Color.White;
            SDGVProveedor.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SDGVProveedor.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SDGVProveedor.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            SDGVProveedor.ThemeStyle.RowsStyle.Height = 50;
            SDGVProveedor.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            SDGVProveedor.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            SDGVProveedor.CellClick += SDGVProveedor_CellClick;
            // 
            // ColumnaRUC
            // 
            ColumnaRUC.HeaderText = "RUC";
            ColumnaRUC.MinimumWidth = 6;
            ColumnaRUC.Name = "ColumnaRUC";
            // 
            // ColumnaNombreProv
            // 
            ColumnaNombreProv.HeaderText = "Nombre";
            ColumnaNombreProv.MinimumWidth = 6;
            ColumnaNombreProv.Name = "ColumnaNombreProv";
            // 
            // ColumnaDireccion
            // 
            ColumnaDireccion.HeaderText = "Dirección";
            ColumnaDireccion.MinimumWidth = 6;
            ColumnaDireccion.Name = "ColumnaDireccion";
            // 
            // ColumnaTelefono
            // 
            ColumnaTelefono.HeaderText = "Teléfono";
            ColumnaTelefono.MinimumWidth = 6;
            ColumnaTelefono.Name = "ColumnaTelefono";
            // 
            // ColumnaEditarProveedor
            // 
            ColumnaEditarProveedor.HeaderText = "";
            ColumnaEditarProveedor.Image = (Image)resources.GetObject("ColumnaEditarProveedor.Image");
            ColumnaEditarProveedor.MinimumWidth = 6;
            ColumnaEditarProveedor.Name = "ColumnaEditarProveedor";
            // 
            // ColumnaEliminarProveedor
            // 
            ColumnaEliminarProveedor.HeaderText = "";
            ColumnaEliminarProveedor.Image = (Image)resources.GetObject("ColumnaEliminarProveedor.Image");
            ColumnaEliminarProveedor.MinimumWidth = 6;
            ColumnaEliminarProveedor.Name = "ColumnaEliminarProveedor";
            // 
            // UC_Proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticoneTabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Proveedores";
            Size = new Size(1549, 945);
            siticoneTabControl1.ResumeLayout(false);
            Añadir.ResumeLayout(false);
            Añadir.PerformLayout();
            Editar.ResumeLayout(false);
            siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SDGVProveedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage Añadir;
        private TabPage Editar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView SDGVProveedor;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTelefono;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDirec;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtRUC;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNombreProv;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBAniadirProveedor;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private DataGridViewTextBoxColumn ColumnaRUC;
        private DataGridViewTextBoxColumn ColumnaNombreProv;
        private DataGridViewTextBoxColumn ColumnaDireccion;
        private DataGridViewTextBoxColumn ColumnaTelefono;
        private DataGridViewImageColumn ColumnaEditarProveedor;
        private DataGridViewImageColumn ColumnaEliminarProveedor;
    }
}
