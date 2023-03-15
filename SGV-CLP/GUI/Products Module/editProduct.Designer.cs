﻿namespace SGV_CLP.GUI
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            buttonEditProduct = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            buttonCancel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            labelInvalidImagePath = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelInvalidProductionPrice = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            LabelSPPNotGreaterThanPP = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelInvalidSalesPriceToThePublic = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCategoryNotChosen = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ButtonBrowse = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            tbImagePath = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel11 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            cbCategory = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbSalesPriceToThePublic = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel8 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbProductionPrice = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            SuspendLayout();
            // 
            // buttonEditProduct
            // 
            buttonEditProduct.Anchor = AnchorStyles.None;
            buttonEditProduct.BorderRadius = 20;
            buttonEditProduct.DisabledState.BorderColor = Color.DarkGray;
            buttonEditProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonEditProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonEditProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonEditProduct.FillColor = Color.Black;
            buttonEditProduct.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditProduct.ForeColor = Color.White;
            buttonEditProduct.Location = new Point(299, 453);
            buttonEditProduct.Margin = new Padding(3, 4, 3, 4);
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(206, 60);
            buttonEditProduct.TabIndex = 40;
            buttonEditProduct.Text = "Aceptar";
            buttonEditProduct.Click += ButtonEditProduct_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.None;
            buttonCancel.BorderRadius = 20;
            buttonCancel.DisabledState.BorderColor = Color.DarkGray;
            buttonCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonCancel.FillColor = Color.Black;
            buttonCancel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(549, 453);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(206, 60);
            buttonCancel.TabIndex = 41;
            buttonCancel.Text = "Cancelar";
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // labelInvalidImagePath
            // 
            labelInvalidImagePath.Anchor = AnchorStyles.None;
            labelInvalidImagePath.BackColor = Color.Transparent;
            labelInvalidImagePath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidImagePath.ForeColor = Color.Red;
            labelInvalidImagePath.Location = new Point(1052, 357);
            labelInvalidImagePath.Margin = new Padding(3, 4, 3, 4);
            labelInvalidImagePath.Name = "labelInvalidImagePath";
            labelInvalidImagePath.Size = new Size(89, 22);
            labelInvalidImagePath.TabIndex = 77;
            labelInvalidImagePath.Text = "Ruta inválida";
            labelInvalidImagePath.Visible = false;
            // 
            // labelInvalidProductionPrice
            // 
            labelInvalidProductionPrice.Anchor = AnchorStyles.None;
            labelInvalidProductionPrice.BackColor = Color.Transparent;
            labelInvalidProductionPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidProductionPrice.ForeColor = Color.Red;
            labelInvalidProductionPrice.Location = new Point(549, 145);
            labelInvalidProductionPrice.Margin = new Padding(3, 4, 3, 4);
            labelInvalidProductionPrice.Name = "labelInvalidProductionPrice";
            labelInvalidProductionPrice.Size = new Size(117, 22);
            labelInvalidProductionPrice.TabIndex = 76;
            labelInvalidProductionPrice.Text = "Máx. 2 decimales";
            labelInvalidProductionPrice.Visible = false;
            // 
            // LabelSPPNotGreaterThanPP
            // 
            LabelSPPNotGreaterThanPP.Anchor = AnchorStyles.None;
            LabelSPPNotGreaterThanPP.BackColor = Color.Transparent;
            LabelSPPNotGreaterThanPP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSPPNotGreaterThanPP.ForeColor = Color.Red;
            LabelSPPNotGreaterThanPP.Location = new Point(549, 258);
            LabelSPPNotGreaterThanPP.Margin = new Padding(3, 4, 3, 4);
            LabelSPPNotGreaterThanPP.Name = "LabelSPPNotGreaterThanPP";
            LabelSPPNotGreaterThanPP.Size = new Size(118, 22);
            LabelSPPNotGreaterThanPP.TabIndex = 75;
            LabelSPPNotGreaterThanPP.Text = "Debe ser >= a PE";
            LabelSPPNotGreaterThanPP.Visible = false;
            // 
            // labelInvalidSalesPriceToThePublic
            // 
            labelInvalidSalesPriceToThePublic.Anchor = AnchorStyles.None;
            labelInvalidSalesPriceToThePublic.BackColor = Color.Transparent;
            labelInvalidSalesPriceToThePublic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidSalesPriceToThePublic.ForeColor = Color.Red;
            labelInvalidSalesPriceToThePublic.Location = new Point(549, 228);
            labelInvalidSalesPriceToThePublic.Margin = new Padding(3, 4, 3, 4);
            labelInvalidSalesPriceToThePublic.Name = "labelInvalidSalesPriceToThePublic";
            labelInvalidSalesPriceToThePublic.Size = new Size(117, 22);
            labelInvalidSalesPriceToThePublic.TabIndex = 74;
            labelInvalidSalesPriceToThePublic.Text = "Máx. 2 decimales";
            labelInvalidSalesPriceToThePublic.Visible = false;
            // 
            // labelCategoryNotChosen
            // 
            labelCategoryNotChosen.Anchor = AnchorStyles.None;
            labelCategoryNotChosen.BackColor = Color.Transparent;
            labelCategoryNotChosen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategoryNotChosen.ForeColor = Color.Red;
            labelCategoryNotChosen.Location = new Point(549, 23);
            labelCategoryNotChosen.Margin = new Padding(3, 4, 3, 4);
            labelCategoryNotChosen.Name = "labelCategoryNotChosen";
            labelCategoryNotChosen.Size = new Size(265, 22);
            labelCategoryNotChosen.TabIndex = 73;
            labelCategoryNotChosen.Text = "Debe pertenecer a una categoría válida";
            labelCategoryNotChosen.Visible = false;
            // 
            // ButtonBrowse
            // 
            ButtonBrowse.Anchor = AnchorStyles.None;
            ButtonBrowse.BorderRadius = 20;
            ButtonBrowse.DisabledState.BorderColor = Color.DarkGray;
            ButtonBrowse.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonBrowse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonBrowse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonBrowse.FillColor = Color.Black;
            ButtonBrowse.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonBrowse.ForeColor = Color.White;
            ButtonBrowse.Location = new Point(831, 334);
            ButtonBrowse.Margin = new Padding(3, 4, 3, 4);
            ButtonBrowse.Name = "ButtonBrowse";
            ButtonBrowse.Size = new Size(206, 60);
            ButtonBrowse.TabIndex = 72;
            ButtonBrowse.Text = "Examinar...";
            ButtonBrowse.Click += ButtonBrowse_Click;
            // 
            // tbImagePath
            // 
            tbImagePath.Anchor = AnchorStyles.None;
            tbImagePath.BorderRadius = 20;
            tbImagePath.DefaultText = "";
            tbImagePath.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbImagePath.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbImagePath.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbImagePath.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbImagePath.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbImagePath.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbImagePath.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbImagePath.Location = new Point(299, 334);
            tbImagePath.Margin = new Padding(3, 7, 3, 7);
            tbImagePath.Name = "tbImagePath";
            tbImagePath.PasswordChar = '\0';
            tbImagePath.PlaceholderText = "";
            tbImagePath.SelectedText = "";
            tbImagePath.Size = new Size(515, 55);
            tbImagePath.TabIndex = 71;
            tbImagePath.TextOffset = new Point(5, 0);
            tbImagePath.TextChanged += TbImagePath_TextChanged;
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
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.BackColor = Color.Transparent;
            cbCategory.BorderRadius = 20;
            cbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbCategory.ItemHeight = 35;
            cbCategory.Items.AddRange(new object[] { "Seleccione...", "Especialidades", "Bebidas Frías", "Bebidas Calientes", "Empanadas" });
            cbCategory.Location = new Point(299, 17);
            cbCategory.Margin = new Padding(3, 5, 3, 5);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(228, 41);
            cbCategory.TabIndex = 69;
            cbCategory.TextOffset = new Point(5, 0);
            cbCategory.SelectedIndexChanged += CbCategory_SelectedIndexChanged;
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
            // tbSalesPriceToThePublic
            // 
            tbSalesPriceToThePublic.Anchor = AnchorStyles.None;
            tbSalesPriceToThePublic.BorderRadius = 20;
            tbSalesPriceToThePublic.DefaultText = "";
            tbSalesPriceToThePublic.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSalesPriceToThePublic.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSalesPriceToThePublic.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSalesPriceToThePublic.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSalesPriceToThePublic.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSalesPriceToThePublic.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbSalesPriceToThePublic.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSalesPriceToThePublic.Location = new Point(299, 228);
            tbSalesPriceToThePublic.Margin = new Padding(3, 8, 3, 8);
            tbSalesPriceToThePublic.Name = "tbSalesPriceToThePublic";
            tbSalesPriceToThePublic.PasswordChar = '\0';
            tbSalesPriceToThePublic.PlaceholderText = "";
            tbSalesPriceToThePublic.SelectedText = "";
            tbSalesPriceToThePublic.Size = new Size(229, 55);
            tbSalesPriceToThePublic.TabIndex = 67;
            tbSalesPriceToThePublic.TextOffset = new Point(5, 0);
            tbSalesPriceToThePublic.TextChanged += TbSalesPriceToThePublic_TextChanged;
            tbSalesPriceToThePublic.KeyPress += TbSalesPriceToThePublic_KeyPress;
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
            // tbProductionPrice
            // 
            tbProductionPrice.Anchor = AnchorStyles.None;
            tbProductionPrice.BorderRadius = 20;
            tbProductionPrice.DefaultText = "";
            tbProductionPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbProductionPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbProductionPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbProductionPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbProductionPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductionPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductionPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductionPrice.Location = new Point(299, 123);
            tbProductionPrice.Margin = new Padding(3, 8, 3, 8);
            tbProductionPrice.Name = "tbProductionPrice";
            tbProductionPrice.PasswordChar = '\0';
            tbProductionPrice.PlaceholderText = "";
            tbProductionPrice.SelectedText = "";
            tbProductionPrice.Size = new Size(229, 55);
            tbProductionPrice.TabIndex = 65;
            tbProductionPrice.TextOffset = new Point(5, 0);
            tbProductionPrice.TextChanged += TbProductionPrice_TextChanged;
            tbProductionPrice.KeyPress += TbProductionPrice_KeyPress;
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
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1149, 533);
            Controls.Add(labelInvalidImagePath);
            Controls.Add(labelInvalidProductionPrice);
            Controls.Add(LabelSPPNotGreaterThanPP);
            Controls.Add(labelInvalidSalesPriceToThePublic);
            Controls.Add(labelCategoryNotChosen);
            Controls.Add(ButtonBrowse);
            Controls.Add(tbImagePath);
            Controls.Add(siticoneHtmlLabel11);
            Controls.Add(cbCategory);
            Controls.Add(siticoneHtmlLabel6);
            Controls.Add(tbSalesPriceToThePublic);
            Controls.Add(siticoneHtmlLabel8);
            Controls.Add(tbProductionPrice);
            Controls.Add(siticoneHtmlLabel7);
            Controls.Add(buttonCancel);
            Controls.Add(buttonEditProduct);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonEditProduct;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonCancel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidImagePath;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidProductionPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LabelSPPNotGreaterThanPP;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidSalesPriceToThePublic;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCategoryNotChosen;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonBrowse;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbImagePath;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel11;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbSalesPriceToThePublic;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel8;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbProductionPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
    }
}