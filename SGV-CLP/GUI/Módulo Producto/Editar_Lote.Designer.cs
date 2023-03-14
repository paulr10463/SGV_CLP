namespace SGV_CLP.GUI.Módulo_Producto
{
    partial class Editar_Lote
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
            SBCancelar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SBAceptar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            FechaHora_not_choose_in_Lote_label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            GBFechaHoraElab = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            DTPHoraLote = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            SRBFechaActual = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            SRBElegirFecha = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            DTPFechaLote = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            txtCantidad = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            GBFechaHoraElab.SuspendLayout();
            SuspendLayout();
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
            SBCancelar.Location = new Point(336, 424);
            SBCancelar.Margin = new Padding(3, 4, 3, 4);
            SBCancelar.Name = "SBCancelar";
            SBCancelar.Size = new Size(206, 60);
            SBCancelar.TabIndex = 72;
            SBCancelar.Text = "Cancelar";
            SBCancelar.Click += siticoneButton2_Click;
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
            SBAceptar.Location = new Point(79, 424);
            SBAceptar.Margin = new Padding(3, 4, 3, 4);
            SBAceptar.Name = "SBAceptar";
            SBAceptar.Size = new Size(206, 60);
            SBAceptar.TabIndex = 71;
            SBAceptar.Text = "Aceptar";
            SBAceptar.Click += SBAceptar_Click;
            // 
            // FechaHora_not_choose_in_Lote_label
            // 
            FechaHora_not_choose_in_Lote_label.Anchor = AnchorStyles.None;
            FechaHora_not_choose_in_Lote_label.BackColor = Color.Transparent;
            FechaHora_not_choose_in_Lote_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FechaHora_not_choose_in_Lote_label.ForeColor = Color.Red;
            FechaHora_not_choose_in_Lote_label.Location = new Point(189, 349);
            FechaHora_not_choose_in_Lote_label.Margin = new Padding(3, 4, 3, 4);
            FechaHora_not_choose_in_Lote_label.Name = "FechaHora_not_choose_in_Lote_label";
            FechaHora_not_choose_in_Lote_label.Size = new Size(240, 22);
            FechaHora_not_choose_in_Lote_label.TabIndex = 76;
            FechaHora_not_choose_in_Lote_label.Text = "Debe tener una fecha y hora válidas";
            FechaHora_not_choose_in_Lote_label.Visible = false;
            // 
            // GBFechaHoraElab
            // 
            GBFechaHoraElab.Anchor = AnchorStyles.None;
            GBFechaHoraElab.BackColor = Color.Transparent;
            GBFechaHoraElab.BorderColor = Color.Black;
            GBFechaHoraElab.BorderRadius = 20;
            GBFechaHoraElab.Controls.Add(DTPHoraLote);
            GBFechaHoraElab.Controls.Add(SRBFechaActual);
            GBFechaHoraElab.Controls.Add(SRBElegirFecha);
            GBFechaHoraElab.Controls.Add(DTPFechaLote);
            GBFechaHoraElab.CustomBorderColor = Color.Black;
            GBFechaHoraElab.FillColor = Color.Transparent;
            GBFechaHoraElab.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GBFechaHoraElab.ForeColor = Color.White;
            GBFechaHoraElab.Location = new Point(59, 132);
            GBFechaHoraElab.Margin = new Padding(3, 4, 3, 4);
            GBFechaHoraElab.Name = "GBFechaHoraElab";
            GBFechaHoraElab.Size = new Size(504, 209);
            GBFechaHoraElab.TabIndex = 75;
            GBFechaHoraElab.Text = "Fecha y Hora";
            GBFechaHoraElab.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // DTPHoraLote
            // 
            DTPHoraLote.Anchor = AnchorStyles.None;
            DTPHoraLote.BorderRadius = 10;
            DTPHoraLote.Checked = true;
            DTPHoraLote.CustomFormat = "HH:mm:ss";
            DTPHoraLote.FillColor = Color.Black;
            DTPHoraLote.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DTPHoraLote.Format = DateTimePickerFormat.Time;
            DTPHoraLote.Location = new Point(361, 112);
            DTPHoraLote.Margin = new Padding(3, 4, 3, 4);
            DTPHoraLote.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DTPHoraLote.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DTPHoraLote.Name = "DTPHoraLote";
            DTPHoraLote.ShowUpDown = true;
            DTPHoraLote.Size = new Size(123, 37);
            DTPHoraLote.TabIndex = 59;
            DTPHoraLote.TextOffset = new Point(5, 0);
            DTPHoraLote.Value = new DateTime(2023, 2, 6, 1, 19, 20, 716);
            DTPHoraLote.Visible = false;
            DTPHoraLote.ValueChanged += DTPHoraLote_ValueChanged;
            // 
            // SRBFechaActual
            // 
            SRBFechaActual.Anchor = AnchorStyles.None;
            SRBFechaActual.AutoSize = true;
            SRBFechaActual.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            SRBFechaActual.CheckedState.BorderThickness = 0;
            SRBFechaActual.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            SRBFechaActual.CheckedState.InnerColor = Color.White;
            SRBFechaActual.CheckedState.InnerOffset = -4;
            SRBFechaActual.ForeColor = Color.Black;
            SRBFechaActual.Location = new Point(21, 67);
            SRBFechaActual.Margin = new Padding(3, 4, 3, 4);
            SRBFechaActual.Name = "SRBFechaActual";
            SRBFechaActual.Size = new Size(112, 34);
            SRBFechaActual.TabIndex = 56;
            SRBFechaActual.Text = "Actual";
            SRBFechaActual.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            SRBFechaActual.UncheckedState.BorderThickness = 2;
            SRBFechaActual.UncheckedState.FillColor = Color.Transparent;
            SRBFechaActual.UncheckedState.InnerColor = Color.Transparent;
            SRBFechaActual.CheckedChanged += SRBFechaActual_CheckedChanged;
            // 
            // SRBElegirFecha
            // 
            SRBElegirFecha.Anchor = AnchorStyles.None;
            SRBElegirFecha.AutoSize = true;
            SRBElegirFecha.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            SRBElegirFecha.CheckedState.BorderThickness = 0;
            SRBElegirFecha.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            SRBElegirFecha.CheckedState.InnerColor = Color.White;
            SRBElegirFecha.CheckedState.InnerOffset = -4;
            SRBElegirFecha.ForeColor = Color.Black;
            SRBElegirFecha.Location = new Point(165, 67);
            SRBElegirFecha.Margin = new Padding(3, 4, 3, 4);
            SRBElegirFecha.Name = "SRBElegirFecha";
            SRBElegirFecha.Size = new Size(98, 34);
            SRBElegirFecha.TabIndex = 57;
            SRBElegirFecha.Text = "Elegir";
            SRBElegirFecha.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            SRBElegirFecha.UncheckedState.BorderThickness = 2;
            SRBElegirFecha.UncheckedState.FillColor = Color.Transparent;
            SRBElegirFecha.UncheckedState.InnerColor = Color.Transparent;
            SRBElegirFecha.CheckedChanged += SRBElegirFecha_CheckedChanged;
            // 
            // DTPFechaLote
            // 
            DTPFechaLote.Anchor = AnchorStyles.None;
            DTPFechaLote.BorderRadius = 10;
            DTPFechaLote.Checked = true;
            DTPFechaLote.CustomFormat = "yyyy-MM-dd";
            DTPFechaLote.FillColor = Color.Black;
            DTPFechaLote.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DTPFechaLote.Format = DateTimePickerFormat.Custom;
            DTPFechaLote.Location = new Point(165, 112);
            DTPFechaLote.Margin = new Padding(3, 4, 3, 4);
            DTPFechaLote.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DTPFechaLote.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DTPFechaLote.Name = "DTPFechaLote";
            DTPFechaLote.Size = new Size(180, 37);
            DTPFechaLote.TabIndex = 58;
            DTPFechaLote.TextOffset = new Point(5, 0);
            DTPFechaLote.Value = new DateTime(2023, 3, 10, 0, 0, 0, 0);
            DTPFechaLote.Visible = false;
            DTPFechaLote.ValueChanged += DTPFechaLote_ValueChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.None;
            txtCantidad.BorderRadius = 20;
            txtCantidad.DefaultText = "";
            txtCantidad.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCantidad.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCantidad.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCantidad.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCantidad.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCantidad.Location = new Point(334, 38);
            txtCantidad.Margin = new Padding(3, 7, 3, 7);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PasswordChar = '\0';
            txtCantidad.PlaceholderText = "";
            txtCantidad.SelectedText = "";
            txtCantidad.Size = new Size(229, 55);
            txtCantidad.TabIndex = 74;
            txtCantidad.TextOffset = new Point(5, 0);
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // siticoneHtmlLabel4
            // 
            siticoneHtmlLabel4.Anchor = AnchorStyles.None;
            siticoneHtmlLabel4.BackColor = Color.Transparent;
            siticoneHtmlLabel4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel4.Location = new Point(59, 38);
            siticoneHtmlLabel4.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            siticoneHtmlLabel4.Size = new Size(126, 34);
            siticoneHtmlLabel4.TabIndex = 73;
            siticoneHtmlLabel4.Text = "Cantidad";
            // 
            // Editar_Lote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(608, 546);
            Controls.Add(SBCancelar);
            Controls.Add(SBAceptar);
            Controls.Add(FechaHora_not_choose_in_Lote_label);
            Controls.Add(GBFechaHoraElab);
            Controls.Add(txtCantidad);
            Controls.Add(siticoneHtmlLabel4);
            Name = "Editar_Lote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Lote";
            GBFechaHoraElab.ResumeLayout(false);
            GBFechaHoraElab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBCancelar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBAceptar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel FechaHora_not_choose_in_Lote_label;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox GBFechaHoraElab;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker DTPHoraLote;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton SRBFechaActual;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton SRBElegirFecha;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker DTPFechaLote;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCantidad;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
    }
}