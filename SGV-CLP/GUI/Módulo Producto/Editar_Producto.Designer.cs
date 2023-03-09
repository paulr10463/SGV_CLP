namespace SGV_CLP.GUI
{
    partial class Editar_Producto
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
            SBEditarProd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SBCancelarEditarProd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            rutaImagen_not_valid_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            PE_not_valid_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            PVP_not_greater_than_PE_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            PVP_not_valid_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            categoria_not_choose_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            txtImagen = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel11 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            cBoxCategoria = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtPVP = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel8 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtPE = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            SuspendLayout();
            // 
            // SBEditarProd
            // 
            SBEditarProd.Anchor = AnchorStyles.None;
            SBEditarProd.BorderRadius = 20;
            SBEditarProd.DisabledState.BorderColor = Color.DarkGray;
            SBEditarProd.DisabledState.CustomBorderColor = Color.DarkGray;
            SBEditarProd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBEditarProd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBEditarProd.FillColor = Color.Black;
            SBEditarProd.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBEditarProd.ForeColor = Color.White;
            SBEditarProd.Location = new Point(299, 453);
            SBEditarProd.Margin = new Padding(3, 4, 3, 4);
            SBEditarProd.Name = "SBEditarProd";
            SBEditarProd.Size = new Size(206, 60);
            SBEditarProd.TabIndex = 40;
            SBEditarProd.Text = "Aceptar";
            SBEditarProd.Click += SBEditarProd_Click;
            // 
            // SBCancelarEditarProd
            // 
            SBCancelarEditarProd.Anchor = AnchorStyles.None;
            SBCancelarEditarProd.BorderRadius = 20;
            SBCancelarEditarProd.DisabledState.BorderColor = Color.DarkGray;
            SBCancelarEditarProd.DisabledState.CustomBorderColor = Color.DarkGray;
            SBCancelarEditarProd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBCancelarEditarProd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBCancelarEditarProd.FillColor = Color.Black;
            SBCancelarEditarProd.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBCancelarEditarProd.ForeColor = Color.White;
            SBCancelarEditarProd.Location = new Point(549, 453);
            SBCancelarEditarProd.Margin = new Padding(3, 4, 3, 4);
            SBCancelarEditarProd.Name = "SBCancelarEditarProd";
            SBCancelarEditarProd.Size = new Size(206, 60);
            SBCancelarEditarProd.TabIndex = 41;
            SBCancelarEditarProd.Text = "Cancelar";
            SBCancelarEditarProd.Click += siticoneButton2_Click;
            // 
            // rutaImagen_not_valid_label
            // 
            rutaImagen_not_valid_label.Anchor = AnchorStyles.None;
            rutaImagen_not_valid_label.BackColor = Color.Transparent;
            rutaImagen_not_valid_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rutaImagen_not_valid_label.ForeColor = Color.Red;
            rutaImagen_not_valid_label.Location = new Point(1052, 357);
            rutaImagen_not_valid_label.Margin = new Padding(3, 4, 3, 4);
            rutaImagen_not_valid_label.Name = "rutaImagen_not_valid_label";
            rutaImagen_not_valid_label.Size = new Size(89, 22);
            rutaImagen_not_valid_label.TabIndex = 77;
            rutaImagen_not_valid_label.Text = "Ruta inválida";
            rutaImagen_not_valid_label.Visible = false;
            // 
            // PE_not_valid_label
            // 
            PE_not_valid_label.Anchor = AnchorStyles.None;
            PE_not_valid_label.BackColor = Color.Transparent;
            PE_not_valid_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PE_not_valid_label.ForeColor = Color.Red;
            PE_not_valid_label.Location = new Point(549, 145);
            PE_not_valid_label.Margin = new Padding(3, 4, 3, 4);
            PE_not_valid_label.Name = "PE_not_valid_label";
            PE_not_valid_label.Size = new Size(117, 22);
            PE_not_valid_label.TabIndex = 76;
            PE_not_valid_label.Text = "Máx. 2 decimales";
            PE_not_valid_label.Visible = false;
            // 
            // PVP_not_greater_than_PE_label
            // 
            PVP_not_greater_than_PE_label.Anchor = AnchorStyles.None;
            PVP_not_greater_than_PE_label.BackColor = Color.Transparent;
            PVP_not_greater_than_PE_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PVP_not_greater_than_PE_label.ForeColor = Color.Red;
            PVP_not_greater_than_PE_label.Location = new Point(549, 258);
            PVP_not_greater_than_PE_label.Margin = new Padding(3, 4, 3, 4);
            PVP_not_greater_than_PE_label.Name = "PVP_not_greater_than_PE_label";
            PVP_not_greater_than_PE_label.Size = new Size(118, 22);
            PVP_not_greater_than_PE_label.TabIndex = 75;
            PVP_not_greater_than_PE_label.Text = "Debe ser >= a PE";
            PVP_not_greater_than_PE_label.Visible = false;
            // 
            // PVP_not_valid_label
            // 
            PVP_not_valid_label.Anchor = AnchorStyles.None;
            PVP_not_valid_label.BackColor = Color.Transparent;
            PVP_not_valid_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PVP_not_valid_label.ForeColor = Color.Red;
            PVP_not_valid_label.Location = new Point(549, 228);
            PVP_not_valid_label.Margin = new Padding(3, 4, 3, 4);
            PVP_not_valid_label.Name = "PVP_not_valid_label";
            PVP_not_valid_label.Size = new Size(117, 22);
            PVP_not_valid_label.TabIndex = 74;
            PVP_not_valid_label.Text = "Máx. 2 decimales";
            PVP_not_valid_label.Visible = false;
            // 
            // categoria_not_choose_label
            // 
            categoria_not_choose_label.Anchor = AnchorStyles.None;
            categoria_not_choose_label.BackColor = Color.Transparent;
            categoria_not_choose_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoria_not_choose_label.ForeColor = Color.Red;
            categoria_not_choose_label.Location = new Point(549, 23);
            categoria_not_choose_label.Margin = new Padding(3, 4, 3, 4);
            categoria_not_choose_label.Name = "categoria_not_choose_label";
            categoria_not_choose_label.Size = new Size(265, 22);
            categoria_not_choose_label.TabIndex = 73;
            categoria_not_choose_label.Text = "Debe pertenecer a una categoría válida";
            categoria_not_choose_label.Visible = false;
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
            siticoneButton3.Location = new Point(831, 334);
            siticoneButton3.Margin = new Padding(3, 4, 3, 4);
            siticoneButton3.Name = "siticoneButton3";
            siticoneButton3.Size = new Size(206, 60);
            siticoneButton3.TabIndex = 72;
            siticoneButton3.Text = "Examinar...";
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
            txtImagen.Location = new Point(299, 334);
            txtImagen.Margin = new Padding(3, 7, 3, 7);
            txtImagen.Name = "txtImagen";
            txtImagen.PasswordChar = '\0';
            txtImagen.PlaceholderText = "";
            txtImagen.SelectedText = "";
            txtImagen.Size = new Size(515, 55);
            txtImagen.TabIndex = 71;
            txtImagen.TextOffset = new Point(5, 0);
            // 
            // siticoneHtmlLabel11
            // 
            siticoneHtmlLabel11.Anchor = AnchorStyles.None;
            siticoneHtmlLabel11.BackColor = Color.Transparent;
            siticoneHtmlLabel11.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel11.Location = new Point(11, 345);
            siticoneHtmlLabel11.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel11.Name = "siticoneHtmlLabel11";
            siticoneHtmlLabel11.Size = new Size(166, 34);
            siticoneHtmlLabel11.TabIndex = 70;
            siticoneHtmlLabel11.Text = "Ruta imagen";
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
            cBoxCategoria.Location = new Point(299, 17);
            cBoxCategoria.Margin = new Padding(3, 5, 3, 5);
            cBoxCategoria.Name = "cBoxCategoria";
            cBoxCategoria.Size = new Size(228, 41);
            cBoxCategoria.TabIndex = 69;
            cBoxCategoria.TextOffset = new Point(5, 0);
            cBoxCategoria.SelectedIndexChanged += cBoxCategoria_SelectedIndexChanged;
            // 
            // siticoneHtmlLabel6
            // 
            siticoneHtmlLabel6.Anchor = AnchorStyles.None;
            siticoneHtmlLabel6.BackColor = Color.Transparent;
            siticoneHtmlLabel6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel6.Location = new Point(11, 23);
            siticoneHtmlLabel6.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            siticoneHtmlLabel6.Size = new Size(133, 34);
            siticoneHtmlLabel6.TabIndex = 68;
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
            txtPVP.Location = new Point(299, 228);
            txtPVP.Margin = new Padding(3, 8, 3, 8);
            txtPVP.Name = "txtPVP";
            txtPVP.PasswordChar = '\0';
            txtPVP.PlaceholderText = "";
            txtPVP.SelectedText = "";
            txtPVP.Size = new Size(229, 55);
            txtPVP.TabIndex = 67;
            txtPVP.TextOffset = new Point(5, 0);
            // 
            // siticoneHtmlLabel8
            // 
            siticoneHtmlLabel8.Anchor = AnchorStyles.None;
            siticoneHtmlLabel8.BackColor = Color.Transparent;
            siticoneHtmlLabel8.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel8.Location = new Point(11, 246);
            siticoneHtmlLabel8.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel8.Name = "siticoneHtmlLabel8";
            siticoneHtmlLabel8.Size = new Size(73, 34);
            siticoneHtmlLabel8.TabIndex = 66;
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
            txtPE.Location = new Point(299, 123);
            txtPE.Margin = new Padding(3, 8, 3, 8);
            txtPE.Name = "txtPE";
            txtPE.PasswordChar = '\0';
            txtPE.PlaceholderText = "";
            txtPE.SelectedText = "";
            txtPE.Size = new Size(229, 55);
            txtPE.TabIndex = 65;
            txtPE.TextOffset = new Point(5, 0);
            // 
            // siticoneHtmlLabel7
            // 
            siticoneHtmlLabel7.Anchor = AnchorStyles.None;
            siticoneHtmlLabel7.BackColor = Color.Transparent;
            siticoneHtmlLabel7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel7.Location = new Point(11, 133);
            siticoneHtmlLabel7.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            siticoneHtmlLabel7.Size = new Size(245, 34);
            siticoneHtmlLabel7.TabIndex = 64;
            siticoneHtmlLabel7.Text = "Precio Elaboración";
            // 
            // Editar_Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1149, 533);
            Controls.Add(rutaImagen_not_valid_label);
            Controls.Add(PE_not_valid_label);
            Controls.Add(PVP_not_greater_than_PE_label);
            Controls.Add(PVP_not_valid_label);
            Controls.Add(categoria_not_choose_label);
            Controls.Add(siticoneButton3);
            Controls.Add(txtImagen);
            Controls.Add(siticoneHtmlLabel11);
            Controls.Add(cBoxCategoria);
            Controls.Add(siticoneHtmlLabel6);
            Controls.Add(txtPVP);
            Controls.Add(siticoneHtmlLabel8);
            Controls.Add(txtPE);
            Controls.Add(siticoneHtmlLabel7);
            Controls.Add(SBCancelarEditarProd);
            Controls.Add(SBEditarProd);
            Name = "Editar_Producto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBEditarProd;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBCancelarEditarProd;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel rutaImagen_not_valid_label;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel PE_not_valid_label;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel PVP_not_greater_than_PE_label;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel PVP_not_valid_label;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel categoria_not_choose_label;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtImagen;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel11;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cBoxCategoria;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPVP;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel8;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPE;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
    }
}