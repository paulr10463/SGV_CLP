namespace SGV_CLP.GUI.Módulo_Ventas
{
    partial class UC_Item
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
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneNumericUpDown1 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 10;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.Black;
            this.siticoneButton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(82, 154);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(71, 36);
            this.siticoneButton1.TabIndex = 7;
            this.siticoneButton1.Text = "Añadir";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(59, 14);
            this.siticoneHtmlLabel1.MinimumSize = new System.Drawing.Size(60, 25);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(60, 25);
            this.siticoneHtmlLabel1.TabIndex = 5;
            this.siticoneHtmlLabel1.Text = null;
            // 
            // siticoneNumericUpDown1
            // 
            this.siticoneNumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneNumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneNumericUpDown1.Location = new System.Drawing.Point(19, 154);
            this.siticoneNumericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.siticoneNumericUpDown1.Name = "siticoneNumericUpDown1";
            this.siticoneNumericUpDown1.Size = new System.Drawing.Size(56, 36);
            this.siticoneNumericUpDown1.TabIndex = 6;
            this.siticoneNumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.Black;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(24, 48);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(124, 86);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 4;
            this.siticonePictureBox1.TabStop = false;
            // 
            // UC_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.siticoneNumericUpDown1);
            this.Controls.Add(this.siticonePictureBox1);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(173, 205);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
    }
}
