namespace SGV_CLP.GUI.Módulo_Administración
{
    partial class Editar_Parametro_Por_Unidad
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
            this.cBox_ProductosParam = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.numUpDown_UnidadBase = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.numUpDown_UnidadExtra = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.SBAceptar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SBCancelar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.label_SinNombProd = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.label_SinUnidadExtra = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.label_SinUnidadBase = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UnidadBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UnidadExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // cBox_ProductosParam
            // 
            this.cBox_ProductosParam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ProductosParam.BackColor = System.Drawing.Color.Transparent;
            this.cBox_ProductosParam.BorderRadius = 20;
            this.cBox_ProductosParam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBox_ProductosParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_ProductosParam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBox_ProductosParam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBox_ProductosParam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBox_ProductosParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBox_ProductosParam.ItemHeight = 40;
            this.cBox_ProductosParam.Items.AddRange(new object[] {
            "Humitas",
            "Tamales",
            "Cafe",
            "Empanadas"});
            this.cBox_ProductosParam.Location = new System.Drawing.Point(366, 295);
            this.cBox_ProductosParam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBox_ProductosParam.Name = "cBox_ProductosParam";
            this.cBox_ProductosParam.Size = new System.Drawing.Size(261, 46);
            this.cBox_ProductosParam.TabIndex = 59;
            this.cBox_ProductosParam.TextOffset = new System.Drawing.Point(5, 0);
            this.cBox_ProductosParam.SelectedIndexChanged += new System.EventHandler(this.cBox_ProductosParam_SelectedIndexChanged);
            // 
            // numUpDown_UnidadBase
            // 
            this.numUpDown_UnidadBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUpDown_UnidadBase.BackColor = System.Drawing.Color.White;
            this.numUpDown_UnidadBase.BorderRadius = 10;
            this.numUpDown_UnidadBase.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDown_UnidadBase.Location = new System.Drawing.Point(366, 50);
            this.numUpDown_UnidadBase.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numUpDown_UnidadBase.Name = "numUpDown_UnidadBase";
            this.numUpDown_UnidadBase.Size = new System.Drawing.Size(145, 50);
            this.numUpDown_UnidadBase.TabIndex = 58;
            this.numUpDown_UnidadBase.TextOffset = new System.Drawing.Point(5, 0);
            this.numUpDown_UnidadBase.UpDownButtonFillColor = System.Drawing.Color.Black;
            this.numUpDown_UnidadBase.UpDownButtonForeColor = System.Drawing.Color.White;
            this.numUpDown_UnidadBase.ValueChanged += new System.EventHandler(this.numUpDown_UnidadBase_ValueChanged);
            // 
            // numUpDown_UnidadExtra
            // 
            this.numUpDown_UnidadExtra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUpDown_UnidadExtra.BackColor = System.Drawing.Color.White;
            this.numUpDown_UnidadExtra.BorderRadius = 10;
            this.numUpDown_UnidadExtra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDown_UnidadExtra.Location = new System.Drawing.Point(366, 163);
            this.numUpDown_UnidadExtra.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numUpDown_UnidadExtra.Name = "numUpDown_UnidadExtra";
            this.numUpDown_UnidadExtra.Size = new System.Drawing.Size(145, 50);
            this.numUpDown_UnidadExtra.TabIndex = 57;
            this.numUpDown_UnidadExtra.TextOffset = new System.Drawing.Point(5, 0);
            this.numUpDown_UnidadExtra.UpDownButtonFillColor = System.Drawing.Color.Black;
            this.numUpDown_UnidadExtra.UpDownButtonForeColor = System.Drawing.Color.White;
            this.numUpDown_UnidadExtra.ValueChanged += new System.EventHandler(this.numUpDown_UnidadExtra_ValueChanged);
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(144, 60);
            this.siticoneHtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(128, 26);
            this.siticoneHtmlLabel4.TabIndex = 56;
            this.siticoneHtmlLabel4.Text = "Unidad Base";
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(144, 171);
            this.siticoneHtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(128, 26);
            this.siticoneHtmlLabel3.TabIndex = 55;
            this.siticoneHtmlLabel3.Text = "Unidad Extra";
            // 
            // SBAceptar
            // 
            this.SBAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SBAceptar.BorderRadius = 20;
            this.SBAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SBAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SBAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SBAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SBAceptar.FillColor = System.Drawing.Color.Black;
            this.SBAceptar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SBAceptar.ForeColor = System.Drawing.Color.White;
            this.SBAceptar.Location = new System.Drawing.Point(203, 415);
            this.SBAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SBAceptar.Name = "SBAceptar";
            this.SBAceptar.Size = new System.Drawing.Size(206, 57);
            this.SBAceptar.TabIndex = 60;
            this.SBAceptar.Text = "Aceptar";
            this.SBAceptar.Click += new System.EventHandler(this.SBAceptar_Click);
            // 
            // SBCancelar
            // 
            this.SBCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SBCancelar.BorderRadius = 20;
            this.SBCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SBCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SBCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SBCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SBCancelar.FillColor = System.Drawing.Color.Black;
            this.SBCancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SBCancelar.ForeColor = System.Drawing.Color.White;
            this.SBCancelar.Location = new System.Drawing.Point(435, 415);
            this.SBCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SBCancelar.Name = "SBCancelar";
            this.SBCancelar.Size = new System.Drawing.Size(206, 57);
            this.SBCancelar.TabIndex = 61;
            this.SBCancelar.Text = "Cancelar";
            this.SBCancelar.Click += new System.EventHandler(this.SBCancelar_Click);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(175, 305);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(97, 26);
            this.siticoneHtmlLabel1.TabIndex = 62;
            this.siticoneHtmlLabel1.Text = "Producto";
            // 
            // label_SinNombProd
            // 
            this.label_SinNombProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_SinNombProd.BackColor = System.Drawing.Color.Transparent;
            this.label_SinNombProd.ForeColor = System.Drawing.Color.Red;
            this.label_SinNombProd.Location = new System.Drawing.Point(671, 310);
            this.label_SinNombProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_SinNombProd.Name = "label_SinNombProd";
            this.label_SinNombProd.Size = new System.Drawing.Size(153, 21);
            this.label_SinNombProd.TabIndex = 73;
            this.label_SinNombProd.Text = "¡Seleccione un producto!";
            // 
            // label_SinUnidadExtra
            // 
            this.label_SinUnidadExtra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_SinUnidadExtra.BackColor = System.Drawing.Color.Transparent;
            this.label_SinUnidadExtra.ForeColor = System.Drawing.Color.Red;
            this.label_SinUnidadExtra.Location = new System.Drawing.Point(562, 176);
            this.label_SinUnidadExtra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_SinUnidadExtra.Name = "label_SinUnidadExtra";
            this.label_SinUnidadExtra.Size = new System.Drawing.Size(129, 21);
            this.label_SinUnidadExtra.TabIndex = 72;
            this.label_SinUnidadExtra.Text = "¡Ingrese una unidad!";
            // 
            // label_SinUnidadBase
            // 
            this.label_SinUnidadBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_SinUnidadBase.BackColor = System.Drawing.Color.Transparent;
            this.label_SinUnidadBase.ForeColor = System.Drawing.Color.Red;
            this.label_SinUnidadBase.Location = new System.Drawing.Point(562, 60);
            this.label_SinUnidadBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_SinUnidadBase.Name = "label_SinUnidadBase";
            this.label_SinUnidadBase.Size = new System.Drawing.Size(129, 21);
            this.label_SinUnidadBase.TabIndex = 71;
            this.label_SinUnidadBase.Text = "¡Ingrese una unidad!";
            // 
            // Editar_Parametro_Por_Unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 540);
            this.Controls.Add(this.label_SinNombProd);
            this.Controls.Add(this.label_SinUnidadExtra);
            this.Controls.Add(this.label_SinUnidadBase);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.SBCancelar);
            this.Controls.Add(this.SBAceptar);
            this.Controls.Add(this.cBox_ProductosParam);
            this.Controls.Add(this.numUpDown_UnidadBase);
            this.Controls.Add(this.numUpDown_UnidadExtra);
            this.Controls.Add(this.siticoneHtmlLabel4);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Name = "Editar_Parametro_Por_Unidad";
            this.Text = "Editar parametro por unidad";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UnidadBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UnidadExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cBox_ProductosParam;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numUpDown_UnidadBase;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numUpDown_UnidadExtra;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBAceptar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBCancelar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label_SinNombProd;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label_SinUnidadExtra;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label_SinUnidadBase;
    }
}