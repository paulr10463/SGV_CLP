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

namespace SGV_CLP.GUI.Módulo_Administración
{
    public partial class Editar_Parametro_Por_Porcentaje : Form
    {
        public Editar_Parametro_Por_Porcentaje()
        {
            InitializeComponent();
        }

        private void SBAceptar_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Parámetro editado con éxito", "Editar Parámetro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void SBCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
