namespace SGV_CLP.GUI.Módulo_Ventas
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            txtCC_ClienteVenta = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ButtonFinalizarVenta = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ButtonAniadirClienteVenta = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            CC = new DataGridViewTextBoxColumn();
            Contras = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            txtTotalVenta = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtRecibidoVenta = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtVueltoVenta = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel12 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel13 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel14 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtApellido2Venta = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtNombre2Venta = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel16 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtApellido1Venta = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel17 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtNombre1Venta = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtTelefVenta = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtDireccionVenta = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ButtonConfirmarVenta = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel_cc_correct_length = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_cc_valida = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_cc_invalida = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_cc_wrong_length = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtCorreoVenta = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel_correct_email = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_wrong_email = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_correct_length_telef = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel9 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_wrong_length_telef = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneCheckBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            labelCustomerIDUnique = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCustomerIDNotUnique = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ((System.ComponentModel.ISupportInitialize)siticoneDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCC_ClienteVenta
            // 
            txtCC_ClienteVenta.Anchor = AnchorStyles.None;
            txtCC_ClienteVenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCC_ClienteVenta.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCC_ClienteVenta.BorderRadius = 20;
            txtCC_ClienteVenta.DefaultText = "";
            txtCC_ClienteVenta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCC_ClienteVenta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCC_ClienteVenta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCC_ClienteVenta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCC_ClienteVenta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCC_ClienteVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCC_ClienteVenta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCC_ClienteVenta.Location = new Point(267, 120);
            txtCC_ClienteVenta.Margin = new Padding(3, 5, 3, 5);
            txtCC_ClienteVenta.Name = "txtCC_ClienteVenta";
            txtCC_ClienteVenta.PasswordChar = '\0';
            txtCC_ClienteVenta.PlaceholderText = "";
            txtCC_ClienteVenta.SelectedText = "";
            txtCC_ClienteVenta.Size = new Size(229, 48);
            txtCC_ClienteVenta.TabIndex = 47;
            txtCC_ClienteVenta.TextChanged += txtCC_ClienteVenta_TextChanged;
            txtCC_ClienteVenta.KeyPress += txtCC_ClienteVenta_KeyPress;
            txtCC_ClienteVenta.KeyUp += txtCC_ClienteVenta_KeyUp;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(183, 133);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(45, 34);
            siticoneHtmlLabel1.TabIndex = 46;
            siticoneHtmlLabel1.Text = "CC";
            // 
            // siticoneButton2
            // 
            siticoneButton2.Anchor = AnchorStyles.None;
            siticoneButton2.BorderRadius = 20;
            siticoneButton2.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton2.FillColor = Color.Black;
            siticoneButton2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton2.ForeColor = Color.White;
            siticoneButton2.Location = new Point(544, 859);
            siticoneButton2.Margin = new Padding(3, 4, 3, 4);
            siticoneButton2.Name = "siticoneButton2";
            siticoneButton2.Size = new Size(206, 60);
            siticoneButton2.TabIndex = 51;
            siticoneButton2.Text = "Cancelar";
            siticoneButton2.Click += siticoneButton2_Click;
            // 
            // ButtonFinalizarVenta
            // 
            ButtonFinalizarVenta.Anchor = AnchorStyles.None;
            ButtonFinalizarVenta.BorderRadius = 20;
            ButtonFinalizarVenta.DisabledState.BorderColor = Color.DarkGray;
            ButtonFinalizarVenta.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonFinalizarVenta.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonFinalizarVenta.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonFinalizarVenta.Enabled = false;
            ButtonFinalizarVenta.FillColor = Color.Black;
            ButtonFinalizarVenta.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonFinalizarVenta.ForeColor = Color.White;
            ButtonFinalizarVenta.Location = new Point(246, 859);
            ButtonFinalizarVenta.Margin = new Padding(3, 4, 3, 4);
            ButtonFinalizarVenta.Name = "ButtonFinalizarVenta";
            ButtonFinalizarVenta.Size = new Size(206, 60);
            ButtonFinalizarVenta.TabIndex = 50;
            ButtonFinalizarVenta.Text = "Finalizar";
            ButtonFinalizarVenta.Click += siticoneButton1_Click;
            // 
            // ButtonAniadirClienteVenta
            // 
            ButtonAniadirClienteVenta.Anchor = AnchorStyles.None;
            ButtonAniadirClienteVenta.BorderRadius = 20;
            ButtonAniadirClienteVenta.DisabledState.BorderColor = Color.DarkGray;
            ButtonAniadirClienteVenta.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonAniadirClienteVenta.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonAniadirClienteVenta.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonAniadirClienteVenta.FillColor = Color.Black;
            ButtonAniadirClienteVenta.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAniadirClienteVenta.ForeColor = Color.White;
            ButtonAniadirClienteVenta.Location = new Point(531, 108);
            ButtonAniadirClienteVenta.Margin = new Padding(3, 4, 3, 4);
            ButtonAniadirClienteVenta.Name = "ButtonAniadirClienteVenta";
            ButtonAniadirClienteVenta.Size = new Size(206, 60);
            ButtonAniadirClienteVenta.TabIndex = 53;
            ButtonAniadirClienteVenta.Text = "Añadir cliente";
            ButtonAniadirClienteVenta.Click += siticoneButton4_Click;
            // 
            // siticoneDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            siticoneDataGridView1.Anchor = AnchorStyles.None;
            siticoneDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            siticoneDataGridView1.ColumnHeadersHeight = 50;
            siticoneDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            siticoneDataGridView1.Columns.AddRange(new DataGridViewColumn[] { CC, Contras, Nombre });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            siticoneDataGridView1.GridColor = Color.White;
            siticoneDataGridView1.Location = new Point(1042, 108);
            siticoneDataGridView1.Margin = new Padding(3, 4, 3, 4);
            siticoneDataGridView1.Name = "siticoneDataGridView1";
            siticoneDataGridView1.RowHeadersVisible = false;
            siticoneDataGridView1.RowHeadersWidth = 51;
            siticoneDataGridView1.RowTemplate.Height = 25;
            siticoneDataGridView1.Size = new Size(430, 552);
            siticoneDataGridView1.TabIndex = 54;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.GridColor = Color.White;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.DimGray;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            siticoneDataGridView1.ThemeStyle.ReadOnly = false;
            siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 25;
            siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // CC
            // 
            CC.HeaderText = "Nombre Producto";
            CC.MinimumWidth = 6;
            CC.Name = "CC";
            // 
            // Contras
            // 
            Contras.HeaderText = "Cantidad";
            Contras.MinimumWidth = 6;
            Contras.Name = "Contras";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Subtotal";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // txtTotalVenta
            // 
            txtTotalVenta.Anchor = AnchorStyles.None;
            txtTotalVenta.BorderRadius = 20;
            txtTotalVenta.DefaultText = "";
            txtTotalVenta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTotalVenta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTotalVenta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTotalVenta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTotalVenta.Enabled = false;
            txtTotalVenta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTotalVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalVenta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTotalVenta.Location = new Point(1168, 693);
            txtTotalVenta.Margin = new Padding(5, 8, 5, 8);
            txtTotalVenta.Name = "txtTotalVenta";
            txtTotalVenta.PasswordChar = '\0';
            txtTotalVenta.PlaceholderText = "";
            txtTotalVenta.SelectedText = "";
            txtTotalVenta.Size = new Size(181, 67);
            txtTotalVenta.TabIndex = 56;
            txtTotalVenta.KeyPress += txtTotalVenta_KeyPress;
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.Anchor = AnchorStyles.None;
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(1042, 709);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(63, 34);
            siticoneHtmlLabel2.TabIndex = 55;
            siticoneHtmlLabel2.Text = "Total";
            // 
            // txtRecibidoVenta
            // 
            txtRecibidoVenta.Anchor = AnchorStyles.None;
            txtRecibidoVenta.BorderRadius = 20;
            txtRecibidoVenta.DefaultText = "";
            txtRecibidoVenta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRecibidoVenta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRecibidoVenta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRecibidoVenta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRecibidoVenta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRecibidoVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecibidoVenta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRecibidoVenta.Location = new Point(1168, 793);
            txtRecibidoVenta.Margin = new Padding(5, 8, 5, 8);
            txtRecibidoVenta.Name = "txtRecibidoVenta";
            txtRecibidoVenta.PasswordChar = '\0';
            txtRecibidoVenta.PlaceholderText = "";
            txtRecibidoVenta.SelectedText = "";
            txtRecibidoVenta.Size = new Size(181, 67);
            txtRecibidoVenta.TabIndex = 58;
            txtRecibidoVenta.KeyPress += txtRecibidoVenta_KeyPress;
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.Anchor = AnchorStyles.None;
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(1042, 811);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(118, 34);
            siticoneHtmlLabel3.TabIndex = 57;
            siticoneHtmlLabel3.Text = "Recibido";
            // 
            // txtVueltoVenta
            // 
            txtVueltoVenta.Anchor = AnchorStyles.None;
            txtVueltoVenta.BorderRadius = 20;
            txtVueltoVenta.DefaultText = "";
            txtVueltoVenta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtVueltoVenta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtVueltoVenta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtVueltoVenta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtVueltoVenta.Enabled = false;
            txtVueltoVenta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtVueltoVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtVueltoVenta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtVueltoVenta.Location = new Point(1168, 896);
            txtVueltoVenta.Margin = new Padding(5, 8, 5, 8);
            txtVueltoVenta.Name = "txtVueltoVenta";
            txtVueltoVenta.PasswordChar = '\0';
            txtVueltoVenta.PlaceholderText = "";
            txtVueltoVenta.SelectedText = "";
            txtVueltoVenta.Size = new Size(181, 67);
            txtVueltoVenta.TabIndex = 60;
            txtVueltoVenta.KeyPress += txtVueltoVenta_KeyPress;
            // 
            // siticoneHtmlLabel4
            // 
            siticoneHtmlLabel4.Anchor = AnchorStyles.None;
            siticoneHtmlLabel4.BackColor = Color.Transparent;
            siticoneHtmlLabel4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel4.Location = new Point(1042, 912);
            siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            siticoneHtmlLabel4.Size = new Size(86, 34);
            siticoneHtmlLabel4.TabIndex = 59;
            siticoneHtmlLabel4.Text = "Vuelto";
            // 
            // siticoneHtmlLabel5
            // 
            siticoneHtmlLabel5.Anchor = AnchorStyles.None;
            siticoneHtmlLabel5.BackColor = Color.Transparent;
            siticoneHtmlLabel5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel5.Location = new Point(734, 381);
            siticoneHtmlLabel5.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            siticoneHtmlLabel5.Size = new Size(131, 22);
            siticoneHtmlLabel5.TabIndex = 74;
            siticoneHtmlLabel5.Text = "Segundo apellido";
            // 
            // siticoneHtmlLabel12
            // 
            siticoneHtmlLabel12.Anchor = AnchorStyles.None;
            siticoneHtmlLabel12.BackColor = Color.Transparent;
            siticoneHtmlLabel12.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel12.Location = new Point(429, 383);
            siticoneHtmlLabel12.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel12.Name = "siticoneHtmlLabel12";
            siticoneHtmlLabel12.Size = new Size(111, 22);
            siticoneHtmlLabel12.TabIndex = 73;
            siticoneHtmlLabel12.Text = "Primer apellido";
            // 
            // siticoneHtmlLabel13
            // 
            siticoneHtmlLabel13.Anchor = AnchorStyles.None;
            siticoneHtmlLabel13.BackColor = Color.Transparent;
            siticoneHtmlLabel13.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel13.Location = new Point(734, 297);
            siticoneHtmlLabel13.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel13.Name = "siticoneHtmlLabel13";
            siticoneHtmlLabel13.Size = new Size(129, 22);
            siticoneHtmlLabel13.TabIndex = 72;
            siticoneHtmlLabel13.Text = "Segundo nombre";
            // 
            // siticoneHtmlLabel14
            // 
            siticoneHtmlLabel14.Anchor = AnchorStyles.None;
            siticoneHtmlLabel14.BackColor = Color.Transparent;
            siticoneHtmlLabel14.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel14.Location = new Point(429, 297);
            siticoneHtmlLabel14.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel14.Name = "siticoneHtmlLabel14";
            siticoneHtmlLabel14.Size = new Size(109, 22);
            siticoneHtmlLabel14.TabIndex = 71;
            siticoneHtmlLabel14.Text = "Primer nombre";
            // 
            // txtApellido2Venta
            // 
            txtApellido2Venta.Anchor = AnchorStyles.None;
            txtApellido2Venta.BorderRadius = 20;
            txtApellido2Venta.DefaultText = "";
            txtApellido2Venta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtApellido2Venta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtApellido2Venta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtApellido2Venta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtApellido2Venta.Enabled = false;
            txtApellido2Venta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtApellido2Venta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido2Venta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtApellido2Venta.Location = new Point(727, 408);
            txtApellido2Venta.Margin = new Padding(3, 5, 3, 5);
            txtApellido2Venta.Name = "txtApellido2Venta";
            txtApellido2Venta.PasswordChar = '\0';
            txtApellido2Venta.PlaceholderText = "";
            txtApellido2Venta.SelectedText = "";
            txtApellido2Venta.Size = new Size(229, 48);
            txtApellido2Venta.TabIndex = 70;
            txtApellido2Venta.KeyPress += txtApellido2Venta_KeyPress;
            // 
            // txtNombre2Venta
            // 
            txtNombre2Venta.Anchor = AnchorStyles.None;
            txtNombre2Venta.BorderRadius = 20;
            txtNombre2Venta.DefaultText = "";
            txtNombre2Venta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombre2Venta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombre2Venta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombre2Venta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombre2Venta.Enabled = false;
            txtNombre2Venta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre2Venta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre2Venta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre2Venta.Location = new Point(727, 323);
            txtNombre2Venta.Margin = new Padding(3, 5, 3, 5);
            txtNombre2Venta.Name = "txtNombre2Venta";
            txtNombre2Venta.PasswordChar = '\0';
            txtNombre2Venta.PlaceholderText = "";
            txtNombre2Venta.SelectedText = "";
            txtNombre2Venta.Size = new Size(229, 48);
            txtNombre2Venta.TabIndex = 69;
            txtNombre2Venta.KeyPress += txtNombre2Venta_KeyPress;
            // 
            // siticoneHtmlLabel16
            // 
            siticoneHtmlLabel16.Anchor = AnchorStyles.None;
            siticoneHtmlLabel16.BackColor = Color.Transparent;
            siticoneHtmlLabel16.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel16.Location = new Point(218, 408);
            siticoneHtmlLabel16.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel16.Name = "siticoneHtmlLabel16";
            siticoneHtmlLabel16.Size = new Size(110, 34);
            siticoneHtmlLabel16.TabIndex = 68;
            siticoneHtmlLabel16.Text = "Apellido";
            // 
            // txtApellido1Venta
            // 
            txtApellido1Venta.Anchor = AnchorStyles.None;
            txtApellido1Venta.BorderRadius = 20;
            txtApellido1Venta.DefaultText = "";
            txtApellido1Venta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtApellido1Venta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtApellido1Venta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtApellido1Venta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtApellido1Venta.Enabled = false;
            txtApellido1Venta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtApellido1Venta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido1Venta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtApellido1Venta.Location = new Point(422, 408);
            txtApellido1Venta.Margin = new Padding(3, 5, 3, 5);
            txtApellido1Venta.Name = "txtApellido1Venta";
            txtApellido1Venta.PasswordChar = '\0';
            txtApellido1Venta.PlaceholderText = "";
            txtApellido1Venta.SelectedText = "";
            txtApellido1Venta.Size = new Size(229, 48);
            txtApellido1Venta.TabIndex = 67;
            txtApellido1Venta.TextChanged += txtApellido1Venta_TextChanged;
            txtApellido1Venta.KeyPress += txtApellido1Venta_KeyPress;
            // 
            // siticoneHtmlLabel17
            // 
            siticoneHtmlLabel17.Anchor = AnchorStyles.None;
            siticoneHtmlLabel17.BackColor = Color.Transparent;
            siticoneHtmlLabel17.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel17.Location = new Point(218, 323);
            siticoneHtmlLabel17.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel17.Name = "siticoneHtmlLabel17";
            siticoneHtmlLabel17.Size = new Size(106, 34);
            siticoneHtmlLabel17.TabIndex = 66;
            siticoneHtmlLabel17.Text = "Nombre";
            // 
            // txtNombre1Venta
            // 
            txtNombre1Venta.Anchor = AnchorStyles.None;
            txtNombre1Venta.BorderRadius = 20;
            txtNombre1Venta.DefaultText = "";
            txtNombre1Venta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombre1Venta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombre1Venta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombre1Venta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombre1Venta.Enabled = false;
            txtNombre1Venta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre1Venta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre1Venta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre1Venta.Location = new Point(422, 323);
            txtNombre1Venta.Margin = new Padding(3, 5, 3, 5);
            txtNombre1Venta.Name = "txtNombre1Venta";
            txtNombre1Venta.PasswordChar = '\0';
            txtNombre1Venta.PlaceholderText = "";
            txtNombre1Venta.SelectedText = "";
            txtNombre1Venta.Size = new Size(229, 48);
            txtNombre1Venta.TabIndex = 65;
            txtNombre1Venta.TextChanged += txtNombre1Venta_TextChanged;
            txtNombre1Venta.KeyPress += txtNombre1Venta_KeyPress;
            // 
            // txtTelefVenta
            // 
            txtTelefVenta.Anchor = AnchorStyles.None;
            txtTelefVenta.BorderRadius = 20;
            txtTelefVenta.DefaultText = "";
            txtTelefVenta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTelefVenta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTelefVenta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTelefVenta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTelefVenta.Enabled = false;
            txtTelefVenta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefVenta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefVenta.Location = new Point(422, 579);
            txtTelefVenta.Margin = new Padding(3, 5, 3, 5);
            txtTelefVenta.Name = "txtTelefVenta";
            txtTelefVenta.PasswordChar = '\0';
            txtTelefVenta.PlaceholderText = "";
            txtTelefVenta.SelectedText = "";
            txtTelefVenta.Size = new Size(229, 48);
            txtTelefVenta.TabIndex = 64;
            txtTelefVenta.TextChanged += txtTelefVenta_TextChanged;
            txtTelefVenta.KeyPress += txtTelefVenta_KeyPress;
            // 
            // txtDireccionVenta
            // 
            txtDireccionVenta.Anchor = AnchorStyles.None;
            txtDireccionVenta.BorderRadius = 20;
            txtDireccionVenta.DefaultText = "";
            txtDireccionVenta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDireccionVenta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDireccionVenta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDireccionVenta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDireccionVenta.Enabled = false;
            txtDireccionVenta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDireccionVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccionVenta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDireccionVenta.Location = new Point(422, 493);
            txtDireccionVenta.Margin = new Padding(3, 5, 3, 5);
            txtDireccionVenta.Name = "txtDireccionVenta";
            txtDireccionVenta.PasswordChar = '\0';
            txtDireccionVenta.PlaceholderText = "";
            txtDireccionVenta.SelectedText = "";
            txtDireccionVenta.Size = new Size(229, 48);
            txtDireccionVenta.TabIndex = 63;
            txtDireccionVenta.TextChanged += txtDireccionVenta_TextChanged;
            txtDireccionVenta.KeyPress += txtDireccionVenta_KeyPress;
            // 
            // siticoneHtmlLabel6
            // 
            siticoneHtmlLabel6.Anchor = AnchorStyles.None;
            siticoneHtmlLabel6.BackColor = Color.Transparent;
            siticoneHtmlLabel6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel6.Location = new Point(218, 493);
            siticoneHtmlLabel6.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            siticoneHtmlLabel6.Size = new Size(126, 34);
            siticoneHtmlLabel6.TabIndex = 62;
            siticoneHtmlLabel6.Text = "Dirección";
            // 
            // siticoneHtmlLabel7
            // 
            siticoneHtmlLabel7.Anchor = AnchorStyles.None;
            siticoneHtmlLabel7.BackColor = Color.Transparent;
            siticoneHtmlLabel7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel7.Location = new Point(218, 579);
            siticoneHtmlLabel7.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            siticoneHtmlLabel7.Size = new Size(112, 34);
            siticoneHtmlLabel7.TabIndex = 61;
            siticoneHtmlLabel7.Text = "Teléfono";
            // 
            // ButtonConfirmarVenta
            // 
            ButtonConfirmarVenta.Anchor = AnchorStyles.None;
            ButtonConfirmarVenta.BorderRadius = 20;
            ButtonConfirmarVenta.DisabledState.BorderColor = Color.DarkGray;
            ButtonConfirmarVenta.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonConfirmarVenta.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonConfirmarVenta.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonConfirmarVenta.FillColor = Color.Black;
            ButtonConfirmarVenta.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonConfirmarVenta.ForeColor = Color.White;
            ButtonConfirmarVenta.Location = new Point(725, 481);
            ButtonConfirmarVenta.Margin = new Padding(3, 4, 3, 4);
            ButtonConfirmarVenta.Name = "ButtonConfirmarVenta";
            ButtonConfirmarVenta.Size = new Size(206, 60);
            ButtonConfirmarVenta.TabIndex = 75;
            ButtonConfirmarVenta.Text = "Confirmar";
            ButtonConfirmarVenta.Visible = false;
            ButtonConfirmarVenta.Click += siticoneButton3_Click_1;
            // 
            // siticoneHtmlLabel_cc_correct_length
            // 
            siticoneHtmlLabel_cc_correct_length.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_cc_correct_length.BackColor = Color.Transparent;
            siticoneHtmlLabel_cc_correct_length.ForeColor = Color.SpringGreen;
            siticoneHtmlLabel_cc_correct_length.Location = new Point(267, 89);
            siticoneHtmlLabel_cc_correct_length.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_cc_correct_length.Name = "siticoneHtmlLabel_cc_correct_length";
            siticoneHtmlLabel_cc_correct_length.Size = new Size(128, 22);
            siticoneHtmlLabel_cc_correct_length.TabIndex = 79;
            siticoneHtmlLabel_cc_correct_length.Text = "¡Longitud correcta!";
            // 
            // siticoneHtmlLabel_cc_valida
            // 
            siticoneHtmlLabel_cc_valida.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_cc_valida.BackColor = Color.Transparent;
            siticoneHtmlLabel_cc_valida.ForeColor = Color.SpringGreen;
            siticoneHtmlLabel_cc_valida.Location = new Point(267, 59);
            siticoneHtmlLabel_cc_valida.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_cc_valida.Name = "siticoneHtmlLabel_cc_valida";
            siticoneHtmlLabel_cc_valida.Size = new Size(101, 22);
            siticoneHtmlLabel_cc_valida.TabIndex = 78;
            siticoneHtmlLabel_cc_valida.Text = "¡Cédula válida!";
            // 
            // siticoneHtmlLabel_cc_invalida
            // 
            siticoneHtmlLabel_cc_invalida.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_cc_invalida.BackColor = Color.Transparent;
            siticoneHtmlLabel_cc_invalida.ForeColor = Color.Red;
            siticoneHtmlLabel_cc_invalida.Location = new Point(267, 59);
            siticoneHtmlLabel_cc_invalida.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_cc_invalida.Name = "siticoneHtmlLabel_cc_invalida";
            siticoneHtmlLabel_cc_invalida.Size = new Size(113, 22);
            siticoneHtmlLabel_cc_invalida.TabIndex = 77;
            siticoneHtmlLabel_cc_invalida.Text = "¡Cédula inválida!";
            // 
            // siticoneHtmlLabel_cc_wrong_length
            // 
            siticoneHtmlLabel_cc_wrong_length.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_cc_wrong_length.BackColor = Color.Transparent;
            siticoneHtmlLabel_cc_wrong_length.ForeColor = Color.Red;
            siticoneHtmlLabel_cc_wrong_length.Location = new Point(266, 89);
            siticoneHtmlLabel_cc_wrong_length.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_cc_wrong_length.Name = "siticoneHtmlLabel_cc_wrong_length";
            siticoneHtmlLabel_cc_wrong_length.Size = new Size(160, 22);
            siticoneHtmlLabel_cc_wrong_length.TabIndex = 76;
            siticoneHtmlLabel_cc_wrong_length.Text = "¡Se necesitan 10 caract.!";
            // 
            // txtCorreoVenta
            // 
            txtCorreoVenta.Anchor = AnchorStyles.None;
            txtCorreoVenta.BorderRadius = 20;
            txtCorreoVenta.DefaultText = "";
            txtCorreoVenta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCorreoVenta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCorreoVenta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCorreoVenta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCorreoVenta.Enabled = false;
            txtCorreoVenta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCorreoVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreoVenta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCorreoVenta.Location = new Point(422, 672);
            txtCorreoVenta.Margin = new Padding(3, 5, 3, 5);
            txtCorreoVenta.Name = "txtCorreoVenta";
            txtCorreoVenta.PasswordChar = '\0';
            txtCorreoVenta.PlaceholderText = "";
            txtCorreoVenta.SelectedText = "";
            txtCorreoVenta.Size = new Size(229, 48);
            txtCorreoVenta.TabIndex = 80;
            txtCorreoVenta.TextChanged += txtCorreoVenta_TextChanged;
            txtCorreoVenta.KeyPress += txtCorreoVenta_KeyPress;
            // 
            // siticoneHtmlLabel_correct_email
            // 
            siticoneHtmlLabel_correct_email.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_correct_email.BackColor = Color.Transparent;
            siticoneHtmlLabel_correct_email.ForeColor = Color.SpringGreen;
            siticoneHtmlLabel_correct_email.Location = new Point(727, 685);
            siticoneHtmlLabel_correct_email.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_correct_email.Name = "siticoneHtmlLabel_correct_email";
            siticoneHtmlLabel_correct_email.Size = new Size(93, 22);
            siticoneHtmlLabel_correct_email.TabIndex = 83;
            siticoneHtmlLabel_correct_email.Text = "¡Email válido!";
            // 
            // siticoneHtmlLabel_wrong_email
            // 
            siticoneHtmlLabel_wrong_email.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_wrong_email.BackColor = Color.Transparent;
            siticoneHtmlLabel_wrong_email.ForeColor = Color.Red;
            siticoneHtmlLabel_wrong_email.Location = new Point(725, 685);
            siticoneHtmlLabel_wrong_email.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_wrong_email.Name = "siticoneHtmlLabel_wrong_email";
            siticoneHtmlLabel_wrong_email.Size = new Size(105, 22);
            siticoneHtmlLabel_wrong_email.TabIndex = 82;
            siticoneHtmlLabel_wrong_email.Text = "¡Email inválido!";
            // 
            // siticoneHtmlLabel_correct_length_telef
            // 
            siticoneHtmlLabel_correct_length_telef.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_correct_length_telef.BackColor = Color.Transparent;
            siticoneHtmlLabel_correct_length_telef.ForeColor = Color.SpringGreen;
            siticoneHtmlLabel_correct_length_telef.Location = new Point(727, 591);
            siticoneHtmlLabel_correct_length_telef.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel_correct_length_telef.Name = "siticoneHtmlLabel_correct_length_telef";
            siticoneHtmlLabel_correct_length_telef.Size = new Size(128, 22);
            siticoneHtmlLabel_correct_length_telef.TabIndex = 85;
            siticoneHtmlLabel_correct_length_telef.Text = "¡Longitud correcta!";
            // 
            // siticoneHtmlLabel9
            // 
            siticoneHtmlLabel9.Anchor = AnchorStyles.None;
            siticoneHtmlLabel9.BackColor = Color.Transparent;
            siticoneHtmlLabel9.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel9.Location = new Point(218, 673);
            siticoneHtmlLabel9.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel9.Name = "siticoneHtmlLabel9";
            siticoneHtmlLabel9.Size = new Size(91, 34);
            siticoneHtmlLabel9.TabIndex = 86;
            siticoneHtmlLabel9.Text = "Correo";
            // 
            // siticoneHtmlLabel_wrong_length_telef
            // 
            siticoneHtmlLabel_wrong_length_telef.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_wrong_length_telef.BackColor = Color.Transparent;
            siticoneHtmlLabel_wrong_length_telef.ForeColor = Color.Red;
            siticoneHtmlLabel_wrong_length_telef.Location = new Point(727, 591);
            siticoneHtmlLabel_wrong_length_telef.Margin = new Padding(3, 7, 3, 7);
            siticoneHtmlLabel_wrong_length_telef.Name = "siticoneHtmlLabel_wrong_length_telef";
            siticoneHtmlLabel_wrong_length_telef.Size = new Size(160, 22);
            siticoneHtmlLabel_wrong_length_telef.TabIndex = 84;
            siticoneHtmlLabel_wrong_length_telef.Text = "¡Se necesitan 10 caract.!";
            // 
            // siticoneCheckBox1
            // 
            siticoneCheckBox1.Anchor = AnchorStyles.None;
            siticoneCheckBox1.AutoSize = true;
            siticoneCheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneCheckBox1.CheckedState.BorderRadius = 0;
            siticoneCheckBox1.CheckedState.BorderThickness = 0;
            siticoneCheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            siticoneCheckBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneCheckBox1.Location = new Point(267, 189);
            siticoneCheckBox1.Margin = new Padding(3, 4, 3, 4);
            siticoneCheckBox1.Name = "siticoneCheckBox1";
            siticoneCheckBox1.Size = new Size(171, 25);
            siticoneCheckBox1.TabIndex = 87;
            siticoneCheckBox1.Text = "Consumidor Final";
            siticoneCheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            siticoneCheckBox1.UncheckedState.BorderRadius = 0;
            siticoneCheckBox1.UncheckedState.BorderThickness = 0;
            siticoneCheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            siticoneCheckBox1.CheckedChanged += siticoneCheckBox1_CheckedChanged;
            // 
            // labelCustomerIDUnique
            // 
            labelCustomerIDUnique.Anchor = AnchorStyles.None;
            labelCustomerIDUnique.BackColor = Color.Transparent;
            labelCustomerIDUnique.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCustomerIDUnique.ForeColor = Color.SpringGreen;
            labelCustomerIDUnique.Location = new Point(266, 29);
            labelCustomerIDUnique.Name = "labelCustomerIDUnique";
            labelCustomerIDUnique.Size = new Size(96, 22);
            labelCustomerIDUnique.TabIndex = 91;
            labelCustomerIDUnique.Text = "¡Cédula única!";
            // 
            // labelCustomerIDNotUnique
            // 
            labelCustomerIDNotUnique.Anchor = AnchorStyles.None;
            labelCustomerIDNotUnique.BackColor = Color.Transparent;
            labelCustomerIDNotUnique.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCustomerIDNotUnique.ForeColor = Color.Red;
            labelCustomerIDNotUnique.Location = new Point(266, 29);
            labelCustomerIDNotUnique.Name = "labelCustomerIDNotUnique";
            labelCustomerIDNotUnique.Size = new Size(147, 22);
            labelCustomerIDNotUnique.TabIndex = 90;
            labelCustomerIDNotUnique.Text = "¡Cédula ya registrada!";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1569, 1031);
            Controls.Add(labelCustomerIDUnique);
            Controls.Add(labelCustomerIDNotUnique);
            Controls.Add(siticoneCheckBox1);
            Controls.Add(siticoneHtmlLabel9);
            Controls.Add(siticoneHtmlLabel_correct_length_telef);
            Controls.Add(siticoneHtmlLabel_correct_email);
            Controls.Add(siticoneHtmlLabel_wrong_email);
            Controls.Add(txtCorreoVenta);
            Controls.Add(siticoneHtmlLabel_cc_correct_length);
            Controls.Add(siticoneHtmlLabel_cc_valida);
            Controls.Add(siticoneHtmlLabel_cc_invalida);
            Controls.Add(siticoneHtmlLabel_cc_wrong_length);
            Controls.Add(ButtonConfirmarVenta);
            Controls.Add(siticoneHtmlLabel5);
            Controls.Add(siticoneHtmlLabel12);
            Controls.Add(siticoneHtmlLabel13);
            Controls.Add(siticoneHtmlLabel14);
            Controls.Add(txtApellido2Venta);
            Controls.Add(txtNombre2Venta);
            Controls.Add(siticoneHtmlLabel16);
            Controls.Add(txtApellido1Venta);
            Controls.Add(siticoneHtmlLabel17);
            Controls.Add(txtNombre1Venta);
            Controls.Add(txtTelefVenta);
            Controls.Add(txtDireccionVenta);
            Controls.Add(siticoneHtmlLabel6);
            Controls.Add(siticoneHtmlLabel7);
            Controls.Add(txtVueltoVenta);
            Controls.Add(siticoneHtmlLabel4);
            Controls.Add(txtRecibidoVenta);
            Controls.Add(siticoneHtmlLabel3);
            Controls.Add(txtTotalVenta);
            Controls.Add(siticoneHtmlLabel2);
            Controls.Add(siticoneDataGridView1);
            Controls.Add(ButtonAniadirClienteVenta);
            Controls.Add(siticoneButton2);
            Controls.Add(ButtonFinalizarVenta);
            Controls.Add(txtCC_ClienteVenta);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(siticoneHtmlLabel_wrong_length_telef);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Checkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago";
            ((System.ComponentModel.ISupportInitialize)siticoneDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCC_ClienteVenta;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonFinalizarVenta;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonAniadirClienteVenta;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private DataGridViewTextBoxColumn CC;
        private DataGridViewTextBoxColumn Contras;
        private DataGridViewTextBoxColumn Nombre;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTotalVenta;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtRecibidoVenta;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtVueltoVenta;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel12;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel13;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel14;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtApellido2Venta;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNombre2Venta;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel16;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtApellido1Venta;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel17;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNombre1Venta;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTelefVenta;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDireccionVenta;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel8;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonConfirmarVenta;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_cc_correct_length;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_cc_valida;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_cc_invalida;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_cc_wrong_length;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCorreoVenta;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_correct_email;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_wrong_email;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_correct_length_telef;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_wrong_length_telef;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel9;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCustomerIDUnique;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCustomerIDNotUnique;
    }
}