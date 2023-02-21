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
        public UC_Productos()
        {
            InitializeComponent();
            
        }

        private void siticoneDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar_Eliminar_Producto ventana = new Editar_Eliminar_Producto();
            ventana.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
            SystemSounds.Beep.Play();
            MessageBox.Show("Producto añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Lote añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker2.Visible = false;
        }

        private void siticoneRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker2.Visible = true;
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
                siticoneTextBox9.Text = fileName;
            }
        }
    }
}
