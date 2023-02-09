using SGV_CLP.Classes;
using SGV_CLP.GUI.Módulo_Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SGV_CLP.GUI
{
    public partial class UC_Clientes : UserControl
    {

        List<Cliente> clientes = new List<Cliente>();
        public UC_Clientes()
        {
            InitializeComponent();
        }

        private void registrarCliente(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
                txtCedulaCliente.Text,
                txtPrimerNombreCliente.Text + " " + txtSegundoNombreCliente.Text,
                txtPrimerApellidoCliente.Text + " " + txtSegundoApellidoCliente.Text,
                txtDireccionCliente.Text,
                txtTelefonoCliente.Text);

            clientes.Add(cliente);
            siticoneDataGridView1.Rows.Clear();
            foreach (Cliente c in clientes)
            {
                siticoneDataGridView1.Rows.Add(c.cedula, c.nombres, c.apellidos, c.direccion, c.telefono);
            }

            SystemSounds.Beep.Play();
            MessageBox.Show("Cliente añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar_Eliminar_Cliente ventana = new Editar_Eliminar_Cliente();
            ventana.ShowDialog();
        }

        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Eliminar.Width;
                var h = Properties.Resources.Eliminar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Eliminar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

    }
}
