using SGV_CLP.Classes;
using SGV_CLP.GUI.Módulo_Producto;
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
    public partial class UC_Productos : UserControl
    {
        List<Producto> ProductosRegistrados = ProductoMapper.ConsultarProductos();
        List<string> NombresProductosRegistrados = ProductoMapper.ConsultarNombresProductos();
        List<Lote> LoteRegistrados = ProductoMapper.ConsultarLotes();
        
        public UC_Productos()
        {
            InitializeComponent();
            llenarTablaProducto();
            llenarTablaLote();
            llenarComboBoxProductos();
        }

        private void vaciarCampos()
        {
            txtIDProd.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPE.Text = string.Empty;
            txtPVP.Text = string.Empty;
            txtImagen.Text = string.Empty;
            txtCategoria.Text = string.Empty;
        }

        public void llenarTablaProducto()
        {
            if (ProductosRegistrados != null)
            {
                siticoneDataGridView1.Rows.Clear();
                ProductosRegistrados = ProductoMapper.ConsultarProductos();
                foreach (Producto producto in ProductosRegistrados)
                {
                    // dgvClientes
                    siticoneDataGridView1.Rows.Add(producto.Id, producto.Nombre, producto.PrecioElaboracion, producto.PVP, producto.Categoria, producto.CantidadTotal);
                }
            }
        }

        public void llenarTablaLote()
        {
            if (LoteRegistrados != null)
            {
                siticoneDataGridView2.Rows.Clear();
                LoteRegistrados = ProductoMapper.ConsultarLotes();
                foreach (Lote lote in LoteRegistrados)
                {
                    siticoneDataGridView2.Rows.Add(lote.Cod_Lote, lote.Cod_Producto, lote.Cantidad, lote.FechaElaboracion);
                }
            }
        }

        public void llenarComboBoxProductos()
        {
            if (NombresProductosRegistrados != null)
            {
                SCBProductoLote.Items.Clear();
                NombresProductosRegistrados = ProductoMapper.ConsultarNombresProductos();
                foreach (string nombreProd in NombresProductosRegistrados)
                {
                    // dgvClientes
                    SCBProductoLote.Items.Add(nombreProd);
                }
            }
        }


        private void siticoneDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar_Eliminar_Producto ventana = new Editar_Eliminar_Producto();
            ventana.ShowDialog();
        }

        private void siticoneRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker1.Visible = false;
        }

        private void siticoneRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker1.Visible = true;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            var producto = new Producto(
                txtIDProd.Text, 
                txtNombreProducto.Text, 
                Convert.ToDouble(txtPE.Text), 
                Convert.ToDouble(txtPVP.Text), 
                txtCategoria.Text, 
                txtImagen.Text);
        
           ProductoMapper.IngresarProducto(producto);
            llenarTablaProducto();
            llenarComboBoxProductos();

            SystemSounds.Beep.Play();
            MessageBox.Show("Producto añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            vaciarCampos();
        }

        private void SBAniadirLote_Click(object sender, EventArgs e)
        {
            var Lote = new Lote(
                ProductoMapper.ConsultarIdProducto(SCBProductoLote.SelectedItem.ToString()) + siticoneDateTimePicker1.Value.ToString("ddMM"),
                ProductoMapper.ConsultarIdProducto(SCBProductoLote.SelectedItem.ToString()),
                Convert.ToInt32(txtCantidad.Text),
                siticoneDateTimePicker1.Value.Date);

            ProductoMapper.IngresarLote(Lote);
            llenarTablaLote();

            //siticoneDateTimePicker1.Value.Year.ToString();
            SystemSounds.Beep.Play();
            MessageBox.Show("Lote añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneDataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar_Eliminar_Lote ventana = new Editar_Eliminar_Lote();
            ventana.ShowDialog();
        }


        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                txtImagen.Text = fileName;
            }
        }


    }
}
