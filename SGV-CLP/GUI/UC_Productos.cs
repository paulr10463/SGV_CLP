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
            SystemSounds.Beep.Play();
            MessageBox.Show("Usuario añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
