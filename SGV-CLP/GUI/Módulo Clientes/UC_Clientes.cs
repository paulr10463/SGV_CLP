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

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (siticoneDataGridView1.Columns[e.ColumnIndex].Name == "ColumnaEliminar")
            {
                if (MessageBox.Show("¿Está seguro de eliminar este cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clientes.RemoveAt(e.RowIndex);
                    siticoneDataGridView1.Rows.Clear();
                    foreach (Cliente c in clientes)
                    {
                        siticoneDataGridView1.Rows.Add(c.cedula, c.nombres, c.apellidos, c.direccion, c.telefono);
                    }
                }
            }

            if (siticoneDataGridView1.Columns[e.ColumnIndex].Name == "ColumnaEditar")
            {
                String cedula = siticoneDataGridView1.Rows[e.RowIndex].Cells["ColumnaCedula"].Value.ToString();
                Editar_Eliminar_Cliente ventana = new Editar_Eliminar_Cliente(cedula);
                ventana.ShowDialog();
            }

        }
    }
}
