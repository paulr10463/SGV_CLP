using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
