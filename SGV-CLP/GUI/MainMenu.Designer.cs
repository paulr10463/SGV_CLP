
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneButton5 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton6 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.uC_Administracion1 = new SGV_CLP.GUI.UC_Administracion();
            this.uC_Compras1 = new SGV_CLP.GUI.UC_Compras();
            this.uC_Ventas1 = new SGV_CLP.GUI.UC_Ventas();
            this.uC_Clientes1 = new SGV_CLP.GUI.UC_Clientes();
            this.uC_Proveedores1 = new SGV_CLP.GUI.UC_Proveedores();
            this.uC_Productos1 = new SGV_CLP.GUI.UC_Productos();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticoneCirclePictureBox1);
            this.siticonePanel1.Controls.Add(this.siticoneButton5);
            this.siticonePanel1.Controls.Add(this.siticoneButton6);
            this.siticonePanel1.Controls.Add(this.siticoneButton4);
            this.siticonePanel1.Controls.Add(this.siticoneButton3);
            this.siticonePanel1.Controls.Add(this.siticoneButton2);
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(260, 813);
            this.siticonePanel1.TabIndex = 3;
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox1.Image")));
            this.siticoneCirclePictureBox1.ImageRotate = 0F;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(39, 39);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(174, 161);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticoneCirclePictureBox1.TabIndex = 0;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.Animated = true;
            this.siticoneButton5.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton5.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.siticoneButton5.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.siticoneButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton5.FillColor = System.Drawing.Color.White;
            this.siticoneButton5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton5.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton5.ImageOffset = new System.Drawing.Point(10, 0);
            this.siticoneButton5.Location = new System.Drawing.Point(1, 494);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.PressedDepth = 0;
            this.siticoneButton5.Size = new System.Drawing.Size(256, 45);
            this.siticoneButton5.TabIndex = 10;
            this.siticoneButton5.Text = "Proveedores";
            this.siticoneButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton5.TextOffset = new System.Drawing.Point(20, 0);
            this.siticoneButton5.CheckedChanged += new System.EventHandler(this.siticoneButton5_CheckedChanged);
            // 
            // siticoneButton6
            // 
            this.siticoneButton6.Animated = true;
            this.siticoneButton6.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton6.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.siticoneButton6.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.siticoneButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton6.FillColor = System.Drawing.Color.White;
            this.siticoneButton6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton6.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton6.ImageOffset = new System.Drawing.Point(10, 0);
            this.siticoneButton6.Location = new System.Drawing.Point(1, 541);
            this.siticoneButton6.Name = "siticoneButton6";
            this.siticoneButton6.PressedDepth = 0;
            this.siticoneButton6.Size = new System.Drawing.Size(256, 45);
            this.siticoneButton6.TabIndex = 11;
            this.siticoneButton6.Text = "Productos";
            this.siticoneButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton6.TextOffset = new System.Drawing.Point(20, 0);
            this.siticoneButton6.CheckedChanged += new System.EventHandler(this.siticoneButton6_CheckedChanged);
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.Animated = true;
            this.siticoneButton4.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton4.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.siticoneButton4.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.siticoneButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton4.FillColor = System.Drawing.Color.White;
            this.siticoneButton4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton4.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton4.ImageOffset = new System.Drawing.Point(10, 0);
            this.siticoneButton4.Location = new System.Drawing.Point(1, 446);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.PressedDepth = 0;
            this.siticoneButton4.Size = new System.Drawing.Size(256, 45);
            this.siticoneButton4.TabIndex = 9;
            this.siticoneButton4.Text = "Clientes";
            this.siticoneButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton4.TextOffset = new System.Drawing.Point(20, 0);
            this.siticoneButton4.CheckedChanged += new System.EventHandler(this.siticoneButton4_CheckedChanged);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.Animated = true;
            this.siticoneButton3.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton3.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.siticoneButton3.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.FillColor = System.Drawing.Color.White;
            this.siticoneButton3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton3.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton3.ImageOffset = new System.Drawing.Point(10, 0);
            this.siticoneButton3.Location = new System.Drawing.Point(1, 398);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.PressedDepth = 0;
            this.siticoneButton3.Size = new System.Drawing.Size(256, 45);
            this.siticoneButton3.TabIndex = 8;
            this.siticoneButton3.Text = "Ventas";
            this.siticoneButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton3.TextOffset = new System.Drawing.Point(20, 0);
            this.siticoneButton3.CheckedChanged += new System.EventHandler(this.siticoneButton3_CheckedChanged);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.Animated = true;
            this.siticoneButton2.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton2.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.siticoneButton2.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.FillColor = System.Drawing.Color.White;
            this.siticoneButton2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton2.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton2.ImageOffset = new System.Drawing.Point(10, 0);
            this.siticoneButton2.Location = new System.Drawing.Point(1, 350);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.PressedDepth = 0;
            this.siticoneButton2.Size = new System.Drawing.Size(256, 45);
            this.siticoneButton2.TabIndex = 7;
            this.siticoneButton2.Text = "Compras";
            this.siticoneButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton2.TextOffset = new System.Drawing.Point(20, 0);
            this.siticoneButton2.CheckedChanged += new System.EventHandler(this.siticoneButton2_CheckedChanged);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Animated = true;
            this.siticoneButton1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton1.Checked = true;
            this.siticoneButton1.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.siticoneButton1.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.White;
            this.siticoneButton1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton1.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton1.ImageOffset = new System.Drawing.Point(10, 0);
            this.siticoneButton1.Location = new System.Drawing.Point(1, 302);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.PressedDepth = 0;
            this.siticoneButton1.Size = new System.Drawing.Size(256, 45);
            this.siticoneButton1.TabIndex = 0;
            this.siticoneButton1.Text = "Administracion";
            this.siticoneButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton1.TextOffset = new System.Drawing.Point(20, 0);
            this.siticoneButton1.CheckedChanged += new System.EventHandler(this.siticoneButton1_CheckedChanged);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.Controls.Add(this.uC_Proveedores1);
            this.siticoneGradientPanel1.Controls.Add(this.uC_Administracion1);
            this.siticoneGradientPanel1.Controls.Add(this.uC_Compras1);
            this.siticoneGradientPanel1.Controls.Add(this.uC_Ventas1);
            this.siticoneGradientPanel1.Controls.Add(this.uC_Clientes1);
            this.siticoneGradientPanel1.Controls.Add(this.uC_Productos1);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(260, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(1604, 813);
            this.siticoneGradientPanel1.TabIndex = 5;
            // 
            // uC_Administracion1
            // 
            this.uC_Administracion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Administracion1.Location = new System.Drawing.Point(0, 0);
            this.uC_Administracion1.Name = "uC_Administracion1";
            this.uC_Administracion1.Size = new System.Drawing.Size(1604, 813);
            this.uC_Administracion1.TabIndex = 12;
            // 
            // uC_Compras1
            // 
            this.uC_Compras1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Compras1.Location = new System.Drawing.Point(0, 0);
            this.uC_Compras1.Name = "uC_Compras1";
            this.uC_Compras1.Size = new System.Drawing.Size(1604, 813);
            this.uC_Compras1.TabIndex = 0;
            // 
            // uC_Ventas1
            // 
            this.uC_Ventas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Ventas1.Location = new System.Drawing.Point(0, 0);
            this.uC_Ventas1.Name = "uC_Ventas1";
            this.uC_Ventas1.Size = new System.Drawing.Size(1604, 813);
            this.uC_Ventas1.TabIndex = 12;
            // 
            // uC_Clientes1
            // 
            this.uC_Clientes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Clientes1.Location = new System.Drawing.Point(0, 0);
            this.uC_Clientes1.Name = "uC_Clientes1";
            this.uC_Clientes1.Size = new System.Drawing.Size(1604, 813);
            this.uC_Clientes1.TabIndex = 12;
            // 
            // uC_Proveedores1
            // 
            this.uC_Proveedores1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Proveedores1.Location = new System.Drawing.Point(0, 0);
            this.uC_Proveedores1.Name = "uC_Proveedores1";
            this.uC_Proveedores1.Size = new System.Drawing.Size(1604, 813);
            this.uC_Proveedores1.TabIndex = 12;
            // 
            // uC_Productos1
            // 
            this.uC_Productos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Productos1.Location = new System.Drawing.Point(0, 0);
            this.uC_Productos1.Name = "uC_Productos1";
            this.uC_Productos1.Size = new System.Drawing.Size(1604, 813);
            this.uC_Productos1.TabIndex = 12;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1864, 813);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.siticonePanel1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private GUI.UC_Compras uC_Compras1;
        private GUI.UC_Administracion uC_Administracion1;
        private GUI.UC_Ventas uC_Ventas1;
        private GUI.UC_Clientes uC_Clientes1;
        private GUI.UC_Proveedores uC_Proveedores1;
        private GUI.UC_Productos uC_Productos1;
    }
}