using SGV_CLP.Classes;
using SGV_CLP.GUI.Módulo_Clientes;
using SGV_CLP.GUI.Módulo_Proveedores;
using Siticone.Desktop.UI.WinForms;
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
    public partial class UC_Proveedores : UserControl
    {
        List<Proveedor> ProovedoresRegistrados = new List<Proveedor>();

        public UC_Proveedores()
        {
            InitializeComponent();
            Proveedor pr1 = new Proveedor("795641569", "Nestle", "ULTIMAS NOTICIAS E37-78 Y EL COMERCIO", "026849853");
            Proveedor pr2 = new Proveedor("298668742", "Juan García", "Mercadillo Oe3-113 y Ulloa", "021549863");
            Proveedor pr3 = new Proveedor("863971548", "Andrés Algüacil", "AV.AMAZONAS N34-159 E IÑAQUITO", "026987453");

            ProovedoresRegistrados.Add(pr1);
            ProovedoresRegistrados.Add(pr2);
            ProovedoresRegistrados.Add(pr3);

            llenarTablaProveedor();
        }

        public void llenarTablaProveedor()
        {
            if (ProovedoresRegistrados != null)
            {
                SDGVProveedor.Rows.Clear();
                foreach (Proveedor proveedor in ProovedoresRegistrados)
                {
                    // dgvClientes
                    SDGVProveedor.Rows.Add(proveedor.Ruc, proveedor.Nombre, proveedor.Direccion, proveedor.Telefono);
                }
            }
        }

        private void SBAniadirProveedor_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor(
                txtRUC.Text,
                txtNombreProv.Text,
                txtDirec.Text,
                txtTelefono.Text
                );

            ProovedoresRegistrados.Add(proveedor);
            llenarTablaProveedor();

            SystemSounds.Beep.Play();
            MessageBox.Show("Proveedor añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SDGVProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SDGVProveedor.Columns[e.ColumnIndex].Name == "ColumnaEliminarProveedor")
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este proveedor?", "Eliminar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        /*clientes.RemoveAt(e.RowIndex);
                        siticoneDataGridView1.Rows.Clear();
                        foreach (Cliente c in clientes)
                        {
                            //siticoneDataGridView1.Rows.Add(c.cedula, c.nombres, c.apellidos, c.direccion, c.telefono);
                        }
                        */
                    }
                }
            }

            if (SDGVProveedor.Columns[e.ColumnIndex].Name == "ColumnaEditarProveedor")
            {
                if (e.RowIndex >= 0)
                {
                    // String cedula = SDGVProveedor.Rows[e.RowIndex].Cells["ColumnaCedula"].Value.ToString();
                    Editar_Proveedor ventana = new Editar_Proveedor();
                    ventana.ShowDialog();
                }
            }
        }
    }
}
