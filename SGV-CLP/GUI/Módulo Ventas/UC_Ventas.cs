using SGV_CLP.Classes;
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
            List<Producto> especialidades = new List<Producto>();
            especialidades.Add(new Producto("Quimbolito", "Quimbolito"));
            especialidades.Add(new Producto("Tamal", "Tamal"));
            especialidades.Add(new Producto("Humita", "Humita"));
            especialidades.Add(new Producto("Empanadas Viento", "Empanadas Viento"));
            especialidades.Add(new Producto("Humita Frita", "HumitaFrita"));

            List<Producto> bebidasCalientes = new List<Producto>();
            bebidasCalientes.Add(new Producto("Café", "Cafe"));
            bebidasCalientes.Add(new Producto("Chocolate", "Chocolate"));
            bebidasCalientes.Add(new Producto("Morocho", "Morocho"));

            foreach (Producto item in especialidades)
            {
                flowLayoutPanel1.Controls.Add(new UC_Item(item.Nombre, item.Imagen));
            }

            foreach (Producto item in bebidasCalientes)
            {
                flowLayoutPanel2.Controls.Add(new UC_Item(item.Nombre, item.Imagen));
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Checkout ventana = new Checkout();
            ventana.ShowDialog();
        }
    }
}
