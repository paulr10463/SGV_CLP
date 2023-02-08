namespace SGV_CLP.GUI
{
    partial class UC_Proveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.Añadir = new System.Windows.Forms.TabPage();
            this.Editar = new System.Windows.Forms.TabPage();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.TabPage();
            this.siticoneTabControl1.SuspendLayout();
            this.Editar.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            this.siticoneTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.siticoneTabControl1.Controls.Add(this.Añadir);
            this.siticoneTabControl1.Controls.Add(this.Editar);
            this.siticoneTabControl1.Controls.Add(this.Eliminar);
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(220, 55);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(1709, 887);
            this.siticoneTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.siticoneTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(220, 55);
            this.siticoneTabControl1.TabIndex = 2;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.Black;
            // 
            // Añadir
            // 
            this.Añadir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Añadir.Location = new System.Drawing.Point(224, 4);
            this.Añadir.Name = "Añadir";
            this.Añadir.Padding = new System.Windows.Forms.Padding(3);
            this.Añadir.Size = new System.Drawing.Size(1481, 879);
            this.Añadir.TabIndex = 0;
            this.Añadir.Text = "Registrar Proveedor";
            this.Añadir.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            this.Editar.Controls.Add(this.siticonePanel1);
            this.Editar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Editar.Location = new System.Drawing.Point(224, 4);
            this.Editar.Name = "Editar";
            this.Editar.Padding = new System.Windows.Forms.Padding(3);
            this.Editar.Size = new System.Drawing.Size(1481, 879);
            this.Editar.TabIndex = 1;
            this.Editar.Text = "Modificar Proveedor";
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticoneDataGridView1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.Location = new System.Drawing.Point(3, 354);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(1475, 522);
            this.siticonePanel1.TabIndex = 1;
            // 
            // siticoneDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.siticoneDataGridView1.ColumnHeadersHeight = 50;
            this.siticoneDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.CC,
            this.Contras,
            this.Nombre,
            this.Ape,
            this.Cargo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.siticoneDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.siticoneDataGridView1.Name = "siticoneDataGridView1";
            this.siticoneDataGridView1.RowHeadersVisible = false;
            this.siticoneDataGridView1.RowTemplate.Height = 25;
            this.siticoneDataGridView1.Size = new System.Drawing.Size(1475, 522);
            this.siticoneDataGridView1.TabIndex = 0;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            this.siticoneDataGridView1.ThemeStyle.ReadOnly = false;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 25;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // User
            // 
            this.User.HeaderText = "Nombre de Usuario";
            this.User.Name = "User";
            // 
            // CC
            // 
            this.CC.HeaderText = "CC";
            this.CC.Name = "CC";
            // 
            // Contras
            // 
            this.Contras.HeaderText = "Contraseña";
            this.Contras.Name = "Contras";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombres";
            this.Nombre.Name = "Nombre";
            // 
            // Ape
            // 
            this.Ape.HeaderText = "Apellidos";
            this.Ape.Name = "Ape";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Eliminar.Location = new System.Drawing.Point(224, 4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(1481, 879);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar Proveedor";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // UC_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneTabControl1);
            this.Name = "UC_Proveedores";
            this.Size = new System.Drawing.Size(1709, 887);
            this.siticoneTabControl1.ResumeLayout(false);
            this.Editar.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage Añadir;
        private TabPage Editar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn CC;
        private DataGridViewTextBoxColumn Contras;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Ape;
        private DataGridViewTextBoxColumn Cargo;
        private TabPage Eliminar;
    }
}
