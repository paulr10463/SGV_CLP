using SGV_CLP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Módulo_Ventas
{
    public partial class UC_Item : UserControl
    {

        public UC_Item(string nombreProducto, string imagen)
        {
            InitializeComponent();
            ResourceManager rm = Resources.ResourceManager;
            Image myImage = (Image)rm.GetObject(imagen);
            this.siticonePictureBox1.Image = myImage;
            this.siticoneHtmlLabel1.Text = nombreProducto;
        }

    }
}
