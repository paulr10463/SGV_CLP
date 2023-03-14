
using SGV_CLP.GUI;

namespace SGV_CLP
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton6 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton5 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneButton7 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(components);
            siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            uC_Clientes1 = new UC_Customers();
            uC_Ventas1 = new UC_Ventas();
            uC_Compras1 = new UC_Compras();
            uC_Productos1 = new UC_Products();
            uC_Proveedores1 = new UC_Proveedores();
            uC_Administracion1 = new UC_Administracion();
            siticonePanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)siticoneCirclePictureBox1).BeginInit();
            siticoneCustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.Controls.Add(flowLayoutPanel1);
            siticonePanel1.Controls.Add(siticoneHtmlLabel2);
            siticonePanel1.Controls.Add(siticoneButton7);
            siticonePanel1.Controls.Add(siticoneCirclePictureBox1);
            siticonePanel1.Dock = DockStyle.Left;
            siticonePanel1.Location = new Point(0, 0);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(227, 1033);
            siticonePanel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(siticoneButton4);
            flowLayoutPanel1.Controls.Add(siticoneButton3);
            flowLayoutPanel1.Controls.Add(siticoneButton2);
            flowLayoutPanel1.Controls.Add(siticoneButton6);
            flowLayoutPanel1.Controls.Add(siticoneButton5);
            flowLayoutPanel1.Controls.Add(siticoneButton1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 255);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(221, 323);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // siticoneButton4
            // 
            siticoneButton4.Animated = true;
            siticoneButton4.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            siticoneButton4.CheckedState.CustomBorderColor = Color.Black;
            siticoneButton4.CustomBorderThickness = new Padding(5, 0, 0, 0);
            siticoneButton4.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton4.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton4.FillColor = Color.White;
            siticoneButton4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton4.ForeColor = Color.Black;
            siticoneButton4.ImageAlign = HorizontalAlignment.Left;
            siticoneButton4.ImageOffset = new Point(10, 0);
            siticoneButton4.Location = new Point(3, 3);
            siticoneButton4.Name = "siticoneButton4";
            siticoneButton4.PressedDepth = 0;
            siticoneButton4.RightToLeft = RightToLeft.No;
            siticoneButton4.Size = new Size(226, 45);
            siticoneButton4.TabIndex = 9;
            siticoneButton4.Text = "Clientes";
            siticoneButton4.TextAlign = HorizontalAlignment.Left;
            siticoneButton4.TextOffset = new Point(20, 0);
            siticoneButton4.CheckedChanged += siticoneButton4_CheckedChanged;
            // 
            // siticoneButton3
            // 
            siticoneButton3.Animated = true;
            siticoneButton3.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            siticoneButton3.CheckedState.CustomBorderColor = Color.Black;
            siticoneButton3.CustomBorderThickness = new Padding(5, 0, 0, 0);
            siticoneButton3.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton3.FillColor = Color.White;
            siticoneButton3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton3.ForeColor = Color.Black;
            siticoneButton3.ImageAlign = HorizontalAlignment.Left;
            siticoneButton3.ImageOffset = new Point(10, 0);
            siticoneButton3.Location = new Point(3, 54);
            siticoneButton3.Name = "siticoneButton3";
            siticoneButton3.PressedDepth = 0;
            siticoneButton3.Size = new Size(226, 45);
            siticoneButton3.TabIndex = 8;
            siticoneButton3.Text = "Ventas";
            siticoneButton3.TextAlign = HorizontalAlignment.Left;
            siticoneButton3.TextOffset = new Point(20, 0);
            siticoneButton3.CheckedChanged += siticoneButton3_CheckedChanged;
            // 
            // siticoneButton2
            // 
            siticoneButton2.Animated = true;
            siticoneButton2.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            siticoneButton2.CheckedState.CustomBorderColor = Color.Black;
            siticoneButton2.CustomBorderThickness = new Padding(5, 0, 0, 0);
            siticoneButton2.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton2.FillColor = Color.White;
            siticoneButton2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton2.ForeColor = Color.Black;
            siticoneButton2.ImageAlign = HorizontalAlignment.Left;
            siticoneButton2.ImageOffset = new Point(10, 0);
            siticoneButton2.Location = new Point(3, 105);
            siticoneButton2.Name = "siticoneButton2";
            siticoneButton2.PressedDepth = 0;
            siticoneButton2.Size = new Size(226, 45);
            siticoneButton2.TabIndex = 7;
            siticoneButton2.Text = "Compras";
            siticoneButton2.TextAlign = HorizontalAlignment.Left;
            siticoneButton2.TextOffset = new Point(20, 0);
            siticoneButton2.CheckedChanged += siticoneButton2_CheckedChanged;
            // 
            // siticoneButton6
            // 
            siticoneButton6.Animated = true;
            siticoneButton6.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            siticoneButton6.CheckedState.CustomBorderColor = Color.Black;
            siticoneButton6.CustomBorderThickness = new Padding(5, 0, 0, 0);
            siticoneButton6.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton6.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton6.FillColor = Color.White;
            siticoneButton6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton6.ForeColor = Color.Black;
            siticoneButton6.ImageAlign = HorizontalAlignment.Left;
            siticoneButton6.ImageOffset = new Point(10, 0);
            siticoneButton6.Location = new Point(3, 156);
            siticoneButton6.Name = "siticoneButton6";
            siticoneButton6.PressedDepth = 0;
            siticoneButton6.Size = new Size(226, 45);
            siticoneButton6.TabIndex = 11;
            siticoneButton6.Text = "Productos";
            siticoneButton6.TextAlign = HorizontalAlignment.Left;
            siticoneButton6.TextOffset = new Point(20, 0);
            siticoneButton6.CheckedChanged += siticoneButton6_CheckedChanged;
            // 
            // siticoneButton5
            // 
            siticoneButton5.Animated = true;
            siticoneButton5.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            siticoneButton5.CheckedState.CustomBorderColor = Color.Black;
            siticoneButton5.CustomBorderThickness = new Padding(5, 0, 0, 0);
            siticoneButton5.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton5.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton5.FillColor = Color.White;
            siticoneButton5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton5.ForeColor = Color.Black;
            siticoneButton5.ImageAlign = HorizontalAlignment.Left;
            siticoneButton5.ImageOffset = new Point(10, 0);
            siticoneButton5.Location = new Point(3, 207);
            siticoneButton5.Name = "siticoneButton5";
            siticoneButton5.PressedDepth = 0;
            siticoneButton5.Size = new Size(226, 45);
            siticoneButton5.TabIndex = 10;
            siticoneButton5.Text = "Proveedores";
            siticoneButton5.TextAlign = HorizontalAlignment.Left;
            siticoneButton5.TextOffset = new Point(20, 0);
            siticoneButton5.CheckedChanged += siticoneButton5_CheckedChanged;
            // 
            // siticoneButton1
            // 
            siticoneButton1.Animated = true;
            siticoneButton1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            siticoneButton1.CheckedState.CustomBorderColor = Color.Black;
            siticoneButton1.CustomBorderThickness = new Padding(5, 0, 0, 0);
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.FillColor = Color.White;
            siticoneButton1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.Black;
            siticoneButton1.ImageAlign = HorizontalAlignment.Left;
            siticoneButton1.ImageOffset = new Point(10, 0);
            siticoneButton1.Location = new Point(3, 258);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.PressedDepth = 0;
            siticoneButton1.Size = new Size(226, 45);
            siticoneButton1.TabIndex = 0;
            siticoneButton1.Text = "Administración";
            siticoneButton1.TextAlign = HorizontalAlignment.Left;
            siticoneButton1.TextOffset = new Point(20, 0);
            siticoneButton1.CheckedChanged += siticoneButton1_CheckedChanged;
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.Anchor = AnchorStyles.None;
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(52, 21);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(17, 25);
            siticoneHtmlLabel2.TabIndex = 13;
            siticoneHtmlLabel2.Text = "a";
            // 
            // siticoneButton7
            // 
            siticoneButton7.Anchor = AnchorStyles.Bottom;
            siticoneButton7.BorderRadius = 20;
            siticoneButton7.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton7.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton7.FillColor = Color.Black;
            siticoneButton7.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton7.ForeColor = Color.White;
            siticoneButton7.Location = new Point(25, 952);
            siticoneButton7.Name = "siticoneButton7";
            siticoneButton7.Size = new Size(189, 45);
            siticoneButton7.TabIndex = 12;
            siticoneButton7.Text = "Cerrar sesión";
            siticoneButton7.Click += siticoneButton7_Click_1;
            // 
            // siticoneCirclePictureBox1
            // 
            siticoneCirclePictureBox1.Image = (Image)resources.GetObject("siticoneCirclePictureBox1.Image");
            siticoneCirclePictureBox1.ImageRotate = 0F;
            siticoneCirclePictureBox1.Location = new Point(25, 63);
            siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            siticoneCirclePictureBox1.Size = new Size(174, 161);
            siticoneCirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            siticoneCirclePictureBox1.TabIndex = 0;
            siticoneCirclePictureBox1.TabStop = false;
            // 
            // siticoneDragControl1
            // 
            siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            siticoneDragControl1.UseTransparentDrag = true;
            // 
            // siticoneCustomGradientPanel1
            // 
            siticoneCustomGradientPanel1.Controls.Add(uC_Clientes1);
            siticoneCustomGradientPanel1.Controls.Add(uC_Ventas1);
            siticoneCustomGradientPanel1.Controls.Add(uC_Compras1);
            siticoneCustomGradientPanel1.Controls.Add(uC_Productos1);
            siticoneCustomGradientPanel1.Controls.Add(uC_Proveedores1);
            siticoneCustomGradientPanel1.Controls.Add(uC_Administracion1);
            siticoneCustomGradientPanel1.Dock = DockStyle.Fill;
            siticoneCustomGradientPanel1.Location = new Point(227, 0);
            siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            siticoneCustomGradientPanel1.Size = new Size(1675, 1033);
            siticoneCustomGradientPanel1.TabIndex = 4;
            // 
            // uC_Clientes1
            // 
            uC_Clientes1.Dock = DockStyle.Fill;
            uC_Clientes1.Location = new Point(0, 0);
            uC_Clientes1.Margin = new Padding(3, 4, 3, 4);
            uC_Clientes1.Name = "uC_Clientes1";
            uC_Clientes1.Size = new Size(1675, 1033);
            uC_Clientes1.TabIndex = 5;
            // 
            // uC_Ventas1
            // 
            uC_Ventas1.Dock = DockStyle.Fill;
            uC_Ventas1.Location = new Point(0, 0);
            uC_Ventas1.Margin = new Padding(3, 4, 3, 4);
            uC_Ventas1.Name = "uC_Ventas1";
            uC_Ventas1.Size = new Size(1675, 1033);
            uC_Ventas1.TabIndex = 4;
            // 
            // uC_Compras1
            // 
            uC_Compras1.Dock = DockStyle.Fill;
            uC_Compras1.Location = new Point(0, 0);
            uC_Compras1.Margin = new Padding(3, 4, 3, 4);
            uC_Compras1.Name = "uC_Compras1";
            uC_Compras1.Size = new Size(1675, 1033);
            uC_Compras1.TabIndex = 3;
            // 
            // uC_Productos1
            // 
            uC_Productos1.Dock = DockStyle.Fill;
            uC_Productos1.Location = new Point(0, 0);
            uC_Productos1.Margin = new Padding(3, 4, 3, 4);
            uC_Productos1.Name = "uC_Productos1";
            uC_Productos1.Size = new Size(1675, 1033);
            uC_Productos1.TabIndex = 2;
            // 
            // uC_Proveedores1
            // 
            uC_Proveedores1.Dock = DockStyle.Fill;
            uC_Proveedores1.Location = new Point(0, 0);
            uC_Proveedores1.Margin = new Padding(3, 4, 3, 4);
            uC_Proveedores1.Name = "uC_Proveedores1";
            uC_Proveedores1.Size = new Size(1675, 1033);
            uC_Proveedores1.TabIndex = 1;
            // 
            // uC_Administracion1
            // 
            uC_Administracion1.Dock = DockStyle.Fill;
            uC_Administracion1.Location = new Point(0, 0);
            uC_Administracion1.Margin = new Padding(3, 4, 3, 4);
            uC_Administracion1.Name = "uC_Administracion1";
            uC_Administracion1.Size = new Size(1675, 1033);
            uC_Administracion1.TabIndex = 0;
            // 
            // MainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(siticoneCustomGradientPanel1);
            Controls.Add(siticonePanel1);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGV-CLP";
            WindowState = FormWindowState.Maximized;
            siticonePanel1.ResumeLayout(false);
            siticonePanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)siticoneCirclePictureBox1).EndInit();
            siticoneCustomGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton7;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private GUI.UC_Customers uC_Clientes1;
        private GUI.UC_Compras uC_Compras1;
        private GUI.UC_Products uC_Productos1;
        private GUI.UC_Proveedores uC_Proveedores1;
        private GUI.UC_Administracion uC_Administracion1;
        private UC_Ventas uC_Ventas1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}