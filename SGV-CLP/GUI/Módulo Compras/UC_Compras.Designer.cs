namespace SGV_CLP.GUI
{
    partial class UC_Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Compras));
            siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            TabRegistrar = new TabPage();
            siticoneTextBox3 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneTextBox2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneDateTimePicker1 = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            siticoneRadioButton2 = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            siticoneRadioButton1 = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            SBAniadirCompra = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            TabEditar = new TabPage();
            SDGVCompra = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            CodCompra = new DataGridViewTextBoxColumn();
            RUCProv = new DataGridViewTextBoxColumn();
            FechaCompra = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Descripción = new DataGridViewTextBoxColumn();
            ColumnaEditarCompra = new DataGridViewImageColumn();
            ColumnaEliminarCompra = new DataGridViewImageColumn();
            siticoneComboBox6 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneTextBox6 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneTabControl1.SuspendLayout();
            TabRegistrar.SuspendLayout();
            TabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SDGVCompra).BeginInit();
            SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            siticoneTabControl1.Alignment = TabAlignment.Left;
            siticoneTabControl1.Controls.Add(TabRegistrar);
            siticoneTabControl1.Controls.Add(TabEditar);
            siticoneTabControl1.Dock = DockStyle.Fill;
            siticoneTabControl1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.ItemSize = new Size(160, 75);
            siticoneTabControl1.Location = new Point(0, 0);
            siticoneTabControl1.Margin = new Padding(3, 4, 3, 4);
            siticoneTabControl1.Name = "siticoneTabControl1";
            siticoneTabControl1.SelectedIndex = 0;
            siticoneTabControl1.Size = new Size(1425, 953);
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
            // TabRegistrar
            // 
            TabRegistrar.Controls.Add(siticoneTextBox3);
            TabRegistrar.Controls.Add(siticoneHtmlLabel1);
            TabRegistrar.Controls.Add(siticoneTextBox2);
            TabRegistrar.Controls.Add(siticoneDateTimePicker1);
            TabRegistrar.Controls.Add(siticoneRadioButton2);
            TabRegistrar.Controls.Add(siticoneRadioButton1);
            TabRegistrar.Controls.Add(SBAniadirCompra);
            TabRegistrar.Controls.Add(siticoneHtmlLabel7);
            TabRegistrar.Controls.Add(siticoneHtmlLabel3);
            TabRegistrar.Controls.Add(siticoneHtmlLabel2);
            TabRegistrar.Controls.Add(siticoneTextBox1);
            TabRegistrar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabRegistrar.Location = new Point(164, 4);
            TabRegistrar.Margin = new Padding(3, 5, 3, 5);
            TabRegistrar.Name = "TabRegistrar";
            TabRegistrar.Padding = new Padding(3, 5, 3, 5);
            TabRegistrar.Size = new Size(1257, 945);
            TabRegistrar.TabIndex = 0;
            TabRegistrar.Text = "Registrar Compra";
            TabRegistrar.UseVisualStyleBackColor = true;
            // 
            // siticoneTextBox3
            // 
            siticoneTextBox3.Anchor = AnchorStyles.None;
            siticoneTextBox3.BorderRadius = 20;
            siticoneTextBox3.DefaultText = "";
            siticoneTextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            siticoneTextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            siticoneTextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            siticoneTextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            siticoneTextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneTextBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTextBox3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneTextBox3.Location = new Point(434, 448);
            siticoneTextBox3.Margin = new Padding(3, 7, 3, 7);
            siticoneTextBox3.Name = "siticoneTextBox3";
            siticoneTextBox3.PasswordChar = '\0';
            siticoneTextBox3.PlaceholderText = "";
            siticoneTextBox3.SelectedText = "";
            siticoneTextBox3.Size = new Size(311, 244);
            siticoneTextBox3.TabIndex = 29;
            siticoneTextBox3.TextOffset = new Point(5, 0);
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(259, 461);
            siticoneHtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(154, 34);
            siticoneHtmlLabel1.TabIndex = 28;
            siticoneHtmlLabel1.Text = "Descripción";
            // 
            // siticoneTextBox2
            // 
            siticoneTextBox2.Anchor = AnchorStyles.None;
            siticoneTextBox2.BorderRadius = 20;
            siticoneTextBox2.DefaultText = "";
            siticoneTextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            siticoneTextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            siticoneTextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            siticoneTextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            siticoneTextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneTextBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneTextBox2.Location = new Point(434, 352);
            siticoneTextBox2.Margin = new Padding(3, 7, 3, 7);
            siticoneTextBox2.Name = "siticoneTextBox2";
            siticoneTextBox2.PasswordChar = '\0';
            siticoneTextBox2.PlaceholderText = "";
            siticoneTextBox2.SelectedText = "";
            siticoneTextBox2.Size = new Size(229, 55);
            siticoneTextBox2.TabIndex = 26;
            siticoneTextBox2.TextOffset = new Point(5, 0);
            // 
            // siticoneDateTimePicker1
            // 
            siticoneDateTimePicker1.Anchor = AnchorStyles.None;
            siticoneDateTimePicker1.BorderRadius = 20;
            siticoneDateTimePicker1.Checked = true;
            siticoneDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            siticoneDateTimePicker1.FillColor = Color.White;
            siticoneDateTimePicker1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDateTimePicker1.Format = DateTimePickerFormat.Long;
            siticoneDateTimePicker1.Location = new Point(718, 304);
            siticoneDateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            siticoneDateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            siticoneDateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            siticoneDateTimePicker1.Name = "siticoneDateTimePicker1";
            siticoneDateTimePicker1.Size = new Size(229, 48);
            siticoneDateTimePicker1.TabIndex = 24;
            siticoneDateTimePicker1.TextOffset = new Point(5, 0);
            siticoneDateTimePicker1.Value = new DateTime(2023, 2, 6, 0, 0, 0, 0);
            siticoneDateTimePicker1.Visible = false;
            // 
            // siticoneRadioButton2
            // 
            siticoneRadioButton2.Anchor = AnchorStyles.None;
            siticoneRadioButton2.AutoSize = true;
            siticoneRadioButton2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneRadioButton2.CheckedState.BorderThickness = 0;
            siticoneRadioButton2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            siticoneRadioButton2.CheckedState.InnerColor = Color.White;
            siticoneRadioButton2.CheckedState.InnerOffset = -4;
            siticoneRadioButton2.Location = new Point(718, 253);
            siticoneRadioButton2.Margin = new Padding(3, 4, 3, 4);
            siticoneRadioButton2.Name = "siticoneRadioButton2";
            siticoneRadioButton2.Size = new Size(176, 34);
            siticoneRadioButton2.TabIndex = 23;
            siticoneRadioButton2.Text = "Elegir fecha";
            siticoneRadioButton2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            siticoneRadioButton2.UncheckedState.BorderThickness = 2;
            siticoneRadioButton2.UncheckedState.FillColor = Color.Transparent;
            siticoneRadioButton2.UncheckedState.InnerColor = Color.Transparent;
            siticoneRadioButton2.CheckedChanged += siticoneRadioButton2_CheckedChanged;
            // 
            // siticoneRadioButton1
            // 
            siticoneRadioButton1.Anchor = AnchorStyles.None;
            siticoneRadioButton1.AutoSize = true;
            siticoneRadioButton1.Checked = true;
            siticoneRadioButton1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneRadioButton1.CheckedState.BorderThickness = 0;
            siticoneRadioButton1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            siticoneRadioButton1.CheckedState.InnerColor = Color.White;
            siticoneRadioButton1.CheckedState.InnerOffset = -4;
            siticoneRadioButton1.Location = new Point(434, 253);
            siticoneRadioButton1.Margin = new Padding(3, 4, 3, 4);
            siticoneRadioButton1.Name = "siticoneRadioButton1";
            siticoneRadioButton1.Size = new Size(194, 34);
            siticoneRadioButton1.TabIndex = 22;
            siticoneRadioButton1.TabStop = true;
            siticoneRadioButton1.Text = "Fecha Actual";
            siticoneRadioButton1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            siticoneRadioButton1.UncheckedState.BorderThickness = 2;
            siticoneRadioButton1.UncheckedState.FillColor = Color.Transparent;
            siticoneRadioButton1.UncheckedState.InnerColor = Color.Transparent;
            siticoneRadioButton1.CheckedChanged += siticoneRadioButton1_CheckedChanged;
            // 
            // SBAniadirCompra
            // 
            SBAniadirCompra.Anchor = AnchorStyles.None;
            SBAniadirCompra.BorderRadius = 20;
            SBAniadirCompra.DisabledState.BorderColor = Color.DarkGray;
            SBAniadirCompra.DisabledState.CustomBorderColor = Color.DarkGray;
            SBAniadirCompra.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBAniadirCompra.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBAniadirCompra.FillColor = Color.Black;
            SBAniadirCompra.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBAniadirCompra.ForeColor = Color.White;
            SBAniadirCompra.Location = new Point(434, 777);
            SBAniadirCompra.Margin = new Padding(3, 5, 3, 5);
            SBAniadirCompra.Name = "SBAniadirCompra";
            SBAniadirCompra.Size = new Size(206, 60);
            SBAniadirCompra.TabIndex = 20;
            SBAniadirCompra.Text = "Aceptar";
            SBAniadirCompra.Click += SBAniadirCompraClick;
            // 
            // siticoneHtmlLabel7
            // 
            siticoneHtmlLabel7.Anchor = AnchorStyles.None;
            siticoneHtmlLabel7.BackColor = Color.Transparent;
            siticoneHtmlLabel7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel7.Location = new Point(259, 372);
            siticoneHtmlLabel7.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            siticoneHtmlLabel7.Size = new Size(76, 34);
            siticoneHtmlLabel7.TabIndex = 12;
            siticoneHtmlLabel7.Text = "Costo";
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.Anchor = AnchorStyles.None;
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(259, 283);
            siticoneHtmlLabel3.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(84, 34);
            siticoneHtmlLabel3.TabIndex = 4;
            siticoneHtmlLabel3.Text = "Fecha";
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.Anchor = AnchorStyles.None;
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(261, 176);
            siticoneHtmlLabel2.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(57, 34);
            siticoneHtmlLabel2.TabIndex = 2;
            siticoneHtmlLabel2.Text = "RUC";
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
            siticoneTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneTextBox1.Location = new Point(434, 169);
            siticoneTextBox1.Margin = new Padding(3, 7, 3, 7);
            siticoneTextBox1.Name = "siticoneTextBox1";
            siticoneTextBox1.PasswordChar = '\0';
            siticoneTextBox1.PlaceholderText = "";
            siticoneTextBox1.SelectedText = "";
            siticoneTextBox1.Size = new Size(229, 55);
            siticoneTextBox1.TabIndex = 0;
            siticoneTextBox1.TextOffset = new Point(5, 0);
            // 
            // TabEditar
            // 
            TabEditar.Controls.Add(SDGVCompra);
            TabEditar.Controls.Add(siticoneComboBox6);
            TabEditar.Controls.Add(siticoneTextBox6);
            TabEditar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabEditar.Location = new Point(164, 4);
            TabEditar.Margin = new Padding(3, 5, 3, 5);
            TabEditar.Name = "TabEditar";
            TabEditar.Padding = new Padding(3, 5, 3, 5);
            TabEditar.Size = new Size(1257, 945);
            TabEditar.TabIndex = 1;
            TabEditar.Text = "Editar/Eliminar Compra";
            TabEditar.UseVisualStyleBackColor = true;
            // 
            // SDGVCompra
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            SDGVCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SDGVCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SDGVCompra.ColumnHeadersHeight = 62;
            SDGVCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SDGVCompra.Columns.AddRange(new DataGridViewColumn[] { CodCompra, RUCProv, FechaCompra, Costo, Descripción, ColumnaEditarCompra, ColumnaEliminarCompra });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SDGVCompra.DefaultCellStyle = dataGridViewCellStyle3;
            SDGVCompra.Dock = DockStyle.Bottom;
            SDGVCompra.GridColor = Color.FromArgb(231, 229, 255);
            SDGVCompra.Location = new Point(3, 273);
            SDGVCompra.Margin = new Padding(3, 4, 3, 4);
            SDGVCompra.MaximumSize = new Size(0, 800);
            SDGVCompra.MinimumSize = new Size(0, 533);
            SDGVCompra.Name = "SDGVCompra";
            SDGVCompra.RowHeadersVisible = false;
            SDGVCompra.RowHeadersWidth = 50;
            SDGVCompra.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            SDGVCompra.RowTemplate.Height = 50;
            SDGVCompra.Size = new Size(1251, 667);
            SDGVCompra.TabIndex = 0;
            SDGVCompra.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SDGVCompra.ThemeStyle.AlternatingRowsStyle.Font = null;
            SDGVCompra.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SDGVCompra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SDGVCompra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SDGVCompra.ThemeStyle.BackColor = Color.White;
            SDGVCompra.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            SDGVCompra.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            SDGVCompra.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SDGVCompra.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SDGVCompra.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SDGVCompra.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SDGVCompra.ThemeStyle.HeaderStyle.Height = 62;
            SDGVCompra.ThemeStyle.ReadOnly = false;
            SDGVCompra.ThemeStyle.RowsStyle.BackColor = Color.White;
            SDGVCompra.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SDGVCompra.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SDGVCompra.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            SDGVCompra.ThemeStyle.RowsStyle.Height = 50;
            SDGVCompra.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            SDGVCompra.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            SDGVCompra.CellClick += SDGVCompra_CellClick;
            // 
            // CodCompra
            // 
            CodCompra.HeaderText = "Código de compra";
            CodCompra.MinimumWidth = 6;
            CodCompra.Name = "CodCompra";
            // 
            // RUCProv
            // 
            RUCProv.HeaderText = "RUC";
            RUCProv.MinimumWidth = 6;
            RUCProv.Name = "RUCProv";
            // 
            // FechaCompra
            // 
            FechaCompra.HeaderText = "Fecha de compra";
            FechaCompra.MinimumWidth = 6;
            FechaCompra.Name = "FechaCompra";
            // 
            // Costo
            // 
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            // 
            // Descripción
            // 
            Descripción.HeaderText = "Descripción";
            Descripción.MinimumWidth = 6;
            Descripción.Name = "Descripción";
            // 
            // ColumnaEditarCompra
            // 
            ColumnaEditarCompra.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnaEditarCompra.HeaderText = "";
            ColumnaEditarCompra.Image = (Image)resources.GetObject("ColumnaEditarCompra.Image");
            ColumnaEditarCompra.MinimumWidth = 6;
            ColumnaEditarCompra.Name = "ColumnaEditarCompra";
            ColumnaEditarCompra.Resizable = DataGridViewTriState.False;
            ColumnaEditarCompra.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnaEditarCompra.Width = 157;
            // 
            // ColumnaEliminarCompra
            // 
            ColumnaEliminarCompra.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnaEliminarCompra.HeaderText = "";
            ColumnaEliminarCompra.Image = (Image)resources.GetObject("ColumnaEliminarCompra.Image");
            ColumnaEliminarCompra.MinimumWidth = 6;
            ColumnaEliminarCompra.Name = "ColumnaEliminarCompra";
            ColumnaEliminarCompra.Resizable = DataGridViewTriState.False;
            ColumnaEliminarCompra.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnaEliminarCompra.Width = 156;
            // 
            // siticoneComboBox6
            // 
            siticoneComboBox6.Anchor = AnchorStyles.None;
            siticoneComboBox6.BackColor = Color.Transparent;
            siticoneComboBox6.BorderRadius = 20;
            siticoneComboBox6.DrawMode = DrawMode.OwnerDrawFixed;
            siticoneComboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            siticoneComboBox6.FocusedColor = Color.FromArgb(94, 148, 255);
            siticoneComboBox6.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneComboBox6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneComboBox6.ForeColor = Color.FromArgb(68, 88, 112);
            siticoneComboBox6.ItemHeight = 42;
            siticoneComboBox6.Items.AddRange(new object[] { "Código de compra", "RUC", "Fecha de compra", "Código de producto" });
            siticoneComboBox6.Location = new Point(633, 103);
            siticoneComboBox6.Margin = new Padding(3, 5, 3, 5);
            siticoneComboBox6.Name = "siticoneComboBox6";
            siticoneComboBox6.Size = new Size(269, 48);
            siticoneComboBox6.TabIndex = 20;
            // 
            // siticoneTextBox6
            // 
            siticoneTextBox6.Anchor = AnchorStyles.None;
            siticoneTextBox6.AutoSize = true;
            siticoneTextBox6.BorderRadius = 20;
            siticoneTextBox6.DefaultText = "";
            siticoneTextBox6.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            siticoneTextBox6.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            siticoneTextBox6.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            siticoneTextBox6.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            siticoneTextBox6.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneTextBox6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTextBox6.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneTextBox6.Location = new Point(275, 103);
            siticoneTextBox6.Margin = new Padding(3, 7, 3, 7);
            siticoneTextBox6.Name = "siticoneTextBox6";
            siticoneTextBox6.PasswordChar = '\0';
            siticoneTextBox6.PlaceholderText = "Buscar...";
            siticoneTextBox6.SelectedText = "";
            siticoneTextBox6.Size = new Size(331, 64);
            siticoneTextBox6.TabIndex = 19;
            // 
            // UC_Compras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticoneTabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Compras";
            Size = new Size(1425, 953);
            siticoneTabControl1.ResumeLayout(false);
            TabRegistrar.ResumeLayout(false);
            TabRegistrar.PerformLayout();
            TabEditar.ResumeLayout(false);
            TabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SDGVCompra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage TabRegistrar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBAniadirCompra;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private TabPage TabEditar;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView SDGVCompra;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker siticoneDateTimePicker1;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton siticoneRadioButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton siticoneRadioButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private DataGridViewTextBoxColumn CodCompra;
        private DataGridViewTextBoxColumn RUCProv;
        private DataGridViewTextBoxColumn FechaCompra;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewImageColumn ColumnaEditarCompra;
        private DataGridViewImageColumn ColumnaEliminarCompra;
    }
}
