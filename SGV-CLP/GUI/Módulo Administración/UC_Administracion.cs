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
    public partial class UC_Administracion : UserControl
    {
        public UC_Administracion()
        {
            InitializeComponent();
        }

        private void siticoneHtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_aniadirUsuario_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Usuario añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_ModificarUsuario_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Usuario modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_EliminarUsuario_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                MessageBox.Show("Usuario eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_aniadirParamUnid_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Parámetro añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_aniadirParamPorc_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Parámetro añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_aniadirModificarParamUnid_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Parámetro modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Burron_ModificarParamPorc_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Parámetro modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_EliminarParam_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                MessageBox.Show("Parámetro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
