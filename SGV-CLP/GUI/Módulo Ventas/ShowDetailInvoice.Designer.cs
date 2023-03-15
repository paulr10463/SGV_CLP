namespace SGV_CLP.GUI.Módulo_Ventas
{
    partial class ShowDetailInvoice
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDetailInvoice));
            siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            CC = new DataGridViewTextBoxColumn();
            Contras = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            CodNotaVentaLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            TotalLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ((System.ComponentModel.ISupportInitialize)siticoneDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // siticoneDataGridView1
            // 
            siticoneDataGridView1.AllowUserToResizeColumns = false;
            siticoneDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            siticoneDataGridView1.Anchor = AnchorStyles.None;
            siticoneDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            siticoneDataGridView1.ColumnHeadersHeight = 50;
            siticoneDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            siticoneDataGridView1.Columns.AddRange(new DataGridViewColumn[] { CC, Contras, Nombre });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            siticoneDataGridView1.GridColor = Color.White;
            siticoneDataGridView1.Location = new Point(26, 112);
            siticoneDataGridView1.Margin = new Padding(3, 4, 3, 4);
            siticoneDataGridView1.Name = "siticoneDataGridView1";
            siticoneDataGridView1.RowHeadersVisible = false;
            siticoneDataGridView1.RowHeadersWidth = 51;
            siticoneDataGridView1.RowTemplate.Height = 25;
            siticoneDataGridView1.Size = new Size(582, 728);
            siticoneDataGridView1.TabIndex = 55;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.GridColor = Color.White;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.DimGray;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            siticoneDataGridView1.ThemeStyle.ReadOnly = false;
            siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 25;
            siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // CC
            // 
            CC.HeaderText = "Nombre Producto";
            CC.MinimumWidth = 6;
            CC.Name = "CC";
            // 
            // Contras
            // 
            Contras.HeaderText = "Cantidad";
            Contras.MinimumWidth = 6;
            Contras.Name = "Contras";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Subtotal";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // CodNotaVentaLabel
            // 
            CodNotaVentaLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CodNotaVentaLabel.BackColor = Color.Transparent;
            CodNotaVentaLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            CodNotaVentaLabel.Location = new Point(153, 36);
            CodNotaVentaLabel.Margin = new Padding(3, 4, 3, 4);
            CodNotaVentaLabel.Name = "CodNotaVentaLabel";
            CodNotaVentaLabel.Size = new Size(309, 42);
            CodNotaVentaLabel.TabIndex = 56;
            CodNotaVentaLabel.Text = "siticoneHtmlLabel1";
            CodNotaVentaLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TotalLabel.BackColor = Color.Transparent;
            TotalLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLabel.Location = new Point(202, 891);
            TotalLabel.Margin = new Padding(3, 4, 3, 4);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(188, 42);
            TotalLabel.TabIndex = 57;
            TotalLabel.Text = "Total: $X.XX";
            TotalLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ShowDetailInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 1007);
            Controls.Add(TotalLabel);
            Controls.Add(CodNotaVentaLabel);
            Controls.Add(siticoneDataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShowDetailInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowDetailInvoice";
            ((System.ComponentModel.ISupportInitialize)siticoneDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private DataGridViewTextBoxColumn CC;
        private DataGridViewTextBoxColumn Contras;
        private DataGridViewTextBoxColumn Nombre;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel CodNotaVentaLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel TotalLabel;
    }
}