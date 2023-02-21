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

        private void txtConsultarVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (ComboBox_ConsultarVentaPor.SelectedIndex)
            {
                case 0:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 1:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números o \"-\" (siga el formato aaaa-mm-dd)!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 2:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 3:
                    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 4:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                default:
                    if (ComboBox_ConsultarVentaPor.SelectedIndex == -1) e.Handled = true;
                    break;
            }
        }

        private void ComboBox_ConsultarVentaPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConsultarVenta.Text = String.Empty;
        }
    }
}
