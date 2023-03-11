namespace SGV_CLP.GUI
{
    partial class UC_Clientes
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Clientes));
            siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            TabRegistrar = new TabPage();
            siticoneHtmlLabel_correct_email = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_wrong_email = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtCorreoCliente = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel_correct_length_telef = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtPrimerNombreCliente = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel_wrong_length_telef = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_cc_correct_length = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            Button_aniadirCliente = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel_cc_valida = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_cc_invalida = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtDireccionCliente = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel_cc_wrong_length = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel14 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtCedulaCliente = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtSegundoNombreCliente = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel12 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtSegundoApellidoCliente = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel13 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtTelefonoCliente = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel16 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtPrimerApellidoCliente = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel17 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            TabEditar = new TabPage();
            siticoneHtmlLabel_buscarCliente_sin_campo = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneComboBox_EliminarEditarCliente = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            txtBuscarClientePor = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            ColumnaCedula = new DataGridViewTextBoxColumn();
            ColumnaNombres = new DataGridViewTextBoxColumn();
            ColumnaApellidos = new DataGridViewTextBoxColumn();
            ColumnaDireccion = new DataGridViewTextBoxColumn();
            ColumnaTelefono = new DataGridViewTextBoxColumn();
            ColumnaCorreo = new DataGridViewTextBoxColumn();
            ColumnaEditar = new DataGridViewImageColumn();
            ColumnaEliminar = new DataGridViewImageColumn();
            siticoneTabControl1.SuspendLayout();
            TabRegistrar.SuspendLayout();
            TabEditar.SuspendLayout();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)siticoneDataGridView1).BeginInit();
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
            siticoneTabControl1.Size = new Size(1653, 1127);
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
            TabRegistrar.Controls.Add(siticoneHtmlLabel_correct_email);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_wrong_email);
            TabRegistrar.Controls.Add(siticoneHtmlLabel2);
            TabRegistrar.Controls.Add(txtCorreoCliente);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_correct_length_telef);
            TabRegistrar.Controls.Add(txtPrimerNombreCliente);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_wrong_length_telef);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_cc_correct_length);
            TabRegistrar.Controls.Add(Button_aniadirCliente);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_cc_valida);
            TabRegistrar.Controls.Add(siticoneHtmlLabel3);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_cc_invalida);
            TabRegistrar.Controls.Add(txtDireccionCliente);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_cc_wrong_length);
            TabRegistrar.Controls.Add(siticoneHtmlLabel14);
            TabRegistrar.Controls.Add(siticoneHtmlLabel4);
            TabRegistrar.Controls.Add(txtCedulaCliente);
            TabRegistrar.Controls.Add(txtSegundoNombreCliente);
            TabRegistrar.Controls.Add(siticoneHtmlLabel12);
            TabRegistrar.Controls.Add(txtSegundoApellidoCliente);
            TabRegistrar.Controls.Add(siticoneHtmlLabel13);
            TabRegistrar.Controls.Add(txtTelefonoCliente);
            TabRegistrar.Controls.Add(siticoneHtmlLabel16);
            TabRegistrar.Controls.Add(siticoneHtmlLabel1);
            TabRegistrar.Controls.Add(txtPrimerApellidoCliente);
            TabRegistrar.Controls.Add(siticoneHtmlLabel17);
            TabRegistrar.Controls.Add(siticoneHtmlLabel7);
            TabRegistrar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabRegistrar.Location = new Point(164, 4);
            TabRegistrar.Margin = new Padding(3, 5, 3, 5);
            TabRegistrar.Name = "TabRegistrar";
            TabRegistrar.Padding = new Padding(3, 5, 3, 5);
            TabRegistrar.Size = new Size(1485, 1119);
            TabRegistrar.TabIndex = 0;
            TabRegistrar.Text = "Registrar Cliente";
            TabRegistrar.UseVisualStyleBackColor = true;
            // 
            // siticoneHtmlLabel_correct_email
            // 
            siticoneHtmlLabel_correct_email.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_correct_email.BackColor = Color.Transparent;
            siticoneHtmlLabel_correct_email.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_correct_email.ForeColor = Color.SpringGreen;
            siticoneHtmlLabel_correct_email.Location = new Point(1118, 691);
            siticoneHtmlLabel_correct_email.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_correct_email.Name = "siticoneHtmlLabel_correct_email";
            siticoneHtmlLabel_correct_email.Size = new Size(93, 22);
            siticoneHtmlLabel_correct_email.TabIndex = 85;
            siticoneHtmlLabel_correct_email.Text = "¡Email válido!";
            // 
            // siticoneHtmlLabel_wrong_email
            // 
            siticoneHtmlLabel_wrong_email.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_wrong_email.BackColor = Color.Transparent;
            siticoneHtmlLabel_wrong_email.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_wrong_email.ForeColor = Color.Red;
            siticoneHtmlLabel_wrong_email.Location = new Point(1118, 691);
            siticoneHtmlLabel_wrong_email.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_wrong_email.Name = "siticoneHtmlLabel_wrong_email";
            siticoneHtmlLabel_wrong_email.Size = new Size(105, 22);
            siticoneHtmlLabel_wrong_email.TabIndex = 84;
            siticoneHtmlLabel_wrong_email.Text = "¡Email inválido!";
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.Anchor = AnchorStyles.None;
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(349, 679);
            siticoneHtmlLabel2.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(75, 34);
            siticoneHtmlLabel2.TabIndex = 62;
            siticoneHtmlLabel2.Text = "eMail";
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Anchor = AnchorStyles.None;
            txtCorreoCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtCorreoCliente.BorderRadius = 20;
            txtCorreoCliente.DefaultText = "";
            txtCorreoCliente.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCorreoCliente.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCorreoCliente.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCorreoCliente.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCorreoCliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCorreoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreoCliente.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCorreoCliente.Location = new Point(510, 665);
            txtCorreoCliente.Margin = new Padding(3, 8, 3, 8);
            txtCorreoCliente.MinimumSize = new Size(229, 60);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.PasswordChar = '\0';
            txtCorreoCliente.PlaceholderText = "";
            txtCorreoCliente.SelectedText = "";
            txtCorreoCliente.Size = new Size(583, 60);
            txtCorreoCliente.TabIndex = 61;
            txtCorreoCliente.TextOffset = new Point(5, 0);
            txtCorreoCliente.TextChanged += txtCorreoCliente_TextChanged;
            txtCorreoCliente.KeyPress += txtCorreoCliente_KeyPress;
            // 
            // siticoneHtmlLabel_correct_length_telef
            // 
            siticoneHtmlLabel_correct_length_telef.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_correct_length_telef.BackColor = Color.Transparent;
            siticoneHtmlLabel_correct_length_telef.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_correct_length_telef.ForeColor = Color.SpringGreen;
            siticoneHtmlLabel_correct_length_telef.Location = new Point(752, 778);
            siticoneHtmlLabel_correct_length_telef.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel_correct_length_telef.Name = "siticoneHtmlLabel_correct_length_telef";
            siticoneHtmlLabel_correct_length_telef.Size = new Size(128, 22);
            siticoneHtmlLabel_correct_length_telef.TabIndex = 60;
            siticoneHtmlLabel_correct_length_telef.Text = "¡Longitud correcta!";
            // 
            // txtPrimerNombreCliente
            // 
            txtPrimerNombreCliente.Anchor = AnchorStyles.None;
            txtPrimerNombreCliente.AutoSize = true;
            txtPrimerNombreCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtPrimerNombreCliente.BorderRadius = 20;
            txtPrimerNombreCliente.DefaultText = "";
            txtPrimerNombreCliente.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrimerNombreCliente.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrimerNombreCliente.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrimerNombreCliente.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrimerNombreCliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrimerNombreCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerNombreCliente.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrimerNombreCliente.Location = new Point(510, 321);
            txtPrimerNombreCliente.Margin = new Padding(3, 8, 3, 8);
            txtPrimerNombreCliente.MaxLength = 50;
            txtPrimerNombreCliente.MinimumSize = new Size(229, 60);
            txtPrimerNombreCliente.Name = "txtPrimerNombreCliente";
            txtPrimerNombreCliente.PasswordChar = '\0';
            txtPrimerNombreCliente.PlaceholderText = "";
            txtPrimerNombreCliente.SelectedText = "";
            txtPrimerNombreCliente.Size = new Size(229, 60);
            txtPrimerNombreCliente.TabIndex = 44;
            txtPrimerNombreCliente.TextOffset = new Point(5, 0);
            txtPrimerNombreCliente.TextChanged += txtPrimerNombreCliente_TextChanged;
            txtPrimerNombreCliente.KeyPress += txtPrimerNombreCliente_KeyPress;
            // 
            // siticoneHtmlLabel_wrong_length_telef
            // 
            siticoneHtmlLabel_wrong_length_telef.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_wrong_length_telef.BackColor = Color.Transparent;
            siticoneHtmlLabel_wrong_length_telef.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_wrong_length_telef.ForeColor = Color.Red;
            siticoneHtmlLabel_wrong_length_telef.Location = new Point(752, 778);
            siticoneHtmlLabel_wrong_length_telef.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel_wrong_length_telef.Name = "siticoneHtmlLabel_wrong_length_telef";
            siticoneHtmlLabel_wrong_length_telef.Size = new Size(160, 22);
            siticoneHtmlLabel_wrong_length_telef.TabIndex = 59;
            siticoneHtmlLabel_wrong_length_telef.Text = "¡Se necesitan 10 caract.!";
            // 
            // siticoneHtmlLabel_cc_correct_length
            // 
            siticoneHtmlLabel_cc_correct_length.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_cc_correct_length.BackColor = Color.Transparent;
            siticoneHtmlLabel_cc_correct_length.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_cc_correct_length.ForeColor = Color.SpringGreen;
            siticoneHtmlLabel_cc_correct_length.Location = new Point(754, 246);
            siticoneHtmlLabel_cc_correct_length.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_cc_correct_length.Name = "siticoneHtmlLabel_cc_correct_length";
            siticoneHtmlLabel_cc_correct_length.Size = new Size(128, 22);
            siticoneHtmlLabel_cc_correct_length.TabIndex = 57;
            siticoneHtmlLabel_cc_correct_length.Text = "¡Longitud correcta!";
            // 
            // Button_aniadirCliente
            // 
            Button_aniadirCliente.Anchor = AnchorStyles.Bottom;
            Button_aniadirCliente.BorderRadius = 20;
            Button_aniadirCliente.DisabledState.BorderColor = Color.DarkGray;
            Button_aniadirCliente.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_aniadirCliente.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_aniadirCliente.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_aniadirCliente.FillColor = Color.Black;
            Button_aniadirCliente.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Button_aniadirCliente.ForeColor = Color.White;
            Button_aniadirCliente.Location = new Point(640, 947);
            Button_aniadirCliente.Margin = new Padding(3, 5, 3, 5);
            Button_aniadirCliente.Name = "Button_aniadirCliente";
            Button_aniadirCliente.Size = new Size(206, 60);
            Button_aniadirCliente.TabIndex = 39;
            Button_aniadirCliente.Text = "Añadir";
            Button_aniadirCliente.Click += registrarCliente;
            // 
            // siticoneHtmlLabel_cc_valida
            // 
            siticoneHtmlLabel_cc_valida.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_cc_valida.BackColor = Color.Transparent;
            siticoneHtmlLabel_cc_valida.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_cc_valida.ForeColor = Color.SpringGreen;
            siticoneHtmlLabel_cc_valida.Location = new Point(754, 208);
            siticoneHtmlLabel_cc_valida.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_cc_valida.Name = "siticoneHtmlLabel_cc_valida";
            siticoneHtmlLabel_cc_valida.Size = new Size(101, 22);
            siticoneHtmlLabel_cc_valida.TabIndex = 56;
            siticoneHtmlLabel_cc_valida.Text = "¡Cédula válida!";
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.Anchor = AnchorStyles.None;
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(349, 223);
            siticoneHtmlLabel3.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(99, 34);
            siticoneHtmlLabel3.TabIndex = 24;
            siticoneHtmlLabel3.Text = "Cédula";
            // 
            // siticoneHtmlLabel_cc_invalida
            // 
            siticoneHtmlLabel_cc_invalida.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_cc_invalida.BackColor = Color.Transparent;
            siticoneHtmlLabel_cc_invalida.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_cc_invalida.ForeColor = Color.Red;
            siticoneHtmlLabel_cc_invalida.Location = new Point(754, 208);
            siticoneHtmlLabel_cc_invalida.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_cc_invalida.Name = "siticoneHtmlLabel_cc_invalida";
            siticoneHtmlLabel_cc_invalida.Size = new Size(113, 22);
            siticoneHtmlLabel_cc_invalida.TabIndex = 55;
            siticoneHtmlLabel_cc_invalida.Text = "¡Cédula inválida!";
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Anchor = AnchorStyles.None;
            txtDireccionCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtDireccionCliente.BorderRadius = 20;
            txtDireccionCliente.DefaultText = "";
            txtDireccionCliente.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDireccionCliente.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDireccionCliente.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDireccionCliente.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDireccionCliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDireccionCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccionCliente.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDireccionCliente.Location = new Point(510, 551);
            txtDireccionCliente.Margin = new Padding(3, 8, 3, 8);
            txtDireccionCliente.MinimumSize = new Size(229, 60);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.PasswordChar = '\0';
            txtDireccionCliente.PlaceholderText = "";
            txtDireccionCliente.SelectedText = "";
            txtDireccionCliente.Size = new Size(583, 60);
            txtDireccionCliente.TabIndex = 42;
            txtDireccionCliente.TextOffset = new Point(5, 0);
            txtDireccionCliente.TextChanged += txtDireccionCliente_TextChanged;
            txtDireccionCliente.KeyPress += txtDireccionCliente_KeyPress;
            // 
            // siticoneHtmlLabel_cc_wrong_length
            // 
            siticoneHtmlLabel_cc_wrong_length.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_cc_wrong_length.BackColor = Color.Transparent;
            siticoneHtmlLabel_cc_wrong_length.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_cc_wrong_length.ForeColor = Color.Red;
            siticoneHtmlLabel_cc_wrong_length.Location = new Point(752, 246);
            siticoneHtmlLabel_cc_wrong_length.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_cc_wrong_length.Name = "siticoneHtmlLabel_cc_wrong_length";
            siticoneHtmlLabel_cc_wrong_length.Size = new Size(160, 22);
            siticoneHtmlLabel_cc_wrong_length.TabIndex = 54;
            siticoneHtmlLabel_cc_wrong_length.Text = "¡Se necesitan 10 caract.!";
            // 
            // siticoneHtmlLabel14
            // 
            siticoneHtmlLabel14.Anchor = AnchorStyles.None;
            siticoneHtmlLabel14.BackColor = Color.Transparent;
            siticoneHtmlLabel14.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel14.Location = new Point(517, 296);
            siticoneHtmlLabel14.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel14.Name = "siticoneHtmlLabel14";
            siticoneHtmlLabel14.Size = new Size(109, 22);
            siticoneHtmlLabel14.TabIndex = 50;
            siticoneHtmlLabel14.Text = "Primer nombre";
            // 
            // siticoneHtmlLabel4
            // 
            siticoneHtmlLabel4.Anchor = AnchorStyles.None;
            siticoneHtmlLabel4.BackColor = Color.Transparent;
            siticoneHtmlLabel4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel4.Location = new Point(875, 412);
            siticoneHtmlLabel4.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            siticoneHtmlLabel4.Size = new Size(131, 22);
            siticoneHtmlLabel4.TabIndex = 53;
            siticoneHtmlLabel4.Text = "Segundo apellido";
            // 
            // txtCedulaCliente
            // 
            txtCedulaCliente.Anchor = AnchorStyles.None;
            txtCedulaCliente.AutoSize = true;
            txtCedulaCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtCedulaCliente.BorderRadius = 20;
            txtCedulaCliente.DefaultText = "";
            txtCedulaCliente.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCedulaCliente.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCedulaCliente.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCedulaCliente.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCedulaCliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCedulaCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCedulaCliente.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCedulaCliente.Location = new Point(510, 208);
            txtCedulaCliente.Margin = new Padding(3, 8, 3, 8);
            txtCedulaCliente.MinimumSize = new Size(229, 60);
            txtCedulaCliente.Name = "txtCedulaCliente";
            txtCedulaCliente.PasswordChar = '\0';
            txtCedulaCliente.PlaceholderText = "";
            txtCedulaCliente.SelectedText = "";
            txtCedulaCliente.Size = new Size(229, 60);
            txtCedulaCliente.TabIndex = 40;
            txtCedulaCliente.TextOffset = new Point(5, 0);
            txtCedulaCliente.TextChanged += txtCedulaCliente_TextChanged;
            txtCedulaCliente.KeyPress += txtCedulaCliente_KeyPress;
            txtCedulaCliente.KeyUp += txtCedulaCliente_KeyUp;
            // 
            // txtSegundoNombreCliente
            // 
            txtSegundoNombreCliente.Anchor = AnchorStyles.None;
            txtSegundoNombreCliente.AutoSize = true;
            txtSegundoNombreCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtSegundoNombreCliente.BorderRadius = 20;
            txtSegundoNombreCliente.DefaultText = "";
            txtSegundoNombreCliente.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSegundoNombreCliente.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSegundoNombreCliente.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSegundoNombreCliente.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSegundoNombreCliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSegundoNombreCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoNombreCliente.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSegundoNombreCliente.Location = new Point(864, 321);
            txtSegundoNombreCliente.Margin = new Padding(3, 8, 3, 8);
            txtSegundoNombreCliente.MaxLength = 50;
            txtSegundoNombreCliente.MinimumSize = new Size(229, 60);
            txtSegundoNombreCliente.Name = "txtSegundoNombreCliente";
            txtSegundoNombreCliente.PasswordChar = '\0';
            txtSegundoNombreCliente.PlaceholderText = "";
            txtSegundoNombreCliente.SelectedText = "";
            txtSegundoNombreCliente.Size = new Size(229, 60);
            txtSegundoNombreCliente.TabIndex = 48;
            txtSegundoNombreCliente.TextOffset = new Point(5, 0);
            txtSegundoNombreCliente.KeyPress += txtSegundoNombreCliente_KeyPress;
            // 
            // siticoneHtmlLabel12
            // 
            siticoneHtmlLabel12.Anchor = AnchorStyles.None;
            siticoneHtmlLabel12.BackColor = Color.Transparent;
            siticoneHtmlLabel12.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel12.Location = new Point(517, 412);
            siticoneHtmlLabel12.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel12.Name = "siticoneHtmlLabel12";
            siticoneHtmlLabel12.Size = new Size(111, 22);
            siticoneHtmlLabel12.TabIndex = 52;
            siticoneHtmlLabel12.Text = "Primer apellido";
            // 
            // txtSegundoApellidoCliente
            // 
            txtSegundoApellidoCliente.Anchor = AnchorStyles.None;
            txtSegundoApellidoCliente.AutoSize = true;
            txtSegundoApellidoCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtSegundoApellidoCliente.BorderRadius = 20;
            txtSegundoApellidoCliente.DefaultText = "";
            txtSegundoApellidoCliente.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSegundoApellidoCliente.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSegundoApellidoCliente.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSegundoApellidoCliente.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSegundoApellidoCliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSegundoApellidoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoApellidoCliente.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSegundoApellidoCliente.Location = new Point(864, 437);
            txtSegundoApellidoCliente.Margin = new Padding(3, 8, 3, 8);
            txtSegundoApellidoCliente.MinimumSize = new Size(229, 60);
            txtSegundoApellidoCliente.Name = "txtSegundoApellidoCliente";
            txtSegundoApellidoCliente.PasswordChar = '\0';
            txtSegundoApellidoCliente.PlaceholderText = "";
            txtSegundoApellidoCliente.SelectedText = "";
            txtSegundoApellidoCliente.Size = new Size(229, 60);
            txtSegundoApellidoCliente.TabIndex = 49;
            txtSegundoApellidoCliente.TextOffset = new Point(5, 0);
            txtSegundoApellidoCliente.KeyPress += txtSegundoApellidoCliente_KeyPress;
            // 
            // siticoneHtmlLabel13
            // 
            siticoneHtmlLabel13.Anchor = AnchorStyles.None;
            siticoneHtmlLabel13.BackColor = Color.Transparent;
            siticoneHtmlLabel13.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel13.Location = new Point(875, 296);
            siticoneHtmlLabel13.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel13.Name = "siticoneHtmlLabel13";
            siticoneHtmlLabel13.Size = new Size(129, 22);
            siticoneHtmlLabel13.TabIndex = 51;
            siticoneHtmlLabel13.Text = "Segundo nombre";
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Anchor = AnchorStyles.None;
            txtTelefonoCliente.AutoSize = true;
            txtTelefonoCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtTelefonoCliente.BorderRadius = 20;
            txtTelefonoCliente.DefaultText = "09";
            txtTelefonoCliente.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTelefonoCliente.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTelefonoCliente.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTelefonoCliente.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTelefonoCliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefonoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefonoCliente.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefonoCliente.Location = new Point(510, 778);
            txtTelefonoCliente.Margin = new Padding(3, 8, 3, 8);
            txtTelefonoCliente.MinimumSize = new Size(229, 60);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.PasswordChar = '\0';
            txtTelefonoCliente.PlaceholderText = "";
            txtTelefonoCliente.SelectedText = "";
            txtTelefonoCliente.SelectionStart = 2;
            txtTelefonoCliente.Size = new Size(229, 60);
            txtTelefonoCliente.TabIndex = 43;
            txtTelefonoCliente.TextOffset = new Point(5, 0);
            txtTelefonoCliente.TextChanged += txtTelefonoCliente_TextChanged;
            txtTelefonoCliente.KeyPress += txtTelefonoCliente_KeyPress;
            // 
            // siticoneHtmlLabel16
            // 
            siticoneHtmlLabel16.Anchor = AnchorStyles.None;
            siticoneHtmlLabel16.BackColor = Color.Transparent;
            siticoneHtmlLabel16.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel16.Location = new Point(349, 449);
            siticoneHtmlLabel16.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel16.Name = "siticoneHtmlLabel16";
            siticoneHtmlLabel16.Size = new Size(110, 34);
            siticoneHtmlLabel16.TabIndex = 47;
            siticoneHtmlLabel16.Text = "Apellido";
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(349, 565);
            siticoneHtmlLabel1.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(126, 34);
            siticoneHtmlLabel1.TabIndex = 41;
            siticoneHtmlLabel1.Text = "Dirección";
            // 
            // txtPrimerApellidoCliente
            // 
            txtPrimerApellidoCliente.Anchor = AnchorStyles.None;
            txtPrimerApellidoCliente.AutoSize = true;
            txtPrimerApellidoCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtPrimerApellidoCliente.BorderRadius = 20;
            txtPrimerApellidoCliente.DefaultText = "";
            txtPrimerApellidoCliente.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrimerApellidoCliente.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrimerApellidoCliente.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrimerApellidoCliente.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrimerApellidoCliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrimerApellidoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerApellidoCliente.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrimerApellidoCliente.Location = new Point(510, 437);
            txtPrimerApellidoCliente.Margin = new Padding(3, 8, 3, 8);
            txtPrimerApellidoCliente.MinimumSize = new Size(229, 60);
            txtPrimerApellidoCliente.Name = "txtPrimerApellidoCliente";
            txtPrimerApellidoCliente.PasswordChar = '\0';
            txtPrimerApellidoCliente.PlaceholderText = "";
            txtPrimerApellidoCliente.SelectedText = "";
            txtPrimerApellidoCliente.Size = new Size(229, 60);
            txtPrimerApellidoCliente.TabIndex = 46;
            txtPrimerApellidoCliente.TextOffset = new Point(5, 0);
            txtPrimerApellidoCliente.TextChanged += txtPrimerApellidoCliente_TextChanged;
            txtPrimerApellidoCliente.KeyPress += txtPrimerApellidoCliente_KeyPress;
            // 
            // siticoneHtmlLabel17
            // 
            siticoneHtmlLabel17.Anchor = AnchorStyles.None;
            siticoneHtmlLabel17.BackColor = Color.Transparent;
            siticoneHtmlLabel17.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel17.Location = new Point(349, 334);
            siticoneHtmlLabel17.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel17.Name = "siticoneHtmlLabel17";
            siticoneHtmlLabel17.Size = new Size(106, 34);
            siticoneHtmlLabel17.TabIndex = 45;
            siticoneHtmlLabel17.Text = "Nombre";
            // 
            // siticoneHtmlLabel7
            // 
            siticoneHtmlLabel7.Anchor = AnchorStyles.None;
            siticoneHtmlLabel7.BackColor = Color.Transparent;
            siticoneHtmlLabel7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel7.Location = new Point(349, 786);
            siticoneHtmlLabel7.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            siticoneHtmlLabel7.Size = new Size(112, 34);
            siticoneHtmlLabel7.TabIndex = 31;
            siticoneHtmlLabel7.Text = "Teléfono";
            // 
            // TabEditar
            // 
            TabEditar.Controls.Add(siticoneHtmlLabel_buscarCliente_sin_campo);
            TabEditar.Controls.Add(siticoneComboBox_EliminarEditarCliente);
            TabEditar.Controls.Add(txtBuscarClientePor);
            TabEditar.Controls.Add(siticonePanel1);
            TabEditar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabEditar.Location = new Point(164, 4);
            TabEditar.Margin = new Padding(3, 5, 3, 5);
            TabEditar.Name = "TabEditar";
            TabEditar.Padding = new Padding(3, 5, 3, 5);
            TabEditar.Size = new Size(1485, 1119);
            TabEditar.TabIndex = 1;
            TabEditar.Text = "Editar/Eliminar Cliente";
            TabEditar.UseVisualStyleBackColor = true;
            // 
            // siticoneHtmlLabel_buscarCliente_sin_campo
            // 
            siticoneHtmlLabel_buscarCliente_sin_campo.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_buscarCliente_sin_campo.BackColor = Color.Transparent;
            siticoneHtmlLabel_buscarCliente_sin_campo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_buscarCliente_sin_campo.ForeColor = Color.Red;
            siticoneHtmlLabel_buscarCliente_sin_campo.Location = new Point(373, 176);
            siticoneHtmlLabel_buscarCliente_sin_campo.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_buscarCliente_sin_campo.Name = "siticoneHtmlLabel_buscarCliente_sin_campo";
            siticoneHtmlLabel_buscarCliente_sin_campo.Size = new Size(152, 22);
            siticoneHtmlLabel_buscarCliente_sin_campo.TabIndex = 19;
            siticoneHtmlLabel_buscarCliente_sin_campo.Text = "¡Seleccione un campo!";
            // 
            // siticoneComboBox_EliminarEditarCliente
            // 
            siticoneComboBox_EliminarEditarCliente.Anchor = AnchorStyles.None;
            siticoneComboBox_EliminarEditarCliente.BackColor = Color.Transparent;
            siticoneComboBox_EliminarEditarCliente.BorderRadius = 20;
            siticoneComboBox_EliminarEditarCliente.DrawMode = DrawMode.OwnerDrawFixed;
            siticoneComboBox_EliminarEditarCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            siticoneComboBox_EliminarEditarCliente.FocusedColor = Color.FromArgb(94, 148, 255);
            siticoneComboBox_EliminarEditarCliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneComboBox_EliminarEditarCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneComboBox_EliminarEditarCliente.ForeColor = Color.FromArgb(68, 88, 112);
            siticoneComboBox_EliminarEditarCliente.ItemHeight = 40;
            siticoneComboBox_EliminarEditarCliente.Items.AddRange(new object[] { "CI", "Nombres", "Apellidos", "Teléfono" });
            siticoneComboBox_EliminarEditarCliente.Location = new Point(719, 221);
            siticoneComboBox_EliminarEditarCliente.Margin = new Padding(3, 5, 3, 5);
            siticoneComboBox_EliminarEditarCliente.MinimumSize = new Size(228, 0);
            siticoneComboBox_EliminarEditarCliente.Name = "siticoneComboBox_EliminarEditarCliente";
            siticoneComboBox_EliminarEditarCliente.Size = new Size(314, 46);
            siticoneComboBox_EliminarEditarCliente.TabIndex = 16;
            siticoneComboBox_EliminarEditarCliente.TextOffset = new Point(5, 0);
            siticoneComboBox_EliminarEditarCliente.SelectedIndexChanged += siticoneComboBox_EliminarEditarCliente_SelectedIndexChanged;
            // 
            // txtBuscarClientePor
            // 
            txtBuscarClientePor.Anchor = AnchorStyles.None;
            txtBuscarClientePor.BorderRadius = 20;
            txtBuscarClientePor.DefaultText = "";
            txtBuscarClientePor.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscarClientePor.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscarClientePor.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarClientePor.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarClientePor.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarClientePor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarClientePor.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarClientePor.Location = new Point(373, 221);
            txtBuscarClientePor.Margin = new Padding(3, 7, 3, 7);
            txtBuscarClientePor.MinimumSize = new Size(286, 47);
            txtBuscarClientePor.Name = "txtBuscarClientePor";
            txtBuscarClientePor.PasswordChar = '\0';
            txtBuscarClientePor.PlaceholderText = "Buscar...";
            txtBuscarClientePor.SelectedText = "";
            txtBuscarClientePor.Size = new Size(312, 61);
            txtBuscarClientePor.TabIndex = 15;
            txtBuscarClientePor.TextOffset = new Point(5, 0);
            txtBuscarClientePor.KeyPress += txtBuscarClientePor_KeyPress;
            // 
            // siticonePanel1
            // 
            siticonePanel1.Controls.Add(siticoneDataGridView1);
            siticonePanel1.Dock = DockStyle.Bottom;
            siticonePanel1.Location = new Point(3, 447);
            siticonePanel1.Margin = new Padding(3, 5, 3, 5);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(1479, 667);
            siticonePanel1.TabIndex = 1;
            // 
            // siticoneDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            siticoneDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            siticoneDataGridView1.ColumnHeadersHeight = 60;
            siticoneDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            siticoneDataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaCedula, ColumnaNombres, ColumnaApellidos, ColumnaDireccion, ColumnaTelefono, ColumnaCorreo, ColumnaEditar, ColumnaEliminar });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            siticoneDataGridView1.Dock = DockStyle.Fill;
            siticoneDataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            siticoneDataGridView1.Location = new Point(0, 0);
            siticoneDataGridView1.Margin = new Padding(3, 4, 3, 4);
            siticoneDataGridView1.Name = "siticoneDataGridView1";
            siticoneDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            siticoneDataGridView1.RowHeadersVisible = false;
            siticoneDataGridView1.RowHeadersWidth = 50;
            siticoneDataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(231, 229, 255);
            siticoneDataGridView1.RowTemplate.DividerHeight = 15;
            siticoneDataGridView1.RowTemplate.Height = 50;
            siticoneDataGridView1.Size = new Size(1479, 667);
            siticoneDataGridView1.TabIndex = 0;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 60;
            siticoneDataGridView1.ThemeStyle.ReadOnly = false;
            siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 50;
            siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            siticoneDataGridView1.CellClick += siticoneDataGridView1_CellClick;
            // 
            // ColumnaCedula
            // 
            ColumnaCedula.HeaderText = "CI";
            ColumnaCedula.MinimumWidth = 6;
            ColumnaCedula.Name = "ColumnaCedula";
            ColumnaCedula.ReadOnly = true;
            ColumnaCedula.Resizable = DataGridViewTriState.True;
            ColumnaCedula.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaNombres
            // 
            ColumnaNombres.HeaderText = "Nombres";
            ColumnaNombres.MinimumWidth = 6;
            ColumnaNombres.Name = "ColumnaNombres";
            ColumnaNombres.ReadOnly = true;
            ColumnaNombres.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaApellidos
            // 
            ColumnaApellidos.HeaderText = "Apellidos";
            ColumnaApellidos.MinimumWidth = 6;
            ColumnaApellidos.Name = "ColumnaApellidos";
            ColumnaApellidos.ReadOnly = true;
            ColumnaApellidos.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaDireccion
            // 
            ColumnaDireccion.HeaderText = "Dirección";
            ColumnaDireccion.MinimumWidth = 6;
            ColumnaDireccion.Name = "ColumnaDireccion";
            ColumnaDireccion.ReadOnly = true;
            ColumnaDireccion.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaTelefono
            // 
            ColumnaTelefono.HeaderText = "Teléfono";
            ColumnaTelefono.MinimumWidth = 6;
            ColumnaTelefono.Name = "ColumnaTelefono";
            ColumnaTelefono.ReadOnly = true;
            ColumnaTelefono.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaCorreo
            // 
            ColumnaCorreo.HeaderText = "Correo Electrónico";
            ColumnaCorreo.MinimumWidth = 6;
            ColumnaCorreo.Name = "ColumnaCorreo";
            // 
            // ColumnaEditar
            // 
            ColumnaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new Padding(5);
            ColumnaEditar.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnaEditar.HeaderText = "";
            ColumnaEditar.Image = (Image)resources.GetObject("ColumnaEditar.Image");
            ColumnaEditar.MinimumWidth = 45;
            ColumnaEditar.Name = "ColumnaEditar";
            ColumnaEditar.Resizable = DataGridViewTriState.False;
            ColumnaEditar.Width = 45;
            // 
            // ColumnaEliminar
            // 
            ColumnaEliminar.HeaderText = "";
            ColumnaEliminar.Image = (Image)resources.GetObject("ColumnaEliminar.Image");
            ColumnaEliminar.MinimumWidth = 45;
            ColumnaEliminar.Name = "ColumnaEliminar";
            ColumnaEliminar.Resizable = DataGridViewTriState.True;
            // 
            // UC_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticoneTabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Clientes";
            Size = new Size(1653, 1127);
            siticoneTabControl1.ResumeLayout(false);
            TabRegistrar.ResumeLayout(false);
            TabRegistrar.PerformLayout();
            TabEditar.ResumeLayout(false);
            TabEditar.PerformLayout();
            siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)siticoneDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage TabRegistrar;
        private TabPage TabEditar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTelefonoCliente;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDireccionCliente;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCedulaCliente;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Button_aniadirCliente;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox_EliminarEditarCliente;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtBuscarClientePor;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel12;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel13;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel14;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSegundoApellidoCliente;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSegundoNombreCliente;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel16;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPrimerApellidoCliente;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel17;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPrimerNombreCliente;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_cc_correct_length;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_cc_valida;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_cc_invalida;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_cc_wrong_length;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_correct_length_telef;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_wrong_length_telef;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_buscarCliente_sin_campo;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCorreoCliente;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_correct_email;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_wrong_email;
        private DataGridViewTextBoxColumn ColumnaCedula;
        private DataGridViewTextBoxColumn ColumnaNombres;
        private DataGridViewTextBoxColumn ColumnaApellidos;
        private DataGridViewTextBoxColumn ColumnaDireccion;
        private DataGridViewTextBoxColumn ColumnaTelefono;
        private DataGridViewTextBoxColumn ColumnaCorreo;
        private DataGridViewImageColumn ColumnaEditar;
        private DataGridViewImageColumn ColumnaEliminar;
    }
}
