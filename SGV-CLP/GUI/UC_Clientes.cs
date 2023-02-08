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
    public partial class UC_Clientes : UserControl
    {
        public UC_Clientes()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Cliente añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
