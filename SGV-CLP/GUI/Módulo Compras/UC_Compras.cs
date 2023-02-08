using SGV_CLP.GUI.Módulo_Clientes;
using SGV_CLP.GUI.Módulo_Compras;
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
        public UC_Compras()
        {
            InitializeComponent();
        }

        private void siticoneRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker1.Visible = true;
        }

        private void siticoneRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker1.Visible = false;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Compra añadida con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar_Eliminar_Compra ventana = new Editar_Eliminar_Compra();
            ventana.ShowDialog();
        }
    }
}