﻿namespace SGV_CLP.GUI.Customers_Module
{
    partial class EditCustomer
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
            buttonCancelar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            buttonEditCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel20 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbHomeAddress = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbEMail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            labelCorrectEMail = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelWrongEMail = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelValidPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelInvalidPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCorrectPhoneNumberLength = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelWrongPhoneNumberLength = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.None;
            buttonCancelar.BorderRadius = 20;
            buttonCancelar.DisabledState.BorderColor = Color.DarkGray;
            buttonCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonCancelar.FillColor = Color.Black;
            buttonCancelar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(426, 315);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(206, 60);
            buttonCancelar.TabIndex = 47;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.Click += ButtonCancel_Click;
            // 
            // button_EditarCliente
            // 
            buttonEditCustomer.Anchor = AnchorStyles.None;
            buttonEditCustomer.BorderRadius = 20;
            buttonEditCustomer.DisabledState.BorderColor = Color.DarkGray;
            buttonEditCustomer.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonEditCustomer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonEditCustomer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonEditCustomer.FillColor = Color.Black;
            buttonEditCustomer.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditCustomer.ForeColor = Color.White;
            buttonEditCustomer.Location = new Point(164, 315);
            buttonEditCustomer.Margin = new Padding(3, 4, 3, 4);
            buttonEditCustomer.Name = "button_EditarCliente";
            buttonEditCustomer.Size = new Size(206, 60);
            buttonEditCustomer.TabIndex = 46;
            buttonEditCustomer.Text = "Aceptar";
            buttonEditCustomer.Click += ButtonEditCustomer_Click;
            // 
            // siticoneHtmlLabel20
            // 
            siticoneHtmlLabel20.Anchor = AnchorStyles.None;
            siticoneHtmlLabel20.BackColor = Color.Transparent;
            siticoneHtmlLabel20.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel20.Location = new Point(63, 43);
            siticoneHtmlLabel20.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel20.Name = "siticoneHtmlLabel20";
            siticoneHtmlLabel20.Size = new Size(126, 34);
            siticoneHtmlLabel20.TabIndex = 49;
            siticoneHtmlLabel20.Text = "Dirección";
            // 
            // txtDireccionCliente
            // 
            tbHomeAddress.Anchor = AnchorStyles.None;
            tbHomeAddress.BorderRadius = 20;
            tbHomeAddress.DefaultText = "";
            tbHomeAddress.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbHomeAddress.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbHomeAddress.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbHomeAddress.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbHomeAddress.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbHomeAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbHomeAddress.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbHomeAddress.Location = new Point(226, 33);
            tbHomeAddress.Margin = new Padding(3, 7, 3, 7);
            tbHomeAddress.Name = "txtDireccionCliente";
            tbHomeAddress.PasswordChar = '\0';
            tbHomeAddress.PlaceholderText = "";
            tbHomeAddress.SelectedText = "";
            tbHomeAddress.Size = new Size(451, 53);
            tbHomeAddress.TabIndex = 48;
            tbHomeAddress.TextOffset = new Point(5, 0);
            tbHomeAddress.TextChanged += TbHomeAddress_TextChanged;
            tbHomeAddress.KeyPress += TbHomeAddress_KeyPress;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(63, 228);
            siticoneHtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(112, 34);
            siticoneHtmlLabel1.TabIndex = 51;
            siticoneHtmlLabel1.Text = "Teléfono";
            // 
            // txtTelefonoCliente
            // 
            tbPhoneNumber.Anchor = AnchorStyles.None;
            tbPhoneNumber.BorderRadius = 20;
            tbPhoneNumber.DefaultText = "";
            tbPhoneNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbPhoneNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbPhoneNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbPhoneNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbPhoneNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPhoneNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhoneNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPhoneNumber.Location = new Point(226, 218);
            tbPhoneNumber.Margin = new Padding(3, 7, 3, 7);
            tbPhoneNumber.Name = "txtTelefonoCliente";
            tbPhoneNumber.PasswordChar = '\0';
            tbPhoneNumber.PlaceholderText = "";
            tbPhoneNumber.SelectedText = "";
            tbPhoneNumber.Size = new Size(218, 53);
            tbPhoneNumber.TabIndex = 50;
            tbPhoneNumber.TextOffset = new Point(5, 0);
            tbPhoneNumber.TextChanged += TbPhoneNumber_TextChanged;
            tbPhoneNumber.KeyPress += TbPhoneNumber_KeyPress;
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.Anchor = AnchorStyles.None;
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(63, 131);
            siticoneHtmlLabel2.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(75, 34);
            siticoneHtmlLabel2.TabIndex = 53;
            siticoneHtmlLabel2.Text = "eMail";
            // 
            // txtCorreoCliente
            // 
            tbEMail.Anchor = AnchorStyles.None;
            tbEMail.BorderRadius = 20;
            tbEMail.DefaultText = "";
            tbEMail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbEMail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbEMail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbEMail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbEMail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbEMail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbEMail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbEMail.Location = new Point(226, 124);
            tbEMail.Margin = new Padding(3, 7, 3, 7);
            tbEMail.Name = "txtCorreoCliente";
            tbEMail.PasswordChar = '\0';
            tbEMail.PlaceholderText = "";
            tbEMail.SelectedText = "";
            tbEMail.Size = new Size(451, 53);
            tbEMail.TabIndex = 52;
            tbEMail.TextOffset = new Point(5, 0);
            tbEMail.TextChanged += TbEMail_TextChanged;
            tbEMail.KeyPress += TbEMail_KeyPress;
            // 
            // siticoneHtmlLabel_correct_email
            // 
            labelCorrectEMail.Anchor = AnchorStyles.None;
            labelCorrectEMail.BackColor = Color.Transparent;
            labelCorrectEMail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorrectEMail.ForeColor = Color.SpringGreen;
            labelCorrectEMail.Location = new Point(696, 143);
            labelCorrectEMail.Margin = new Padding(3, 4, 3, 4);
            labelCorrectEMail.Name = "siticoneHtmlLabel_correct_email";
            labelCorrectEMail.Size = new Size(93, 22);
            labelCorrectEMail.TabIndex = 87;
            labelCorrectEMail.Text = "¡Email válido!";
            // 
            // siticoneHtmlLabel_wrong_email
            // 
            labelWrongEMail.Anchor = AnchorStyles.None;
            labelWrongEMail.BackColor = Color.Transparent;
            labelWrongEMail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelWrongEMail.ForeColor = Color.Red;
            labelWrongEMail.Location = new Point(696, 143);
            labelWrongEMail.Margin = new Padding(3, 4, 3, 4);
            labelWrongEMail.Name = "siticoneHtmlLabel_wrong_email";
            labelWrongEMail.Size = new Size(105, 22);
            labelWrongEMail.TabIndex = 86;
            labelWrongEMail.Text = "¡Email inválido!";
            // 
            // siticoneHtmlLabel_valid_telef
            // 
            labelValidPhoneNumber.Anchor = AnchorStyles.None;
            labelValidPhoneNumber.BackColor = Color.Transparent;
            labelValidPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelValidPhoneNumber.ForeColor = Color.SpringGreen;
            labelValidPhoneNumber.Location = new Point(450, 249);
            labelValidPhoneNumber.Margin = new Padding(3, 5, 3, 5);
            labelValidPhoneNumber.Name = "siticoneHtmlLabel_valid_telef";
            labelValidPhoneNumber.Size = new Size(163, 22);
            labelValidPhoneNumber.TabIndex = 91;
            labelValidPhoneNumber.Text = "¡Teléfono celular válido!";
            labelValidPhoneNumber.Visible = false;
            // 
            // siticoneHtmlLabel_invalid_telef
            // 
            labelInvalidPhoneNumber.Anchor = AnchorStyles.None;
            labelInvalidPhoneNumber.BackColor = Color.Transparent;
            labelInvalidPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidPhoneNumber.ForeColor = Color.Red;
            labelInvalidPhoneNumber.Location = new Point(450, 249);
            labelInvalidPhoneNumber.Margin = new Padding(3, 5, 3, 5);
            labelInvalidPhoneNumber.Name = "siticoneHtmlLabel_invalid_telef";
            labelInvalidPhoneNumber.Size = new Size(175, 22);
            labelInvalidPhoneNumber.TabIndex = 90;
            labelInvalidPhoneNumber.Text = "¡Teléfono celular inválido!";
            // 
            // siticoneHtmlLabel_correct_length_telef
            // 
            labelCorrectPhoneNumberLength.Anchor = AnchorStyles.None;
            labelCorrectPhoneNumberLength.BackColor = Color.Transparent;
            labelCorrectPhoneNumberLength.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorrectPhoneNumberLength.ForeColor = Color.SpringGreen;
            labelCorrectPhoneNumberLength.Location = new Point(450, 218);
            labelCorrectPhoneNumberLength.Margin = new Padding(3, 5, 3, 5);
            labelCorrectPhoneNumberLength.Name = "siticoneHtmlLabel_correct_length_telef";
            labelCorrectPhoneNumberLength.Size = new Size(128, 22);
            labelCorrectPhoneNumberLength.TabIndex = 89;
            labelCorrectPhoneNumberLength.Text = "¡Longitud correcta!";
            // 
            // siticoneHtmlLabel_wrong_length_telef
            // 
            labelWrongPhoneNumberLength.Anchor = AnchorStyles.None;
            labelWrongPhoneNumberLength.BackColor = Color.Transparent;
            labelWrongPhoneNumberLength.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelWrongPhoneNumberLength.ForeColor = Color.Red;
            labelWrongPhoneNumberLength.Location = new Point(450, 218);
            labelWrongPhoneNumberLength.Margin = new Padding(3, 5, 3, 5);
            labelWrongPhoneNumberLength.Name = "siticoneHtmlLabel_wrong_length_telef";
            labelWrongPhoneNumberLength.Size = new Size(160, 22);
            labelWrongPhoneNumberLength.TabIndex = 88;
            labelWrongPhoneNumberLength.Text = "¡Se necesitan 10 caract.!";
            // 
            // Editar_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 407);
            Controls.Add(labelValidPhoneNumber);
            Controls.Add(labelInvalidPhoneNumber);
            Controls.Add(labelCorrectPhoneNumberLength);
            Controls.Add(labelWrongPhoneNumberLength);
            Controls.Add(labelCorrectEMail);
            Controls.Add(labelWrongEMail);
            Controls.Add(siticoneHtmlLabel2);
            Controls.Add(tbEMail);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(tbPhoneNumber);
            Controls.Add(siticoneHtmlLabel20);
            Controls.Add(tbHomeAddress);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEditCustomer);
            Name = "Editar_Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonCancelar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonEditCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel20;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbHomeAddress;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbEMail;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCorrectEMail;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelWrongEMail;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelValidPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCorrectPhoneNumberLength;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelWrongPhoneNumberLength;
    }
}