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
    public partial class Editar_Eliminar_Producto : Form
    {
        public Editar_Eliminar_Producto()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Producto editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
             this.Dispose();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                MessageBox.Show("Producto eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Producto no eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
