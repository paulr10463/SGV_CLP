using SGV_CLP.Classes;
using SGV_CLP.GUI.Customers_Module;
using SGV_CLP.GUI.Módulo_Compras;
using SGV_CLP.GUI.Módulo_Proveedores;
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
    public partial class UC_Compras : UserControl
    {
        List<Compra> comprasRegistradas = new List<Compra>();

        public UC_Compras()
        {
            InitializeComponent();
            Compra comp1 = new Compra("Comp01", "795641569", new DateTime(2022, 02, 21), 42.50, "Compra de 50 unidades de leche");
            Compra comp2 = new Compra("Comp02", "298668742", new DateTime(2022, 05, 22), 35.70, "Compra de 26 libras de morocho");
            Compra comp3 = new Compra("Comp03", "863971548", new DateTime(2022, 11, 01), 15, "Compra de 100 unidades de pan");

            comprasRegistradas.Add(comp1);
            comprasRegistradas.Add(comp2);
            comprasRegistradas.Add(comp3);

            llenarTablaCompras();
        }

        public void llenarTablaCompras()
        {
            if (comprasRegistradas != null)
            {
                SDGVCompra.Rows.Clear();
                foreach (Compra compra in comprasRegistradas)
                {
                    // dgvClientes
                    SDGVCompra.Rows.Add(compra.CodCompra, compra.RUC, compra.FechaCompra.ToString("yyyy/MM/dd"), compra.Costo, compra.Descripcion);
                }
            }
        }

        private void siticoneRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker1.Visible = true;
        }

        private void siticoneRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker1.Visible = false;
        }

        private void SBAniadirCompraClick(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Compra añadida con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SDGVCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SDGVCompra.Columns[e.ColumnIndex].Name == "ColumnaEliminarCompra")
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar esta compra?", "Eliminar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

            if (SDGVCompra.Columns[e.ColumnIndex].Name == "ColumnaEditarCompra")
            {
                if (e.RowIndex >= 0)
                {
                    // String cedula = SDGVProveedor.Rows[e.RowIndex].Cells["ColumnaCedula"].Value.ToString();
                    Editar_Compra ventana = new Editar_Compra();
                    ventana.ShowDialog();
                }
            }
        }

    }
}