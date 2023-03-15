namespace SGV_CLP.GUI.Módulo_Administración
{
    partial class Editar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Usuario));
            cBox_EditarCargo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel12 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel13 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel14 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txt_EditarApell2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txt_EditarNombre2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel15 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel16 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txt_EditarApell1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel17 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txt_EditarNombre1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel18 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txt_EditarPassword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel20 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txt_editarUsername = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            SBCancelar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SBAceptar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel_correct_length_contra = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_wrong_length_contra = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_correct_length_nombreuser = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel_wrong_length_nombreuser = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            SuspendLayout();
            // 
            // cBox_EditarCargo
            // 
            cBox_EditarCargo.Anchor = AnchorStyles.None;
            cBox_EditarCargo.AutoCompleteCustomSource.AddRange(new string[] { "Administrador", "Cajero" });
            cBox_EditarCargo.BackColor = Color.Transparent;
            cBox_EditarCargo.BorderRadius = 20;
            cBox_EditarCargo.DrawMode = DrawMode.OwnerDrawFixed;
            cBox_EditarCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_EditarCargo.FocusedColor = Color.FromArgb(94, 148, 255);
            cBox_EditarCargo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cBox_EditarCargo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_EditarCargo.ForeColor = Color.FromArgb(68, 88, 112);
            cBox_EditarCargo.ItemHeight = 30;
            cBox_EditarCargo.Items.AddRange(new object[] { "Administrador", "Cajero" });
            cBox_EditarCargo.Location = new Point(417, 459);
            cBox_EditarCargo.Margin = new Padding(3, 4, 3, 4);
            cBox_EditarCargo.Name = "cBox_EditarCargo";
            cBox_EditarCargo.Size = new Size(226, 36);
            cBox_EditarCargo.TabIndex = 98;
            cBox_EditarCargo.TextOffset = new Point(5, 0);
            cBox_EditarCargo.SelectedIndexChanged += cBox_EditarCargo_SelectedIndexChanged;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(722, 341);
            siticoneHtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(131, 22);
            siticoneHtmlLabel1.TabIndex = 97;
            siticoneHtmlLabel1.Text = "Segundo apellido";
            // 
            // siticoneHtmlLabel12
            // 
            siticoneHtmlLabel12.Anchor = AnchorStyles.None;
            siticoneHtmlLabel12.BackColor = Color.Transparent;
            siticoneHtmlLabel12.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel12.Location = new Point(417, 341);
            siticoneHtmlLabel12.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel12.Name = "siticoneHtmlLabel12";
            siticoneHtmlLabel12.Size = new Size(111, 22);
            siticoneHtmlLabel12.TabIndex = 96;
            siticoneHtmlLabel12.Text = "Primer apellido";
            // 
            // siticoneHtmlLabel13
            // 
            siticoneHtmlLabel13.Anchor = AnchorStyles.None;
            siticoneHtmlLabel13.BackColor = Color.Transparent;
            siticoneHtmlLabel13.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel13.Location = new Point(721, 246);
            siticoneHtmlLabel13.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel13.Name = "siticoneHtmlLabel13";
            siticoneHtmlLabel13.Size = new Size(129, 22);
            siticoneHtmlLabel13.TabIndex = 95;
            siticoneHtmlLabel13.Text = "Segundo nombre";
            // 
            // siticoneHtmlLabel14
            // 
            siticoneHtmlLabel14.Anchor = AnchorStyles.None;
            siticoneHtmlLabel14.BackColor = Color.Transparent;
            siticoneHtmlLabel14.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel14.Location = new Point(418, 246);
            siticoneHtmlLabel14.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel14.Name = "siticoneHtmlLabel14";
            siticoneHtmlLabel14.Size = new Size(109, 22);
            siticoneHtmlLabel14.TabIndex = 94;
            siticoneHtmlLabel14.Text = "Primer nombre";
            // 
            // txt_EditarApell2
            // 
            txt_EditarApell2.Anchor = AnchorStyles.None;
            txt_EditarApell2.BorderRadius = 20;
            txt_EditarApell2.DefaultText = "";
            txt_EditarApell2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_EditarApell2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_EditarApell2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_EditarApell2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_EditarApell2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_EditarApell2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_EditarApell2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_EditarApell2.Location = new Point(718, 366);
            txt_EditarApell2.Margin = new Padding(3, 7, 3, 7);
            txt_EditarApell2.Name = "txt_EditarApell2";
            txt_EditarApell2.PasswordChar = '\0';
            txt_EditarApell2.PlaceholderText = "";
            txt_EditarApell2.SelectedText = "";
            txt_EditarApell2.Size = new Size(229, 53);
            txt_EditarApell2.TabIndex = 93;
            txt_EditarApell2.TextOffset = new Point(5, 0);
            txt_EditarApell2.TextChanged += txt_EditarApell2_TextChanged;
            txt_EditarApell2.KeyPress += txt_EditarApell2_KeyPress;
            // 
            // txt_EditarNombre2
            // 
            txt_EditarNombre2.Anchor = AnchorStyles.None;
            txt_EditarNombre2.BorderRadius = 20;
            txt_EditarNombre2.DefaultText = "";
            txt_EditarNombre2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_EditarNombre2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_EditarNombre2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_EditarNombre2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_EditarNombre2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_EditarNombre2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_EditarNombre2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_EditarNombre2.Location = new Point(718, 273);
            txt_EditarNombre2.Margin = new Padding(3, 7, 3, 7);
            txt_EditarNombre2.Name = "txt_EditarNombre2";
            txt_EditarNombre2.PasswordChar = '\0';
            txt_EditarNombre2.PlaceholderText = "";
            txt_EditarNombre2.SelectedText = "";
            txt_EditarNombre2.Size = new Size(229, 53);
            txt_EditarNombre2.TabIndex = 92;
            txt_EditarNombre2.TextOffset = new Point(5, 0);
            txt_EditarNombre2.TextChanged += txt_EditarNombre2_TextChanged;
            txt_EditarNombre2.KeyPress += txt_EditarNombre2_KeyPress;
            // 
            // siticoneHtmlLabel15
            // 
            siticoneHtmlLabel15.Anchor = AnchorStyles.None;
            siticoneHtmlLabel15.BackColor = Color.Transparent;
            siticoneHtmlLabel15.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel15.Location = new Point(152, 461);
            siticoneHtmlLabel15.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel15.Name = "siticoneHtmlLabel15";
            siticoneHtmlLabel15.Size = new Size(84, 34);
            siticoneHtmlLabel15.TabIndex = 91;
            siticoneHtmlLabel15.Text = "Cargo";
            // 
            // siticoneHtmlLabel16
            // 
            siticoneHtmlLabel16.Anchor = AnchorStyles.None;
            siticoneHtmlLabel16.BackColor = Color.Transparent;
            siticoneHtmlLabel16.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel16.Location = new Point(152, 366);
            siticoneHtmlLabel16.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel16.Name = "siticoneHtmlLabel16";
            siticoneHtmlLabel16.Size = new Size(110, 34);
            siticoneHtmlLabel16.TabIndex = 90;
            siticoneHtmlLabel16.Text = "Apellido";
            // 
            // txt_EditarApell1
            // 
            txt_EditarApell1.Anchor = AnchorStyles.None;
            txt_EditarApell1.BorderRadius = 20;
            txt_EditarApell1.DefaultText = "";
            txt_EditarApell1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_EditarApell1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_EditarApell1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_EditarApell1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_EditarApell1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_EditarApell1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_EditarApell1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_EditarApell1.Location = new Point(417, 366);
            txt_EditarApell1.Margin = new Padding(3, 7, 3, 7);
            txt_EditarApell1.Name = "txt_EditarApell1";
            txt_EditarApell1.PasswordChar = '\0';
            txt_EditarApell1.PlaceholderText = "";
            txt_EditarApell1.SelectedText = "";
            txt_EditarApell1.Size = new Size(229, 53);
            txt_EditarApell1.TabIndex = 89;
            txt_EditarApell1.TextOffset = new Point(5, 0);
            txt_EditarApell1.TextChanged += txt_EditarApell1_TextChanged;
            txt_EditarApell1.KeyPress += txt_EditarApell1_KeyPress;
            // 
            // siticoneHtmlLabel17
            // 
            siticoneHtmlLabel17.Anchor = AnchorStyles.None;
            siticoneHtmlLabel17.BackColor = Color.Transparent;
            siticoneHtmlLabel17.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel17.Location = new Point(152, 269);
            siticoneHtmlLabel17.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel17.Name = "siticoneHtmlLabel17";
            siticoneHtmlLabel17.Size = new Size(106, 34);
            siticoneHtmlLabel17.TabIndex = 88;
            siticoneHtmlLabel17.Text = "Nombre";
            // 
            // txt_EditarNombre1
            // 
            txt_EditarNombre1.Anchor = AnchorStyles.None;
            txt_EditarNombre1.BorderRadius = 20;
            txt_EditarNombre1.DefaultText = "";
            txt_EditarNombre1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_EditarNombre1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_EditarNombre1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_EditarNombre1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_EditarNombre1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_EditarNombre1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_EditarNombre1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_EditarNombre1.Location = new Point(414, 273);
            txt_EditarNombre1.Margin = new Padding(3, 7, 3, 7);
            txt_EditarNombre1.Name = "txt_EditarNombre1";
            txt_EditarNombre1.PasswordChar = '\0';
            txt_EditarNombre1.PlaceholderText = "";
            txt_EditarNombre1.SelectedText = "";
            txt_EditarNombre1.Size = new Size(229, 53);
            txt_EditarNombre1.TabIndex = 87;
            txt_EditarNombre1.TextOffset = new Point(5, 0);
            txt_EditarNombre1.TextChanged += txt_EditarNombre1_TextChanged;
            txt_EditarNombre1.KeyPress += txt_EditarNombre1_KeyPress;
            // 
            // siticoneHtmlLabel18
            // 
            siticoneHtmlLabel18.Anchor = AnchorStyles.None;
            siticoneHtmlLabel18.BackColor = Color.Transparent;
            siticoneHtmlLabel18.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel18.Location = new Point(152, 181);
            siticoneHtmlLabel18.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel18.Name = "siticoneHtmlLabel18";
            siticoneHtmlLabel18.Size = new Size(152, 34);
            siticoneHtmlLabel18.TabIndex = 86;
            siticoneHtmlLabel18.Text = "Contraseña";
            // 
            // txt_EditarPassword
            // 
            txt_EditarPassword.Anchor = AnchorStyles.None;
            txt_EditarPassword.BorderRadius = 20;
            txt_EditarPassword.DefaultText = "";
            txt_EditarPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_EditarPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_EditarPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_EditarPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_EditarPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_EditarPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_EditarPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_EditarPassword.Location = new Point(414, 179);
            txt_EditarPassword.Margin = new Padding(3, 7, 3, 7);
            txt_EditarPassword.Name = "txt_EditarPassword";
            txt_EditarPassword.PasswordChar = '●';
            txt_EditarPassword.PlaceholderText = "";
            txt_EditarPassword.SelectedText = "";
            txt_EditarPassword.Size = new Size(229, 53);
            txt_EditarPassword.TabIndex = 85;
            txt_EditarPassword.TextOffset = new Point(5, 0);
            txt_EditarPassword.TextChanged += txt_EditarPassword_TextChanged;
            txt_EditarPassword.KeyPress += txt_EditarPassword_KeyPress;
            // 
            // siticoneHtmlLabel20
            // 
            siticoneHtmlLabel20.Anchor = AnchorStyles.None;
            siticoneHtmlLabel20.BackColor = Color.Transparent;
            siticoneHtmlLabel20.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel20.Location = new Point(152, 96);
            siticoneHtmlLabel20.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel20.Name = "siticoneHtmlLabel20";
            siticoneHtmlLabel20.Size = new Size(247, 34);
            siticoneHtmlLabel20.TabIndex = 84;
            siticoneHtmlLabel20.Text = "Nombre de Usuario";
            // 
            // txt_editarUsername
            // 
            txt_editarUsername.Anchor = AnchorStyles.None;
            txt_editarUsername.BorderRadius = 20;
            txt_editarUsername.DefaultText = "";
            txt_editarUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_editarUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_editarUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_editarUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_editarUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_editarUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_editarUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_editarUsername.Location = new Point(417, 96);
            txt_editarUsername.Margin = new Padding(3, 7, 3, 7);
            txt_editarUsername.Name = "txt_editarUsername";
            txt_editarUsername.PasswordChar = '\0';
            txt_editarUsername.PlaceholderText = "";
            txt_editarUsername.SelectedText = "";
            txt_editarUsername.Size = new Size(229, 53);
            txt_editarUsername.TabIndex = 83;
            txt_editarUsername.TextOffset = new Point(5, 0);
            txt_editarUsername.TextChanged += txt_editarUsername_TextChanged;
            txt_editarUsername.KeyPress += txt_editarUsername_KeyPress;
            // 
            // SBCancelar
            // 
            SBCancelar.Anchor = AnchorStyles.None;
            SBCancelar.BorderRadius = 20;
            SBCancelar.DisabledState.BorderColor = Color.DarkGray;
            SBCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            SBCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBCancelar.FillColor = Color.Black;
            SBCancelar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBCancelar.ForeColor = Color.White;
            SBCancelar.Location = new Point(545, 586);
            SBCancelar.Margin = new Padding(3, 4, 3, 4);
            SBCancelar.Name = "SBCancelar";
            SBCancelar.Size = new Size(206, 60);
            SBCancelar.TabIndex = 82;
            SBCancelar.Text = "Cancelar";
            SBCancelar.Click += SBCancelar_Click;
            // 
            // SBAceptar
            // 
            SBAceptar.Anchor = AnchorStyles.None;
            SBAceptar.BorderRadius = 20;
            SBAceptar.DisabledState.BorderColor = Color.DarkGray;
            SBAceptar.DisabledState.CustomBorderColor = Color.DarkGray;
            SBAceptar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBAceptar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBAceptar.FillColor = Color.Black;
            SBAceptar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBAceptar.ForeColor = Color.White;
            SBAceptar.Location = new Point(321, 586);
            SBAceptar.Margin = new Padding(3, 4, 3, 4);
            SBAceptar.Name = "SBAceptar";
            SBAceptar.Size = new Size(206, 60);
            SBAceptar.TabIndex = 81;
            SBAceptar.Text = "Aceptar";
            SBAceptar.Click += SBAceptar_Click;
            // 
            // siticoneHtmlLabel_correct_length_contra
            // 
            siticoneHtmlLabel_correct_length_contra.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_correct_length_contra.BackColor = Color.Transparent;
            siticoneHtmlLabel_correct_length_contra.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_correct_length_contra.ForeColor = Color.SpringGreen;
            siticoneHtmlLabel_correct_length_contra.Location = new Point(718, 186);
            siticoneHtmlLabel_correct_length_contra.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_correct_length_contra.Name = "siticoneHtmlLabel_correct_length_contra";
            siticoneHtmlLabel_correct_length_contra.Size = new Size(128, 22);
            siticoneHtmlLabel_correct_length_contra.TabIndex = 101;
            siticoneHtmlLabel_correct_length_contra.Text = "¡Longitud correcta!";
            siticoneHtmlLabel_correct_length_contra.Click += siticoneHtmlLabel_correct_length_contra_Click;
            // 
            // siticoneHtmlLabel_wrong_length_contra
            // 
            siticoneHtmlLabel_wrong_length_contra.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_wrong_length_contra.BackColor = Color.Transparent;
            siticoneHtmlLabel_wrong_length_contra.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_wrong_length_contra.ForeColor = Color.Red;
            siticoneHtmlLabel_wrong_length_contra.Location = new Point(717, 186);
            siticoneHtmlLabel_wrong_length_contra.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_wrong_length_contra.Name = "siticoneHtmlLabel_wrong_length_contra";
            siticoneHtmlLabel_wrong_length_contra.Size = new Size(129, 22);
            siticoneHtmlLabel_wrong_length_contra.TabIndex = 100;
            siticoneHtmlLabel_wrong_length_contra.Text = "¡Mínimo 10 caract.!";
            // 
            // siticoneHtmlLabel_correct_length_nombreuser
            // 
            siticoneHtmlLabel_correct_length_nombreuser.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_correct_length_nombreuser.BackColor = Color.Transparent;
            siticoneHtmlLabel_correct_length_nombreuser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_correct_length_nombreuser.ForeColor = Color.SpringGreen;
            siticoneHtmlLabel_correct_length_nombreuser.Location = new Point(721, 101);
            siticoneHtmlLabel_correct_length_nombreuser.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_correct_length_nombreuser.Name = "siticoneHtmlLabel_correct_length_nombreuser";
            siticoneHtmlLabel_correct_length_nombreuser.Size = new Size(128, 22);
            siticoneHtmlLabel_correct_length_nombreuser.TabIndex = 103;
            siticoneHtmlLabel_correct_length_nombreuser.Text = "¡Longitud correcta!";
            // 
            // siticoneHtmlLabel_wrong_length_nombreuser
            // 
            siticoneHtmlLabel_wrong_length_nombreuser.Anchor = AnchorStyles.None;
            siticoneHtmlLabel_wrong_length_nombreuser.BackColor = Color.Transparent;
            siticoneHtmlLabel_wrong_length_nombreuser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel_wrong_length_nombreuser.ForeColor = Color.Red;
            siticoneHtmlLabel_wrong_length_nombreuser.Location = new Point(723, 101);
            siticoneHtmlLabel_wrong_length_nombreuser.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel_wrong_length_nombreuser.Name = "siticoneHtmlLabel_wrong_length_nombreuser";
            siticoneHtmlLabel_wrong_length_nombreuser.Size = new Size(121, 22);
            siticoneHtmlLabel_wrong_length_nombreuser.TabIndex = 102;
            siticoneHtmlLabel_wrong_length_nombreuser.Text = "¡Mínimo 5 caract.!";
            // 
            // Editar_Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1099, 742);
            Controls.Add(siticoneHtmlLabel_correct_length_nombreuser);
            Controls.Add(siticoneHtmlLabel_wrong_length_nombreuser);
            Controls.Add(siticoneHtmlLabel_correct_length_contra);
            Controls.Add(siticoneHtmlLabel_wrong_length_contra);
            Controls.Add(cBox_EditarCargo);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(siticoneHtmlLabel12);
            Controls.Add(siticoneHtmlLabel13);
            Controls.Add(siticoneHtmlLabel14);
            Controls.Add(txt_EditarApell2);
            Controls.Add(txt_EditarNombre2);
            Controls.Add(siticoneHtmlLabel15);
            Controls.Add(siticoneHtmlLabel16);
            Controls.Add(txt_EditarApell1);
            Controls.Add(siticoneHtmlLabel17);
            Controls.Add(txt_EditarNombre1);
            Controls.Add(siticoneHtmlLabel18);
            Controls.Add(txt_EditarPassword);
            Controls.Add(siticoneHtmlLabel20);
            Controls.Add(txt_editarUsername);
            Controls.Add(SBCancelar);
            Controls.Add(SBAceptar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Editar_Usuario";
            Text = "Editar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cBox_EditarCargo;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel12;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel13;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel14;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_EditarApell2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_EditarNombre2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel15;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel16;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_EditarApell1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel17;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_EditarNombre1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel18;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_EditarPassword;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel20;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_editarUsername;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBCancelar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBAceptar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_correct_length_contra;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_wrong_length_contra;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_correct_length_nombreuser;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_wrong_length_nombreuser;
    }
}