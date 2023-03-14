namespace SGV_CLP.GUI
{
    partial class UC_Customer
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customer));
            siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            TabRegistrar = new TabPage();
            labelValidPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_invalid_telef = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCorrectEMail = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_wrong_email = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbEMail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            labelCorrectPhoneNumberLength = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbFirstName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel_wrong_length_telef = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCorrectCustomerIDLength = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            buttonAddCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            labelValidCustomerID = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_cc_invalida = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbHomeAddress = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel_cc_wrong_length = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel14 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbCustomerID = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            tbMiddleName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel12 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbSecondLastName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel13 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel16 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbFirstLastName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel17 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            TabEditar = new TabPage();
            siticoneHtmlLabel_buscarCliente_sin_campo = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            cbSearchCustomerBy = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            txtBuscarClientePor = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            CustomerDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
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
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
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
            TabRegistrar.Controls.Add(labelValidPhoneNumber);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_invalid_telef);
            TabRegistrar.Controls.Add(labelCorrectEMail);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_wrong_email);
            TabRegistrar.Controls.Add(siticoneHtmlLabel2);
            TabRegistrar.Controls.Add(tbEMail);
            TabRegistrar.Controls.Add(labelCorrectPhoneNumberLength);
            TabRegistrar.Controls.Add(tbFirstName);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_wrong_length_telef);
            TabRegistrar.Controls.Add(labelCorrectCustomerIDLength);
            TabRegistrar.Controls.Add(buttonAddCustomer);
            TabRegistrar.Controls.Add(labelValidCustomerID);
            TabRegistrar.Controls.Add(siticoneHtmlLabel3);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_cc_invalida);
            TabRegistrar.Controls.Add(tbHomeAddress);
            TabRegistrar.Controls.Add(siticoneHtmlLabel_cc_wrong_length);
            TabRegistrar.Controls.Add(siticoneHtmlLabel14);
            TabRegistrar.Controls.Add(siticoneHtmlLabel4);
            TabRegistrar.Controls.Add(tbCustomerID);
            TabRegistrar.Controls.Add(tbMiddleName);
            TabRegistrar.Controls.Add(siticoneHtmlLabel12);
            TabRegistrar.Controls.Add(tbSecondLastName);
            TabRegistrar.Controls.Add(siticoneHtmlLabel13);
            TabRegistrar.Controls.Add(tbPhoneNumber);
            TabRegistrar.Controls.Add(siticoneHtmlLabel16);
            TabRegistrar.Controls.Add(siticoneHtmlLabel1);
            TabRegistrar.Controls.Add(tbFirstLastName);
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
            // siticoneHtmlLabel_valid_telef
            // 
            labelValidPhoneNumber.Anchor = AnchorStyles.None;
            labelValidPhoneNumber.BackColor = Color.Transparent;
            labelValidPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelValidPhoneNumber.ForeColor = Color.SpringGreen;
            labelValidPhoneNumber.Location = new Point(752, 816);
            labelValidPhoneNumber.Margin = new Padding(3, 5, 3, 5);
            labelValidPhoneNumber.Name = "siticoneHtmlLabel_valid_telef";
            labelValidPhoneNumber.Size = new Size(163, 22);
            labelValidPhoneNumber.TabIndex = 87;
            labelValidPhoneNumber.Text = "¡Teléfono celular válido!";
            labelValidPhoneNumber.Visible = false;
            // 
            // siticoneHtmlLabel_invalid_telef
            // 
            siticoneHtmlLabel_invalid_telef.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_invalid_telef.BackColor = Color.Transparent;
            siticoneHtmlLabel_invalid_telef.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_invalid_telef.ForeColor = Color.Red;
            siticoneHtmlLabel_invalid_telef.Location = new Point(752, 816);
            siticoneHtmlLabel_invalid_telef.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel_invalid_telef.Name = "siticoneHtmlLabel_invalid_telef";
            siticoneHtmlLabel_invalid_telef.Size = new Size(175, 22);
            siticoneHtmlLabel_invalid_telef.TabIndex = 86;
            siticoneHtmlLabel_invalid_telef.Text = "¡Teléfono celular inválido!";
            // 
            // siticoneHtmlLabel_correct_email
            // 
            labelCorrectEMail.Anchor = AnchorStyles.None;
            labelCorrectEMail.BackColor = Color.Transparent;
            labelCorrectEMail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorrectEMail.ForeColor = Color.SpringGreen;
            labelCorrectEMail.Location = new Point(1118, 691);
            labelCorrectEMail.Margin = new Padding(3, 4, 3, 4);
            labelCorrectEMail.Name = "siticoneHtmlLabel_correct_email";
            labelCorrectEMail.Size = new Size(93, 22);
            labelCorrectEMail.TabIndex = 85;
            labelCorrectEMail.Text = "¡Email válido!";
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
            tbEMail.Anchor = AnchorStyles.None;
            tbEMail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbEMail.BorderRadius = 20;
            tbEMail.DefaultText = "";
            tbEMail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbEMail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbEMail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbEMail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbEMail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbEMail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbEMail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbEMail.Location = new Point(510, 665);
            tbEMail.Margin = new Padding(3, 8, 3, 8);
            tbEMail.MinimumSize = new Size(229, 60);
            tbEMail.Name = "txtCorreoCliente";
            tbEMail.PasswordChar = '\0';
            tbEMail.PlaceholderText = "";
            tbEMail.SelectedText = "";
            tbEMail.Size = new Size(583, 60);
            tbEMail.TabIndex = 61;
            tbEMail.TextOffset = new Point(5, 0);
            tbEMail.TextChanged += txtCorreoCliente_TextChanged;
            tbEMail.KeyPress += txtCorreoCliente_KeyPress;
            // 
            // siticoneHtmlLabel_correct_length_telef
            // 
            labelCorrectPhoneNumberLength.Anchor = AnchorStyles.None;
            labelCorrectPhoneNumberLength.BackColor = Color.Transparent;
            labelCorrectPhoneNumberLength.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorrectPhoneNumberLength.ForeColor = Color.SpringGreen;
            labelCorrectPhoneNumberLength.Location = new Point(752, 778);
            labelCorrectPhoneNumberLength.Margin = new Padding(3, 5, 3, 5);
            labelCorrectPhoneNumberLength.Name = "siticoneHtmlLabel_correct_length_telef";
            labelCorrectPhoneNumberLength.Size = new Size(128, 22);
            labelCorrectPhoneNumberLength.TabIndex = 60;
            labelCorrectPhoneNumberLength.Text = "¡Longitud correcta!";
            // 
            // txtPrimerNombreCliente
            // 
            tbFirstName.Anchor = AnchorStyles.None;
            tbFirstName.AutoSize = true;
            tbFirstName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbFirstName.BorderRadius = 20;
            tbFirstName.DefaultText = "";
            tbFirstName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbFirstName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbFirstName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbFirstName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbFirstName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFirstName.Location = new Point(510, 321);
            tbFirstName.Margin = new Padding(3, 8, 3, 8);
            tbFirstName.MaxLength = 50;
            tbFirstName.MinimumSize = new Size(229, 60);
            tbFirstName.Name = "txtPrimerNombreCliente";
            tbFirstName.PasswordChar = '\0';
            tbFirstName.PlaceholderText = "";
            tbFirstName.SelectedText = "";
            tbFirstName.Size = new Size(229, 60);
            tbFirstName.TabIndex = 44;
            tbFirstName.TextOffset = new Point(5, 0);
            tbFirstName.TextChanged += txtPrimerNombreCliente_TextChanged;
            tbFirstName.KeyPress += txtPrimerNombreCliente_KeyPress;
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
            labelCorrectCustomerIDLength.Anchor = AnchorStyles.None;
            labelCorrectCustomerIDLength.BackColor = Color.Transparent;
            labelCorrectCustomerIDLength.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorrectCustomerIDLength.ForeColor = Color.SpringGreen;
            labelCorrectCustomerIDLength.Location = new Point(754, 246);
            labelCorrectCustomerIDLength.Margin = new Padding(3, 4, 3, 4);
            labelCorrectCustomerIDLength.Name = "siticoneHtmlLabel_cc_correct_length";
            labelCorrectCustomerIDLength.Size = new Size(128, 22);
            labelCorrectCustomerIDLength.TabIndex = 57;
            labelCorrectCustomerIDLength.Text = "¡Longitud correcta!";
            // 
            // Button_aniadirCliente
            // 
            buttonAddCustomer.Anchor = AnchorStyles.Bottom;
            buttonAddCustomer.BorderRadius = 20;
            buttonAddCustomer.DisabledState.BorderColor = Color.DarkGray;
            buttonAddCustomer.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonAddCustomer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonAddCustomer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonAddCustomer.FillColor = Color.Black;
            buttonAddCustomer.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCustomer.ForeColor = Color.White;
            buttonAddCustomer.Location = new Point(640, 947);
            buttonAddCustomer.Margin = new Padding(3, 5, 3, 5);
            buttonAddCustomer.Name = "Button_aniadirCliente";
            buttonAddCustomer.Size = new Size(206, 60);
            buttonAddCustomer.TabIndex = 39;
            buttonAddCustomer.Text = "Añadir";
            buttonAddCustomer.Click += ButtonAddCustomer_Click;
            // 
            // siticoneHtmlLabel_cc_valida
            // 
            labelValidCustomerID.Anchor = AnchorStyles.None;
            labelValidCustomerID.BackColor = Color.Transparent;
            labelValidCustomerID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelValidCustomerID.ForeColor = Color.SpringGreen;
            labelValidCustomerID.Location = new Point(754, 208);
            labelValidCustomerID.Margin = new Padding(3, 4, 3, 4);
            labelValidCustomerID.Name = "siticoneHtmlLabel_cc_valida";
            labelValidCustomerID.Size = new Size(101, 22);
            labelValidCustomerID.TabIndex = 56;
            labelValidCustomerID.Text = "¡Cédula válida!";
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
            tbHomeAddress.Anchor = AnchorStyles.None;
            tbHomeAddress.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbHomeAddress.BorderRadius = 20;
            tbHomeAddress.DefaultText = "";
            tbHomeAddress.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbHomeAddress.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbHomeAddress.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbHomeAddress.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbHomeAddress.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbHomeAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbHomeAddress.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbHomeAddress.Location = new Point(510, 551);
            tbHomeAddress.Margin = new Padding(3, 8, 3, 8);
            tbHomeAddress.MinimumSize = new Size(229, 60);
            tbHomeAddress.Name = "txtDireccionCliente";
            tbHomeAddress.PasswordChar = '\0';
            tbHomeAddress.PlaceholderText = "";
            tbHomeAddress.SelectedText = "";
            tbHomeAddress.Size = new Size(583, 60);
            tbHomeAddress.TabIndex = 42;
            tbHomeAddress.TextOffset = new Point(5, 0);
            tbHomeAddress.TextChanged += txtDireccionCliente_TextChanged;
            tbHomeAddress.KeyPress += txtDireccionCliente_KeyPress;
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
            tbCustomerID.Anchor = AnchorStyles.None;
            tbCustomerID.AutoSize = true;
            tbCustomerID.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbCustomerID.BorderRadius = 20;
            tbCustomerID.DefaultText = "";
            tbCustomerID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbCustomerID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbCustomerID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbCustomerID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbCustomerID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbCustomerID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbCustomerID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbCustomerID.Location = new Point(510, 208);
            tbCustomerID.Margin = new Padding(3, 8, 3, 8);
            tbCustomerID.MinimumSize = new Size(229, 60);
            tbCustomerID.Name = "txtCedulaCliente";
            tbCustomerID.PasswordChar = '\0';
            tbCustomerID.PlaceholderText = "";
            tbCustomerID.SelectedText = "";
            tbCustomerID.Size = new Size(229, 60);
            tbCustomerID.TabIndex = 40;
            tbCustomerID.TextOffset = new Point(5, 0);
            tbCustomerID.TextChanged += txtCedulaCliente_TextChanged;
            tbCustomerID.KeyPress += TbCustomerID_KeyPress;
            tbCustomerID.KeyUp += TbCustomerID_KeyUp;
            // 
            // txtSegundoNombreCliente
            // 
            tbMiddleName.Anchor = AnchorStyles.None;
            tbMiddleName.AutoSize = true;
            tbMiddleName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbMiddleName.BorderRadius = 20;
            tbMiddleName.DefaultText = "";
            tbMiddleName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbMiddleName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbMiddleName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbMiddleName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbMiddleName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbMiddleName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbMiddleName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbMiddleName.Location = new Point(864, 321);
            tbMiddleName.Margin = new Padding(3, 8, 3, 8);
            tbMiddleName.MaxLength = 50;
            tbMiddleName.MinimumSize = new Size(229, 60);
            tbMiddleName.Name = "txtSegundoNombreCliente";
            tbMiddleName.PasswordChar = '\0';
            tbMiddleName.PlaceholderText = "";
            tbMiddleName.SelectedText = "";
            tbMiddleName.Size = new Size(229, 60);
            tbMiddleName.TabIndex = 48;
            tbMiddleName.TextOffset = new Point(5, 0);
            tbMiddleName.KeyPress += txtSegundoNombreCliente_KeyPress;
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
            tbSecondLastName.Anchor = AnchorStyles.None;
            tbSecondLastName.AutoSize = true;
            tbSecondLastName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbSecondLastName.BorderRadius = 20;
            tbSecondLastName.DefaultText = "";
            tbSecondLastName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSecondLastName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSecondLastName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSecondLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSecondLastName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSecondLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbSecondLastName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSecondLastName.Location = new Point(864, 437);
            tbSecondLastName.Margin = new Padding(3, 8, 3, 8);
            tbSecondLastName.MinimumSize = new Size(229, 60);
            tbSecondLastName.Name = "txtSegundoApellidoCliente";
            tbSecondLastName.PasswordChar = '\0';
            tbSecondLastName.PlaceholderText = "";
            tbSecondLastName.SelectedText = "";
            tbSecondLastName.Size = new Size(229, 60);
            tbSecondLastName.TabIndex = 49;
            tbSecondLastName.TextOffset = new Point(5, 0);
            tbSecondLastName.KeyPress += txtSegundoApellidoCliente_KeyPress;
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
            tbPhoneNumber.Anchor = AnchorStyles.None;
            tbPhoneNumber.AutoSize = true;
            tbPhoneNumber.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbPhoneNumber.BorderRadius = 20;
            tbPhoneNumber.DefaultText = "";
            tbPhoneNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbPhoneNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbPhoneNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbPhoneNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbPhoneNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPhoneNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhoneNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPhoneNumber.Location = new Point(510, 778);
            tbPhoneNumber.Margin = new Padding(3, 8, 3, 8);
            tbPhoneNumber.MinimumSize = new Size(229, 60);
            tbPhoneNumber.Name = "txtTelefonoCliente";
            tbPhoneNumber.PasswordChar = '\0';
            tbPhoneNumber.PlaceholderText = "";
            tbPhoneNumber.SelectedText = "";
            tbPhoneNumber.Size = new Size(229, 60);
            tbPhoneNumber.TabIndex = 43;
            tbPhoneNumber.TextOffset = new Point(5, 0);
            tbPhoneNumber.TextChanged += txtTelefonoCliente_TextChanged;
            tbPhoneNumber.KeyPress += txtTelefonoCliente_KeyPress;
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
            tbFirstLastName.Anchor = AnchorStyles.None;
            tbFirstLastName.AutoSize = true;
            tbFirstLastName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbFirstLastName.BorderRadius = 20;
            tbFirstLastName.DefaultText = "";
            tbFirstLastName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbFirstLastName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbFirstLastName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbFirstLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbFirstLastName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFirstLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbFirstLastName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFirstLastName.Location = new Point(510, 437);
            tbFirstLastName.Margin = new Padding(3, 8, 3, 8);
            tbFirstLastName.MinimumSize = new Size(229, 60);
            tbFirstLastName.Name = "txtPrimerApellidoCliente";
            tbFirstLastName.PasswordChar = '\0';
            tbFirstLastName.PlaceholderText = "";
            tbFirstLastName.SelectedText = "";
            tbFirstLastName.Size = new Size(229, 60);
            tbFirstLastName.TabIndex = 46;
            tbFirstLastName.TextOffset = new Point(5, 0);
            tbFirstLastName.TextChanged += txtPrimerApellidoCliente_TextChanged;
            tbFirstLastName.KeyPress += txtPrimerApellidoCliente_KeyPress;
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
            TabEditar.Controls.Add(cbSearchCustomerBy);
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
            // cBConsultarClientePor
            // 
            cbSearchCustomerBy.Anchor = AnchorStyles.None;
            cbSearchCustomerBy.BackColor = Color.Transparent;
            cbSearchCustomerBy.BorderRadius = 20;
            cbSearchCustomerBy.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearchCustomerBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchCustomerBy.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSearchCustomerBy.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSearchCustomerBy.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchCustomerBy.ForeColor = Color.FromArgb(68, 88, 112);
            cbSearchCustomerBy.ItemHeight = 40;
            cbSearchCustomerBy.Items.AddRange(new object[] { "Seleccionar...", "CI", "Nombres", "Apellidos", "Teléfono" });
            cbSearchCustomerBy.Location = new Point(719, 221);
            cbSearchCustomerBy.Margin = new Padding(3, 5, 3, 5);
            cbSearchCustomerBy.MinimumSize = new Size(228, 0);
            cbSearchCustomerBy.Name = "cBConsultarClientePor";
            cbSearchCustomerBy.Size = new Size(314, 46);
            cbSearchCustomerBy.TabIndex = 16;
            cbSearchCustomerBy.TextOffset = new Point(5, 0);
            cbSearchCustomerBy.SelectedIndexChanged += CbSearchCustomerBy_SelectedIndexChanged;
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
            txtBuscarClientePor.Enabled = false;
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
            txtBuscarClientePor.TextChanged += txtBuscarClientePor_TextChanged;
            txtBuscarClientePor.KeyPress += TbSearchCustomerBy_KeyPress;
            // 
            // siticonePanel1
            // 
            siticonePanel1.Controls.Add(CustomerDataGridView);
            siticonePanel1.Dock = DockStyle.Bottom;
            siticonePanel1.Location = new Point(3, 447);
            siticonePanel1.Margin = new Padding(3, 5, 3, 5);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(1479, 667);
            siticonePanel1.TabIndex = 1;
            // 
            // SDGVCliente
            // 
            dataGridViewCellStyle5.BackColor = Color.White;
            CustomerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            CustomerDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            CustomerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            CustomerDataGridView.ColumnHeadersHeight = 60;
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CustomerDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnaCedula, ColumnaNombres, ColumnaApellidos, ColumnaDireccion, ColumnaTelefono, ColumnaCorreo, ColumnaEditar, ColumnaEliminar });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            CustomerDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            CustomerDataGridView.Dock = DockStyle.Fill;
            CustomerDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            CustomerDataGridView.Location = new Point(0, 0);
            CustomerDataGridView.Margin = new Padding(3, 4, 3, 4);
            CustomerDataGridView.Name = "SDGVCliente";
            CustomerDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            CustomerDataGridView.RowHeadersVisible = false;
            CustomerDataGridView.RowHeadersWidth = 50;
            CustomerDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(231, 229, 255);
            CustomerDataGridView.RowTemplate.DividerHeight = 15;
            CustomerDataGridView.RowTemplate.Height = 50;
            CustomerDataGridView.Size = new Size(1479, 667);
            CustomerDataGridView.TabIndex = 0;
            CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CustomerDataGridView.ThemeStyle.BackColor = Color.White;
            CustomerDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            CustomerDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            CustomerDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CustomerDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CustomerDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CustomerDataGridView.ThemeStyle.HeaderStyle.Height = 60;
            CustomerDataGridView.ThemeStyle.ReadOnly = false;
            CustomerDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            CustomerDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CustomerDataGridView.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CustomerDataGridView.ThemeStyle.RowsStyle.Height = 50;
            CustomerDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CustomerDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            CustomerDataGridView.CellClick += CustomerDataGridView_CellClick;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new Padding(5);
            ColumnaEditar.DefaultCellStyle = dataGridViewCellStyle7;
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
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage TabRegistrar;
        private TabPage TabEditar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView CustomerDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbHomeAddress;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbCustomerID;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonAddCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSearchCustomerBy;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtBuscarClientePor;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel12;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel13;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel14;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbSecondLastName;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbMiddleName;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel16;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbFirstLastName;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel17;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbFirstName;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCorrectCustomerIDLength;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelValidCustomerID;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_cc_invalida;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_cc_wrong_length;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCorrectPhoneNumberLength;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_wrong_length_telef;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_buscarCliente_sin_campo;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbEMail;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCorrectEMail;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_wrong_email;
        private DataGridViewTextBoxColumn ColumnaCedula;
        private DataGridViewTextBoxColumn ColumnaNombres;
        private DataGridViewTextBoxColumn ColumnaApellidos;
        private DataGridViewTextBoxColumn ColumnaDireccion;
        private DataGridViewTextBoxColumn ColumnaTelefono;
        private DataGridViewTextBoxColumn ColumnaCorreo;
        private DataGridViewImageColumn ColumnaEditar;
        private DataGridViewImageColumn ColumnaEliminar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelValidPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_invalid_telef;
    }
}
