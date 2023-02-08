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

namespace SGV_CLP.GUI.Módulo_Producto
{
    public partial class Editar_Eliminar_Lote : Form
    {
        public Editar_Eliminar_Lote()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Lote editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                MessageBox.Show("Lote eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Lote no eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void siticoneRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker1.Visible = true;
        }

        private void siticoneRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker1.Visible = false;
        }

        private void siticoneRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker2.Visible = true;
        }

        private void siticoneRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            siticoneDateTimePicker2.Visible = false;
        }
    }
}
