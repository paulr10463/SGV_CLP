using SGV_CLP.Classes;
using SGV_CLP.GUI.Módulo_Ventas;
using Siticone.Desktop.UI.AnimatorNS;
using Siticone.Desktop.UI.WinForms;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SGV_CLP.GUI
{
    public partial class UC_Ventas : UserControl
    {
        List<Producto> especialidades;
        List<Producto> bebidasCalientes;
        public UC_Ventas()
        {
            InitializeComponent();

            especialidades = new List<Producto>();
            especialidades.Add(new Producto("TAM", "Tamal", 0.5, 1.25, "Especialidades", 0, null));
            especialidades.Add(new Producto("HUM", "Humita", 0.5, 1.5, "Especialidades", 0, null));
            especialidades.Add(new Producto("QUIM", "Quimbolito", 0.5, 1, "Especialidades", 0, null));
            /*
            especialidades.Add(new Producto("Tamal", "Tamal"));
            especialidades.Add(new Producto("Humita", "Humita"));
            especialidades.Add(new Producto("Empanadas Viento", "Empanadas Viento"));
            especialidades.Add(new Producto("Humita Frita", "HumitaFrita"));
            */

            bebidasCalientes = new List<Producto>();
            bebidasCalientes.Add(new Producto("CAFE", "Café", 0.5, 0.75, "Bebidas", 0, null));
            bebidasCalientes.Add(new Producto("CHOC", "Chocolate", 0.5, 1.25, "Bebidas", 0, null));
            bebidasCalientes.Add(new Producto("MORO", "Morocho", 0.5, 1, "Bebidas", 0, null));



        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Checkout ventana = new Checkout(siticoneDataGridView2);
            ventana.ShowDialog();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown1, especialidades[0]);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown2, especialidades[1]);
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown3, especialidades[2]);
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown4, bebidasCalientes[0]);
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown5, bebidasCalientes[1]);
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown6, bebidasCalientes[2]);
        }

        public void addRowInTable(SiticoneNumericUpDown cantidad, Producto producto)
        {
            bool flag = false;

            foreach (DataGridViewRow rowItem in siticoneDataGridView2.Rows)
            {
                if (rowItem.Cells[0].Value != null)
                {
                    if (rowItem.Cells[0].Value.Equals(producto.Nombre))
                    {
                        rowItem.Cells[1].Value = (int)cantidad.Value;
                        rowItem.Cells[2].Value = producto.PVP * (int)cantidad.Value;
                        flag = true;
                    }
                }
                else
                {
                    break;
                }
            }
            if (!flag)
            {
                DataGridViewRow row = (DataGridViewRow)siticoneDataGridView2.Rows[0].Clone();
                row.Cells[0].Value = producto.Nombre;
                row.Cells[1].Value = (int)cantidad.Value;
                row.Cells[2].Value = producto.PVP * (int)cantidad.Value;
                siticoneDataGridView2.Rows.Add(row);
            }
            setTotal(siticoneDataGridView2);

        }

        public void setTotal(SiticoneDataGridView tablaVenta)
        {
            double total = 0;
            foreach (DataGridViewRow rowItem in siticoneDataGridView2.Rows)
            {
                if (rowItem.Cells[0].Value != null)
                {
                    total += (double)rowItem.Cells[2].Value;
                }
                else
                {
                    break;
                }
            }

            siticoneHtmlLabel11.Text = "Total:      $"+ total.ToString();

        }


    }
}
