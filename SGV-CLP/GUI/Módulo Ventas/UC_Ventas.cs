using SGV_CLP.GUI.Módulo_Producto;
using SGV_CLP.GUI.Módulo_Ventas;
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
    public partial class UC_Ventas : UserControl
    {
        public UC_Ventas()
        {
            InitializeComponent();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Checkout ventana = new Checkout();
            ventana.ShowDialog();
            /*SystemSounds.Beep.Play();
            MessageBox.Show("Venta añadida con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

        }

    }
}
