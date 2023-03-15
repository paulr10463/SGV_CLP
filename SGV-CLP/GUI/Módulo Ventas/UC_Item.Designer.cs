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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Item));
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneNumericUpDown1 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            ((System.ComponentModel.ISupportInitialize)siticoneNumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // siticoneButton1
            // 
            siticoneButton1.BorderRadius = 10;
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.FillColor = Color.Black;
            siticoneButton1.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.White;
            siticoneButton1.Location = new Point(94, 205);
            siticoneButton1.Margin = new Padding(3, 4, 3, 4);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.Size = new Size(81, 48);
            siticoneButton1.TabIndex = 7;
            siticoneButton1.Text = "Añadir";
            siticoneButton1.Click += siticoneButton1_Click;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(2, 23);
            siticoneHtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel1.MinimumSize = new Size(194, 33);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(194, 33);
            siticoneHtmlLabel1.TabIndex = 6;
            siticoneHtmlLabel1.Text = null;
            siticoneHtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // siticoneNumericUpDown1
            // 
            siticoneNumericUpDown1.BackColor = Color.Transparent;
            siticoneNumericUpDown1.BorderRadius = 10;
            siticoneNumericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneNumericUpDown1.Location = new Point(22, 205);
            siticoneNumericUpDown1.Margin = new Padding(5, 4, 5, 4);
            siticoneNumericUpDown1.Name = "siticoneNumericUpDown1";
            siticoneNumericUpDown1.Size = new Size(64, 48);
            siticoneNumericUpDown1.TabIndex = 6;
            siticoneNumericUpDown1.UpDownButtonFillColor = Color.Black;
            siticoneNumericUpDown1.UpDownButtonForeColor = Color.White;
            siticoneNumericUpDown1.ValueChanged += siticoneNumericUpDown1_ValueChanged;
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.ImageRotate = 0F;
            siticonePictureBox1.InitialImage = (Image)resources.GetObject("siticonePictureBox1.InitialImage");
            siticonePictureBox1.Location = new Point(27, 64);
            siticonePictureBox1.Margin = new Padding(3, 4, 3, 4);
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.Size = new Size(142, 115);
            siticonePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            siticonePictureBox1.TabIndex = 4;
            siticonePictureBox1.TabStop = false;
            // 
            // UC_Item
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticoneButton1);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(siticoneNumericUpDown1);
            Controls.Add(siticonePictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Item";
            Size = new Size(198, 273);
            ((System.ComponentModel.ISupportInitialize)siticoneNumericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
    }
}
